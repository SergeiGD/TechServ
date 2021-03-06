using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.ordersLog;
using Forms_TechServ.classes.products;
using Forms_TechServ.classes.services;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.classes.workshops;

namespace Forms_TechServ.classes.orders
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientComment { get; set; }

        
        public decimal ClientSale { get; set; }
        public decimal PrepaymentRequired { get; set; }
        public decimal PrepaymentMade { get; set; }
        public decimal FinalPrice { get; set; }

        public DateTime? DateStart { get; set; }
        public DateTime? DateDiagnostic { get; set; }
        public DateTime? DateClientAnswer { get; set; }
        public DateTime? DatePrepayment { get; set; }
        public DateTime? DatePaid { get; set; }
        public DateTime? DateRepaired { get; set; }
        public DateTime? DateFinish { get; set; }
        public DateTime? DateCancel { get; set; }

        [Column("Id_Product")]
        public int ProductId { get; set; }
        [Column("Id_Product")]
        public Product Product { get; set; }

        [Column("Id_Manager")]
        public int ManagerId { get; set; }
        [Column("Id_Manager")]
        public Employee Manager { get; set; }

        [Column("Id_Master")]
        public int MasterId { get; set; }
        [Column("Id_Master")]
        public Master Master { get; set; }

        [Column("Id_Workshop")]
        public int WorkshopId { get; set; }
        [Column("Id_Workshop")]
        public Workshop Workshop { get; set; }

        public OrderStatus Status { get; set; }

        public virtual bool AddOrder()
        {
            using (TechContext db = new TechContext())
            {
                db.Orders.Add(this);

                OrderLog orderLog = new OrderLog(this.Id, UserSession.UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = "Заказ создан"
                };
                orderLog.AddOrderLog();

                db.SaveChanges();
                return true;
            }
        }

        public virtual bool EditOrder()
        {
            using (TechContext db = new TechContext())
            {
                Order order = db.Orders.Find(this.Id);


                foreach (PropertyInfo property in typeof(Order).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {

                    if (property.PropertyType.IsValueType && !object.Equals(property.GetValue(this), property.GetValue(order)))
                    {
                        string stateCurrent;
                        if (property.GetValue(this) == null)
                        {
                            stateCurrent = "не определен(а)";
                        }
                        else
                        {
                            stateCurrent = property.GetValue(this).ToString();
                        }
                        string stateBefore;
                        if (property.GetValue(order) == null)
                        {
                            stateBefore = "не определен(а)";
                        }
                        else
                        {
                            stateBefore = property.GetValue(order).ToString();
                        }
                        OrderLog orderLog = new OrderLog(this.Id, UserSession.UserSession.GetLoggedInUser().Id) 
                        {
                            EventDate = DateTime.Now,
                            EventDescription = $"{property.Name} изменен(а) с {stateBefore} на {stateCurrent}"
                        };
                        orderLog.AddOrderLog();
                    }
                    
                }

                db.Entry(order).CurrentValues.SetValues(this);
                db.SaveChanges();
                return true;
            }
        }

        public decimal CalcFinalPrice()
        {
            using(TechContext db = new TechContext())
            {
                decimal price = 0;

                foreach(OrderService service in db.OrdersServices.Where(s => s.OrderId == this.Id).Include(s => s.Service))
                {
                    price += service.Price * service.Quantity - (service.Price * service.Quantity * (service.Sale / 100));
                }

                foreach (OrderSparePart sparePart in this.GetSpareParts())
                {
                    price += sparePart.CalcPrice();
                }
                

                return price - (price * (this.ClientSale / 100));
            }
        }

        // ПОЛЕЧЕНИЕ УСЛУГ ДЛЯ ПОСТРАНИЧНОГО ВЫВОДА
        public List<OrderService> GetServices(bool onlyUnfinished, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<OrderService> orderServices = db.OrdersServices.Where(s => s.OrderId == this.Id).Include(s => s.Service);

                if (onlyUnfinished)
                {
                    orderServices = orderServices.Where(s => s.Done == false);
                }

                rowsCount = orderServices.Count();                                  // общее кол-во строк для постраничного вывода

                orderServices = orderServices.Skip((page - 1) * count).Take(count);

                return orderServices.ToList();
            }
        }

        // ПРОСТО ПОЛУЧЕНИЕ ВСЕХ УСЛУГ В ЗАКАЗЕ
        public List<OrderService> GetServices(bool onlyUnfinished)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<OrderService> orderServices = db.OrdersServices.Where(s => s.OrderId == this.Id).Include(s => s.Service);

                if (onlyUnfinished)
                {
                    orderServices = orderServices.Where(s => s.Done == false);
                }

                return orderServices.ToList();
            }
        }

        public bool CheckServicesDone()
        {
            using (TechContext db = new TechContext())
            {
                if (db.OrdersServices.Any(s => s.OrderId == this.Id && s.Done == false)) return false;

                return true;
            }
        }

        // ПОЛЕЧЕНИЕ ЗАПЧАСТЕЙ ДЛЯ ПОСТРАНИЧНОГО ВЫВОДА
        public List<OrderSparePart> GetSpareParts(int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                List<OrderSparePart> orderSpareParts = new List<OrderSparePart>();
                foreach (SparePartFromBatch sparePartFromBatch in db.OrdersSpareParts.Where(s => s.OrderId == this.Id).Include(s => s.SparePart))
                {

                    if (!orderSpareParts.Any(s => s.SparePart.Id == sparePartFromBatch.SparePartId))
                    {
                        OrderSparePart sparePart = new OrderSparePart()
                        {
                            Order = this,
                            SparePart = sparePartFromBatch.SparePart
                        };
                        orderSpareParts.Add(sparePart);
                        
                    }
                    
                }

                rowsCount = orderSpareParts.Count();                                  // общее кол-во строк для постраничного вывода

                orderSpareParts = orderSpareParts.Skip((page - 1) * count).Take(count).ToList();
                

                return orderSpareParts;
                
            }
        }

        // ПРОСТО ПОЛУЧЕНИЕ ВСЕХ ЗАПЧАТЕЙ В ЗАКАЗЕ
        public List<OrderSparePart> GetSpareParts()
        {
            using (TechContext db = new TechContext())
            {
                List<OrderSparePart> orderSpareParts = new List<OrderSparePart>();
                foreach (SparePartFromBatch sparePartFromBatch in db.OrdersSpareParts.Where(s => s.OrderId == this.Id).Include(s => s.SparePart))
                {

                    if (!orderSpareParts.Any(s => s.SparePart.Id == sparePartFromBatch.SparePartId))
                    {
                        OrderSparePart sparePart = new OrderSparePart()
                        {
                            Order = this,
                            SparePart = sparePartFromBatch.SparePart
                        };
                        orderSpareParts.Add(sparePart);

                    }

                }

                return orderSpareParts;

            }
        }

        public bool CheckSparePartsDelivered()
        {
            using(TechContext db = new TechContext())
            {
                foreach (OrderSparePart sparePart in this.GetSpareParts())
                {
                    if (!sparePart.CheckBatchesDelivered())
                    {
                        return false;                                           // если хоть одна деталь не прибыла, то false
                    }
                }

                return true;
            }
            
        }

        public OrderSparePart GetSparePart(int sparePartId)
        {
            using (TechContext db = new TechContext())
            {
                SparePart sparePart = db.SpareParts.Find(sparePartId);
                return new OrderSparePart()
                {
                    Order = this,
                    SparePart = sparePart
                };
            }
                
        }

        

        public bool AddService(OrderService service)
        {
            using(TechContext db = new TechContext())
            {
                if(service.Quantity < 1 || service.Sale < 0)
                {
                    return false;
                }

                service.OrderId = this.Id;

                db.OrdersServices.Add(service);

                OrderLog orderLog = new OrderLog(this.Id, UserSession.UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Услуга №{service.ServiceId} в количестве {service.Quantity} добавлена к заказу. Цена за 1 услугу - {service.Price}, доп. скидка на услугу - {service.Sale}%"
                };
                orderLog.AddOrderLog();
                db.SaveChanges();


                this.FinalPrice = CalcFinalPrice();
                this.EditOrder();


                return true;
            }
        }

        public bool DelService(OrderService service)
        {
            using(TechContext db = new TechContext())
            {
                db.Entry(service).State = EntityState.Deleted;

                OrderLog orderLog = new OrderLog(this.Id, UserSession.UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Услуга №{service.ServiceId} удалена из заказа"
                };
                orderLog.AddOrderLog();

                db.SaveChanges();

                this.FinalPrice = CalcFinalPrice();
                this.EditOrder();

                return true;
            }
        }

        public bool EditService(OrderService service)
        {
            using (TechContext db = new TechContext())
            {
                if(service.Quantity < 1 || service.Sale < 0)
                {
                    return false;
                }

                db.Entry(service).State = EntityState.Modified;

                OrderLog orderLog = new OrderLog(this.Id, UserSession.UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Услуга №{service.ServiceId} изменена в заказе. Текущее количество - {service.Quantity}, доп. скидка на услугу - {service.Sale}%, оказана - {service.Done}"
                };
                orderLog.AddOrderLog();

                db.SaveChanges();

                this.FinalPrice = CalcFinalPrice();
                this.EditOrder();

                return true;
            }
        }

        public bool FindMaster()
        {
            using (TechContext db = new TechContext())
            {
                
                Category category = ProductsList.GetById(this.ProductId, true).Category;

                

                foreach(Master master in from m in db.MastersCategories.Include(m => m.Master)
                        where m.Master.WorkshopId == this.WorkshopId && m.Master.DelTime == null
                        select m.Master)
                {
                    if (master.CheckMasterCategory(category))
                    {
                        this.MasterId = master.Id;
                        return true;
                    }

                }

                return false;
                
            }
        }

        public int CalcServicesCount()
        {
            using(TechContext db = new TechContext())
            {
                return db.OrdersServices.Where(s => s.OrderId == this.Id).Count();
            }
        }

        public decimal CalcServicesPrice()
        {
            using (TechContext db = new TechContext())
            {
                decimal price = 0;

                foreach (OrderService service in db.OrdersServices.Where(s => s.OrderId == this.Id).Include(s => s.Service))
                {
                    price += service.Price * service.Quantity - (service.Price * service.Quantity * (service.Sale / 100));
                }

                return price;
            }
        }

        public bool CheckService(Service service)                   // есть ли уже услуга в заказе
        {
            using(TechContext db = new TechContext())
            {
                OrderService orderService = db.OrdersServices.Find(this.Id, service.Id);

                if(orderService != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public OrderService GetService(int id)                       // есть ли уже деталь в заказе
        {
            using (TechContext db = new TechContext())
            {
                return db.OrdersServices.Find(this.Id, id);
            }
        }

        public bool CheckSparePart(SparePart sparePart)
        {
            using (TechContext db = new TechContext())
            {
                if (db.OrdersSpareParts.Any(s => s.OrderId == this.Id && s.SparePartId == sparePart.Id))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public int CalcSparePartsCount()
        {

            return this.GetSpareParts().Count();
            
        }

        public decimal CalcSparePartsPrice()
        {
            using (TechContext db = new TechContext())
            {
                decimal price = 0;

                foreach (OrderSparePart sparePart in this.GetSpareParts())
                {
                    price += sparePart.CalcPrice();
                }

                

                return price;
            }
        }

        public decimal CalcClientPrepayment()
        {
            using(TechContext db = new TechContext())
            {
                decimal prepayment = 0;
                foreach (var sparePart in db.OrdersSpareParts.Where(s => s.OrderId == this.Id).Include(s => s.SparePart))
                {
                    prepayment += sparePart.SparePart.ClientPrepayment * sparePart.Quantity;
                }

                return prepayment;
            }
            
        }

        public List<OrderLog> GetOrderLogs(OrderLog FilterA, OrderLog FilterB, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<OrderLog> orderLogs = db.OrderLogs.Where(o => o.OrderId == this.Id).Include(o => o.Employee);

                if(FilterA.Id != 0)
                {
                    orderLogs = orderLogs.Where(o => o.Id == FilterA.Id);
                }

                if(FilterA.Employee != null)
                {
                    orderLogs = orderLogs.Where(o => o.EmployeeId == FilterA.Employee.Id);
                }

                orderLogs = orderLogs.Where(o => o.EventDate >= FilterA.EventDate && o.EventDate <= FilterB.EventDate);

                orderLogs = orderLogs.SortBy("Id", true);

                rowsCount = orderLogs.Count();                                  // общее кол-во строк для постраничного вывода

                orderLogs = orderLogs.Skip((page - 1) * count).Take(count);

                return orderLogs.ToList();
            }
        }

        public OrderLog GetOrderLog(int id, bool withNavProp)
        {
            using(TechContext db = new TechContext())
            {
                if (withNavProp)
                {
                    OrderLog orderLog = db.OrderLogs.Find(id);
                    db.Entry(orderLog).Reference(o => o.Employee).Load();
                    return orderLog;
                }
                else
                {
                    return db.OrderLogs.Find(id);
                }
            }
        }

    }
}
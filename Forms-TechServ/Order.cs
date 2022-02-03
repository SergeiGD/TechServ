using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Forms_TechServ
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

                OrderLog orderLog = new OrderLog(this.Id, UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = "Заказ создан"
                };
                db.OrderLogs.Add(orderLog);

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
                        OrderLog orderLog = new OrderLog(this.Id, UserSession.GetLoggedInUser().Id) 
                        {
                            EventDate = DateTime.Now,
                            EventDescription = $"{property.Name} изменен(а) с {stateBefore} на {stateCurrent}"
                        };
                        db.OrderLogs.Add(orderLog);
                    }
                    
                }

                db.Entry(order).CurrentValues.SetValues(this);
                //db.Entry(this).State = EntityState.Modified;
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
                    //price += service.Service.Price * service.Quantity - (service.Service.Price * service.Quantity * (service.Sale / 100));
                    price += service.Price * service.Quantity - (service.Price * service.Quantity * (service.Sale / 100));
                }

                foreach (OrderSparePart sparePart in this.GetSpareParts())
                {
                    price += sparePart.CalcPrice();
                }
                

                return price - (price * (this.ClientSale / 100));
            }
        }

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

                OrderLog orderLog = new OrderLog(this.Id, UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Услуга №{service.ServiceId} в количестве {service.Quantity} добавлена к заказу. Цена за 1 услугу - {service.Price}, доп. скидка на услугу - {service.Sale}%"
                };
                db.OrderLogs.Add(orderLog);
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

                OrderLog orderLog = new OrderLog(this.Id, UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Услуга №{service.ServiceId} удалена из заказа"
                };
                db.OrderLogs.Add(orderLog);

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

                OrderLog orderLog = new OrderLog(this.Id, UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Услуга №{service.ServiceId} изменена в заказе. Текущее количество - {service.Quantity}, доп. скидка на услугу - {service.Sale}%, оказана - {service.Done}"
                };
                db.OrderLogs.Add(orderLog);

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

                

                foreach(Master master in from m in db.MastersCategories.Include(m => m.Master)//.Include(m => m.Category)
                                         where m.Master.WorkshopId == this.WorkshopId && m.Master.DelTime == null// && m.ch == product.CategoryId//this.Product.CategoryId
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
                    //price += service.Service.Price * service.Quantity - (service.Service.Price * service.Quantity * (service.Sale / 100));
                }

                // ПОТОМ ДЕТАЛИ

                return price;// - (price * (this.ClientSale / 100));
            }
        }

        public bool CheckService(Service service)
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

        public OrderService GetService(int id)
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
                SparePartFromBatch sparePartFromBatch = db.OrdersSpareParts.Where(s => s.OrderId == this.Id && s.SparePartId == sparePart.Id).FirstOrDefault();

                if (sparePartFromBatch != null)
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

    public static class OrdersList
    {
        public static Order GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                Order order = db.Orders.Find(id);

                if(order != null)
                {
                    db.Entry(order).Reference(o => o.Product).Load();
                    //db.Entry(order).Reference(o => o.Product.Client).Load();
                    db.Entry(order).Reference(o => o.Workshop).Load();
                    db.Entry(order).Reference(o => o.Master).Load();
                    db.Entry(order).Reference(o => o.Manager).Load();
                }

                return order;
            }
        }

        public static List<Order> GetOrders(Order FilterA, Order FilterB, Client client, bool activeOnly,/*List<OrderStatus> pickedStatuses,*/ bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Order> orders = db.Orders.Include(o => o.Workshop).Include(o => o.Product).Include(o => o.Product.Client).Include(o => o.Master).Include(o => o.Manager);

                if (FilterA.Id != 0)
                {
                    orders = orders.Where(o => o.Id == FilterA.Id);
                }

                if (client != null)
                {
                    orders = orders.Where(o => o.Product.ClientId == client.Id);
                }

                if (FilterA.Workshop != null)
                {
                    orders = orders.Where(o => o.WorkshopId == FilterA.Workshop.Id);
                }

                if (FilterA.Product != null)
                {
                    orders = orders.Where(o => o.ProductId == FilterA.Product.Id);
                }

                if (FilterA.Master != null)
                {
                    orders = orders.Where(o => o.MasterId == FilterA.Master.Id);
                }

                if (FilterA.Manager != null)
                {
                    orders = orders.Where(o => o.ManagerId == FilterA.Manager.Id);
                }

                if (FilterA.Status != OrderStatus.Unknown)
                {
                    orders = orders.Where(o => o.Status == FilterA.Status);
                }

                if (activeOnly)
                {
                    orders = orders.Where(o => o.Status != OrderStatus.Finished && o.Status != OrderStatus.Canceled);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice == 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice);
                }

                if (FilterA.FinalPrice == 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice && o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired == 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired == 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired && o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade == 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade == 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade && o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.DateStart.HasValue && !FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart);
                }

                if (!FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart && o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateDiagnostic.HasValue && !FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic);
                }

                if (!FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic && o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateClientAnswer.HasValue && !FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer);
                }

                if (!FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer && o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateCancel.HasValue && !FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel);
                }

                if (!FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel && o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateRepaired.HasValue && !FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired);
                }

                if (!FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired && o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DatePaid.HasValue && !FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid);
                }

                if (!FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid && o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DateFinish.HasValue && !FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish);
                }

                if (!FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish <= FilterB.DateFinish);
                }

                if (FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish && o.DateFinish <= FilterB.DateFinish);
                }

                orders = orders.SortBy(sortBy, desk);

                rowsCount = orders.Count();                                  // общее кол-во строк для постраничного вывода

                orders = orders.Skip((page - 1) * count).Take(count);

                return orders.ToList();

            }
        }

        // ТОЛЬКО ЗАКАЗЫ В МАСТЕРСКОЙ
        public static List<Order> GetInOrders(Order FilterA, Order FilterB, Client client, bool activeOnly, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Order> orders = db.Orders.Include(o => o.Workshop).Include(o => o.Product).Include(o => o.Product.Client).Include(o => o.Master).Include(o => o.Manager).Where(o => !(o is OrderAtHome));

                if (FilterA.Id != 0)
                {
                    orders = orders.Where(o => o.Id == FilterA.Id);
                }

                if (client != null)
                {
                    orders = orders.Where(o => o.Product.ClientId == client.Id);
                }

                if (FilterA.Workshop != null)
                {
                    orders = orders.Where(o => o.WorkshopId == FilterA.Workshop.Id);
                }

                if (FilterA.Product != null)
                {
                    orders = orders.Where(o => o.ProductId == FilterA.Product.Id);
                }

                if(FilterA.Master != null)
                {
                    orders = orders.Where(o => o.MasterId == FilterA.Master.Id);
                }

                if(FilterA.Manager != null)
                {
                    orders = orders.Where(o => o.ManagerId == FilterA.Manager.Id);
                }

                if (FilterA.Status != OrderStatus.Unknown)
                {
                    orders = orders.Where(o => o.Status == FilterA.Status);
                }

                if (activeOnly)
                {
                    orders = orders.Where(o => o.Status != OrderStatus.Finished && o.Status != OrderStatus.Canceled);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice == 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice);
                }

                if (FilterA.FinalPrice == 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice && o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired == 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired == 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired && o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade == 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade == 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade && o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.DateStart.HasValue && !FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart);
                }

                if (!FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart && o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateDiagnostic.HasValue && !FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic);
                }

                if (!FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic && o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateClientAnswer.HasValue && !FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer);
                }

                if (!FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer && o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateCancel.HasValue && !FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel);
                }

                if (!FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel && o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateRepaired.HasValue && !FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired);
                }

                if (!FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired && o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DatePaid.HasValue && !FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid);
                }

                if (!FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid && o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DateFinish.HasValue && !FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish);
                }

                if (!FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish <= FilterB.DateFinish);
                }

                if (FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish && o.DateFinish <= FilterB.DateFinish);
                }

                orders = orders.SortBy(sortBy, desk);

                rowsCount = orders.Count();                                  // общее кол-во строк для постраничного вывода

                orders = orders.Skip((page - 1) * count).Take(count);

                return orders.ToList();

            }
        }
    }

    public enum OrderStatus
    {
        Canceled,
        Finished,
        WaitingForAnswer,
        WaitingForDiagnostic,
        WaitingForPrepayment,
        WaitingForRefund,
        WaitingForRepairing,
        WaitingForSpareParts,
        WaitingForPayment,
        Unknown
    }

    public static class StatusStringExtensions
    {
        public static string GetStatusString(this OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.Canceled:
                    return "Отменен";
                case OrderStatus.Finished:
                    return "Завершен";
                case OrderStatus.WaitingForDiagnostic:
                    return "Ожидает диагностики";
                case OrderStatus.WaitingForAnswer:
                    return "Ожидает ответа клиента";
                case OrderStatus.WaitingForPrepayment:
                    return "Ожидает предоплаты";
                case OrderStatus.WaitingForRepairing:
                    return "Ожидает ремонта";
                case OrderStatus.WaitingForRefund:
                    return "Ожидает возврарата средств";
                case OrderStatus.WaitingForSpareParts:
                    return "Ожидает прибытия запчастей";
                case OrderStatus.WaitingForPayment:
                    return "Ожидает оплаты";

                default:
                    return "Неопределенный статус";
            }
        }

        public static OrderStatus GetStatusEnum(string status)
        {
            switch (status)
            {
                
                case "Отменен":
                    return OrderStatus.Canceled;
                case "Завершен":
                    return OrderStatus.Finished;
                case "Ожидает диагностики":
                    return OrderStatus.WaitingForDiagnostic;
                case "Ожидает ответа клиента":
                    return OrderStatus.WaitingForAnswer;
                case "Ожидает предоплаты":
                    return OrderStatus.WaitingForPrepayment;
                case "Ожидает ремонта":
                    return OrderStatus.WaitingForRepairing;
                case "Ожидает возврарата средств":
                    return OrderStatus.WaitingForRefund;
                case "Ожидает прибытия запчастей":
                    return OrderStatus.WaitingForSpareParts;
                case "Ожидает оплаты":
                    return OrderStatus.WaitingForPayment;

                default:
                    return OrderStatus.Unknown;
            }
        }
    }
}

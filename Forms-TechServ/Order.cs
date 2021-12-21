using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forms_TechServ
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientComment { get; set; }
        //public string MasterComment { get; set; }
        public OrderStatus Status;
        public decimal ClientSale { get; set; }
        public decimal Prepayment { get; set; }
        public decimal FinalPrice { get; set; }
        //public bool HighPriority { get; set; }

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
        public Manager Manager { get; set; }

        [Column("Id_Master")]
        public int MasterId { get; set; }
        [Column("Id_Master")]
        public Master Master { get; set; }

        [Column("Id_Workshop")]
        public int WorkshopId { get; set; }
        [Column("Id_Workshop")]
        public Workshop Workshop { get; set; }

        public virtual bool AddOrder()
        {
            using (TechContext db = new TechContext())
            {
                db.Orders.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public virtual bool EditOrder()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
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
                    price += service.Service.Price * service.Quantity - (service.Service.Price * service.Quantity * (service.Sale / 100));
                }

                // ПОТОМ ДЕТАЛИ

                return price - (price * (this.ClientSale / 100));
            }
        }

        public List<OrderService> GetServices(int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<OrderService> orderServices = db.OrdersServices.Where(s => s.OrderId == this.Id).Include(s => s.Service);

                rowsCount = orderServices.Count();                                  // общее кол-во строк для постраничного вывода

                orderServices = orderServices.Skip((page - 1) * count).Take(count);

                return orderServices.ToList();
            }
        }

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
                /*IEnumerable<OrderService> orderServices = db.OrdersServices.Where(s => s.OrderId == this.Id).Include(s => s.Service);

                rowsCount = orderServices.Count();                                  // общее кол-во строк для постраничного вывода

                orderServices = orderServices.Skip((page - 1) * count).Take(count);

                return orderServices.ToList();*/
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
                service.OrderId = this.Id;

                db.OrdersServices.Add(service);

                db.SaveChanges();

                Order orderToUpdate = db.Orders.Find(this.Id);
                this.FinalPrice = CalcFinalPrice();
                db.Entry(orderToUpdate).CurrentValues.SetValues(this);
                db.SaveChanges();

                return true;
            }
        }

        public bool DelService(OrderService service)
        {
            using(TechContext db = new TechContext())
            {
                db.Entry(service).State = EntityState.Deleted;
                db.SaveChanges();

                Order orderToUpdate = db.Orders.Find(this.Id);
                this.FinalPrice = CalcFinalPrice();
                db.Entry(orderToUpdate).CurrentValues.SetValues(this);
                db.SaveChanges();

                return true;
            }
        }

        public bool EditService(OrderService service)
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(service).State = EntityState.Modified;
                db.SaveChanges();

                Order orderToUpdate = db.Orders.Find(this.Id);
                this.FinalPrice = CalcFinalPrice();
                db.Entry(orderToUpdate).CurrentValues.SetValues(this);
                db.SaveChanges();

                return true;
            }
        }

        public bool FindMaster()
        {
            using (TechContext db = new TechContext())
            {
                /*foreach (MastersCategories master in db.MastersCategories.Include(m => m.Master).Where(m => m.Master.WorkshopId == this.WorkshopId))
                {

                }*/
                //Master master = in db.MastersCategories.Include(m => m.Master).Where(m => m.Master.WorkshopId == this.WorkshopId).Include(m => m.Category).Where(m => m.CategoryId == this);
                //Product product = ProductsList.GetById(this.ProductId, true).CategoryId
                Category category = ProductsList.GetById(this.ProductId, true).Category;

                /*Master master = (from m in db.MastersCategories.Include(m => m.Master)//.Include(m => m.Category)
                                where m.Master.WorkshopId == this.WorkshopId// && m.ch == product.CategoryId//this.Product.CategoryId
                                 select m.Master).FirstOrDefault();*/

                foreach(Master master in from m in db.MastersCategories.Include(m => m.Master)//.Include(m => m.Category)
                                         where m.Master.WorkshopId == this.WorkshopId// && m.ch == product.CategoryId//this.Product.CategoryId
                                         select m.Master)
                {
                    if (master.CheckMasterCategory(category))
                    {
                        this.MasterId = master.Id;
                        return true;
                    }

                }

                return false;
                /*int b = 0;
                foreach (MastersCategories ms in from m in db.MastersCategories.Include(m => m.Master)//.Include(m => m.Category)
                                      where m.Master.WorkshopId == this.WorkshopId //&& m.CategoryId == product.CategoryId//this.Product.CategoryId
                                      select m)
                {
                    b++;
                }*/

                /*int b = 0;
                foreach(MastersCategories ms in db.MastersCategories.Include(m => m.Master).Where(m => m.Master.WorkshopId == this.WorkshopId && m.CategoryId == product.CategoryId))
                {
                    b++;
                }*/

                /*if(master != null)
                {
                    this.MasterId = master.Id;
                    return true;
                }
                else
                {
                    return false;
                }*/
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
                    price += service.Service.Price * service.Quantity - (service.Service.Price * service.Quantity * (service.Sale / 100));
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

        public static List<Order> GetOrders(Order FilterA, Order FilterB/*, Client client, List<OrderStatus> pickedStatuses*/, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Order> orders = db.Orders.Include(o => o.Workshop).Include(o => o.Product).Include(o => o.Product.Client).Include(o => o.Master).Include(o => o.Manager);

                if(FilterA.Id != 0)
                {
                    orders = orders.Where(o => o.Id == FilterA.Id);
                }

                /*if(client != null)
                {
                    //orders = orders.Where(o => o.Id == FilterA.Id);
                }

                if(pickedStatuses.Count > 0)
                {
                    orders = orders.Where(o => pickedStatuses.Contains(o.Status));
                }*/

                if(FilterA.Workshop != null)
                {
                    orders = orders.Where(o => o.WorkshopId == FilterA.Workshop.Id);
                }

                if(FilterA.FinalPrice > 0 && FilterB.FinalPrice == 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice);
                }

                if (FilterA.FinalPrice == 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice >  0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice && o.FinalPrice <= FilterB.FinalPrice);
                }

                /*if (FilterA.DateStart.HasValue && !FilterB.DateStart.HasValue)
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
                }*/

                orders = orders.SortBy(sortBy, desk);

                rowsCount = orders.Count();                                  // общее кол-во строк для постраничного вывода

                orders = orders.Skip((page - 1) * count).Take(count);

                return orders.ToList();
                //if(FilterA)
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
        WaitingForSpareParts
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
                case OrderStatus.WaitingForAnswer:
                    return "Ожидает ответа клиента";
                case OrderStatus.WaitingForDiagnostic:
                    return "Ожидает диагностики";
                case OrderStatus.WaitingForPrepayment:
                    return "Ожидает предоплаты";
                case OrderStatus.WaitingForRefund:
                    return "Ожидает возврарата средств";
                case OrderStatus.WaitingForRepairing:
                    return "Ожидает ремонта";
                case OrderStatus.WaitingForSpareParts:
                    return "Ожидает прибытия запчастей";
                default:
                    return "Неопределенный статус";
            }
        }
    }
}

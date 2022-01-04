using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Forms_TechServ
{
    public class OrderAtHome : Order
    {
        public string Address { get; set; }

        public override bool AddOrder()
        {
            using (TechContext db = new TechContext())
            {
                db.OrdersAtHome.Add(this);

                OrderLog orderLog = new OrderLog()
                {
                    OrderId = this.Id,
                    EventDate = DateTime.Now,
                    EventDescription = "Заказ создан"
                };
                db.OrderLogs.Add(orderLog);

                db.SaveChanges();
                return true;
            }
        }

        public override bool EditOrder()
        {
            using (TechContext db = new TechContext())
            {
                Order orderAtHome = db.OrdersAtHome.Find(this.Id);

                foreach (PropertyInfo property in typeof(OrderAtHome).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (property.PropertyType.IsValueType && !object.Equals(property.GetValue(this), property.GetValue(orderAtHome)))
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
                        if (property.GetValue(orderAtHome) == null)
                        {
                            stateBefore = "не определен(а)";
                        }
                        else
                        {
                            stateBefore = property.GetValue(orderAtHome).ToString();
                        }
                        OrderLog orderLog = new OrderLog()
                        {
                            OrderId = this.Id,
                            EventDate = DateTime.Now,
                            EventDescription = $"{property.Name} изменен(а) с {stateBefore} на {stateCurrent}"
                        };
                        db.OrderLogs.Add(orderLog);
                    }

                }

                db.Entry(orderAtHome).CurrentValues.SetValues(this);
                db.SaveChanges();
                return true;
            }
        }

        // ПРОСТО ПОЛУЧЕНИЕ ВСЕХ ВИЗИТОВ
        public List<Visit> GetVisits()
        {
            using (TechContext db = new TechContext())
            {
                return db.Visits.Where(v => v.OrderId == this.Id && v.DelTime == null).ToList();
            }
        }

        // ДЛЯ ПОСТРАНИЧНОГО ВЫВОДА
        public List<Visit> GetVisits(Visit FilterA, Visit FilterB, Master master, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using(TechContext db = new TechContext())
            {
                IEnumerable<Visit> visits = db.Visits.Where(v => v.OrderId == this.Id && v.DelTime == null).Include(v => v.Order);

                if(FilterA.Id != 0)
                {
                    visits = visits.Where(v => v.Id == FilterA.Id);
                }

                if (FilterA.Order != null && FilterA.Order.Address != null && FilterA.Order.Address != string.Empty)
                {
                    visits = visits.Where(v => v.Order.Address == FilterA.Order.Address);
                }

                if (!FilterA.Done)
                {
                    visits = visits.Where(v => v.Done == false);
                }

                if(master != null)
                {
                    visits = visits.Where(v => v.Order.MasterId == master.Id);
                }

                visits = visits.Where(v => v.DateVisit >= FilterA.DateVisit && v.DateVisit <= FilterB.DateVisit);

                visits = visits.SortBy(sortBy, desk);

                rowsCount = visits.Count();                                  // общее кол-во строк для постраничного вывода

                visits = visits.Skip((page - 1) * count).Take(count);

                return visits.ToList();
            }
        }
    }

    public static class OrderAtHomeList
    {
        public static OrderAtHome GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                OrderAtHome order = db.OrdersAtHome.Where(o => o.Id == id).Include(o => o.Master).Include(o => o.Master.Role).FirstOrDefault();

                if (order != null)
                {
                    db.Entry(order).Reference(o => o.Product).Load();
                    //db.Entry(order).Reference(o => o.Product.Client).Load();
                    db.Entry(order).Reference(o => o.Workshop).Load();
  
                    db.Entry(order).Reference(o => o.Manager).Load();
                }

                return order;
            }
        }

        public static List<OrderAtHome> GetOrders(OrderAtHome FilterA, OrderAtHome FilterB, Client client, bool activeOnly,/*List<OrderStatus> pickedStatuses,*/ bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<OrderAtHome> orders = db.OrdersAtHome.Include(o => o.Workshop).Include(o => o.Product).Include(o => o.Product.Client).Include(o => o.Master).Include(o => o.Manager);



                if (FilterA.Id != 0)
                {
                    orders = orders.Where(o => o.Id == FilterA.Id);
                }

                if (FilterA.Address != null && FilterA.Address != string.Empty)
                {
                    orders = orders.Where(o => o.Address.IndexOf(FilterA.Address, StringComparison.OrdinalIgnoreCase) > -1);
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
    }
}

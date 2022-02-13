using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.ordersLog;
using Forms_TechServ.classes.visits;

namespace Forms_TechServ.classes.orders
{
    public class OrderAtHome : Order
    {
        public string Address { get; set; }

        public override bool AddOrder()
        {
            using (TechContext db = new TechContext())
            {
                db.OrdersAtHome.Add(this);

                OrderLog orderLog = new OrderLog(this.Id, UserSession.UserSession.GetLoggedInUser().Id)
                {
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
                        OrderLog orderLog = new OrderLog(this.Id, UserSession.UserSession.GetLoggedInUser().Id)
                        {
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
}
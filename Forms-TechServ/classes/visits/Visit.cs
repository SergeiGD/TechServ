using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees.timetables;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.ordersLog;
using Forms_TechServ.classes.services;
using Itenso.TimePeriod;

namespace Forms_TechServ.classes.visits
{
    public class Visit
    {
        public int Id { get; set; }
        public string MasterComment { get; set; }
        public DateTime DateVisit { get; set; }
        public bool Done { get; set; }

        [Column("Id_Order")]
        public int OrderId { get; set; }
        [Column("Id_Order")]
        public OrderAtHome Order { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddVisit()
        {
            using (TechContext db = new TechContext())
            {
                

                if (CheckTimeAvailable())
                {
                    db.Visits.Add(this);

                    OrderLog orderLog = new OrderLog(this.OrderId, UserSession.UserSession.GetLoggedInUser().Id)
                    {
                        EventDate = DateTime.Now,
                        EventDescription = $"Выезд №{this.Id} на время {this.DateVisit} добавлен к заказу"
                    };
                    orderLog.AddOrderLog();


                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public bool EditVisit()
        {
            using (TechContext db = new TechContext())
            {
                

                if (CheckTimeAvailable())
                {
                    db.Entry(this).State = EntityState.Modified;

                    OrderLog orderLog = new OrderLog(this.OrderId, UserSession.UserSession.GetLoggedInUser().Id)
                    {
                        EventDate = DateTime.Now,
                        EventDescription = $"Выезд №{this.Id} изменен. Запланированное время - {this.DateVisit}, выполнен - {this.Done}"
                    };
                    orderLog.AddOrderLog();


                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        private bool CheckTimeAvailable()
        {
            using(TechContext db = new TechContext())
            {
                // ДЛЯ НАЧАЛА СМОТРИМ РАБОТАЕТ ЛИ МАСТЕР ВООБЩЕ В ЭТОТ ДЕНЬ
                OrderAtHome order = OrderAtHomeList.GetById(OrderId);
                DateTime dayOfVisit = new DateTime(this.DateVisit.Year, this.DateVisit.Month, this.DateVisit.Day, 0, 0, 0);
                TimeRange currentVisitRange = new TimeRange(this.DateVisit, this.DateVisit.Add(this.CalcEstimatedTime()));

                EmployeeTimetable timetable = db.EmployeesTimetables.Where(t => t.EmployeeId == order.MasterId).ToList().Where(t => new DateTime(t.ShiftStart.Year, t.ShiftStart.Month, t.ShiftStart.Day, 0, 0, 0) == dayOfVisit).FirstOrDefault();
                if (timetable == null)
                {
                    return false;
                }


                // ПОТОМ СМОТРИМ НЕ ЗАКОНЧИЛАСЬ ЛИ ЕГО СМЕНА К ВЫБРАННОМУ ВРЕМЕНИ
                TimeRange shiftRange = new TimeRange(timetable.ShiftStart, timetable.ShiftEnd);
                if (!shiftRange.HasInside(currentVisitRange))
                {
                    return false;
                }

                // ПОТОМ СМОТРИМ НЕ КОНфЛИКТУЕТ ЛИ С ДРУГИМИ ВИЗИТАМИ
                List<TimeRange> visitsRanges = new List<TimeRange>();
                foreach (Visit visit in order.Master.GetMasterVisits().Where(v => v.Id != this.Id && new DateTime(v.DateVisit.Year, v.DateVisit.Month, v.DateVisit.Day, 0, 0, 0) == dayOfVisit))
                {

                    TimeSpan timeTaken = visit.CalcEstimatedTime();



                    visitsRanges.Add(new TimeRange(visit.DateVisit, visit.DateVisit.Add(timeTaken)));
                }

                foreach (TimeRange visit in visitsRanges)
                {
                    if (visit.OverlapsWith(currentVisitRange))
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public bool DelVisit()
        {
            using (TechContext db = new TechContext())
            {
                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;

                OrderLog orderLog = new OrderLog(this.OrderId, UserSession.UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Выезд №{this.Id} был удален"
                };
                orderLog.AddOrderLog();

                db.SaveChanges();
                return true;
            }
        }



        // ХРАНИМ ТО, КАКОЕ УСЛУГИ МЫ СОБИРАЕМСЯ ОКАЗЫВАТЬ ВО ВРЕМЯ ВИЗИТА, ЧТОБ РАСЧИТЫВАТЬ ВРЕМЯ
        public List<VisitService> GetVisitServices()
        {
            using(TechContext db = new TechContext())
            {
                return db.VisitsServices.Where(v => v.VisitId == this.Id).ToList();
            }
        }

        // ДЛЯ ПОСТАНИЧНОГО ВЫВОДА
        public List<OrderService> GetVisitOrderServices(int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {

                IEnumerable<OrderService> services = from vs in this.GetVisitServices()
                    join s in db.OrdersServices.Include(s => s.Service) on
                        new { ServiceId = vs.ServiceId, OrderId = this.OrderId }
                        equals
                        new { ServiceId = s.ServiceId, OrderId = s.OrderId }
                    select s;

                rowsCount = services.Count();                                  // общее кол-во строк для постраничного вывода

                services = services.Skip((page - 1) * count).Take(count);

                return services.ToList(); 



            }
        }

        // ПРОСТО ПОЛУЧЕНИЕ OrderService ДЛЯ РАСЧЕТОВ И ПРОЧЕГО
        public List<OrderService> GetVisitOrderServices()
        {
            using (TechContext db = new TechContext())
            {

                IEnumerable<OrderService> services = from vs in this.GetVisitServices()
                    join s in db.OrdersServices.Include(s => s.Service) on
                        new { ServiceId = vs.ServiceId, OrderId = this.OrderId }
                        equals
                        new { ServiceId = s.ServiceId, OrderId = s.OrderId }
                    select s;

                return services.ToList();



            }
        }

        public bool AddService(Service service)
        {
            using(TechContext db = new TechContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    db.VisitsServices.Add(new VisitService()
                    {
                        ServiceId = service.Id,
                        VisitId = this.Id
                    });


                    db.SaveChanges();

                    if (CheckTimeAvailable())
                    {
                        transaction.Commit();
                        OrderLog orderLog = new OrderLog(this.OrderId, UserSession.UserSession.GetLoggedInUser().Id)
                        {
                            EventDate = DateTime.Now,
                            EventDescription = $"Выезд №{this.Id} был изменен. Добавлена запланированная услуга №{service.Id}"
                        };
                        orderLog.AddOrderLog();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }


                }

                
            }
        }

        public bool DelService(Service service)
        {
            using (TechContext db = new TechContext())
            {
                db.VisitsServices.Remove(db.VisitsServices.Find(this.Id, service.Id));

                OrderLog orderLog = new OrderLog(this.OrderId, UserSession.UserSession.GetLoggedInUser().Id)
                {
                    EventDate = DateTime.Now,
                    EventDescription = $"Выезд №{this.Id} был изменен. Удалена запланированная услуга №{service.Id}"
                };
                orderLog.AddOrderLog();

                db.SaveChanges();
                return true;
            }
        }

        public bool CheckService(Service service)
        {
            using (TechContext db = new TechContext())
            {
                if(db.VisitsServices.Find(this.Id, service.Id) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public TimeSpan CalcEstimatedTime()
        {
            using(TechContext db = new TechContext())
            {
                TimeSpan timeTaken = new TimeSpan(0);
                var services = (from vs in this.GetVisitServices()
                        join s in db.OrdersServices.Include(s => s.Service) on
                            new { ServiceId = vs.ServiceId, OrderId = this.OrderId }
                            equals
                            new { ServiceId = s.ServiceId, OrderId = s.OrderId }
                        select new { AvgTime = s.Service.AvgServiceTime, Quantity = s.Quantity })
                    .ToList();


                foreach (var item in services)
                {
                    timeTaken += TimeSpan.FromTicks(item.AvgTime.Ticks * item.Quantity);
                }

                return timeTaken.Add(new TimeSpan(0, 10, 0));       // + 10 минут запасного времени на дорогу
            }
            
        }
    }
}
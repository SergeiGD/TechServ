using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.batches;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.workshops.timetables;

namespace Forms_TechServ.classes.workshops
{
    public class Workshop
    {
        //[Column("id")]
        public int Id { get; set; }
        public string Location { get; set; }
        public string PhoneNum { get; set; }

       

        public DateTime? DelTime { get; set; }

        public bool AddWorkshop()
        {
            using (TechContext db = new TechContext())
            {
                db.Workshops.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool DelWorkshop()
        {
            using (TechContext db = new TechContext())
            {
                Employee employee = db.Employees.Where(emp => emp.WorkshopId == this.Id && emp.DelTime == null).FirstOrDefault();      // если есть хоть один сотрудник в филиале, то удалить нельзя
                Order order = db.Orders.Where(o => o.WorkshopId == this.Id && (o.Status != OrderStatus.Finished || o.Status != OrderStatus.Canceled)).FirstOrDefault(); // если есть хоть один заказ в филиале, то удалить нельзя
                foreach (Batch batch in db.Batches.Where(b => b.WorkshopId == this.Id && b.DelTime == null))
                {
                    if (!batch.IsSpent())
                    {
                        return false;
                    }
                }
                

                if(employee == null && order == null)
                {
                    this.DelTime = DateTime.Now;
                    db.Entry(this).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public bool EditWorkshop()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public List<WorkshopTimetable> GetTimetables(int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<WorkshopTimetable> timetables = db.WorkshopsTimetables.Where(t => t.DelTime == null && t.WorkshopId == this.Id).Include(t => t.Workshop);

                timetables.SortBy("ValidUntil", true);

                rowsCount = timetables.Count();

                timetables = timetables.Skip((page - 1) * count).Take(count);

                return timetables.ToList();
            }
        }

        public WorkshopTimetable GetValidTimetable()
        {
            using (TechContext db = new TechContext())
            {
                return db.WorkshopsTimetables.Where(t => t.WorkshopId == this.Id && t.ValidFrom <= DateTime.Now && t.ValidUntil >= DateTime.Now).FirstOrDefault();
            }
        }

        public double CalcLoad(DateTime from, DateTime until)
        {
            using(TechContext db = new TechContext())
            {
                int masters = db.Masters.Where(m => m.WorkshopId == this.Id && m.DelTime == null).Count();
                int orders = db.Orders.Where(o => o.WorkshopId == this.Id && o.Status != OrderStatus.Canceled && o.DateStart >= from && o.DateStart <= until).Count();
                if(masters == 0)
                {
                    return 0;
                }
                else
                {
                    return orders / masters;
                }

            }
        }

        public decimal CalcProfit(DateTime from, DateTime until)
        {
            using (TechContext db = new TechContext())
            {
                List<Order> orders = db.Orders.Where(o => o.WorkshopId == this.Id && o.Status == OrderStatus.Finished && o.DateStart >= from && o.DateStart <= until).ToList();
                decimal profit = 0;
                foreach(Order order in orders)
                {
                    profit += order.FinalPrice;
                }
                return profit;
            }
        }
       

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Entity;


namespace Forms_TechServ
{
    public class Workshop
    {
        //[Column("id")]
        public int Id { get; set; }
        public string Location { get; set; }
        public string PhoneNum { get; set; }

        /*[Column("id_Head")]
        public int HeadId { get; set; }
        [Column("id_Head")]
        public Employee Head { get; set; }*/

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
                Order order = db.Orders.Where(o => o.WorkshopId == this.Id && (o.Status != OrderStatus.Finished || o.Status != OrderStatus.Canceled)).FirstOrDefault();
                foreach (Batch batch in db.Batches.Where(b => b.WorkshopId == this.Id && b.DelTime == null))
                {
                    if (!batch.IsSpent())
                    {
                        return false;
                    }
                }
                /*foreach (Order order in db.Orders.Where(o => o.WorkshopId == this.Id && (o.Status != OrderStatus.Finished || o.Status != OrderStatus.Canceled)))
                {

                }*/

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
                //int masters = db.Masters.Where(m => m.WorkshopId == this.Id && m.DelTime == null).Count();
                List<Order> orders = db.Orders.Where(o => o.WorkshopId == this.Id && o.Status == OrderStatus.Finished && o.DateStart >= from && o.DateStart <= until).ToList();
                decimal profit = 0;
                foreach(Order order in orders)
                {
                    profit += order.FinalPrice;
                }
                return profit;
            }
        }
        /*public Dictionary<SparePart, int> GetInStockSpareParts()
        {
            using (TechContext db = new TechContext())
            {
                Dictionary<SparePart, int> sparePartsInStock = new Dictionary<SparePart, int>();

                foreach (SparePart sparePart in db.SpareParts)
                {
                    int quantity = sparePart.GetCountInStock(this);
                    if (quantity > 0)
                    {
                        sparePartsInStock.Add(sparePart, quantity);
                    }
                }

                return sparePartsInStock;
            }
        }*/

    }

    public static class WorkshopsList
    {
        public static Workshop GetById(int id)
        {
            using(TechContext db = new TechContext())
            {
                /*Workshop workshop = db.Workshops.Find(id);

                if (withNavProps)
                {
                    //db.Entry(workshop.)
                }*/
                //return db.Workshops.Find(id);
                return db.Workshops.Find(id);
            }
        }

        public static List<Workshop> GetWorkshops(Workshop FilterA, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Workshop> workshops = db.Workshops.Where(m => m.DelTime == null);

                if (FilterA.Id != 0)
                {
                    workshops = workshops.Where(w => w.Id == FilterA.Id);
                }

                if (FilterA.Location != null && FilterA.Location != string.Empty)
                {
                    workshops = workshops.Where(w => w.Location.IndexOf(FilterA.Location, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if (FilterA.PhoneNum != null && FilterA.PhoneNum != string.Empty)
                {
                    workshops = workshops.Where(w => w.PhoneNum.Contains(FilterA.PhoneNum));                // регистр не играет роли, т.к. цифры => можно обойтись Contains
                }

                workshops = workshops.SortBy(sortBy, desk);

                rowsCount = workshops.Count();

                workshops = workshops.Skip((page - 1) * count).Take(count);

                return workshops.ToList();

            }
        }

        public static List<Workshop> GetWorkshops()
        {
            using (TechContext db = new TechContext())
            {


                return db.Workshops.Where(m => m.DelTime == null).OrderBy(w => w.Id).ToList();

            }
        }
    }
}

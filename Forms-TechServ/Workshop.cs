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

                if(employee == null)
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
    }
}

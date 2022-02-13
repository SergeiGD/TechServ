using System;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.orders;

namespace Forms_TechServ.classes.employees
{
    public class Manager : Employee
    {
        public bool Remotely { get; set; }

        public bool AddManager()
        {
            using (TechContext db = new TechContext())
            {
                if(db.Employees.Where(e => e.DelTime == null && e.PhoneNum == this.PhoneNum).Count() != 0)
                {
                    return false;
                }

                db.Managers.Add(this);
                db.SaveChanges();
                return true;
                
            }
        }

        public bool DelManager()
        {
            using (TechContext db = new TechContext())
            {
                Order order = db.Orders.Where(o => o.ManagerId == this.Id && o.Status != OrderStatus.Canceled && o.Status != OrderStatus.Finished).FirstOrDefault();

                if (order != null)
                {
                    return false;
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;

                
            }
        }

        public bool EditManager()
        {
            using (TechContext db = new TechContext())
            {
                if (db.Employees.Where(e => e.DelTime == null && e.PhoneNum == this.PhoneNum && e.Id != this.Id).Count() != 0)
                {
                    return false;
                }

                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;

                
            }
        }

       
    }
}
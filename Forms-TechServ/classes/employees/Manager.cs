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

        public override bool AddEmployee()
        {
            using (TechContext db = new TechContext())
            {
                if(db.Employees.Any(e => e.DelTime == null && e.PhoneNum == this.PhoneNum))
                {
                    return false;
                }

                db.Managers.Add(this);
                db.SaveChanges();
                return true;
                
            }
        }

        public override bool DelEmployee()
        {
            using (TechContext db = new TechContext())
            {
                // ЕСТЬ ЛИ НЕЗАВЕРШЕННЫЕ ЗАКАЗЫ
                if (db.Orders.Any(o => o.ManagerId == this.Id && o.Status != OrderStatus.Canceled && o.Status != OrderStatus.Finished))
                {
                    return false;
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;

                
            }
        }

        public override bool EditEmployee()
        {
            using (TechContext db = new TechContext())
            {
                if (db.Employees.Any(e => e.DelTime == null && e.PhoneNum == this.PhoneNum && e.Id != this.Id))
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
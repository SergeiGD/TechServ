using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forms_TechServ
{
    public class OrderLog
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }

        [Column("Id_Order")]
        public int OrderId { get; set; }
        [Column("Id_Order")]
        public Order Order { get; set; }

        public bool AddOrderLog()
        {
            using (TechContext db = new TechContext())
            {
                db.OrderLogs.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool DelOrderLog()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.orders;

namespace Forms_TechServ.classes.ordersLog
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

        [Column("Id_Employee")]
        public int EmployeeId { get; set; }
        [Column("Id_Employee")]
        public Employee Employee { get; set; }

        public OrderLog(int orderId, int employeeId)    // конструктор с параметрами для создания нового экземляра
        {
            this.OrderId = orderId;
            this.EmployeeId = employeeId;
        }

        public OrderLog() { }                           // пустой конструктор для создание фильтров сортировки

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

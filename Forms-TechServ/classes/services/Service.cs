using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.orders;

namespace Forms_TechServ.classes.services
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Column("AvgServiceTime")]
        public double TimeSpanTicks { get; set; }                                 // SQLite не поддерживает TimeSpan, так что сделаем обертку в виде числа (кол-во минут)
        [NotMapped]                                                                 // и трансформации его в TimeSpan
        public TimeSpan AvgServiceTime                                             // благодаря этому работаем как с обычным TimeSpan и оно автоматически будет трансформировать в тип БД
        {
            get
            {
               
                return TimeSpan.FromMinutes(TimeSpanTicks);
            }
            set
            {
                TimeSpanTicks = value.TotalMinutes;
            }
        }

        [Column("Id_Category")]
        public int CategoryId { get; set; }
        [Column("Id_Category")]
        public Category Category { get; set; }

        public DateTime? DelTime { get; set; }

        public class ServiceConfig : EntityTypeConfiguration<Service>    // Настрока свойства TimeSpanTicks, чтоб оно взаимодействовало с моделью, не смотря на то, что private
        {
            public ServiceConfig()
            {
                Property(p => p.TimeSpanTicks);
            }
        }

        public bool AddService()
        {
            using (TechContext db = new TechContext())
            {
                db.Services.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditSerive()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();

                db.SaveChanges();
                return true;
            }
        }

        public bool DelService()
        {
            using (TechContext db = new TechContext())
            {
                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        // ДЛЯ РАСЧЕТА СТАТИСТИКИ
        public int CountInOrders(DateTime from, DateTime until)
        {

            using (TechContext db = new TechContext())
            {
                return db.OrdersServices.Include(s => s.Order).Where(s => s.ServiceId == this.Id && s.Order.Status != OrderStatus.Canceled).Count();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forms_TechServ
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
                /*if (TimeSpanTicks.HasValue)
                {
                    return TimeSpan.FromMinutes(TimeSpanTicks.Value);
                }
                else
                {
                    return null;
                }*/
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

        public int CountInOrders(DateTime from, DateTime until)
        {
            //int count = 0;
            using (TechContext db = new TechContext())
            {
                return db.OrdersServices.Include(s => s.Order).Where(s => s.ServiceId == this.Id && s.Order.Status != OrderStatus.Canceled).Count();
            }
        }
    }

    public static class ServicesList
    {
        public static Service GetById(int id, bool withNavProps)
        {
            using (TechContext db = new TechContext())
            {
                Service service = db.Services.Find(id);

                if (withNavProps)
                {
                    db.Entry(service).Reference(s => s.Category).Load();
                }

                return service;
            }
        }

        public static List<Service> GetService(Service FilterA, Service FilterB, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Service> services = db.Services.Where(s => s.DelTime == null).Include(s => s.Category);

                if(FilterA.Id != 0)
                {
                    services = services.Where(s => s.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    services = services.Where(s => s.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if(FilterA.Price > 0 && FilterB.Price == 0)
                {
                    services = services.Where(s => s.Price >= FilterA.Price);
                }

                if (FilterA.Price > 0 && FilterB.Price > 0)
                {
                    services = services.Where(s => s.Price >= FilterA.Price && s.Price <= FilterB.Price);
                }

                if (FilterA.Price == 0 && FilterB.Price > 0)
                {
                    services = services.Where(s => s.Price <= FilterB.Price);
                }

                if(FilterA.Category != null)
                {
                    services = services.Where(s => s.CategoryId == FilterA.Category.Id);
                }

                services = services.SortBy(sortBy, desk);

                rowsCount = services.Count();                                  // общее кол-во строк для постраничного вывода

                services = services.Skip((page - 1) * count).Take(count);

                return services.ToList();
            }
        }

        public static List<Service> GetService()
        {
            using (TechContext db = new TechContext())
            {
                return db.Services.Where(s => s.DelTime == null).ToList();

                
            }
        }
    }
}

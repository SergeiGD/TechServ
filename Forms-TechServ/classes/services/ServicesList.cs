using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.services
{
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

        public static List<Service> GetServices(Service FilterA, Service FilterB, bool withParentsServices, bool desk, string sortBy, int count, int page, out int rowsCount)
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

                if(withParentsServices && FilterA.Category != null)
                {
                    List<Category> parents = FilterA.Category.GetParents();
                    services = services.Where(s => parents.Any(p => p.Id == s.CategoryId));
                }
                else if(FilterA.Category != null)
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

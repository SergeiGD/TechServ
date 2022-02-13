using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.visits
{
    public static class VisitsList
    {
        public static Visit GetById(int id)
        {
            using(TechContext db = new TechContext())
            {
                return db.Visits.Where(v => v.Id == id).Include(v => v.Order).Include(v => v.Order.Product).Include(v => v.Order.Product.Client).Include(o => o.Order.Master).FirstOrDefault();

            }
        }

        public static List<Visit> GetVisits(Visit FilterA, Visit FilterB, Master master, string address, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Visit> visits = db.Visits.Where(v => v.DelTime == null).Include(v => v.Order);

                if (FilterA.Id != 0)
                {
                    visits = visits.Where(v => v.Id == FilterA.Id);
                }

                if (address != null && address != string.Empty)
                {
                    visits = visits.Where(v => v.Order.Address == address);
                }

                if (!FilterA.Done)
                {
                    visits = visits.Where(v => v.Done == false);
                }

                if (FilterA.Order != null)
                {
                    visits = visits.Where(v => v.OrderId == FilterA.Order.Id);
                }

                if (master != null)
                {
                    visits = visits.Where(v => v.Order.MasterId == master.Id);
                }

                visits = visits.Where(v => v.DateVisit >= FilterA.DateVisit && v.DateVisit <= FilterB.DateVisit);

                visits = visits.SortBy(sortBy, desk);

                rowsCount = visits.Count();                                  // общее кол-во строк для постраничного вывода

                visits = visits.Skip((page - 1) * count).Take(count);

                return visits.ToList();
            }
        }

        public static bool IsAlreadyPlanned(int OrderId, int ServiceId)
        {
            using(TechContext db = new TechContext())
            {
                foreach(VisitService service in db.VisitsServices.Include(v => v.Visit).Where(v => v.Visit.OrderId == OrderId && v.Visit.DelTime == null))
                {
                    if(service.ServiceId == ServiceId)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }

    
}

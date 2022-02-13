using System;
using System.Collections.Generic;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.workshops
{
    public static class WorkshopsList
    {
        public static Workshop GetById(int id)
        {
            using(TechContext db = new TechContext())
            {
                
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

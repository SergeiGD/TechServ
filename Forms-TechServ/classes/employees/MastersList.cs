using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.employees
{
    public static class MastersList
    {
        public static Master GetById(int id, bool withNavProps)
        {
            using (TechContext db = new TechContext())
            {
                Master master = db.Masters.Find(id);

                if (withNavProps)
                {
                    db.Entry(master).Reference(m => m.Workshop).Load();
                    db.Entry(master).Reference(m => m.Role).Load();
                }

                return master;
            }
        }

        public static List<Master> GetMasters(Master FilterA, Master FilterB, Category masterCat, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Master> masters = db.Masters.Include(m => m.Workshop).Include(m => m.Role).Where(m => m.DelTime == null);

                if (FilterA.Id != 0)
                {
                    masters = masters.Where(m => m.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    masters = masters.Where(m => m.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if (FilterA.PhoneNum != null && FilterA.PhoneNum != string.Empty)
                {
                    masters = masters.Where(m => m.PhoneNum.Contains(FilterA.PhoneNum));                // регистр не играет роли, т.к. цифры => можно обойтись Contains
                }

                if(FilterA.Salary > 0 && FilterB.Salary == 0)                                           // от указанной до любой
                {
                    masters = masters.Where(m => m.Salary >= FilterA.Salary);
                }

                if (FilterB.Salary > 0)                                                                 // от любой до указанной
                {
                    masters = masters.Where(m => m.Salary <= FilterB.Salary);
                }

                if (FilterA.Salary > 0 && FilterB.Salary > 0)                                           // от указанной до указанной
                {
                    masters = masters.Where(m => m.Salary >= FilterA.Salary && m.Salary <= FilterB.Salary);
                }

                if (FilterA.Workshop != null)
                {
                    masters = masters.Where(m => m.WorkshopId == FilterA.Workshop.Id);
                }

                if (FilterA.Role != null)
                {
                    masters = masters.Where(m => m.RoleId == FilterA.Role.Id);
                }

                if(masterCat != null)
                {
                    masters = masters.Where(m => m.CheckMasterCategory(masterCat));
                }


                masters = masters.SortBy(sortBy, desk);

                rowsCount = masters.Count();

                masters = masters.Skip((page - 1) * count).Take(count);

                return masters.ToList();

            }
        }
    
    }
}
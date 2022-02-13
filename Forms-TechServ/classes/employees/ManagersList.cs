using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.employees
{
    public static class ManagersList
    {
        public static Manager GetById(int id, bool withNavProps)
        {
            using (TechContext db = new TechContext())
            {
                Manager manager = db.Managers.Find(id);

                if (withNavProps)
                {
                    db.Entry(manager).Reference(m => m.Workshop).Load();
                    db.Entry(manager).Reference(m => m.Role).Load();
                }

                return manager;
            }
        }

        public static List<Manager> GetManagers(Manager FilterA, Manager FilterB, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Manager> managers = db.Managers.Include(m => m.Workshop).Include(m => m.Role).Where(m => m.DelTime == null);

                if (FilterA.Id != 0)
                {
                    managers = managers.Where(m => m.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    managers = managers.Where(m => m.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if (FilterA.PhoneNum != null && FilterA.PhoneNum != string.Empty)
                {
                    managers = managers.Where(m => m.PhoneNum.Contains(FilterA.PhoneNum));                // регистр не играет роли, т.к. цифры => можно обойтись Contains
                }

                if (FilterA.Salary > 0 && FilterB.Salary == 0)                                           // от указанной до любой
                {
                    managers = managers.Where(m => m.Salary >= FilterA.Salary);
                }

                if (FilterB.Salary > 0)                                                                 // от любой до указанной
                {
                    managers = managers.Where(m => m.Salary <= FilterB.Salary);
                }

                if (FilterA.Salary > 0 && FilterB.Salary > 0)                                           // от указанной до указанной
                {
                    managers = managers.Where(m => m.Salary >= FilterA.Salary && m.Salary <= FilterB.Salary);
                }

                if (FilterA.Workshop != null)
                {
                    managers = managers.Where(m => m.WorkshopId == FilterA.Workshop.Id);
                }

                if (FilterA.Remotely)
                {
                    managers = managers.Where(m => m.Remotely);
                }

                if (FilterA.Role != null)
                {
                    managers = managers.Where(m => m.RoleId == FilterA.Role.Id);
                }


                managers = managers.SortBy(sortBy, desk);

                rowsCount = managers.Count();

                managers = managers.Skip((page - 1) * count).Take(count);

                return managers.ToList();

            }
        }

    }
}
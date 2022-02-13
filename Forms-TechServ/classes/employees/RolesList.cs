using System;
using System.Collections.Generic;
using System.Linq;
using Forms_TechServ.classes.databaseContext;

namespace Forms_TechServ.classes.employees
{
    public static class RolesList
    {
        public static Role GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                return db.Roles.Find(id);
            }
        }

        public static List<Role> GetRoles(Role FilterA, Employee employee, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Role> roles = db.Roles.Where(r => r.Id != 1 && r.DelTime == null);

                if (FilterA.Id != 0)
                {
                    roles = roles.Where(r => r.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    roles = roles.Where(r => r.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if(employee != null)
                {
                    if(employee.GetType() == typeof(Master))
                    {
                        roles = roles.Where(r => r.RoleType == RoleType.Мастер || r.RoleType == RoleType.Все);
                    }
                    if (employee.GetType() == typeof(Manager))
                    {
                        roles = roles.Where(r => r.RoleType == RoleType.Менеджер || r.RoleType == RoleType.Все);
                    }
                }

                if(FilterA.RoleType != RoleType.Неопределенно)
                {
                    roles = roles.Where(r => r.RoleType == FilterA.RoleType);
                }

                rowsCount = roles.Count();

                roles = roles.Skip((page - 1) * count).Take(count);


                return roles.ToList();

            }
        }
    }
}
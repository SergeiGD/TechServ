using System;
using System.Collections.Generic;
using System.Linq;
using Forms_TechServ.classes.databaseContext;

namespace Forms_TechServ.classes.employees
{
    public static class PermissionsList
    {
        public static Permission GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                return db.Permissions.Find(id);
            }
        }

        public static List<Permission> GetPermissions(Permission FilterA, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Permission> permissions = db.Permissions;

                if (FilterA.Id != 0)
                {
                    permissions = permissions.Where(p => p.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    permissions = permissions.Where(r => r.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }


                rowsCount = permissions.Count();

                permissions = permissions.Skip((page - 1) * count).Take(count);


                return permissions.ToList();
            }
        }
    }
}
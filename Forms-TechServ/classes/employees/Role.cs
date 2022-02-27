using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.employees
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DelTime { get; set; }
        public RoleType RoleType { get; set; }

        public List<Permission> GetPermissions(Permission FilterA, int count, int page, out int rowsCount)
        {
            using(TechContext db = new TechContext())
            {
                IEnumerable<Permission> permissions;

                if (this.Id == 1)                           // 1 - гл. администратор и есть все права
                {
                    permissions = (from p in db.RolesPermissions.Include(p => p.Permission)
                        select p.Permission);
                }
                else
                {
                    permissions = (from p in db.RolesPermissions.Include(p => p.Permission)
                        where p.RoleId == this.Id
                        select p.Permission);
                }

                if(FilterA.Id != 0)
                {
                    permissions = permissions.Where(p => p.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    permissions = permissions.Where(r => r.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                permissions = permissions.SortBy("Id", true);

                rowsCount = permissions.Count();

                permissions = permissions.Skip((page - 1) * count).Take(count);


                return permissions.ToList();
            }
        }

        public bool AddRole()
        {
            using (TechContext db = new TechContext())
            {
                db.Roles.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool DelRole()
        {
            using(TechContext db = new TechContext())
            {
                if(this.Id == 1)
                {
                    return false;                       // 1 - главный администратор (разработчик) - изменять нельзя
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            
        }

        public bool EditRole()
        {
            using (TechContext db = new TechContext())
            {
                if(this.Id == 1)
                {
                    return false;
                }

                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public int CalcPermissionsCount()
        {
            using (TechContext db = new TechContext())
            {
                return db.RolesPermissions.Where(b => b.RoleId == this.Id).Count();
            }
        }

        public bool AddPermission(Permission permission)
        {
            using (TechContext db = new TechContext())
            {
                RolesPermissions rolesPermission = new RolesPermissions()
                {
                    RoleId = this.Id,
                    PermissionId = permission.Id
                };

                db.RolesPermissions.Add(rolesPermission);

                db.SaveChanges();

                return true;
            }
        }

        public bool DelPermission(Permission permission)
        {
            using (TechContext db = new TechContext())
            {
                RolesPermissions rolesPermission = db.RolesPermissions.Find(this.Id, permission.Id);

                db.RolesPermissions.Remove(rolesPermission);

                db.SaveChanges();

                return true;
            }
        }

        public bool CheckPermission(Permission permission)
        {
            using (TechContext db = new TechContext())
            {
                RolesPermissions rolesPermission = db.RolesPermissions.Find(this.Id, permission.Id);

                if (rolesPermission != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
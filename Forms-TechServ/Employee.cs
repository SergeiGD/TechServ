using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace Forms_TechServ
{
    public abstract class Employee : Person
    {
        public string AdditionalInfo { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        // WORKSHOP
        [Column("Id_Role")]
        public int RoleId { get; set; }
        [Column("Id_Role")]
        public Role Role { get; set; }

        [Column("Id_Workshop")]
        public int WorkshopId { get; set; }
        [Column("Id_Workshop")]
        public Workshop Workshop { get; set; }


        public List<EmployeeTimetable> GetTimetables(EmployeeTimetable FilterA, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<EmployeeTimetable> timetables = db.EmployeesTimetables.Where(t => t.EmployeeId == this.Id && t.DelTime == null).Include(t => t.Employee);

                if (FilterA.Id != 0)
                {
                    timetables = timetables.Where(t => t.Id == FilterA.Id);
                    //timetables = timetables.Where(t => t.ShiftStart >= from);
                }

                timetables = timetables.Where(t => t.ShiftStart >= FilterA.ShiftStart && t.ShiftEnd <= FilterA.ShiftEnd);


                timetables = timetables.SortBy("ShiftStart", true);

                rowsCount = timetables.Count();

                timetables = timetables.Skip((page - 1) * count).Take(count);

                return timetables.ToList();
            }
        }
        // GETTIMETABLE
    }

    public static class EmployeesList
    {
        public static Employee GetById(int id, bool withNavProps)
        {
            using (TechContext db = new TechContext())
            {
                Employee employee = db.Employees.Find(id);

                if (withNavProps)
                {
                    db.Entry(employee).Reference(m => m.Workshop).Load();
                    db.Entry(employee).Reference(m => m.Role).Load();
                }

                return employee;
            }
        }

        public static List<Employee> GetEmployees(Employee FilterA, Employee FilterB, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Employee> employees = db.Employees.Include(m => m.Workshop).Include(m => m.Role).Where(m => m.DelTime == null);

                if (FilterA.Id != 0)
                {
                    employees = employees.Where(m => m.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    employees = employees.Where(m => m.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if (FilterA.PhoneNum != null && FilterA.PhoneNum != string.Empty)
                {
                    employees = employees.Where(m => m.PhoneNum.Contains(FilterA.PhoneNum));                // регистр не играет роли, т.к. цифры => можно обойтись Contains
                }

                if (FilterA.Salary > 0 && FilterB.Salary == 0)                                           // от указанной до любой
                {
                    employees = employees.Where(m => m.Salary >= FilterA.Salary);
                }

                if (FilterA.Salary == 0 && FilterB.Salary > 0)                                                                 // от любой до указанной
                {
                    employees = employees.Where(m => m.Salary <= FilterB.Salary);
                }

                if (FilterA.Salary > 0 && FilterB.Salary > 0)                                           // от указанной до указанной
                {
                    employees = employees.Where(m => m.Salary >= FilterA.Salary && m.Salary <= FilterB.Salary);
                }

                if (FilterA.Workshop != null)
                {
                    employees = employees.Where(m => m.WorkshopId == FilterA.Workshop.Id);
                }

                if (FilterA.Role != null)
                {
                    employees = employees.Where(m => m.RoleId == FilterA.Role.Id);
                }

                /*if (FilterA.Cat != null)
                {
                    
                }*/

                employees = employees.SortBy(sortBy, desk);

                rowsCount = employees.Count();                                  // общее кол-во строк для постраничного вывода

                employees = employees.Skip((page - 1) * count).Take(count);

                return employees.ToList();

            }
        }

    }

    public class Master : Employee
    {
        public bool AddMaster()
        {
            using (TechContext db = new TechContext())
            {
                
                db.Masters.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool DelMaster()
        {
            using (TechContext db = new TechContext())
            {
                // ПРОВЕРЯТЬ ЕСТЬ ЛИ АКТИВНЫЕ ЗАКАЗЫ

                Order order = db.Orders.Where(o => o.MasterId == this.Id && o.Status != OrderStatus.Canceled && o.Status != OrderStatus.Finished).FirstOrDefault();

                if(order != null)
                {
                    return false;
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
               
            }
        }

        //private DbContextTransaction transact;

        public bool EditMaster()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                
                db.SaveChanges();
                


                return true;
                
            }
        }

        public List<Visit> GetMasterVisits()
        {
            using (TechContext db = new TechContext())
            {
                return db.Visits.Include(v => v.Order).Where(v => v.Order.MasterId == this.Id && v.DelTime == null).ToList();
            }
        }

        public bool AddMasterCategory(Category category)
        {
            using (TechContext db = new TechContext())
            {

                if (!CheckMasterCategory(category))
                {

                    MastersCategories masterCat = new MastersCategories()
                    {
                        MasterId = this.Id,
                        CategoryId = category.Id
                    };



                    CleanChildern(category);

                    db.MastersCategories.Add(new MastersCategories()
                    {
                        MasterId = this.Id,
                        CategoryId = category.Id
                    });

                    db.SaveChanges();


                    // рекурсивная локальная функция, которая удалят дочерние элементы, когда добавляется категория более выского уровня (узла)
                    void CleanChildern(Category currentCat)
                    {
                        foreach (Category cat in db.Categories.Where(c => c.ParentCategoryId == currentCat.Id && c.DelTime == null))
                        {
                            CleanChildern(cat);
                            db.MastersCategories.RemoveRange(db.MastersCategories.Where(c => c.CategoryId == cat.Id && c.MasterId == this.Id));
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
                
                
            }
        }

        public bool DelMasterCategory(Category category)
        {
            using (TechContext db = new TechContext())
            {
                MastersCategories catToDelete = db.MastersCategories.Find(this.Id, category.Id);//db.MastersCategories.Where(mc => mc.CategoryId == category.Id && mc.MasterId == this.Id).FirstOrDefault();
                if(catToDelete != null)
                {
                    db.MastersCategories.Remove(catToDelete);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
               
            }
        }

        public List<Category> GetMasterCategories(int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Category> categories = from c in db.MastersCategories.Include(c => c.Category)
                                             where c.MasterId == this.Id && c.Category.DelTime == null
                                             select c.Category;

                rowsCount = categories.Count();

                categories = categories.Skip((page - 1) * count).Take(count);
                //categories = 
                return categories.ToList();
            }
        }

        public bool CheckMasterCategory(Category category)
        {
            using (TechContext db = new TechContext())
            {
                MastersCategories masterCat = null;// = db.MastersCategories.Find(this.Id, category.Id);
                Category pickedCat = category;//new Category() { Id = category.Id, ParentCategoryId = category.ParentCategoryId};

                
                while (pickedCat != null && masterCat == null)
                {
                    masterCat = db.MastersCategories.Find(this.Id, pickedCat.Id);
                    pickedCat = db.Categories.Where(c => c.Id == pickedCat.ParentCategoryId && c.DelTime == null).FirstOrDefault();
                }
                

                if (masterCat != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //foreach(MastersCategories cat in db.MastersCategories.Where(m))
                
            }
        }

        // ORDERS
    }

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

    public class Manager : Employee
    {
        public bool Remotely { get; set; }

        public bool AddManager()
        {
            using (TechContext db = new TechContext())
            {
                db.Managers.Add(this);
                db.SaveChanges();
                return true;
                
            }
        }

        public bool DelManager()
        {
            using (TechContext db = new TechContext())
            {
                Order order = db.Orders.Where(o => o.ManagerId == this.Id && o.Status != OrderStatus.Canceled && o.Status != OrderStatus.Finished).FirstOrDefault();

                if (order != null)
                {
                    return false;
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;

                
            }
        }

        public bool EditManager()
        {
            using (TechContext db = new TechContext())
            {

                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;

                
            }
        }

       
    }

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

                /*if (FilterA.Cat != null)
                {
                    
                }*/

                managers = managers.SortBy(sortBy, desk);

                rowsCount = managers.Count();

                managers = managers.Skip((page - 1) * count).Take(count);

                return managers.ToList();

            }
        }

    }

    public class Role
    {
        //[Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
        

        public List<Permission> GetPermissions()
        {
            using(TechContext db = new TechContext())
            {
                List<Permission> permissions = (from p in db.RolesPermissions
                                                where p.Role.Equals(this)
                                                select p.Permission).ToList();
                return permissions;
            }
        }
    }

    public static class RolesList
    {
        public static Role GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                return db.Roles.Find(id);
            }
        }

        public static List<Role> GetRoles(Role FilterA/*, int count, int page*/, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Role> roles = db.Roles.Where(r => r.Id != 1);

                if (FilterA.Id != 0)
                {
                    roles = roles.Where(r => r.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    //query = query.Where(r => r.Name.Contains(FilterA.Name));
                    roles = roles.Where(r => r.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                rowsCount = roles.Count();

                roles = roles.Skip((page - 1) * count).Take(count);


                return roles.ToList();

            }
        }
    }

    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        //public DateTime DelTime { get; set; }
    }

    [Table("RolesPermissions")]
    public class RolesPermissions
    {
        [Column("Id_Role")]
        public int RoleId { get; set; }
        [Column("Id_Role")]
        public Role Role { get; set; }

        [Column("Id_Permission")]
        public int PermissionId { get; set; }
        [Column("Id_Permission")]
        public Permission Permission { get; set; }
    }

    [Table("MastersCategories")]
    public class MastersCategories
    {
        [Column("Id_Master")]
        public int MasterId { get; set; }
        [Column("Id_Master")]
        public Master Master { get; set; }

        [Column("Id_Category")]
        public int CategoryId { get; set; }
        [Column("Id_Category")]
        public Category Category { get; set; }
    }

}

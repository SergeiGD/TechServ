using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.employees
{
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

                

                employees = employees.SortBy(sortBy, desk);

                rowsCount = employees.Count();                                  // общее кол-во строк для постраничного вывода

                employees = employees.Skip((page - 1) * count).Take(count);

                return employees.ToList();

            }
        }

    }
}
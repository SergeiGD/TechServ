using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees.timetables;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.person;
using Forms_TechServ.classes.workshops;

namespace Forms_TechServ.classes.employees
{
    public abstract class Employee : Person
    {
        public string AdditionalInfo { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        [Column("Id_Role")]
        public int RoleId { get; set; }
        [Column("Id_Role")]
        public Role Role { get; set; }

        [Column("Id_Workshop")]
        public int WorkshopId { get; set; }
        [Column("Id_Workshop")]
        public Workshop Workshop { get; set; }

        public abstract bool AddEmployee();
        public abstract bool DelEmployee();
        public abstract bool EditEmployee();

        public List<EmployeeTimetable> GetTimetables(EmployeeTimetable FilterA, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<EmployeeTimetable> timetables = db.EmployeesTimetables.Where(t => t.EmployeeId == this.Id && t.DelTime == null).Include(t => t.Employee);

                if (FilterA.Id != 0)
                {
                    timetables = timetables.Where(t => t.Id == FilterA.Id);
                }

                timetables = timetables.Where(t => t.ShiftStart >= FilterA.ShiftStart && t.ShiftEnd <= FilterA.ShiftEnd);


                timetables = timetables.SortBy("ShiftStart", true);

                rowsCount = timetables.Count();

                timetables = timetables.Skip((page - 1) * count).Take(count);

                return timetables.ToList();
            }
        }

    }
}
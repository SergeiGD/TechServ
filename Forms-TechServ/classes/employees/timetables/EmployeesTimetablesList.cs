using Forms_TechServ.classes.databaseContext;

namespace Forms_TechServ.classes.employees.timetables
{
    public static class EmployeesTimetablesList
    {
        public static EmployeeTimetable GetById(int id)
        {
            using (var db = new TechContext())
            {
                var timetable = db.EmployeesTimetables.Find(id);
                db.Entry(timetable).Reference(t => t.Employee).Load();
                return timetable;
            }
        }
    }
}
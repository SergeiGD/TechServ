using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.workshops.timetables
{
    public static class WorkshopsTimetablesList
    {
        public static WorkshopTimetable GetById(int id)
        {
            using(TechContext db = new TechContext())
            {
                WorkshopTimetable timetable = db.WorkshopsTimetables.Find(id);
                db.Entry(timetable).Reference(t => t.Workshop).Load();
                return timetable;
            }
        }

        public static List<WorkshopTimetable> GetWorkshopsTimetables(WorkshopTimetable FilterA, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<WorkshopTimetable> timetables = db.WorkshopsTimetables.Where(t => t.DelTime == null && t.WorkshopId == FilterA.Workshop.Id).Include(t => t.Workshop);

                timetables.SortBy("ValidUntil", true);

                rowsCount = timetables.Count();

                timetables = timetables.Skip((page - 1) * count).Take(count);

                return timetables.ToList();
            }
        }
    }
}

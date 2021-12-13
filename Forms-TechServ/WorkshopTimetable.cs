using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Itenso.TimePeriod;

namespace Forms_TechServ
{
    [Table("WorkshopsTimetables")]
    public class WorkshopTimetable
    {
        public int Id { get; set; }

        [Column("Opening")]                                                             // В c# нету типа данных для времени без даты, так что сделал это через TimeSpan
        private double OpeningTicks { get; set; }                                       // и т.к. SQLite не поддерживает TimeSpan, как в услугах сделаем обертку
        [NotMapped]                                                                     // в виде private числовых свойств, которые преобразуются в TimeSpan
        public TimeSpan Opening                                                         // и теперь можем нормально работать с TimeSpan
        {
            get
            {
                return TimeSpan.FromHours(OpeningTicks);
            }
            set
            {
                OpeningTicks = value.TotalHours;
            }
        }

        [Column("Closing")]
        private double ClosingTicks { get; set; }
        [NotMapped]
        public TimeSpan Closing
        {
            get
            {
                return TimeSpan.FromHours(ClosingTicks);
            }
            set
            {
                ClosingTicks = value.TotalHours;
            }
        }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }

        [Column("Id_Workshop")]
        public int WorkshopId { get; set; }
        [Column("Id_Workshop")]
        public Workshop Workshop { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddWorkshopTimetable()
        {
            using (TechContext db = new TechContext())
            {
                // С ПОМОЩЬЮ БИБЛИОТЕКИ TimePeriod ПРОВЕРЯЕМ, ЧТОБ ВВЕДЕННЫЙ ПРОМЕЖУТОК НЕ ПЕРЕСЕКАЛСЯ С СУЩЕСТВУЮЩИМИ В ЭТОЙ МАСТЕРСКОЙ
                TimeRange timeRangeCurrent = new TimeRange(this.ValidFrom, this.ValidUntil);
 
                foreach (WorkshopTimetable timetable in db.WorkshopsTimetables.Where(t => t.DelTime == null && t.WorkshopId == this.WorkshopId))
                {
                    TimeRange timeRangeFound = new TimeRange(timetable.ValidFrom, timetable.ValidUntil);
                    if (timeRangeFound.IntersectsWith(timeRangeCurrent))
                    {
                        return false;
                    }
                }

                db.WorkshopsTimetables.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditWorkshopTimetalbe()
        {
            using (TechContext db = new TechContext())
            {
                TimeRange timeRangeCurrent = new TimeRange(this.ValidFrom, this.ValidUntil);

                foreach (WorkshopTimetable timetable in db.WorkshopsTimetables.Where(t => t.DelTime == null && t.WorkshopId == this.WorkshopId && t.Id != this.Id))
                {
                    TimeRange timeRangeFound = new TimeRange(timetable.ValidFrom, timetable.ValidUntil);
                    if (timeRangeFound.IntersectsWith(timeRangeCurrent))
                    {
                        return false;
                    }
                }

                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelWorkshopTimetalbe()
        {
            using (TechContext db = new TechContext())
            {
                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public class TimetableConfig : EntityTypeConfiguration<WorkshopTimetable>    // Настрока свойства ..Ticks, чтоб оно взаимодействовало с моделью, не смотря на то, что private
        {
            public TimetableConfig()
            {
                Property(p => p.OpeningTicks);
                Property(p => p.ClosingTicks);
            }
        }
    }

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

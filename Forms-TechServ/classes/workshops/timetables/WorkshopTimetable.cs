using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees.timetables;
using Itenso.TimePeriod;

namespace Forms_TechServ.classes.workshops.timetables
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

                // ПРОВЕРКА, НЕ ПРОПАДУТ ЛИ ПРИ ИЗМЕНЕНИЕ РАСПИСАНИЯ ФИЛИАЛА СМЕНЫ У РАБОТНИКОВ
                // НАМ НУЖНО ПОЛУЧИТЬ ТЕКУЩЕЕ РАСПИСАНИЯ ДО ВНЕСЕНИЯ ИЗМЕНЕНИЙ
                WorkshopTimetable oldTimtalbe = WorkshopsTimetablesList.GetById(this.Id);//db.WorkshopsTimetables.Find(this.Id);
                TimeRange timeRangeOld = new TimeRange(oldTimtalbe.ValidFrom, oldTimtalbe.ValidUntil);

                foreach (EmployeeTimetable timetable in db.EmployeesTimetables.Include(t => t.Employee).Where(t => t.Employee.WorkshopId == this.Id && t.DelTime == null && t.Employee.DelTime == null))
                {
                    // ЕСЛИ В СТАРОМ РАПИСАНИЕ БЫЛА СМЕНА РАБОТНИКА, А ПРИ НОВОМ ЕЕ НЕТУ, ТО ОТМЕНЯЕМ ИЗМЕНЕНИЯ
                    if(timeRangeOld.HasInside(timetable.ShiftStart) && !timeRangeCurrent.HasInside(timetable.ShiftStart))
                    {
                        return false;
                    }

                    // ЕСЛИ ДАТЫ НЕ КОНФЛИКТУЮТ, ТО ПРОВЕРЯМ ВРЕМЯ
                    if (timeRangeCurrent.HasInside(timetable.ShiftStart))
                    {
                        TimeSpan shitStart = new TimeSpan(timetable.ShiftStart.Hour, timetable.ShiftStart.Minute, 0);
                        TimeSpan shitEnd = new TimeSpan(timetable.ShiftEnd.Hour, timetable.ShiftEnd.Minute, 0);

                        if (this.Opening > shitStart || this.Closing < shitEnd)
                        {
                            return false;
                        }
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

                TimeRange timeRange = new TimeRange(this.ValidFrom, this.ValidUntil);
                foreach (EmployeeTimetable timetable in db.EmployeesTimetables.Include(t => t.Employee).Where(t => t.Employee.WorkshopId == this.WorkshopId && t.DelTime == null && t.Employee.DelTime == null))
                {
                    // ЕСЛИ НА ЭТО ВРЕМЯ ЕСТЬ РАСПИСАНИЯ СОТРУДНИКОВ, ТО УДАЛИТЬ НЕЛЬЗЯ
                    if (timeRange.HasInside(timetable.ShiftStart))
                    {
                        return false;
                    }
                }


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
}
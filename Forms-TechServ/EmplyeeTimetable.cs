using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itenso.TimePeriod;
using System.Data.Entity;

namespace Forms_TechServ
{
    [Table("EmployeesTimetables")]
    public class EmployeeTimetable
    {
        public int Id { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }

        [Column("Id_Employee")]
        public int EmployeeId { get; set; }
        [Column("Id_Employee")]
        public Employee Employee { get; set; }

        public DateTime? DelTime { get; set; }

        public int AddTimetalbe()
        {
            using (TechContext db = new TechContext())
            {
                // СНАЧАЛА ПРОВЕРЯЕМ НЕТУ ЛИ УЖЕ РАСПИСАНИЯ НА ЭТОТ ДЕНЬ

                foreach (EmployeeTimetable timetable in db.EmployeesTimetables.Where(t => t.EmployeeId == this.EmployeeId && t.DelTime == null))
                {
                    if (new DateTime(timetable.ShiftStart.Year, timetable.ShiftStart.Month, timetable.ShiftStart.Day) == new DateTime(this.ShiftStart.Year, this.ShiftStart.Month, this.ShiftStart.Day))
                    {

                        return 1;
                    }
                }

                // ПОТОМ ПРОВЕРЯМ РАБОТАЕТ ЛИ ФИЛИАЛ В ВЫБРАННОЕ ВРЕМЯ
                TimeRange shitRange = new TimeRange(this.ShiftStart, this.ShiftEnd);
                Employee employee = EmployeesList.GetById(this.EmployeeId, false);      // т.к. на этом моменте еще не присвоен объект employee, но есть его id'шник, получим его с помощью id

                foreach (WorkshopTimetable workshopTimetable in db.WorkshopsTimetables.Include(t => t.Workshop).Where(t => t.WorkshopId == employee.WorkshopId && t.DelTime == null && t.Workshop.DelTime == null))
                {
                    if (new TimeRange(workshopTimetable.ValidFrom, workshopTimetable.ValidUntil).HasInside(shitRange) && workshopTimetable.Opening <= new TimeSpan(this.ShiftStart.Hour, this.ShiftStart.Minute, 0) && workshopTimetable.Closing >= new TimeSpan(this.ShiftEnd.Hour, this.ShiftEnd.Minute, 0))
                    {
                        db.EmployeesTimetables.Add(this);
                        db.SaveChanges();
                        return 0;               // 0 - успешно добавлено
                    }
                }

                return 2;
                
            }
        }

        public bool EditTimetable()
        {
            using (TechContext db = new TechContext())
            {
                foreach (WorkshopTimetable workshopTimetable in db.WorkshopsTimetables.Where(t => t.WorkshopId == this.Employee.WorkshopId && DelTime == null))
                {
                    // МОЖЕМ ИЗМЕНИТЬ ТОЛЬКО ЧАСЫ РАБОТЫ, ТАК ЧТО ДАТУ ПОВТОРНО ПРОВЕРЯТЬ НЕ НАДО
                    if (workshopTimetable.Opening <= new TimeSpan(this.ShiftStart.Hour, this.ShiftStart.Minute, 0) && workshopTimetable.Closing >= new TimeSpan(this.ShiftEnd.Hour, this.ShiftEnd.Minute, 0))
                    {

                        db.Entry(this).Reference(t => t.Employee);

                        if (this.Employee is Master)
                        {
                            // ПРОВЕРЯЕМ НЕ КОНФЛИКТУЕТ ЛИ НОВОЕ РАСПИСАНИЕ С ВИЗИТАМИ НА ЭТОТ ДЕНЬ
                            foreach (Visit visit in db.Visits.Include(v => v.Order).Where(v => v.Order.MasterId == this.EmployeeId && v.DelTime == null))
                            {
                                if (new DateTime(visit.DateVisit.Year, visit.DateVisit.Month, visit.DateVisit.Day) == new DateTime(this.ShiftStart.Year, this.ShiftStart.Month, this.ShiftStart.Day))
                                {
                                    TimeRange visitRange = new TimeRange(visit.DateVisit, visit.DateVisit + visit.CalcEstimatedTime());
                                    TimeRange shiftRange = new TimeRange(this.ShiftStart, this.ShiftEnd);

                                    if (!shiftRange.IntersectsWith(visitRange))
                                    {
                                        return false;
                                    }
                                }

                            }
                        }

                        db.Entry(this).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;

                    }
                }

                return false;
            }
        }

        public bool DelTimetable()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).Reference(t => t.Employee);

                if(this.Employee is Master)
                {
                    foreach (Visit visit in db.Visits.Include(v => v.Order).Where(v => v.Order.MasterId == this.EmployeeId && v.DelTime == null))
                    {
                        //new DateTime(visit.DateVisit.Year, visit.DateVisit.Month, visit.DateVisit.Day);
                        if(new DateTime(visit.DateVisit.Year, visit.DateVisit.Month, visit.DateVisit.Day) == new DateTime(this.ShiftStart.Year, this.ShiftStart.Month, this.ShiftStart.Day))
                        {
                            return false;   // ЕСЛИ НА ЭТОТ ДЕНЬ ЗАПЛАНИРОВАН ВЫЕЗД, ТО УДАЛИТЬ НЕЛЬЗЯ

                            
                        }
                        
                    }
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;

                

                db.SaveChanges();
                return true;
            }
        }
    }

    public static class EmployeesTimetablesList
    {
        public static EmployeeTimetable GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                EmployeeTimetable timetable = db.EmployeesTimetables.Find(id);
                db.Entry(timetable).Reference(t => t.Employee).Load();
                return timetable;
            }
        }
    }
}

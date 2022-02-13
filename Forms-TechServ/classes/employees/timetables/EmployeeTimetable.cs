using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Itenso.TimePeriod;

namespace Forms_TechServ.classes.employees.timetables
{
    [Table("EmployeesTimetables")]
    public class EmployeeTimetable
    {
        public int Id { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }

        [Column("Id_Employee")] public int EmployeeId { get; set; }

        [Column("Id_Employee")] public Employee Employee { get; set; }

        public DateTime? DelTime { get; set; }

        public int AddTimetalbe()
        {
            using (var db = new TechContext())
            {
                // СНАЧАЛА ПРОВЕРЯЕМ НЕТУ ЛИ УЖЕ РАСПИСАНИЯ НА ЭТОТ ДЕНЬ

                foreach (var timetable in db.EmployeesTimetables.Where(t =>
                             t.EmployeeId == EmployeeId && t.DelTime == null))
                    if (new DateTime(timetable.ShiftStart.Year, timetable.ShiftStart.Month, timetable.ShiftStart.Day) ==
                        new DateTime(ShiftStart.Year, ShiftStart.Month, ShiftStart.Day))
                        return 1;

                // ПОТОМ ПРОВЕРЯМ РАБОТАЕТ ЛИ ФИЛИАЛ В ВЫБРАННОЕ ВРЕМЯ
                var shitRange = new TimeRange(ShiftStart, ShiftEnd);
                var employee =
                    EmployeesList.GetById(EmployeeId,
                        false); // т.к. на этом моменте еще не присвоен объект employee, но есть его id'шник, получим его с помощью id

                foreach (var workshopTimetable in db.WorkshopsTimetables.Include(t => t.Workshop).Where(t =>
                             t.WorkshopId == employee.WorkshopId && t.DelTime == null && t.Workshop.DelTime == null))
                    if (new TimeRange(workshopTimetable.ValidFrom, workshopTimetable.ValidUntil).HasInside(shitRange) &&
                        workshopTimetable.Opening <= new TimeSpan(ShiftStart.Hour, ShiftStart.Minute, 0) &&
                        workshopTimetable.Closing >= new TimeSpan(ShiftEnd.Hour, ShiftEnd.Minute, 0))
                    {
                        db.EmployeesTimetables.Add(this);
                        db.SaveChanges();
                        return 0; // 0 - успешно добавлено
                    }

                return 2;
            }
        }

        public bool EditTimetable()
        {
            using (var db = new TechContext())
            {
                foreach (var workshopTimetable in db.WorkshopsTimetables.Where(t =>
                             t.WorkshopId == Employee.WorkshopId && DelTime == null))
                    // МОЖЕМ ИЗМЕНИТЬ ТОЛЬКО ЧАСЫ РАБОТЫ, ТАК ЧТО ДАТУ ПОВТОРНО ПРОВЕРЯТЬ НЕ НАДО
                    if (workshopTimetable.Opening <= new TimeSpan(ShiftStart.Hour, ShiftStart.Minute, 0) &&
                        workshopTimetable.Closing >= new TimeSpan(ShiftEnd.Hour, ShiftEnd.Minute, 0))
                    {
                        db.Entry(this).Reference(t => t.Employee);

                        if (Employee is Master)
                            // ПРОВЕРЯЕМ НЕ КОНФЛИКТУЕТ ЛИ НОВОЕ РАСПИСАНИЕ С ВИЗИТАМИ НА ЭТОТ ДЕНЬ
                            foreach (var visit in db.Visits.Include(v => v.Order)
                                         .Where(v => v.Order.MasterId == EmployeeId && v.DelTime == null))
                                if (new DateTime(visit.DateVisit.Year, visit.DateVisit.Month, visit.DateVisit.Day) ==
                                    new DateTime(ShiftStart.Year, ShiftStart.Month, ShiftStart.Day))
                                {
                                    var visitRange = new TimeRange(visit.DateVisit,
                                        visit.DateVisit + visit.CalcEstimatedTime());
                                    var shiftRange = new TimeRange(ShiftStart, ShiftEnd);

                                    if (!shiftRange.IntersectsWith(visitRange)) return false;
                                }

                        db.Entry(this).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }

                return false;
            }
        }

        public bool DelTimetable()
        {
            using (var db = new TechContext())
            {
                db.Entry(this).Reference(t => t.Employee);

                if (Employee is Master)
                    foreach (var visit in db.Visits.Include(v => v.Order)
                                 .Where(v => v.Order.MasterId == EmployeeId && v.DelTime == null))
                        //new DateTime(visit.DateVisit.Year, visit.DateVisit.Month, visit.DateVisit.Day);
                        if (new DateTime(visit.DateVisit.Year, visit.DateVisit.Month, visit.DateVisit.Day) ==
                            new DateTime(ShiftStart.Year, ShiftStart.Month, ShiftStart.Day))
                            return false; // ЕСЛИ НА ЭТОТ ДЕНЬ ЗАПЛАНИРОВАН ВЫЕЗД, ТО УДАЛИТЬ НЕЛЬЗЯ

                DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;


                db.SaveChanges();
                return true;
            }
        }
    }
}
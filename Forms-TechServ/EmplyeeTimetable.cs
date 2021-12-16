﻿using System;
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

        public bool AddTimetalbe()
        {
            using (TechContext db = new TechContext())
            {
                // СНАЧАЛА ПРОВЕРЯЕМ НЕТУ ЛИ УЖЕ РАСПИСАНИЯ НА ЭТОТ ДЕНЬ

                foreach (EmployeeTimetable timetable in db.EmployeesTimetables.Where(t => t.EmployeeId == this.EmployeeId && t.DelTime == null))
                {
                    if (new DateTime(timetable.ShiftStart.Year, timetable.ShiftStart.Month, timetable.ShiftStart.Day) == new DateTime(this.ShiftStart.Year, this.ShiftStart.Month, this.ShiftStart.Day))
                    {

                        return false;
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
                        return true;
                    }
                }

                return false;
                /*if (db.EmployeesTimetables.Where(t => t.ShiftStart.ToShortDateString()new DateTime(t.ShiftStart.Year, t.ShiftStart.Month, t.ShiftStart.Day) == new DateTime(this.ShiftStart.Year, this.ShiftStart.Month, this.ShiftStart.Day) && t.EmployeeId == this.EmployeeId).Count() == 0)
                {

                    // ПОТОМ С ПОМОЩЬЮ БИБЛИОТЕКИ TimePeriod ПРОВЕРЯЕМ, ЧТОБ УКАЗАННОЕ РАСПИСАНИЕ НЕ КОНФЛИКТОВАЛО С ФИЛИАЛОМ РАБОТНИКА
                    TimeRange shitRange = new TimeRange(this.ShiftStart, this.ShiftEnd);

                    foreach (WorkshopTimetable workshopTimetable in db.WorkshopsTimetables.Where(t => t.WorkshopId == this.Employee.WorkshopId && DelTime == null))
                    {
                        if (new TimeRange(workshopTimetable.ValidFrom, workshopTimetable.ValidUntil).HasInside(shitRange) && workshopTimetable.Opening <= new TimeSpan(this.ShiftStart.Hour, this.ShiftStart.Minute, 0) && workshopTimetable.Closing >= new TimeSpan(this.ShiftEnd.Hour, this.ShiftEnd.Minute, 0))
                        {
                            db.EmployeesTimetables.Add(this);
                            db.SaveChanges();
                            return true;
                        }
                    }

                    return false;
                }
                else
                {
                    return false;
                }*/
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
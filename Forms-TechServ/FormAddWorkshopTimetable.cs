using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TechServ
{
    public partial class FormManageWorkshopTimetable : Form
    {
        public WorkshopTimetable timetable;
        Workshop workshop;

        public FormManageWorkshopTimetable(Workshop workshop)
        {
            InitializeComponent();

            actionBtn.Text = "Добавить";

            this.workshop = workshop;

            timetable = new WorkshopTimetable();
        }

        public FormManageWorkshopTimetable(WorkshopTimetable timetable)
        {
            InitializeComponent();

            actionBtn.Text = "Сохранить";

            this.timetable = timetable;
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (!Regex.IsMatch(tbStart.Text, @"\d{2}:\d{2}") || Convert.ToInt32(tbStart.Text.Substring(0, 2)) >= 24 || Convert.ToInt32(tbStart.Text.Substring(0, 2)) < 0 || Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)) >= 60 || Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)) < 0)
            {
                errorProvider.SetError(tbStart, "Введите корректно время открытия (24 часовой формат)");
                return false;
            }
            if (!Regex.IsMatch(tbEnd.Text, @"\d{2}:\d{2}") || Convert.ToInt32(tbEnd.Text.Substring(0, 2)) >= 24 || Convert.ToInt32(tbEnd.Text.Substring(0, 2)) < 0 || Convert.ToInt32(tbEnd.Text.Substring(tbEnd.Text.Length - 2)) >= 60 || Convert.ToInt32(tbEnd.Text.Substring(tbEnd.Text.Length - 2)) < 0)
            {
                errorProvider.SetError(tbEnd, "Введите корректно время закрытия (24 часовой формат)");
                return false;
            }

            TimeSpan from = new TimeSpan(Convert.ToInt32(tbStart.Text.Substring(0, 2)), Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)), 0);
            TimeSpan until = new TimeSpan(Convert.ToInt32(tbEnd.Text.Substring(0, 2)), Convert.ToInt32(tbEnd.Text.Substring(tbStart.Text.Length - 2)), 0);
            if(from >= until)
            {
                errorProvider.SetError(tbStart, "Время открытия не может быть больше время закрытия или равняться ему");
                return false;
            }

            if(new DateTime(datePickerFrom.Value.Year, datePickerFrom.Value.Month, datePickerFrom.Value.Day) >= new DateTime(datePickerUntil.Value.Year, datePickerUntil.Value.Month, datePickerUntil.Value.Day))
            {
                errorProvider.SetError(datePickerFrom, "Дата начала действия расписания не может быть больше даты окончания или равняться ей");
                return false;
            }

            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                timetable.ValidFrom = new DateTime(datePickerFrom.Value.Year, datePickerFrom.Value.Month, datePickerFrom.Value.Day);
                timetable.ValidUntil = new DateTime(datePickerUntil.Value.Year, datePickerUntil.Value.Month, datePickerUntil.Value.Day);
                timetable.Opening = new TimeSpan(Convert.ToInt32(tbStart.Text.Substring(0, 2)), Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)), 0);
                timetable.Closing = new TimeSpan(Convert.ToInt32(tbEnd.Text.Substring(0, 2)), Convert.ToInt32(tbEnd.Text.Substring(tbStart.Text.Length - 2)), 0);
                

                if(timetable.Id == 0)
                {
                    timetable.WorkshopId = workshop.Id;

                    if (timetable.AddWorkshopTimetable())
                    {
                        MessageBox.Show($"Новое расписание успешно сформированно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"На данные промежуток дат уже есть расписание или они частично пересекаются", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

                else
                {
                    if (timetable.EditWorkshopTimetalbe())
                    {
                        MessageBox.Show($"Расписание успешно изменено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"На данные промежуток дат уже есть расписание или они частично пересекаются или же это изменение конфликтует с расписанием сотрудника/сотрудников", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormManageWorkshopTimetable_Load(object sender, EventArgs e)
        {
            if(timetable.Id != 0)
            {
                tbStart.Text = timetable.Opening.ToString();
                tbEnd.Text = timetable.Closing.ToString();

                datePickerFrom.Value = timetable.ValidFrom;
                datePickerUntil.Value = timetable.ValidUntil;
            }
        }
    }
}

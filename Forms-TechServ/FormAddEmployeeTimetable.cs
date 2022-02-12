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
    public partial class FormAddEmployeeTimetable : Form
    {
        EmployeeTimetable timetable;
        Employee employee;

        public FormAddEmployeeTimetable(Employee employee)
        {
            InitializeComponent();

            timetable = new EmployeeTimetable();
            this.employee = employee;

        }

        public FormAddEmployeeTimetable(EmployeeTimetable timetable)
        {
            InitializeComponent();

            datePickerBegin.Enabled = false;
            checkBoxRepeat.Enabled = false;

            this.timetable = timetable;
        }

        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRepeat.Checked)
            {
                groupDays.Enabled = true;
                groupEnd.Enabled = true;
            }
            else
            {
                groupDays.Enabled = false;
                groupEnd.Enabled = false;
            }
        }

        private void FormAddEmployeeTimetable_Load(object sender, EventArgs e)
        {
            checkBoxRepeat.Checked = true;
            radioBtnEndDate.Checked = true;

            if (timetable.Id != 0)
            {
                checkBoxRepeat.Checked = false;

                datePickerBegin.Value = timetable.ShiftStart;
                tbStart.Text = timetable.ShiftStart.ToShortTimeString();
                tbEnd.Text = timetable.ShiftEnd.ToShortTimeString();
            }
            else
            {
                checkBoxRepeat.Checked = false;
            }
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (!Regex.IsMatch(tbStart.Text, @"\d{2}:\d{2}") || Convert.ToInt32(tbStart.Text.Substring(0, 2)) >= 24 || Convert.ToInt32(tbStart.Text.Substring(0, 2)) < 0 || Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)) >= 60 || Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)) < 0)
            {
                errorProvider.SetError(tbStart, "Введите корректно время начала смены (24 часовой формат)");
                return false;
            }
            if (!Regex.IsMatch(tbEnd.Text, @"\d{2}:\d{2}") || Convert.ToInt32(tbEnd.Text.Substring(0, 2)) >= 24 || Convert.ToInt32(tbEnd.Text.Substring(0, 2)) < 0 || Convert.ToInt32(tbEnd.Text.Substring(tbEnd.Text.Length - 2)) >= 60 || Convert.ToInt32(tbEnd.Text.Substring(tbEnd.Text.Length - 2)) < 0)
            {
                errorProvider.SetError(tbEnd, "Введите корректно время окончания смены (24 часовой формат)");
                return false;
            }

            TimeSpan from = new TimeSpan(Convert.ToInt32(tbStart.Text.Substring(0, 2)), Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)), 0);
            TimeSpan until = new TimeSpan(Convert.ToInt32(tbEnd.Text.Substring(0, 2)), Convert.ToInt32(tbEnd.Text.Substring(tbStart.Text.Length - 2)), 0);
            if (from >= until)
            {
                errorProvider.SetError(tbStart, "Время начала смены не может быть больше время окончания или равняться ему");
                return false;
            }

            if (checkBoxRepeat.Checked && !checkBoxMon.Checked && !checkBoxTue.Checked && !checkBoxWen.Checked && !checkBoxThu.Checked && !checkBoxFri.Checked && !checkBoxSat.Checked && !checkBoxSun.Checked)
            {
                errorProvider.SetError(checkBoxRepeat, "Для начала выберите хотя бы один день для повторения");
                return false;
            }

            if (checkBoxRepeat.Checked && radioBtnEndDate.Checked)
            {
                if (new DateTime(datePickerBegin.Value.Year, datePickerBegin.Value.Month, datePickerBegin.Value.Day) >= new DateTime(datePickerEnd.Value.Year, datePickerEnd.Value.Month, datePickerEnd.Value.Day))
                {
                    errorProvider.SetError(datePickerEnd, "Дата начала действия расписания не может быть больше даты окончания или равняться ей");
                    return false;
                }
            }

            
            

            return true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                timetable.ShiftStart = new DateTime(datePickerBegin.Value.Year, datePickerBegin.Value.Month, datePickerBegin.Value.Day, Convert.ToInt32(tbStart.Text.Substring(0, 2)), Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)), 0);
                timetable.ShiftEnd = new DateTime(datePickerBegin.Value.Year, datePickerBegin.Value.Month, datePickerBegin.Value.Day, Convert.ToInt32(tbEnd.Text.Substring(0, 2)), Convert.ToInt32(tbEnd.Text.Substring(tbEnd.Text.Length - 2)), 0);

                if (timetable.Id == 0)
                {
                    timetable.EmployeeId = employee.Id;

                    //bool success = true;
                    int errorsFormed = 0;
                    int errorsBranch = 0;

                    switch (timetable.AddTimetalbe())
                    {
                        case 1:
                            errorsFormed++;
                            break;
                        case 2:
                            errorsBranch++;
                            break;
                    }


                    if (checkBoxRepeat.Checked)
                    {
                        List<DayOfWeek> pickedDays = new List<DayOfWeek>();
                        if (checkBoxMon.Checked)
                            pickedDays.Add(DayOfWeek.Monday);
                        if (checkBoxTue.Checked)
                            pickedDays.Add(DayOfWeek.Tuesday);
                        if (checkBoxWen.Checked)
                            pickedDays.Add(DayOfWeek.Wednesday);
                        if (checkBoxThu.Checked)
                            pickedDays.Add(DayOfWeek.Thursday);
                        if (checkBoxFri.Checked)
                            pickedDays.Add(DayOfWeek.Friday);
                        if (checkBoxSat.Checked)
                            pickedDays.Add(DayOfWeek.Saturday);
                        if (checkBoxSun.Checked)
                            pickedDays.Add(DayOfWeek.Sunday);

                        if (radioBtnEndDate.Checked)
                        {
                            DateTime currentDay = new DateTime(datePickerBegin.Value.Year, datePickerBegin.Value.Month, datePickerBegin.Value.Day + 1);
                            DateTime endOn = new DateTime(datePickerEnd.Value.Year, datePickerEnd.Value.Month, datePickerEnd.Value.Day);
                            while (currentDay <= endOn)
                            {
                                if (pickedDays.Contains(currentDay.DayOfWeek))
                                {
                                    EmployeeTimetable anotherDay = new EmployeeTimetable()
                                    {
                                        ShiftStart = new DateTime(currentDay.Year, currentDay.Month, currentDay.Day, Convert.ToInt32(tbStart.Text.Substring(0, 2)), Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)), 0),
                                        ShiftEnd = new DateTime(currentDay.Year, currentDay.Month, currentDay.Day, Convert.ToInt32(tbEnd.Text.Substring(0, 2)), Convert.ToInt32(tbEnd.Text.Substring(tbEnd.Text.Length - 2)), 0),
                                        EmployeeId = employee.Id
                                    };


                                    switch (anotherDay.AddTimetalbe())
                                    {
                                        case 1:
                                            errorsFormed++;
                                            break;
                                        case 2:
                                            errorsBranch++;
                                            break;
                                    }

                                }
                                currentDay = currentDay.AddDays(1);
                            }
                        }
                        else
                        {
                            DateTime currentDay = new DateTime(datePickerBegin.Value.Year, datePickerBegin.Value.Month, datePickerBegin.Value.Day + 1);
                            DateTime endOn = new DateTime(datePickerBegin.Value.Year, datePickerBegin.Value.Month, datePickerBegin.Value.Day).AddDays(7 * (double)numericRepeat.Value);
                            while (currentDay <= endOn)
                            {
                                if (pickedDays.Contains(currentDay.DayOfWeek))
                                {
                                    EmployeeTimetable anotherDay = new EmployeeTimetable()
                                    {
                                        ShiftStart = new DateTime(currentDay.Year, currentDay.Month, currentDay.Day, Convert.ToInt32(tbStart.Text.Substring(0, 2)), Convert.ToInt32(tbStart.Text.Substring(tbStart.Text.Length - 2)), 0),
                                        ShiftEnd = new DateTime(currentDay.Year, currentDay.Month, currentDay.Day, Convert.ToInt32(tbEnd.Text.Substring(0, 2)), Convert.ToInt32(tbEnd.Text.Substring(tbEnd.Text.Length - 2)), 0),
                                        EmployeeId = employee.Id
                                    };


                                    switch (anotherDay.AddTimetalbe())
                                    {
                                        case 1:
                                            errorsFormed++;
                                            break;
                                        case 2:
                                            errorsBranch++;
                                            break;
                                    }

                                }
                                currentDay = currentDay.AddDays(1);
                            }
                        }
                    }

                    this.Close();

                    if (errorsFormed == 0 && errorsBranch == 0)
                    {
                        MessageBox.Show("Все дни расписания успешно сформированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{errorsFormed + errorsBranch} дней не были добавлены из-за конфликтов расписаний: {Environment.NewLine} {errorsFormed} - расписание уже сформировано; {Environment.NewLine} {errorsBranch} - расписание для филиала не сформированно или филиал не работает в это время", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {


                    if (timetable.EditTimetable())
                    {
                        MessageBox.Show("Расписание успешно изменено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Невозможно внести изменения из-за конфликтов раписаний", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    this.Close();
                }

                
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TechServ
{
    public partial class FormEmpTimetalbe : Form
    {
        int rowsCount;
        int currentPage = 1;
        Employee employee;
        bool readOnly;

        public FormEmpTimetalbe(Employee employee, bool readOnly)
        {
            InitializeComponent();

            this.employee = employee;
            this.readOnly = readOnly;

            if (!readOnly && UserSession.Can("edit_employee"))
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddNewTimetalbe_Click;

                ManageButton btnADel = new ManageButton();
                btnADel.Text = "Удалить";
                panelControl.Controls.Add(btnADel);
                btnADel.Click += BtnDel_Click;

                dataTimetable.CellMouseDoubleClick += dataTimetable_CellMouseDoubleClick;
            }

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        

        private void BtnAddNewTimetalbe_Click(object sender, EventArgs e)
        {
            FormAddEmployeeTimetable formAddEmployeeTimetable = new FormAddEmployeeTimetable(employee);
            formAddEmployeeTimetable.ShowDialog();

            FillGrid();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить ВСЕ выделенные смены?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                int errorDays = 0;
                foreach (DataGridViewRow row in dataTimetable.SelectedRows)
                {
                    EmployeeTimetable anotherTimetable = EmployeesTimetablesList.GetById(Convert.ToInt32(dataTimetable.Rows[row.Index].Cells[0].Value));
                    if (!anotherTimetable.DelTimetable())
                    {
                        errorDays++;
                    }
                    
                }
                if(errorDays == 0)
                {
                    MessageBox.Show("Все смены успешно удалены");
                }
                else
                {
                    MessageBox.Show($"{errorDays} не были удаленны, т.к. на эти дни запланированы выезды");
                }
                

                FillGrid();
            }

        }

        private void FormEmpTimetalbe_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "Id";
            DataGridViewTextBoxColumn dateCol = new DataGridViewTextBoxColumn();
            dateCol.Name = "Дата";
            DataGridViewTextBoxColumn dayOfWeekCol = new DataGridViewTextBoxColumn();
            dayOfWeekCol.Name = "День недели";
            DataGridViewTextBoxColumn startCol = new DataGridViewTextBoxColumn();
            startCol.Name = "Начало смены";
            DataGridViewTextBoxColumn endCol = new DataGridViewTextBoxColumn();
            endCol.Name = "Конец смены";

            dataTimetable.Columns.Add(idCol);
            dataTimetable.Columns.Add(dateCol);
            dataTimetable.Columns.Add(dayOfWeekCol);
            dataTimetable.Columns.Add(startCol);
            dataTimetable.Columns.Add(endCol);

            if (!readOnly && UserSession.Can("edit_employee"))
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataTimetable.Columns.Add(delCol);

                dataTimetable.CellContentClick += DelCol_Click;
            }

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(15);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 1;


            // По умолчанию показываем ближайшие две недели
            datePickerFrom.Value = DateTime.Now;
            datePickerUntil.Value = DateTime.Now + new TimeSpan(14, 0, 0, 0, 0);

            FillGrid();
        }

        private void FillGrid()
        {
            
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            List<EmployeeTimetable> timetables = employee.GetTimetables(
                new EmployeeTimetable()
                {
                    Id = id,
                    ShiftStart = new DateTime(datePickerFrom.Value.Year, datePickerFrom.Value.Month, datePickerFrom.Value.Day),
                    ShiftEnd = new DateTime(datePickerUntil.Value.Year, datePickerUntil.Value.Month, datePickerUntil.Value.Day)
                },
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount);


            dataTimetable.Rows.Clear();
            for (int i = 0; i < timetables.Count; i++)
            {
                dataTimetable.Rows.Add(new DataGridViewRow());

                dataTimetable.Rows[i].Cells[0].Value = timetables[i].Id;
                dataTimetable.Rows[i].Cells[1].Value = timetables[i].ShiftStart.ToShortDateString();
                dataTimetable.Rows[i].Cells[2].Value = timetables[i].ShiftStart.DayOfWeek;
                dataTimetable.Rows[i].Cells[3].Value = timetables[i].ShiftStart.ToShortTimeString();
                dataTimetable.Rows[i].Cells[4].Value = timetables[i].ShiftEnd.ToShortTimeString();

                if (dataTimetable.Columns.Count > 5)
                {
                    dataTimetable.Rows[i].Cells[5].Value = "Удалить";
                    dataTimetable.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataTimetable.Rows[i].Cells[5].Style.ForeColor = Color.White;

                }
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                EmployeeTimetable timetableToDel = EmployeesTimetablesList.GetById((int)dataTimetable.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить смену с id {timetableToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (timetableToDel.DelTimetable())
                    {
                        MessageBox.Show("Смена успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("На этот день запланирован выезд, эту смену пока удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            datePickerFrom.Value = DateTime.Now;
            datePickerUntil.Value = DateTime.Now + new TimeSpan(14, 0, 0, 0, 0);

            FillGrid();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
        }

        private void numericCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentPage.Value = (int)numericCurrentPage.Value;           // если ввели дробное число, оно автоматически округлится
            currentPage = (int)numericCurrentPage.Value;
            FillGrid();
        }

        private void comboBoxShowRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dataTimetable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (!readOnly && UserSession.Can("edit_employee"))
            {
                FormAddEmployeeTimetable formAddEmployeeTimetable = new FormAddEmployeeTimetable(EmployeesTimetablesList.GetById(Convert.ToInt32(dataTimetable.SelectedRows[0].Cells[0].Value)));
                formAddEmployeeTimetable.ShowDialog();

                FillGrid();
            }
            
        }
    }
}

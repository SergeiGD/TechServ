using System;
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

        public FormEmpTimetalbe(Employee employee, bool readOnly)
        {
            InitializeComponent();

            this.employee = employee;

            if (!readOnly)
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
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить эту смену?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {

                EmployeesTimetablesList.GetById(Convert.ToInt32(dataTimetable.SelectedRows[0].Cells[0].Value)).DelTimetable();

                
                MessageBox.Show("Смена успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(15);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 1;

            //datePickerFrom.Va = null;

            // По умолчанию показываем ближайшие две недели
            datePickerFrom.Value = DateTime.Now;
            datePickerUntil.Value = DateTime.Now + new TimeSpan(14, 0, 0, 0, 0);

            FillGrid();
        }

        private void FillGrid()
        {
            

            /*List<WorkshopTimetable> timetables = WorkshopsTimetablesList.GetWorkshopsTimetables(
                new WorkshopTimetable() 
                {
                    Workshop = workshop
                },
                (int)comboBoxShowTimetableRows.SelectedItem,
                currentPage, 
                out rowsCount);*/
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
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            labelPageCount.Text = $"из {maxPage}";
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
            //if(read)
            FormAddEmployeeTimetable formAddEmployeeTimetable = new FormAddEmployeeTimetable(EmployeesTimetablesList.GetById(Convert.ToInt32(dataTimetable.SelectedRows[0].Cells[0].Value)));
            formAddEmployeeTimetable.ShowDialog();

            FillGrid();
        }
    }
}

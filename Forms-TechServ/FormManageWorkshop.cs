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
    public partial class FormManageWorkshop : Form
    {
        Workshop workshop;
        int currentPage = 1;
        int rowsCount;

        Size pickedSize = new Size(1078, 481);
        TabPage empsPage = new TabPage("Сотрудники");
        TabPage batchesPage = new TabPage("Поставки");

        public FormManageWorkshop()
        {
            InitializeComponent();

            this.Size = new Size(494, 187);

            workshopTabs.TabPages.Remove(timetablePage);

            workshop = new Workshop();                      // ЕСЛИ ДОБАВЛЯЕМ НОВЫЙ

            btnAction.Text = "Добавить";
        }

        public FormManageWorkshop(Workshop workshop)
        {
            InitializeComponent();

            this.Size = new Size(494, 187);


            this.workshop = workshop;

            btnAction.Text = "Сохранить общую информацию";

        }

        private void workshopTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workshopTabs.SelectedIndex == 0)
            {
                this.Size = new Size(494, 187);
            }
            else if (workshopTabs.SelectedIndex == 1)
            {
                this.Size = new Size(808, 399);

            }
            else if (workshopTabs.SelectedIndex == 2)
            {
                this.Size = pickedSize;

                FormEmployees formEmployees = new FormEmployees(false, workshop);


                formEmployees.TopLevel = false;
                formEmployees.FormBorderStyle = FormBorderStyle.None;
                workshopTabs.TabPages[2].Controls.Add(formEmployees);
                formEmployees.Dock = DockStyle.Fill;
                formEmployees.BringToFront();
                formEmployees.Show();
            }
            else if (workshopTabs.SelectedTab.Equals(batchesPage))
            {
                this.Size = pickedSize;

                FormBatches formBatches = new FormBatches(workshop, false);

               

                formBatches.TopLevel = false;
                formBatches.FormBorderStyle = FormBorderStyle.None;
                batchesPage.Controls.Add(formBatches);
                formBatches.Dock = DockStyle.Fill;
                formBatches.BringToFront();
                formBatches.Show();
            }
        }

        private void FormManageWorkshop_ResizeEnd(object sender, EventArgs e)
        {
            if(!workshopTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void btnAddTimetable_Click(object sender, EventArgs e)
        {
            FormManageWorkshopTimetable formAddWorkshopTimetable = new FormManageWorkshopTimetable(workshop);
            formAddWorkshopTimetable.ShowDialog();

            FillTimetales();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                workshop.Location = tbAddress.Text;
                workshop.PhoneNum = tbPhoneNum.Text;

                if(workshop.Id == 0)
                {
                    workshop.AddWorkshop();

                    DialogResult answer = MessageBox.Show($"Новый филиал успешно добавлен. Желаете сразу же сформировать расписание?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(answer == DialogResult.Yes)
                    {
                        FormManageWorkshop formManageWorkshop = new FormManageWorkshop(workshop);
                        formManageWorkshop.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    workshop.EditWorkshop();

                    MessageBox.Show($"Данные о филиале успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                
            }
            
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbAddress.Text == "")
            {
                errorProvider.SetError(tbAddress, "Введите адрес");
                return false;
            }
            if (!Regex.IsMatch(tbPhoneNum.Text, @"\d+"))
            {
                errorProvider.SetError(tbPhoneNum, "Введите номер числом");
                return false;
            }

            return true;
        }

        private void FormManageWorkshop_Load(object sender, EventArgs e)
        {
            if(workshop.Id != 0)
            {
                tbAddress.Text = workshop.Location;
                tbPhoneNum.Text = workshop.PhoneNum;

                DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
                idCol.Name = "id";
                DataGridViewTextBoxColumn openCol = new DataGridViewTextBoxColumn();
                openCol.Name = "Открывается";
                DataGridViewTextBoxColumn closeCol = new DataGridViewTextBoxColumn();
                closeCol.Name = "Закрывается";
                DataGridViewTextBoxColumn fromCol = new DataGridViewTextBoxColumn();
                fromCol.Name = "Действует с";
                DataGridViewTextBoxColumn untilCol = new DataGridViewTextBoxColumn();
                untilCol.Name = "Действует до";

                dataTimetable.Columns.Add(idCol);
                dataTimetable.Columns.Add(openCol);
                dataTimetable.Columns.Add(closeCol);
                dataTimetable.Columns.Add(fromCol);
                dataTimetable.Columns.Add(untilCol);

                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataTimetable.Columns.Add(delCol);

                dataTimetable.CellContentClick += DelCol_Click;

                comboBoxShowTimetableRows.Items.Add(5);
                comboBoxShowTimetableRows.Items.Add(20);
                comboBoxShowTimetableRows.Items.Add(30);
                comboBoxShowTimetableRows.Items.Add(40);
                comboBoxShowTimetableRows.SelectedIndex = 2;

                FillTimetales();
            }
        }

        private void FillTimetales()
        {
            dataTimetable.Rows.Clear();

            List<WorkshopTimetable> timetables = workshop.GetTimetables(
                (int)comboBoxShowTimetableRows.SelectedItem,
                currentPage,
                out rowsCount);

            for (int i = 0; i < timetables.Count; i++)
            {
                dataTimetable.Rows.Add(new DataGridViewRow());

                dataTimetable.Rows[i].Cells[0].Value = timetables[i].Id;
                dataTimetable.Rows[i].Cells[1].Value = timetables[i].Opening;
                dataTimetable.Rows[i].Cells[2].Value = timetables[i].Closing;
                dataTimetable.Rows[i].Cells[3].Value = timetables[i].ValidFrom.ToShortDateString();
                dataTimetable.Rows[i].Cells[4].Value = timetables[i].ValidUntil.ToShortDateString();

                if (dataTimetable.Columns.Count > 5)
                {
                    dataTimetable.Rows[i].Cells[5].Value = "Удалить";
                    dataTimetable.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataTimetable.Rows[i].Cells[5].Style.ForeColor = Color.White;

                }
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowTimetableRows.SelectedItem);
            numericCurrentTImetablePage.Maximum = maxPage;

            if (numericCurrentTImetablePage.Maximum > 0)
                numericCurrentTImetablePage.Value = numericCurrentTImetablePage.Value == 0 ? 1 : numericCurrentTImetablePage.Value;

            labelTimetablePageCount.Text = $"из {maxPage}";
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                WorkshopTimetable timetableToDel = WorkshopsTimetablesList.GetById((int)dataTimetable.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить расписание с id {timetableToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (timetableToDel.DelWorkshopTimetalbe())
                    {
                        MessageBox.Show("Расписание успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillTimetales();
                    }
                    else
                    {
                        MessageBox.Show("На этом промежутке времени есть расписания сотрудников, сейчас его удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void dataTimetable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            FormManageWorkshopTimetable formAddWorkshopTimetable = new FormManageWorkshopTimetable(WorkshopsTimetablesList.GetById(Convert.ToInt32(dataTimetable.SelectedRows[0].Cells[0].Value)));
            formAddWorkshopTimetable.ShowDialog();

            FillTimetales();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

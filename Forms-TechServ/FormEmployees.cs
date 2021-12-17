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
    public partial class FormEmployees : Form
    {
        int currentPage = 1;
        int rowsCount;
        bool readOnly;
        Workshop workshop;

        public FormEmployees()
        {
            InitializeComponent();

            readOnly = false;

            if (UserSession.Can("add_del_employee"))
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManage_Click;
            }
                

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }

            btnClean.Click += btnCleanAll_Click;
        }

        public FormEmployees(bool readOnly, Workshop workshop)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddFromWorkshop_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click/*BtnShowInClient_Click*/;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }

            this.workshop = workshop;
            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;

            btnFlindWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;

            btnClean.Click += btnCleanInWorkshop_Click;
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";
            DataGridViewTextBoxColumn phoneCol = new DataGridViewTextBoxColumn();
            phoneCol.Name = "Номер телефона";
            DataGridViewTextBoxColumn salaryCol = new DataGridViewTextBoxColumn();
            salaryCol.Name = "Зарплата";
            DataGridViewTextBoxColumn branchCol = new DataGridViewTextBoxColumn();
            branchCol.Name = "Филиал";
            DataGridViewTextBoxColumn roleCol = new DataGridViewTextBoxColumn();
            roleCol.Name = "Позиция";

            dataEmployees.Columns.Add(idCol);
            dataEmployees.Columns.Add(nameCol);
            dataEmployees.Columns.Add(phoneCol);
            dataEmployees.Columns.Add(salaryCol);
            dataEmployees.Columns.Add(branchCol);
            dataEmployees.Columns.Add(roleCol);

            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Имени");
            comboBoxSortBy.Items.Add("Зарплате");
            //comboBoxSortBy.Items.Add("Номер телефона");
            comboBoxSortBy.SelectedIndex = 0;

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            

            FillGrid();

            /*int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : rowsCount / (int)comboBoxShowRows.SelectedItem;   // устанавливаем начальное кол-во страниц
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";*/

        }

        private void FillGrid()
        {
            // ЕСЛИ ФИЛЬТРЫ ПУСТЫЕ, ТО ПОЛУЧАЕМ ВСЕ ЗНАЧЕНИЯ
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            string sortBy = "Id";

            if (comboBoxSortBy.SelectedItem.ToString() == "id")
            {
                sortBy = "Id";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Имени")
            {
                sortBy = "Name";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Зарплате")
            {
                sortBy = "Salary";
            }

            List<Employee> employees = EmployeesList.GetEmployees(
                new Manager()                                   // т.к. Employee абстрактый, отправим вместо него экземляр Manager с полями Employee
                {
                    Id = id,
                    Name = tbName.Text,
                    PhoneNum = tbPhoneNum.Text,
                    Salary = numericSalaryFrom.Value,
                    Workshop = (Workshop)tbWorkshop.Tag,
                    Role = (Role)tbPosition.Tag,
                },
                new Manager()
                {
                    Salary = numericSalaryUntil.Value
                },
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            // ЗАПОЛНЯЕМ ГРИД
            dataEmployees.Rows.Clear();
            for (int i = 0; i < employees.Count; i++)
            {
                dataEmployees.Rows.Add(new DataGridViewRow());

                dataEmployees.Rows[i].Cells[0].Value = employees[i].Id;
                dataEmployees.Rows[i].Cells[1].Value = employees[i].Name;
                dataEmployees.Rows[i].Cells[2].Value = employees[i].PhoneNum;
                dataEmployees.Rows[i].Cells[3].Value = employees[i].Salary;
                dataEmployees.Rows[i].Cells[4].Value = employees[i].Workshop.Location;
                dataEmployees.Rows[i].Cells[5].Value = employees[i].Role.Name;
            }

            // Расчитываем кол-во страниц
            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : rowsCount / (int)comboBoxShowRows.SelectedItem;
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormPickEmployeeType formPickEmployeeType = new FormPickEmployeeType();
            formPickEmployeeType.ShowDialog();

            
            FillGrid();
        }

        private void BtnAddFromWorkshop_Click(object sender, EventArgs e)
        {
            FormPickEmployeeType formPickEmployeeType = new FormPickEmployeeType(workshop);
            formPickEmployeeType.ShowDialog();


            FillGrid();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if(dataEmployees.SelectedRows.Count > 0)
            {
                Employee employee = EmployeesList.GetById(Convert.ToInt32(dataEmployees.SelectedRows[0].Cells[0].Value), true);     // получаем выбранного сотрудника

                if (employee.GetType() == typeof(Manager))                                                                           // ищем на какой тип ссылка
                {                                                                                                                   // и в зависимости от этого
                    FormShowManager formShowManager = new FormShowManager(readOnly, (Manager)employee);                             // отображаем соотвествующую форму
                    formShowManager.ShowDialog();
                }
                else if (employee.GetType() == typeof(Master))
                {
                    FormShowMaster showMaster = new FormShowMaster(readOnly, (Master)employee);
                    showMaster.ShowDialog();
                }

                FillGrid();
            }
            else
            {
                MessageBox.Show("Для начала выберите сотрудника");
            }   
        }

        private void btnFlindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private void btnAskOrDesk_Click(object sender, EventArgs e)
        {
            if ((bool)btnAskOrDesk.Tag)
            {
                btnAskOrDesk.Tag = false;
            }
            else
            {
                btnAskOrDesk.Tag = true;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnCleanInWorkshop_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbPhoneNum.Clear();
            tbPosition.Clear();
            numericSalaryFrom.Value = 0;
            numericSalaryUntil.Value = 0;
            
            tbPosition.Clear();
            tbPosition.Tag = null;

            FillGrid();
        }

        private void btnCleanAll_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbPhoneNum.Clear();
            tbPosition.Clear();
            numericSalaryFrom.Value = 0;
            numericSalaryUntil.Value = 0;
            tbPosition.Clear();
            tbPosition.Tag = null;
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;

            FillGrid();
        }

        private void btnCleanWorkshop_Click(object sender, EventArgs e)
        {
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;
        }

        private void btnCleanPosition_Click(object sender, EventArgs e)
        {
            tbPosition.Clear();
            tbPosition.Tag = null;
        }

        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormFindEmpPosition formFindEmpPosition = new FormFindEmpPosition();
            formFindEmpPosition.ShowDialog();

            tbPosition.Text = formFindEmpPosition?.pickedRole?.Name;
            tbPosition.Tag = formFindEmpPosition?.pickedRole;
        }

        private void comboBoxShowRows_SelectedIndexChanged(object sender, EventArgs e)
        {

            FillGrid();
        }

        private void numericCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentPage.Value = (int)numericCurrentPage.Value;           // если ввели дробное число, оно автоматически округлится
            currentPage = (int)numericCurrentPage.Value;
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

        private void btnAskOrDesk_MouseHover(object sender, EventArgs e)
        {
            if ((bool)btnAskOrDesk.Tag)
            {
                toolTipCurrentSort.SetToolTip(btnAskOrDesk, "По возрастанию");
            }
            else
            {
                toolTipCurrentSort.SetToolTip(btnAskOrDesk, "По убыванию");
            }
        }

        private void btnSalaryInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipSlalaryInfo.SetToolTip(btnSalaryInfo, "Ноль - до скольки угодно");
        }

        private void dataEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Employee employee = EmployeesList.GetById(Convert.ToInt32(dataEmployees.SelectedRows[0].Cells[0].Value), true);     // получаем выбранного сотрудника

            if (employee.GetType() == typeof(Manager))                                                                           // ищем на какой тип ссылка
            {                                                                                                                   // и в зависимости от этого
                FormShowManager formShowManager = new FormShowManager(readOnly, (Manager)employee);                             // отображаем соотвествующую форму
                formShowManager.ShowDialog();
            }
            else if (employee.GetType() == typeof(Master))
            {
                FormShowMaster showMaster = new FormShowMaster(readOnly, (Master)employee);
                showMaster.ShowDialog();
            }

            FillGrid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.categories;
using Forms_TechServ.forms.customControls;
using Forms_TechServ.forms.employees.roles;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.employees
{
    public partial class FormMasters : Form
    {
        bool readOnly;
        //List<Master> masters;
        int rowsCount;
        int currentPage = 1;
        public Master master;

        public FormMasters(bool forSearching)
        {
            InitializeComponent();

            

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                dataMasters.CellMouseDoubleClick += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_employee"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManage_Click;
                }

                dataMasters.CellMouseDoubleClick += BtnShow_Click;

                readOnly = false;

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

            clearBtn.Click += clearBtnAll_Click;
        }

        public FormMasters(bool forSearching, Workshop workshop)
        {
            InitializeComponent();

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                dataMasters.CellMouseDoubleClick += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_employee"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManage_Click;
                }

                dataMasters.CellMouseDoubleClick += BtnShow_Click;

                readOnly = false;

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

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;
            btnFindWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;

            clearBtn.Click += clearBtnWithoutWorkshop_Click;
        }



        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageMaster formManageMaster = new FormManageMaster();
            formManageMaster.ShowDialog();


            FillGrid();
        }

        private void BtnPick_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида

            }
            if (dataMasters.SelectedRows.Count > 0)
            {
                master = MastersList.GetById(Convert.ToInt32(dataMasters.SelectedRows[0].Cells[0].Value), false);
                this.Close();
            }
            else
            {
                MessageBox.Show("Для начала выберите мастера");
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataMasters.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите сотрудника");
            }
            else
            {
                FormShowMaster showMaster = new FormShowMaster(readOnly, MastersList.GetById(Convert.ToInt32(dataMasters.SelectedRows[0].Cells[0].Value), true));
                showMaster.ShowDialog();

                FillGrid();
            }

            
        }

        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormRoles formFindEmpPosition = new FormRoles(true);
            formFindEmpPosition.ShowDialog();

            tbPosition.Text = formFindEmpPosition?.pickedRole?.Name;
            tbPosition.Tag = formFindEmpPosition?.pickedRole;
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private void btnFindCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
            formCategories.ShowDialog();

            tbCat.Text = formCategories?.category?.Name;
            tbCat.Tag = formCategories?.category;
        }

        private void FormMasters_Load(object sender, EventArgs e)
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

            dataMasters.Columns.Add(idCol);
            dataMasters.Columns.Add(nameCol);
            dataMasters.Columns.Add(phoneCol);
            dataMasters.Columns.Add(salaryCol);
            dataMasters.Columns.Add(branchCol);
            dataMasters.Columns.Add(roleCol);

            if (UserSession.Can("add_del_employee") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataMasters.Columns.Add(delCol);

                dataMasters.CellContentClick += DelCol_Click;
            }

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
        }

        private void FillGrid()
        {
            // ЕСЛИ ФИЛЬТРЫ ПУСТЫЕ, ТО ПОЛУЧАЕМ ВСЕ ЗНАЧЕНИЯ
            int id;
            if (!int.TryParse(tbID.Text, out id) || id < 0) id = 0;                                // получаем введенное для сортировки id

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

            List<Master> masters = MastersList.GetMasters(
                new Master()
                {
                    Id = id,
                    Name = tbName.Text,
                    PhoneNum = tbPhoneNum.Text,
                    Salary = numericSalaryFrom.Value,
                    Workshop = (Workshop)tbWorkshop.Tag,
                    Role = (Role)tbPosition.Tag,
                },
                new Master()
                {
                    Salary = numericSalaryUntil.Value
                },
                (Category)tbCat.Tag,
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            // ЗАПОЛНЯЕМ ГРИД
            dataMasters.Rows.Clear();
            for (int i = 0; i < masters.Count; i++)
            {
                dataMasters.Rows.Add(new DataGridViewRow());

                dataMasters.Rows[i].Cells[0].Value = masters[i].Id;
                dataMasters.Rows[i].Cells[1].Value = masters[i].Name;
                dataMasters.Rows[i].Cells[2].Value = masters[i].PhoneNum;
                dataMasters.Rows[i].Cells[3].Value = masters[i].Salary;
                dataMasters.Rows[i].Cells[4].Value = masters[i].Workshop.Location;
                dataMasters.Rows[i].Cells[5].Value = masters[i].Role.Name;

                if (dataMasters.Columns.Count > 6)
                {
                    dataMasters.Rows[i].Cells[6].Value = "Удалить";
                    dataMasters.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataMasters.Rows[i].Cells[6].Style.ForeColor = Color.White;

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
                Master masterToDel = MastersList.GetById((int)dataMasters.SelectedRows[0].Cells[0].Value, false);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить сотрудника с id {masterToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (masterToDel.DelMaster())
                    {
                        MessageBox.Show("Сотрудник успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("У сотрудника есть незавершенный заказ, пока его удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void clearBtnAll_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbPhoneNum.Clear();
            tbPosition.Clear();
            numericSalaryFrom.Value = 0;
            numericSalaryUntil.Value = 0;
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;
            tbPosition.Clear();
            tbPosition.Tag = null;
            tbCat.Clear();
            tbCat.Tag = null;

            FillGrid();
        }

        private void clearBtnWithoutWorkshop_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbPhoneNum.Clear();
            tbPosition.Clear();
            numericSalaryFrom.Value = 0;
            numericSalaryUntil.Value = 0;
            tbPosition.Clear();
            tbPosition.Tag = null;
            tbCat.Clear();
            tbCat.Tag = null;

            FillGrid();
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnCleanCat_Click(object sender, EventArgs e)
        {
            tbCat.Clear();
            tbCat.Tag = null;
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

        private void btnIdInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipIdInfo.SetToolTip(btnIdInfo, "id может быть только целом положительным числом");
        }
    }
}

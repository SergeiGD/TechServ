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
    public partial class FormManagers : Form
    {
        bool readOnly;
        int currentPage = 1;
        int rowsCount;
        public Manager pickedManager;
        //int pickedRowIndex;

        public FormManagers(bool forSearching)
        {
            InitializeComponent();

            

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;
                dataManagers.CellMouseDoubleClick += BtnPick_Click;

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

                readOnly = false;

                dataManagers.CellMouseDoubleClick += BtnShow_Click;

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
        }

        /*public FormManagers(bool readOnly, string workshop)
        {
            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManage_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click; //BtnShowInClient_Click;

            dataManagers.CellMouseDoubleClick += BtnShow_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }*/

        private void BtnPick_Click(object sender, EventArgs e)
        {
            this.Close();                                               // и тут ретерн
        }

        private void FormManagers_Load(object sender, EventArgs e)
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

            dataManagers.Columns.Add(idCol);
            dataManagers.Columns.Add(nameCol);
            dataManagers.Columns.Add(phoneCol);
            dataManagers.Columns.Add(salaryCol);
            dataManagers.Columns.Add(branchCol);
            dataManagers.Columns.Add(roleCol);

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

            List<Manager> managers = ManagersList.GetManagers(
                new Manager()
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
            dataManagers.Rows.Clear();
            for (int i = 0; i < managers.Count; i++)
            {
                dataManagers.Rows.Add(new DataGridViewRow());

                dataManagers.Rows[i].Cells[0].Value = managers[i].Id;
                dataManagers.Rows[i].Cells[1].Value = managers[i].Name;
                dataManagers.Rows[i].Cells[2].Value = managers[i].PhoneNum;
                dataManagers.Rows[i].Cells[3].Value = managers[i].Salary;
                dataManagers.Rows[i].Cells[4].Value = managers[i].Workshop.Location;
                dataManagers.Rows[i].Cells[5].Value = managers[i].Role.Name;
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageManager formManageManager = new FormManageManager();
            formManageManager.ShowDialog();

            /*if (formManageManager.manager.Id != 0)
            {
                MessageBox.Show($"Новый сотрудник успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid();
            }*/

            FillGrid();

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowManager showManager = new FormShowManager(readOnly, ManagersList.GetById(Convert.ToInt32(dataManagers.SelectedRows[0].Cells[0].Value), true));
            showManager.ShowDialog();

            FillGrid();
        }

        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormFindEmpPosition formFindEmpPosition = new FormFindEmpPosition();
            formFindEmpPosition.ShowDialog();

            tbPosition.Text = formFindEmpPosition?.pickedRole?.Name;
            tbPosition.Tag = formFindEmpPosition?.pickedRole;
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

        private void clearBtn_Click(object sender, EventArgs e)
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
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        /*private void dataManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pickedRowIndex = e.RowIndex;
        }*/

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
    }
}

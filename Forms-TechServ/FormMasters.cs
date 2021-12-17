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
    public partial class FormMasters : Form
    {
        bool readOnly;
        //List<Master> masters;
        int rowsCount;
        int currentPage = 1;
        //int pickedRowIndex;

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

            
        }

        /*public FormMasters(bool readOnly, string workshop)
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
            btnShow.Click += BtnShow_Click/*BtnShowInClient_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }*/


        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageMaster formManageMaster = new FormManageMaster();
            formManageMaster.ShowDialog();

            /*if(formManageMaster.master.Id != 0)
            {
                MessageBox.Show($"Новый сотрудник успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid();
            }*/

            FillGrid();
        }

        private void BtnPick_Click(object sender, EventArgs e)
        {
            this.Close();                                               // и тут ретерн
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            
            //int selectedRow = dataMasters.SelectedRows[0].Index;
            FormShowMaster showMaster = new FormShowMaster(readOnly, MastersList.GetById(Convert.ToInt32(dataMasters.SelectedRows[0].Cells[0].Value), true));
            showMaster.ShowDialog();

            FillGrid();
        }

        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormFindEmpPosition formFindEmpPosition = new FormFindEmpPosition();
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
            FormCategories formCategories = new FormCategories(true, false);
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
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
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
            tbCat.Clear();
            tbCat.Tag = null;

            FillGrid();
        }

        private void comboBoxShowRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(masters != null)
            {
                FillGrid();
            }*/
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

        /*private void dataMasters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pickedRowIndex = e.RowIndex;
        }*/

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
    }
}

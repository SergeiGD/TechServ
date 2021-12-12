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
    public partial class FormServices : Form
    {
        bool readOnly;
        int rowsCount;
        int currentPage = 1;
        public Service service;
        Category category;

        public FormServices(bool forSearching)
        {
            InitializeComponent();

            //readOnly = false;
            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_service"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnAddNewService_Click;
                }

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

        public FormServices(bool readOnly, Category category)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddFromCategory_Click;
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

            this.category = category;
            tbCat.Text = category.Name;
            tbCat.Tag = category;

            btnFindCat.Enabled = false;
            btnCleanCat.Enabled = false;

            btnClean.Click += btnCleanInCat_Click;
        }

        

        /*public FormServices(string category, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddNewService_Click;
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
        }*/
        /*public FormServices(string category, bool readOnly)
        {
            InitializeComponent();

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddNewService_Click;
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
        }*/

        private void FormServices_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";
            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.Name = "Цена";
            DataGridViewTextBoxColumn timeCol = new DataGridViewTextBoxColumn();
            timeCol.Name = "Примерное время";
            DataGridViewTextBoxColumn catCol = new DataGridViewTextBoxColumn();
            catCol.Name = "Категорию";

            dataServies.Columns.Add(idCol);
            dataServies.Columns.Add(nameCol);
            dataServies.Columns.Add(priceCol);
            dataServies.Columns.Add(timeCol);
            dataServies.Columns.Add(catCol);

            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Названию");
            comboBoxSortBy.Items.Add("Цене");
            comboBoxSortBy.Items.Add("Времени оказания");
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
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            string sortBy = "Id";

            if (comboBoxSortBy.SelectedItem.ToString() == "id")
            {
                sortBy = "Id";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Названию")
            {
                sortBy = "Name";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Цене")
            {
                sortBy = "Price";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Времени оказания")
            {
                sortBy = "TimeSpanTicks";
            }

            List<Service> services = ServicesList.GetService(
                new Service() 
                {
                    Id = id,
                    Name = tbName.Text,
                    Price = numericPriceFrom.Value,
                    Category = (Category)tbCat.Tag
                },
                new Service()
                {
                    Price = numericPriceUntil.Value
                },
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataServies.Rows.Clear();
            for (int i = 0; i < services.Count; i++)
            {
                dataServies.Rows.Add(new DataGridViewRow());
                
                dataServies.Rows[i].Cells[0].Value = services[i].Id;
                dataServies.Rows[i].Cells[1].Value = services[i].Name;
                dataServies.Rows[i].Cells[2].Value = services[i].Price;
                dataServies.Rows[i].Cells[3].Value = services[i].AvgServiceTime;
                dataServies.Rows[i].Cells[4].Value = services[i].Category.Name;
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";
        }

        private void btnCleanInCat_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();

            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;

            FillGrid();
        }

        private void BtnAddFromCategory_Click(object sender, EventArgs e)
        {
            FormManageService formManageService = new FormManageService(category);
            formManageService.ShowDialog();

            FillGrid();
        }

        private void BtnPick_Click(object sender, EventArgs e)
        {
            service = ServicesList.GetById(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value), true);

            this.Close();                                               // и тут ретерн
        }

        private void BtnAddNewService_Click(object sender, EventArgs e)     // СОЗДАТЬ НОВУЮ УСЛУГУ
        {
            FormManageService addService = new FormManageService();
            addService.ShowDialog();

            FillGrid();
        }

        private void BtnAddToOrder_Click(object sender, EventArgs e)        // ВОТ ТУТ К ЗАКАЗУ ДОБАВИТЬ УСЛУГУ
        {
            FormChooseQuantity formChooseQuantity = new FormChooseQuantity();
            formChooseQuantity.ShowDialog();
            this.Close();
        }

        /*private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageService manageService = new FormManageService();
            manageService.ShowDialog();
        }*/

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if(dataServies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите категорию");
            }
            else
            {
                FormShowService showService = new FormShowService(readOnly, ServicesList.GetById(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value), true));
                showService.ShowDialog();
                FillGrid();
            }
            
        }

        /*private void BtnShowInOrder_Click(object sender, EventArgs e)         // НУЖНО ЧТОБ ИЗ ЗАКАЗА НЕ МОГЛИ ИЗМЕНИТЬ УСЛУГУ ПРИ ПРОСМОТРЕ ВСЕХ УСЛУГ
        {
            FormShowService showService = new FormShowService(true);
            showService.ShowDialog();
        }*/

        private void btnFindCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
            formCategories.ShowDialog();

            tbCat.Text = formCategories?.category?.Name;
            tbCat.Tag = formCategories?.category;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();

            tbCat.Clear();
            tbCat.Tag = null;

            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
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
            toolTipPriceInfo.SetToolTip(btnSalaryInfo, "Ноль - до скольки угодно");
        }
    }
}

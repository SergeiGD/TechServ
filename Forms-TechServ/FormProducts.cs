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
    public partial class FormProducts : Form
    {
        bool readOnly;
        int rowsCount;
        int currentPage = 1;
        Client client;                                                  // при работа с техникой из клиента
        public Product product;

        public FormProducts(bool forSearching)
        {
            InitializeComponent();

            

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                dataProducts.CellMouseDoubleClick += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_product"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManage_Click;
                }
                


                dataProducts.CellMouseDoubleClick += BtnShow_Click;
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

            btnClean.Click += btnCleanAll_Click;
        }

        /*public FormProducts(bool readOnly)
        {
            InitializeComponent();

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

        public FormProducts(bool readOnly, Client client)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly && UserSession.Can("add_del_product"))
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddFromClient_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click/*BtnShowInClient_Click*/;

            dataProducts.CellMouseDoubleClick += BtnShow_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }

            this.client = client;
            tbClient.Text = client.Name;
            tbClient.Tag = client;

            btnFindClient.Enabled = false;
            btnCleanClient.Enabled = false;

            btnClean.Click += btnCleanInClient_Click;
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";
            DataGridViewTextBoxColumn clientCol = new DataGridViewTextBoxColumn();
            clientCol.Name = "Владалец";
            DataGridViewTextBoxColumn catCol = new DataGridViewTextBoxColumn();
            catCol.Name = "Категория";

            dataProducts.Columns.Add(idCol);
            dataProducts.Columns.Add(nameCol);
            dataProducts.Columns.Add(clientCol);
            dataProducts.Columns.Add(catCol);

            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Названию");
            //comboBoxSortBy.Items.Add("Владельцу");
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


            List<Product> products = ProductsList.GetProducts(
                new Product() 
                {
                    Id = id,
                    Name = tbName.Text,
                    Client = (Client)tbClient.Tag,
                    Category = (Category)tbCat.Tag
                },
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataProducts.Rows.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                dataProducts.Rows.Add(new DataGridViewRow());

                dataProducts.Rows[i].Cells[0].Value = products[i].Id;
                dataProducts.Rows[i].Cells[1].Value = products[i].Name;
                dataProducts.Rows[i].Cells[2].Value = products[i].Client.Name;
                dataProducts.Rows[i].Cells[3].Value = products[i].Category.Name;
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageProduct manageProduct = new FormManageProduct();
            manageProduct.ShowDialog();

            FillGrid();
        }

        private void BtnAddFromClient_Click(object sender, EventArgs e)
        {
            FormManageProduct manageProduct = new FormManageProduct(client);
            manageProduct.ShowDialog();

            FillGrid();
        }

        private void BtnPick_Click(object sender, EventArgs e)              // вот тут ретернить
        {
            if(dataProducts.SelectedRows.Count > 0)
            {
                product = ProductsList.GetById(Convert.ToInt32(dataProducts.SelectedRows[0].Cells[0].Value), true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Для начала выберите технику");
            }
        }

        /*private void BtnEdit_Click(object sender, EventArgs e)
        {
            FormEditProduct editProduct = new FormEditProduct();
            editProduct.ShowDialog();
        }*/
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if(dataProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите технику");
            }
            else
            {
                
                FormShowProduct showProduct = new FormShowProduct(readOnly, ProductsList.GetById(Convert.ToInt32(dataProducts.SelectedRows[0].Cells[0].Value), true));
                showProduct.ShowDialog();

                FillGrid();
            }
        }

        private void btnFindCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
            formCategories.ShowDialog();

            tbCat.Text = formCategories?.category?.Name;
            tbCat.Tag = formCategories?.category;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();

            tbClient.Text = formClients?.client?.Name;
            tbClient.Tag = formClients?.client;
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnCleanAll_Click(object sender, EventArgs e)          // очищаем все поля, когда форма вызывается в качестве самостоятельной влкдаки
        {
            tbID.Clear();
            tbName.Clear();
            tbCat.Clear();
            tbCat.Tag = null;
            tbClient.Clear();
            tbClient.Tag = null;

            FillGrid();
        }

        private void btnCleanInClient_Click(object sender, EventArgs e)     // при просмотре из клиента нельзя убирать фильтр по нему
        {
            tbID.Clear();
            tbName.Clear();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
        }

        private void btnCleanClient_Click(object sender, EventArgs e)
        {
            tbClient.Clear();
            tbClient.Tag = null;
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
            //t.SetToolTip(btnAskOrDesk, "");
        }

        /*private void BtnShowInClient_Click(object sender, EventArgs e)
        {
            FormShowProduct showProduct = new FormShowProduct(readOnly);
            showProduct.ShowDialog();
        }*/
    }
}

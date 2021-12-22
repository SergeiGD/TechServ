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
    public partial class FormInOrders : Form
    {
        //Order order;
        int rowsCount;
        int currentPage = 1;

        FormOrdersExtedFilter ordersExtedFilter = new FormOrdersExtedFilter(true);
        bool filterDeployed = false;
        Size filterBaseSize;
        bool readOnly;

        public FormInOrders(bool forSearching)
        {
            InitializeComponent();

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                dataOrders.CellMouseDoubleClick += BtnPick_Click;
                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_order"))
                {
                    ManageButton btnAdd = new ManageButton();
                    //btnAdd.Location = new Point(0, 120);
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManage_Click;
                }
                

                ManageButton btnShow = new ManageButton();
                btnShow.Text = "Просмотреть";
                panelControl.Controls.Add(btnShow);
                btnShow.Click += BtnShow_Click;

                readOnly = false;
                dataOrders.CellMouseDoubleClick += BtnShow_Click;
            }
            

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);

            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormInOrders(string Client, bool readOnly)
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
            /*ManageButton btnAdd = new ManageButton();
            btnAdd.Location = new Point(0, 120);
            btnAdd.Text = "Добавить";
            panelControl.Controls.Add(btnAdd);
            btnAdd.Click += BtnManage_Click;*/

            /*ManageButton btnEdit = new ManageButton();
            btnEdit.Location = new Point(0, 160);
            btnEdit.BackColor = Color.FromArgb(51, 225, 231);
            btnEdit.Text = "Изменить";
            btnEdit.Click += BtnManage_Click;*/

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

        public FormInOrders(int product, bool readOnly)
        {
            InitializeComponent();

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManage_Click;
            }
            /*ManageButton btnAdd = new ManageButton();
            btnAdd.Location = new Point(0, 120);
            btnAdd.Text = "Добавить";
            panelControl.Controls.Add(btnAdd);
            btnAdd.Click += BtnManage_Click;*/

            /*ManageButton btnEdit = new ManageButton();
            btnEdit.Location = new Point(0, 160);
            btnEdit.BackColor = Color.FromArgb(51, 225, 231);
            btnEdit.Text = "Изменить";
            btnEdit.Click += BtnManage_Click;*/

            ManageButton btnShow = new ManageButton();
            btnShow.Location = new Point(0, 160);
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

        private void BtnManage_Click(object sender, EventArgs e)        
        {
            FormAddOrder addOrder = new FormAddOrder(true);
            addOrder.ShowDialog();

            FillGrid();
        }

        private void BtnPick_Click(object sender, EventArgs e)          // вот тут ретернить выбранного клиента
        {
            this.Close();
        }

        private void BtnShow_Click(object sender, EventArgs e)          
        {
            if(dataOrders.SelectedRows.Count > 0)
            {
                FormShowOrder showOrder = new FormShowOrder(readOnly, OrdersList.GetById((int)dataOrders.SelectedRows[0].Cells[0].Value));
                showOrder.ShowDialog();
                FillGrid();
            }
            else
            {
                MessageBox.Show("Для начала выберите заказ");
            }
        }

        private void ExtendFilterBtn_Click(object sender, EventArgs e)
        {
            if (filterDeployed)
            {
                ordersExtedFilter.Hide();                           // СКРЫВАЕМ ФОРМУ СОРТИРОВКИ И УМЕНЬШАЕМ РАЗМЕР ПАНЕЛИ С СОРТИРОВКОЙ
                panelFind.Height = filterBaseSize.Height;
                dataOrders.Location = new Point(dataOrders.Location.X, panelFind.Height);                       // ВОЗВРАЩАЕМ РАЗМЕР ГРИДУ
                dataOrders.Height = dataOrders.Height + (ordersExtedFilter.Height - filterBaseSize.Height);
                filterDeployed = false;
            }
            else
            {

                ordersExtedFilter.TopLevel = false;
                ordersExtedFilter.FormBorderStyle = FormBorderStyle.None;

                panelFind.Height = ordersExtedFilter.Height;
                dataOrders.Location = new Point(dataOrders.Location.X, panelFind.Height);                       // ПЕРЕДВИГАЕМ И УМЕНЬШАЕМ ГРИД
                dataOrders.Height = dataOrders.Height - (ordersExtedFilter.Height - filterBaseSize.Height);

                Control progenitor = this.Parent;
                while (progenitor.Parent != null)                       // НАХОДИМ ГЛАВНУЮ ТЕКУЩУЮ ФОРМУ
                {
                    progenitor = progenitor.Parent;
                }
                progenitor.Width = progenitor.Width + (ordersExtedFilter.Width - panelFind.Width);      // РАСШИРЫЕМ ГЛАВНУЮ ТЕКУЩУЮ ФОРМУ (ЧТОБ ВЛЕЗ ФИЛЬТР)


                panelFind.Controls.Add(ordersExtedFilter);          // ФОРМА ФИЛЬТРА ПРОСТО ВСТАВЕТ ПОВЕРХ ТЕКУЩИХ ПОЛЕЙ СОРТИРОВКИ
                ordersExtedFilter.Dock = DockStyle.Fill;
                ordersExtedFilter.BringToFront();
                ordersExtedFilter.Show();

                filterDeployed = true;
            }
        }

        private void FormInOrders_Load(object sender, EventArgs e)
        {
            filterBaseSize = panelFind.Size;

            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn clientCol = new DataGridViewTextBoxColumn();
            clientCol.Name = "Клиент";
            DataGridViewTextBoxColumn statusCol = new DataGridViewTextBoxColumn();
            statusCol.Name = "Статус";
            DataGridViewTextBoxColumn productCol = new DataGridViewTextBoxColumn();
            productCol.Name = "Техника";
            DataGridViewTextBoxColumn masterCol = new DataGridViewTextBoxColumn();
            masterCol.Name = "Мастер";
            DataGridViewTextBoxColumn managerCol = new DataGridViewTextBoxColumn();
            managerCol.Name = "Составитель";
            DataGridViewTextBoxColumn workshopCol = new DataGridViewTextBoxColumn();
            workshopCol.Name = "Филиал";
            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.Name = "Стоимость";


            dataOrders.Columns.Add(idCol);
            dataOrders.Columns.Add(clientCol);
            dataOrders.Columns.Add(statusCol);
            dataOrders.Columns.Add(productCol);
            dataOrders.Columns.Add(masterCol);
            dataOrders.Columns.Add(managerCol);
            dataOrders.Columns.Add(workshopCol);
            dataOrders.Columns.Add(priceCol);


            btnAskOrDesk.Tag = true;

            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.Canceled.GetStatusString(), Tag = OrderStatus.Canceled });
            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.Finished.GetStatusString(), Tag = OrderStatus.Finished });
            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.WaitingForAnswer.GetStatusString(), Tag = OrderStatus.WaitingForAnswer });
            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.WaitingForDiagnostic.GetStatusString(), Tag = OrderStatus.WaitingForDiagnostic });
            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.WaitingForPrepayment.GetStatusString(), Tag = OrderStatus.WaitingForPrepayment });
            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.WaitingForRefund.GetStatusString(), Tag = OrderStatus.WaitingForRefund });
            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.WaitingForRepairing.GetStatusString(), Tag = OrderStatus.WaitingForRepairing });
            listViewStatuses.Items.Add(new ListViewItem() { Text = OrderStatus.WaitingForSpareParts.GetStatusString(), Tag = OrderStatus.WaitingForSpareParts });

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Статусу заказа");
            comboBoxSortBy.Items.Add("Цене");
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
            else if (comboBoxSortBy.SelectedItem.ToString() == "Статусу заказа")
            {
                sortBy = "Status";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Цене")
            {
                sortBy = "FinalPrice";
            }

            List<Order> orders= OrdersList.GetOrders(
                new Order() 
                {
                    Id = id,
                    Workshop = (Workshop)tbWorkshop.Tag,
                    FinalPrice = numericPriceFrom.Value
                },
                new Order() 
                {
                    FinalPrice = numericPriceUntil.Value
                },
                //(Client)tbClient.Tag
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataOrders.Rows.Clear();
            for (int i = 0; i < orders.Count; i++)
            {
                dataOrders.Rows.Add(new DataGridViewRow());

                dataOrders.Rows[i].Cells[0].Value = orders[i].Id;
                dataOrders.Rows[i].Cells[1].Value = orders[i].Product.Client.Name; 
                dataOrders.Rows[i].Cells[2].Value = orders[i].Status.GetStatusString();
                dataOrders.Rows[i].Cells[3].Value = orders[i].Product.Name;                         // вот сюда кол-во заказов через GetOrder().Count наверное
                dataOrders.Rows[i].Cells[4].Value = orders[i].Master.Name;
                dataOrders.Rows[i].Cells[5].Value = orders[i].Manager.Name;
                dataOrders.Rows[i].Cells[6].Value = orders[i].Workshop.Location;
                dataOrders.Rows[i].Cells[7].Value = orders[i].FinalPrice;

            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";

        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }

       
    }
}

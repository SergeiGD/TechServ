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
    public partial class FormOrders : Form
    {
        Order FilterA = new Order();
        Order FilterB = new Order();
        ValueWrapper<bool> FilterActive = new ValueWrapper<bool>(false);
        ValueWrapper<string> FilterSortBy = new ValueWrapper<string>("Id");
        ValueWrapper<bool> FilterAksOrDesk = new ValueWrapper<bool>(true);
        Client FilterClient;
        Product product;
        Master master;
        Manager manager;
        Workshop workshop;

        int rowsCount;
        int currentPage = 1;

        FormOrdersExtedFilter ordersExtedFilter = new FormOrdersExtedFilter(true);
        bool filterDeployed = false;
        Size filterBaseSize;
        bool readOnly;

        public Order order;

        public FormOrders(bool forSearching)
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

            clearBtn.Click += clearAllBtn_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);

            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }


        }



        public FormOrders(Client client)
        {
            InitializeComponent();

            readOnly = true;

            tbClient.Text = client.Name;
            tbClient.Tag = client;
            btnFindClient.Enabled = false;
            btnCleanClient.Enabled = false;
            ordersExtedFilter.btnFindClient.Enabled = false;
            ordersExtedFilter.btnCleanClient.Enabled = false;
            FilterClient = client;

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            clearBtn.Click += clearInClientBtn_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormOrders(Product product)
        {
            InitializeComponent();

            readOnly = true;

            tbProduct.Text = product.Name;
            tbProduct.Tag = product;
            btnFindProduct.Enabled = false;
            btnCleanProduct.Enabled = false;
            ordersExtedFilter.btnFindProduct.Enabled = false;
            ordersExtedFilter.btnCleanProduct.Enabled = false;
            FilterA.Product = product;
            this.product = product;

            ManageButton btnShow = new ManageButton();
            btnShow.Location = new Point(0, 160);
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            clearBtn.Click += clearInProductBtn_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormOrders(Workshop workshop)
        {
            InitializeComponent();

            readOnly = true;

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;
            btnFindWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;
            ordersExtedFilter.btnFindWorkshop.Enabled = false;
            ordersExtedFilter.btnCleanWorkshop.Enabled = false;
            FilterA.Workshop = workshop;
            this.workshop = workshop;

            ManageButton btnShow = new ManageButton();
            btnShow.Location = new Point(0, 160);
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            clearBtn.Click += clearInWorkshopBtn_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormOrders(Master master)
        {
            InitializeComponent();

            readOnly = true;

            ordersExtedFilter.btnFindMaster.Enabled = false;
            ordersExtedFilter.btnCleanMaster.Enabled = false;
            FilterA.Master = master;
            this.master = master;

            ManageButton btnShow = new ManageButton();
            btnShow.Location = new Point(0, 160);
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            clearBtn.Click += clearInMasterBtn_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormOrders(Manager manager)
        {
            InitializeComponent();

            readOnly = true;

            ordersExtedFilter.btnFindManager.Enabled = false;
            ordersExtedFilter.btnCleanManager.Enabled = false;
            FilterA.Manager = manager;
            this.manager = manager;

            ManageButton btnShow = new ManageButton();
            btnShow.Location = new Point(0, 160);
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            clearBtn.Click += clearInManagerBtn_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        

        private void BtnPick_Click(object sender, EventArgs e)          // вот тут ретернить выбранного клиента
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataOrders.SelectedRows.Count > 0)
            {
                order = OrdersList.GetById(Convert.ToInt32(dataOrders.SelectedRows[0].Cells[0].Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("Для начала выберите заказ");
            }
        }

        private void FormOrders_Load(object sender, EventArgs e)
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

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if (status == OrderStatus.Unknown)
                {
                    continue;
                }
                comboBoxStatus.Items.Add(status.GetStatusString());
            }
            comboBoxStatus.SelectedItem = null;

            FilterA.Status = OrderStatus.Unknown;

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";

            comboBoxSortBy.Items.Add("Дате начала");
            comboBoxSortBy.Items.Add("Требуемой предоплате");
            comboBoxSortBy.Items.Add("Внесенной предоплате");
            comboBoxSortBy.SelectedIndex = 0;

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            datePickerStartFrom.ValueChanged += dateTimePicker_ValueChanged;
            datePickerStartUntil.ValueChanged += dateTimePicker_ValueChanged;

            FillGrid();
        }

        private void FillGrid()
        {
            // ЕСЛИ ФИЛЬТРЫ ПУСТЫЕ, ТО ПОЛУЧАЕМ ВСЕ ЗНАЧЕНИЯ
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            string sortBy = "Id";


            if (FilterSortBy.Value == "Дате начала")
            {
                sortBy = "DateStart";
            }
            if (FilterSortBy.Value == "Требуемой предоплате")
            {
                sortBy = "PrepaymentRequired";
            }
            if (FilterSortBy.Value == "Внесенной предоплате")
            {
                sortBy = "PrepaymentMade";
            }

            List<Order> orders = OrdersList.GetOrders(
                FilterA,
                FilterB,
                FilterClient,
                FilterActive.Value,
                FilterAksOrDesk.Value,
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
                dataOrders.Rows[i].Cells[3].Value = orders[i].Product.Name;
                dataOrders.Rows[i].Cells[4].Value = orders[i].Master.Name;
                dataOrders.Rows[i].Cells[5].Value = orders[i].Manager.Name;
                dataOrders.Rows[i].Cells[6].Value = orders[i].Workshop.Location;
                dataOrders.Rows[i].Cells[7].Value = orders[i].FinalPrice;

            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";

        }


        private void BtnManage_Click(object sender, EventArgs e)        // !!!!ВОТ ТУТ АДРЕС БУДЕТ ИЛИ НЕТ!!!!
        {
            
            FormPickOrderType addOrder = new FormPickOrderType();         // когда добавлянем заказ по(из) клиенту, либо у формы конструктор с клиентом, который будет его ставить и лочить поле к выбором клиента, либо разные методы на добавление у класса order
            addOrder.ShowDialog();

            FillGrid();
        }


        private void BtnShow_Click(object sender, EventArgs e)          // !!!!ВОТ ТУТ АДРЕС БУДЕТ ИЛИ НЕТ!!!!
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataOrders.SelectedRows.Count > 0)
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

                // ОБНОВЛЯЕМ ФИЛЬТРЫ НА ТЕ, КОТОРЫЕ БЫЛИ ВВЕДЕНЫ НА ФОРМЕ РАСШИРЕШШНОЙ СОРТИРОВКИ
                if (FilterA.Id != 0)
                {
                    tbID.Text = FilterA.Id.ToString();
                }

                tbWorkshop.Tag = FilterA?.Workshop;
                tbWorkshop.Text = FilterA?.Workshop?.Location;

                tbClient.Tag = FilterClient;
                tbClient.Text = FilterClient?.Name;

                tbProduct.Tag = FilterA?.Product;
                tbProduct.Text = FilterA?.Product?.Name;

                if (FilterA.DateStart.HasValue)
                {
                    datePickerStartFrom.Format = DateTimePickerFormat.Short;
                    datePickerStartFrom.Value = FilterA.DateStart.Value;
                }
                else
                {
                    datePickerStartFrom.Format = DateTimePickerFormat.Custom;
                    datePickerStartFrom.CustomFormat = " ";
                }
                if (FilterB.DateStart.HasValue)
                {
                    datePickerStartUntil.Format = DateTimePickerFormat.Short;
                    datePickerStartUntil.Value = FilterB.DateStart.Value;
                }
                else
                {
                    datePickerStartUntil.Format = DateTimePickerFormat.Custom;
                    datePickerStartUntil.CustomFormat = " ";
                }
                numericPriceFrom.Value = FilterA.FinalPrice;
                numericPriceUntil.Value = FilterB.FinalPrice;
                if (FilterA.Status != OrderStatus.Unknown)
                {
                    comboBoxStatus.SelectedIndex = comboBoxStatus.FindString(StatusStringExtensions.GetStatusString(FilterA.Status));
                }
                else
                {
                    comboBoxStatus.SelectedItem = null;
                }
                checkBoxActive.Checked = FilterActive.Value;

                btnAskOrDesk.Tag = FilterAksOrDesk.Value;
                comboBoxSortBy.SelectedIndex = comboBoxSortBy.FindString(FilterSortBy.Value);
            }
            else
            {
                ordersExtedFilter.LoadData(FilterA, FilterB, FilterClient, FilterActive, FilterSortBy, FilterAksOrDesk);

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

        private void btnFindClient_Click_1(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();

            tbClient.Tag = formClients?.client;
            tbClient.Text = formClients?.client?.Name;
            
        }

        private void btnFindWorkshop_Click_1(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Tag = formWorkshops?.workshop;
            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();

            tbProduct.Tag = formProducts?.product;
            tbProduct.Text = formProducts?.product?.Name;
            
        }

        private void btnCleanWorkshop_Click(object sender, EventArgs e)
        {
            tbWorkshop.Tag = null;
            tbWorkshop.Clear();
            
        }

        private void btnCleanClient_Click(object sender, EventArgs e)
        {
            tbClient.Tag = null;
            tbClient.Clear();
            
        }

        private void btnCleanProduct_Click(object sender, EventArgs e)
        {
            tbProduct.Tag = null;
            tbProduct.Clear();
            
        }

        private void btnCleanStatus_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedItem = null;
        }

        private void btnCleanStartFrom_Click(object sender, EventArgs e)
        {
            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
        }

        private void btnCleanStartUntil_Click(object sender, EventArgs e)
        {
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            dateTimePicker.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);

            if (dateTimePicker.Format == DateTimePickerFormat.Short)
            {
                // сменим формат, чтоб вызвать событие FormatChanged и поменять данные
                dateTimePicker.Format = DateTimePickerFormat.Custom;
            }
            dateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbWorkshop.Tag = null;
            tbWorkshop.Clear();

            tbClient.Tag = null;
            tbClient.Clear();

            tbProduct.Tag = null;
            tbProduct.Clear();

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            //comboBoxStatus.SelectedItem = numericPriceUntil;
            checkBoxActive.Checked = false;

            FilterA = new Order();
            FilterB = new Order();
            FilterClient = null;
            FilterActive.Value = false;

            //comboBoxStatus.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
            FilterA.Status = OrderStatus.Unknown;

            ordersExtedFilter.LoadData(FilterA, FilterB, FilterClient, FilterActive, FilterSortBy, FilterAksOrDesk);

            FillGrid();
        }

        private void clearInClientBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbWorkshop.Tag = null;
            tbWorkshop.Clear();

            tbProduct.Tag = null;
            tbProduct.Clear();

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            //comboBoxStatus.SelectedItem = numericPriceUntil;
            checkBoxActive.Checked = false;

            FilterA = new Order();

            FilterB = new Order();

            FilterActive.Value = false;

            //comboBoxStatus.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
            FilterA.Status = OrderStatus.Unknown;

            ordersExtedFilter.LoadData(FilterA, FilterB, FilterClient, FilterActive, FilterSortBy, FilterAksOrDesk);

            FillGrid();
        }

        private void clearInProductBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbWorkshop.Tag = null;
            tbWorkshop.Clear();

            tbClient.Tag = null;
            tbClient.Clear();

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            //comboBoxStatus.SelectedItem = numericPriceUntil;
            checkBoxActive.Checked = false;

            FilterA = new Order();
            FilterA.Product = product;

            FilterB = new Order();
            FilterClient = null;
            FilterActive.Value = false;

            //comboBoxStatus.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
            FilterA.Status = OrderStatus.Unknown;

            ordersExtedFilter.LoadData(FilterA, FilterB, FilterClient, FilterActive, FilterSortBy, FilterAksOrDesk);

            FillGrid();
        }

        private void clearInWorkshopBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();

            tbProduct.Tag = null;
            tbProduct.Clear();

            tbClient.Tag = null;
            tbClient.Clear();

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            //comboBoxStatus.SelectedItem = numericPriceUntil;
            checkBoxActive.Checked = false;

            FilterA = new Order();
            FilterA.Workshop = workshop;

            FilterB = new Order();
            FilterClient = null;
            FilterActive.Value = false;

            //comboBoxStatus.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
            FilterA.Status = OrderStatus.Unknown;

            ordersExtedFilter.LoadData(FilterA, FilterB, FilterClient, FilterActive, FilterSortBy, FilterAksOrDesk);

            FillGrid();
        }

        private void clearInMasterBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbWorkshop.Tag = null;
            tbWorkshop.Clear();

            tbProduct.Tag = null;
            tbProduct.Clear();

            tbClient.Tag = null;
            tbClient.Clear();

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            //comboBoxStatus.SelectedItem = numericPriceUntil;
            checkBoxActive.Checked = false;

            FilterA = new Order();
            FilterA.Master = master;

            FilterB = new Order();
            FilterClient = null;
            FilterActive.Value = false;

            //comboBoxStatus.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
            FilterA.Status = OrderStatus.Unknown;

            ordersExtedFilter.LoadData(FilterA, FilterB, FilterClient, FilterActive, FilterSortBy, FilterAksOrDesk);

            FillGrid();
        }

        private void clearInManagerBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbWorkshop.Tag = null;
            tbWorkshop.Clear();

            tbProduct.Tag = null;
            tbProduct.Clear();

            tbClient.Tag = null;
            tbClient.Clear();

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            //comboBoxStatus.SelectedItem = numericPriceUntil;
            checkBoxActive.Checked = false;

            FilterA = new Order();
            FilterA.Manager = manager;

            FilterB = new Order();
            FilterClient = null;
            FilterActive.Value = false;

            //comboBoxStatus.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
            FilterA.Status = OrderStatus.Unknown;

            ordersExtedFilter.LoadData(FilterA, FilterB, FilterClient, FilterActive, FilterSortBy, FilterAksOrDesk);

            FillGrid();
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

            FilterAksOrDesk.Value = (bool)btnAskOrDesk.Tag;
        }

        private void btnPriceInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPriceInfo.SetToolTip(btnPriceInfo, "Ноль - до скольки угодно");
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

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
            {
                comboBoxStatus.SelectedItem = null;
            }
            FilterActive.Value = checkBoxActive.Checked;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
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

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderStatus pickedStatus = OrderStatus.Unknown;
            if (comboBoxStatus.SelectedItem != null)
            {
                pickedStatus = StatusStringExtensions.GetStatusEnum(comboBoxStatus.SelectedItem.ToString());
            }
            FilterA.Status = pickedStatus;
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSortBy.Value = comboBoxSortBy.SelectedItem.ToString();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            int id;
            int.TryParse(tbID.Text, out id);

            FilterA.Id = id;
        }

        private void tbWorkshop_TextChanged(object sender, EventArgs e)
        {
            FilterA.Workshop = (Workshop)tbWorkshop.Tag;
        }

        private void tbClient_TextChanged(object sender, EventArgs e)
        {
            FilterClient = (Client)tbClient.Tag;
        }

        private void tbProduct_TextChanged(object sender, EventArgs e)
        {
            FilterA.Product = (Product)tbProduct.Tag;
        }

        private void datePickerStartFrom_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateStartFrom = null;
            if (datePickerStartFrom.Format != DateTimePickerFormat.Custom)
                dateStartFrom = datePickerStartFrom.Value;
            FilterA.DateStart = dateStartFrom;
        }

        private void datePickerStartUntil_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateStartUntil = null;
            if (datePickerStartUntil.Format != DateTimePickerFormat.Custom)
                dateStartUntil = datePickerStartUntil.Value;
            FilterB.DateStart = dateStartUntil;
        }

        private void numericPriceFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterA.FinalPrice = numericPriceFrom.Value;
        }

        private void numericPriceUntil_ValueChanged(object sender, EventArgs e)
        {
            FilterB.FinalPrice = numericPriceUntil.Value;
        }

        
    }
    
}

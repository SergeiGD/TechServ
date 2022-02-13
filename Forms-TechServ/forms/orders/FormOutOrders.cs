using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.clients;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.products;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.clients;
using Forms_TechServ.forms.customControls;
using Forms_TechServ.forms.products;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.orders
{
    public partial class FormOutOrders : Form
    {
        OrderAtHome FilterA = new OrderAtHome();
        OrderAtHome FilterB = new OrderAtHome();
        ValueWrapper<bool> FilterActive = new ValueWrapper<bool>(false);
        ValueWrapper<string> FilterSortBy = new ValueWrapper<string>("Id");
        ValueWrapper<bool> FilterAksOrDesk = new ValueWrapper<bool>(true);
        Client FilterClient;

        public OrderAtHome order;
        int rowsCount;
        int currentPage = 1;

        FormOrdersExtedFilter ordersExtedFilter = new FormOrdersExtedFilter(false);
        bool filterDeployed = false;
        Size filterBaseSize;
        bool readOnly;

        public FormOutOrders(bool forSearching)
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



        private void BtnPick_Click(object sender, EventArgs e)         
        {
            if(dataOrders.SelectedRows.Count > 0)
            {
                order = OrderAtHomeList.GetById((int)dataOrders.SelectedRows[0].Cells[0].Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ");
            }
        }

        private void FormOutOrders_Load(object sender, EventArgs e)
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
            DataGridViewTextBoxColumn addressCol = new DataGridViewTextBoxColumn();
            addressCol.Name = "Адрес";
            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.Name = "Стоимость";


            dataOrders.Columns.Add(idCol);
            dataOrders.Columns.Add(clientCol);
            dataOrders.Columns.Add(statusCol);
            dataOrders.Columns.Add(productCol);
            dataOrders.Columns.Add(masterCol);
            dataOrders.Columns.Add(managerCol);
            dataOrders.Columns.Add(workshopCol);
            dataOrders.Columns.Add(addressCol);
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

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Дате начала");
            comboBoxSortBy.Items.Add("Требуемой предоплате");
            comboBoxSortBy.Items.Add("Внесенной предоплате");
            comboBoxSortBy.Items.Add("Стоимосте");
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

            if (comboBoxSortBy.SelectedItem.ToString() == "id")
            {
                sortBy = "Id";
            }
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
            if (FilterSortBy.Value == "Стоимосте")
            {
                sortBy = "FinalPrice";
            }

            List<OrderAtHome> orders = OrderAtHomeList.GetOrders(
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
                dataOrders.Rows[i].Cells[7].Value = orders[i].Address;
                dataOrders.Rows[i].Cells[8].Value = orders[i].FinalPrice;

            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";

        }

        private void BtnManage_Click(object sender, EventArgs e)        
        {

            FormAddOrder addOrder = new FormAddOrder(false);
            addOrder.ShowDialog();

            FillGrid();
        }

        private void BtnShow_Click(object sender, EventArgs e)          
        {
            if (dataOrders.SelectedRows.Count > 0)
            {
                FormShowOrder showOrder = new FormShowOrder(readOnly, OrderAtHomeList.GetById((int)dataOrders.SelectedRows[0].Cells[0].Value));
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
                else
                {
                    tbID.Clear();
                }

                tbAddress.Text = FilterA.Address;

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

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Tag = formWorkshops?.workshop;
            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();

            tbClient.Tag = formClients?.client;
            tbClient.Text = formClients?.client?.Name;
            
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAddress.Clear();
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

            FilterA = new OrderAtHome();
            FilterB = new OrderAtHome();
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

        private void btnCleanStatus_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedItem = null;
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
            {
                comboBoxStatus.SelectedItem = null;
            }
            FilterActive.Value = checkBoxActive.Checked;
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
            if (!int.TryParse(tbID.Text, out id) || id < 0) id = 0;

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

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            FilterA.Address = tbAddress.Text;
        }

        private void btnIdInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipIdInfo.SetToolTip(btnIdInfo, "id может быть только целом положительным числом");
        }
    }
}

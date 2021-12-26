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
    public partial class FormOutOrders : Form
    {
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

        public FormOutOrders(string client, bool readOnly)
        {
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

        public FormOutOrders(int product, bool readOnly)
        {
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

            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Статусу заказа");
            comboBoxSortBy.Items.Add("Цене");
            comboBoxSortBy.Items.Add("Дате начала");
            comboBoxSortBy.Items.Add("Адресу");
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
            else if (comboBoxSortBy.SelectedItem.ToString() == "Статусу заказа")
            {
                sortBy = "Status";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Цене")
            {
                sortBy = "FinalPrice";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Дате начала")
            {
                sortBy = "DateStart";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Адресу")
            {
                sortBy = "Address";
            }

            OrderStatus pickedStatus = OrderStatus.Unknown;
            if (comboBoxStatus.SelectedItem != null)
            {
                pickedStatus = StatusStringExtensions.GetStatusEnum(comboBoxStatus.SelectedItem.ToString());
            }

            DateTime? dateStartFrom = null;
            if (datePickerStartFrom.Format != DateTimePickerFormat.Custom)
                dateStartFrom = datePickerStartFrom.Value;

            DateTime? dateStartUntil = null;
            if (datePickerStartUntil.Format != DateTimePickerFormat.Custom)
                dateStartUntil = datePickerStartUntil.Value;

            List<OrderAtHome> orders = OrderAtHomeList.GetOrders(
                new OrderAtHome()
                {
                    Id = id,
                    Workshop = (Workshop)tbWorkshop.Tag,
                    Product = (Product)tbProduct.Tag,
                    FinalPrice = numericPriceFrom.Value,
                    Status = pickedStatus,
                    DateStart = dateStartFrom,
                    Address = tbAddress.Text
                },
                new OrderAtHome()
                {
                    FinalPrice = numericPriceUntil.Value,
                    DateStart = dateStartUntil

                },
                (Client)tbClient.Tag,
                checkBoxActive.Checked,
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

        private void BtnManage_Click(object sender, EventArgs e)        // !!!!ВОТ ТУТ АДРЕС БУДЕТ ИЛИ НЕТ!!!!
        {

            FormAddOrder addOrder = new FormAddOrder(false);
            addOrder.ShowDialog();

            FillGrid();
        }

        private void BtnShow_Click(object sender, EventArgs e)          // !!!!ВОТ ТУТ АДРЕС БУДЕТ ИЛИ НЕТ!!!!
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

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            dateTimePicker.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            dateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();

            tbClient.Text = formClients?.client?.Name;
            tbClient.Tag = formClients?.client;
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();

            tbProduct.Text = formProducts?.product?.Name;
            tbProduct.Tag = formProducts?.product;
        }

        private void btnCleanWorkshop_Click(object sender, EventArgs e)
        {
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;
        }

        private void btnCleanClient_Click(object sender, EventArgs e)
        {
            tbClient.Clear();
            tbClient.Tag = null;
        }

        private void btnCleanProduct_Click(object sender, EventArgs e)
        {
            tbProduct.Clear();
            tbProduct.Tag = null;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAddress.Clear();
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;
            tbClient.Clear();
            tbClient.Tag = null;
            tbProduct.Clear();
            tbProduct.Tag = null;
            datePickerStartFrom.Format = DateTimePickerFormat.Custom;
            datePickerStartFrom.CustomFormat = " ";
            datePickerStartUntil.Format = DateTimePickerFormat.Custom;
            datePickerStartUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            comboBoxStatus.SelectedItem = numericPriceUntil;

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
        }
    }
}

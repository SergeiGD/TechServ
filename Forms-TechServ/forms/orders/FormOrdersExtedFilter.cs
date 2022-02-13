using System;
using System.Drawing;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.clients;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.products;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.clients;
using Forms_TechServ.forms.employees;
using Forms_TechServ.forms.products;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.orders
{
    public partial class FormOrdersExtedFilter : Form
    {
        Order FilterA = new OrderAtHome();
        Order FilterB = new OrderAtHome();
        ValueWrapper<bool> FilterActive;
        ValueWrapper<string> FilterSortBy;
        ValueWrapper<bool> FilterAksOrDesk;
        Client FilterClient;
        bool inOrder;

        public FormOrdersExtedFilter(bool inOrder)
        {
            InitializeComponent();

            this.inOrder = inOrder;
            //this.FilterActive = FilterActive;


            if (inOrder)                                // ЕСЛИ ЗАКАЗ НЕ НА ДОМУ, ТО АДРЕС НЕ НУЖЕН, ПОЭТОМУ СКРЫВАЕМ И НЕМНОГО ДВИГАЕМ СЛЕДУЮЩИЙ ЭЛЕМЕНТ
            {
                label1.Visible = false;
                tbAddress.Visible = false;
                checkBoxActive.Location = new Point(checkBoxActive.Location.X, checkBoxActive.Location.Y + 20);        
            }

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if (status == OrderStatus.Unknown)
                {
                    continue;
                }
                comboBoxStatus.Items.Add(status.GetStatusString());
            }
            comboBoxStatus.SelectedItem = null;

            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Дате начала");
            comboBoxSortBy.Items.Add("Требуемой предоплате");
            comboBoxSortBy.Items.Add("Внесенной предоплате");
            comboBoxSortBy.Items.Add("Стоимосте");
            FilterSortBy = new ValueWrapper<string>(comboBoxSortBy.Items[0].ToString());
            comboBoxSortBy.SelectedIndex = 0;

            datePickerStartFrom.CloseUp += dateTimePicker_ValuePicked;
            datePickerStartUntil.CloseUp += dateTimePicker_ValuePicked;
            datePickerDiagnoseFrom.CloseUp += dateTimePicker_ValuePicked;
            datePickerDiagnoseUntil.CloseUp += dateTimePicker_ValuePicked;
            datePickerAnswerFrom.CloseUp += dateTimePicker_ValuePicked;
            datePickerAnswerUntil.CloseUp += dateTimePicker_ValuePicked;
            datePickerCanceledFrom.CloseUp += dateTimePicker_ValuePicked;
            datePickerCanceledUntil.CloseUp += dateTimePicker_ValuePicked;
            datePickerRepaiedFrom.CloseUp += dateTimePicker_ValuePicked;
            datePickerRepaiedUntil.CloseUp += dateTimePicker_ValuePicked;
            datePickerPaidFrom.CloseUp += dateTimePicker_ValuePicked;
            datePickerPaidUntil.CloseUp += dateTimePicker_ValuePicked;
            datePickerFinishFrom.CloseUp += dateTimePicker_ValuePicked;
            //datePickerFinishUntil.ValueChanged += dateTimePicker_ValueChanged;
            datePickerFinishUntil.CloseUp += dateTimePicker_ValuePicked;
        }

        public void LoadData(Order FilterA, Order FilterB, Client FilterClient, ValueWrapper<bool> FilterActive, ValueWrapper<string> FilterSortBy, ValueWrapper<bool> FilterAksOrDesk)
        {
            this.FilterA = FilterA;
            this.FilterB = FilterB;
            this.FilterClient = FilterClient;
            this.FilterActive = FilterActive;
            this.FilterSortBy = FilterSortBy;
            this.FilterAksOrDesk = FilterAksOrDesk;

            if(FilterA.Id != 0)
            {
                tbID.Text = FilterA.Id.ToString();
            }
            else
            {
                tbID.Clear();
            }

            if (!inOrder)
            {
                tbAddress.Text = ((OrderAtHome)FilterA).Address;
            }

            tbWorkshop.Tag = FilterA?.Workshop;
            tbWorkshop.Text = FilterA?.Workshop?.Location;

            tbClient.Tag = FilterClient;
            tbClient.Text = FilterClient?.Name;

            tbProduct.Tag = FilterA?.Product;
            tbProduct.Text = FilterA?.Product?.Name;

            tbMaster.Tag = FilterA?.Master;
            tbMaster.Text = FilterA?.Master?.Name;

            tbManager.Tag = FilterA?.Manager;
            tbManager.Text = FilterA?.Manager?.Name;

            numericPaidFrom.Value = FilterA.PrepaymentMade;
            numericPaidUntil.Value = FilterB.PrepaymentMade;

            numericPrepaymentFrom.Value = FilterA.PrepaymentRequired;
            numericPrepaymentUntil.Value = FilterB.PrepaymentRequired;

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
            if (FilterA.DateDiagnostic.HasValue)
            {
                datePickerDiagnoseFrom.Format = DateTimePickerFormat.Short;
                datePickerDiagnoseFrom.Value = FilterA.DateDiagnostic.Value;
            }
            else
            {
                datePickerDiagnoseFrom.Format = DateTimePickerFormat.Custom;
                datePickerDiagnoseFrom.CustomFormat = " ";
            }
            if (FilterB.DateDiagnostic.HasValue)
            {
                datePickerDiagnoseUntil.Format = DateTimePickerFormat.Short;
                datePickerDiagnoseUntil.Value = FilterB.DateDiagnostic.Value;
            }
            else
            {
                datePickerDiagnoseUntil.Format = DateTimePickerFormat.Custom;
                datePickerDiagnoseUntil.CustomFormat = " ";
            }
            if (FilterA.DateClientAnswer.HasValue)
            {
                datePickerAnswerFrom.Format = DateTimePickerFormat.Short;
                datePickerAnswerFrom.Value = FilterA.DateClientAnswer.Value;
            }
            else
            {
                datePickerAnswerFrom.Format = DateTimePickerFormat.Custom;
                datePickerAnswerFrom.CustomFormat = " ";
            }
            if (FilterB.DateClientAnswer.HasValue)
            {
                datePickerAnswerUntil.Format = DateTimePickerFormat.Short;
                datePickerAnswerUntil.Value = FilterB.DateClientAnswer.Value;
            }
            else
            {
                datePickerAnswerUntil.Format = DateTimePickerFormat.Custom;
                datePickerAnswerUntil.CustomFormat = " ";
            }
            if (FilterA.DateCancel.HasValue)
            {
                datePickerCanceledFrom.Format = DateTimePickerFormat.Short;
                datePickerCanceledFrom.Value = FilterA.DateCancel.Value;
            }
            else
            {
                datePickerCanceledFrom.Format = DateTimePickerFormat.Custom;
                datePickerCanceledFrom.CustomFormat = " ";
            }
            if (FilterB.DateCancel.HasValue)
            {
                datePickerCanceledUntil.Format = DateTimePickerFormat.Short;
                datePickerCanceledUntil.Value = FilterB.DateCancel.Value;
            }
            else
            {
                datePickerCanceledUntil.Format = DateTimePickerFormat.Custom;
                datePickerCanceledUntil.CustomFormat = " ";
            }
            if (FilterA.DateRepaired.HasValue)
            {
                datePickerRepaiedFrom.Format = DateTimePickerFormat.Short;
                datePickerRepaiedFrom.Value = FilterA.DateRepaired.Value;
            }
            else
            {
                datePickerRepaiedFrom.Format = DateTimePickerFormat.Custom;
                datePickerRepaiedFrom.CustomFormat = " ";
            }
            if (FilterB.DateRepaired.HasValue)
            {
                datePickerRepaiedUntil.Format = DateTimePickerFormat.Short;
                datePickerRepaiedUntil.Value = FilterB.DateRepaired.Value;
            }
            else
            {
                datePickerRepaiedUntil.Format = DateTimePickerFormat.Custom;
                datePickerRepaiedUntil.CustomFormat = " ";
            }
            if (FilterA.DatePaid.HasValue)
            {
                datePickerPaidFrom.Format = DateTimePickerFormat.Short;
                datePickerPaidFrom.Value = FilterA.DatePaid.Value;
            }
            else
            {
                datePickerPaidFrom.Format = DateTimePickerFormat.Custom;
                datePickerPaidFrom.CustomFormat = " ";
            }
            if (FilterB.DatePaid.HasValue)
            {
                datePickerPaidUntil.Format = DateTimePickerFormat.Short;
                datePickerPaidUntil.Value = FilterB.DatePaid.Value;
            }
            else
            {
                datePickerPaidUntil.Format = DateTimePickerFormat.Custom;
                datePickerPaidUntil.CustomFormat = " ";
            }
            if (FilterA.DateFinish.HasValue)
            {
                datePickerFinishFrom.Format = DateTimePickerFormat.Short;
                datePickerFinishFrom.Value = FilterA.DateFinish.Value;
            }
            else
            {
                datePickerFinishFrom.Format = DateTimePickerFormat.Custom;
                datePickerFinishFrom.CustomFormat = " ";
            }
            if (FilterB.DateFinish.HasValue)
            {
                datePickerFinishUntil.Format = DateTimePickerFormat.Short;
                datePickerFinishUntil.Value = FilterB.DateFinish.Value;
            }
            else
            {
                datePickerFinishUntil.Format = DateTimePickerFormat.Custom;
                datePickerFinishUntil.CustomFormat = " ";
            }

            numericPriceFrom.Value = FilterA.FinalPrice;
            numericPriceUntil.Value = FilterB.FinalPrice;
            if(FilterA.Status != OrderStatus.Unknown)
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

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();

            tbMaster.Tag = formMasters?.master;
            tbMaster.Text = formMasters?.master?.Name;
        }

        private void btnFindManager_Click(object sender, EventArgs e)
        {
            FormManagers formManagers = new FormManagers(true);
            formManagers.ShowDialog();

            tbManager.Tag = formManagers?.manager;
            tbManager.Text = formManagers?.manager?.Name;
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Tag = formWorkshops?.workshop;
            tbWorkshop.Text = formWorkshops?.workshop?.Location;
        }

        private void FormOrdersExtedFilter_Load(object sender, EventArgs e)
        {
            /*foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if (status == OrderStatus.Unknown)
                {
                    continue;
                }
                comboBoxStatus.Items.Add(status.GetStatusString());
            }
            comboBoxStatus.SelectedItem = null;*/
        }

        private void dateTimePicker_ValuePicked(object sender, EventArgs e)
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

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderStatus pickedStatus = OrderStatus.Unknown;
            if (comboBoxStatus.SelectedItem != null)
            {
                pickedStatus = StatusStringExtensions.GetStatusEnum(comboBoxStatus.SelectedItem.ToString());
            }
            FilterA.Status = pickedStatus;
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
            {
                comboBoxStatus.SelectedItem = null;
            }
            FilterActive.Value = checkBoxActive.Checked;
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

        private void btnCleanMaster_Click(object sender, EventArgs e)
        {
            tbMaster.Tag = null;
            tbMaster.Clear();
        }

        private void btnCleanManager_Click(object sender, EventArgs e)
        {
            tbManager.Tag = null;
            tbManager.Clear();
        }

        private void tbMaster_TextChanged(object sender, EventArgs e)
        {
            FilterA.Master = (Master)tbMaster.Tag;
        }

        private void tbManager_TextChanged(object sender, EventArgs e)
        {
            FilterA.Manager = (Manager)tbManager.Tag;
        }

        private void numericPrepaymentFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterA.PrepaymentRequired = numericPrepaymentFrom.Value;
        }

        private void numericPrepaymentUntil_ValueChanged(object sender, EventArgs e)
        {
            FilterB.PrepaymentRequired = numericPrepaymentUntil.Value;
        }

        private void numericPaidFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterA.PrepaymentMade = numericPaidFrom.Value;
        }

        private void numericPaidUntil_ValueChanged(object sender, EventArgs e)
        {
            FilterB.PrepaymentMade = numericPaidUntil.Value;
        }

        private void btnPriceInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPriceInfo.SetToolTip(btnPriceInfo, "Ноль - до скольки угодно");
        }

        private void btnCleanDiagnosticFrom_Click(object sender, EventArgs e)
        {
            datePickerDiagnoseFrom.Format = DateTimePickerFormat.Custom;
            datePickerDiagnoseFrom.CustomFormat = " ";
        }

        private void btnCleanDiagnosticUntil_Click(object sender, EventArgs e)
        {
            datePickerDiagnoseUntil.Format = DateTimePickerFormat.Custom;
            datePickerDiagnoseUntil.CustomFormat = " ";
        }

        private void btnCleanAnswerFrom_Click(object sender, EventArgs e)
        {
            datePickerAnswerFrom.Format = DateTimePickerFormat.Custom;
            datePickerAnswerFrom.CustomFormat = " ";
        }

        private void btnCleanAnswerUntil_Click(object sender, EventArgs e)
        {
            datePickerAnswerUntil.Format = DateTimePickerFormat.Custom;
            datePickerAnswerUntil.CustomFormat = " ";
        }

        private void btnClanCancelFrom_Click(object sender, EventArgs e)
        {
            datePickerCanceledFrom.Format = DateTimePickerFormat.Custom;
            datePickerCanceledFrom.CustomFormat = " ";
        }

        private void btnClanCancelUntil_Click(object sender, EventArgs e)
        {
            datePickerCanceledUntil.Format = DateTimePickerFormat.Custom;
            datePickerCanceledUntil.CustomFormat = " ";
        }

        private void btnClanRepairedFrom_Click(object sender, EventArgs e)
        {
            datePickerRepaiedFrom.Format = DateTimePickerFormat.Custom;
            datePickerRepaiedFrom.CustomFormat = " ";
        }

        private void btnClanRepairedUntil_Click(object sender, EventArgs e)
        {
            datePickerRepaiedUntil.Format = DateTimePickerFormat.Custom;
            datePickerRepaiedUntil.CustomFormat = " ";
        }

        private void btnClanPaidFrom_Click(object sender, EventArgs e)
        {
            datePickerPaidFrom.Format = DateTimePickerFormat.Custom;
            datePickerPaidFrom.CustomFormat = " ";
        }

        private void btnClanPaidUntil_Click(object sender, EventArgs e)
        {
            datePickerPaidUntil.Format = DateTimePickerFormat.Custom;
            datePickerPaidUntil.CustomFormat = " ";
        }

        private void btnCleanFinishFrom_Click(object sender, EventArgs e)
        {
            datePickerFinishFrom.Format = DateTimePickerFormat.Custom;
            datePickerFinishFrom.CustomFormat = " ";
        }

        private void btnCleanFinishUntil_Click(object sender, EventArgs e)
        {
            datePickerFinishUntil.Format = DateTimePickerFormat.Custom;
            datePickerFinishUntil.CustomFormat = " ";
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

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSortBy.Value = comboBoxSortBy.SelectedItem.ToString();
        }

        private void datePickerDiagnoseFrom_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateDiagnosticFrom = null;
            if (datePickerDiagnoseFrom.Format != DateTimePickerFormat.Custom)
                dateDiagnosticFrom = datePickerDiagnoseFrom.Value;
            FilterA.DateDiagnostic = dateDiagnosticFrom;
        }

        private void datePickerDiagnoseUntil_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateDiagnosticUntil = null;
            if (datePickerDiagnoseUntil.Format != DateTimePickerFormat.Custom)
                dateDiagnosticUntil = datePickerDiagnoseUntil.Value;
            FilterB.DateDiagnostic = dateDiagnosticUntil;
        }

        private void datePickerAnswerFrom_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateAnswerFrom = null;
            if (datePickerAnswerFrom.Format != DateTimePickerFormat.Custom)
                dateAnswerFrom = datePickerAnswerFrom.Value;
            FilterA.DateClientAnswer = dateAnswerFrom;
        }

        private void datePickerAnswerUntil_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateAnswerUntil = null;
            if (datePickerAnswerUntil.Format != DateTimePickerFormat.Custom)
                dateAnswerUntil = datePickerAnswerUntil.Value;
            FilterB.DateClientAnswer = dateAnswerUntil;
        }

        private void datePickerCanceledFrom_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateCancelFrom = null;
            if (datePickerCanceledFrom.Format != DateTimePickerFormat.Custom)
                dateCancelFrom = datePickerCanceledFrom.Value;
            FilterA.DateCancel = dateCancelFrom;
        }

        private void datePickerCanceledUntil_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateCancelUntil = null;
            if (datePickerCanceledUntil.Format != DateTimePickerFormat.Custom)
                dateCancelUntil = datePickerCanceledUntil.Value;
            FilterB.DateCancel = dateCancelUntil;
        }

        private void datePickerRepaiedFrom_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateRepairedFrom = null;
            if (datePickerRepaiedFrom.Format != DateTimePickerFormat.Custom)
                dateRepairedFrom = datePickerRepaiedFrom.Value;
            FilterA.DateRepaired = dateRepairedFrom;
        }

        private void datePickerRepaiedUntil_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateRepairedUntil = null;
            if (datePickerRepaiedUntil.Format != DateTimePickerFormat.Custom)
                dateRepairedUntil = datePickerRepaiedUntil.Value;
            FilterB.DateRepaired = dateRepairedUntil;
        }

        private void datePickerPaidFrom_FormatChanged(object sender, EventArgs e)
        {
            DateTime? datePaidFrom = null;
            if (datePickerPaidFrom.Format != DateTimePickerFormat.Custom)
                datePaidFrom = datePickerPaidFrom.Value;
            FilterA.DatePaid = datePaidFrom;
        }

        private void datePickerPaidUntil_FormatChanged(object sender, EventArgs e)
        {
            DateTime? datePaidUntil = null;
            if (datePickerPaidUntil.Format != DateTimePickerFormat.Custom)
                datePaidUntil = datePickerPaidUntil.Value;
            FilterB.DatePaid = datePaidUntil;
        }

        private void datePickerFinishFrom_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateFinishFrom = null;
            if (datePickerFinishFrom.Format != DateTimePickerFormat.Custom)
                dateFinishFrom = datePickerFinishFrom.Value;
            FilterA.DateFinish = dateFinishFrom;
        }

        private void datePickerFinishUntil_FormatChanged(object sender, EventArgs e)
        {
            DateTime? dateFinishUntil = null;
            if (datePickerFinishUntil.Format != DateTimePickerFormat.Custom)
                dateFinishUntil = datePickerFinishUntil.Value;
            FilterB.DateFinish = dateFinishUntil;
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            ((OrderAtHome)FilterA).Address = tbAddress.Text;
        }

        private void btnIdInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipIdInfo.SetToolTip(btnIdInfo, "id может быть только целом положительным числом");
        }
    }
}

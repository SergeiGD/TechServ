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
    public partial class FormShowOrder : Form
    {
        Order order;
        bool inOrder;
        bool readOnly;
        int servicesRowsCount;
        int servicesCurrentPage = 1;

        public FormShowOrder(bool readOnly, Order order)
        {
            InitializeComponent();


            this.readOnly = readOnly;

            this.order = order;
            if (order.GetType() != typeof(OrderAtHome))
            {
                this.inOrder = true;
                ordersTab.TabPages.Remove(visitsPage);
            }

        }

        private void FormEditWorkshopOrder_Load(object sender, EventArgs e)
        {

            comboBoxShowServicesRows.Items.Add(5);
            comboBoxShowServicesRows.Items.Add(20);
            comboBoxShowServicesRows.Items.Add(30);
            comboBoxShowServicesRows.Items.Add(40);
            comboBoxShowServicesRows.SelectedIndex = 2;



            if (inOrder)
            {
                labelAddress.Visible = false;
                label34.Visible = false;
            }
            else
            {
                labelAddress.Text = ((OrderAtHome)order).Address;
            }

            if (readOnly || !UserSession.Can("edit_order"))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }

            FillForm();
        }

        private void FillForm()
        {
            labelID.Text = order.Id.ToString();
            labelClient.Text = ClientsList.GetById(order.Product.ClientId).Name;
            labelProduct.Text = order.Product.Name;
            labelMaster.Text = order.Master.Name;
            labelWorkshop.Text = order.Workshop.Location;
            labelStatus.Text = order.Status.GetStatusString();
            labelServicesCount.Text = order.CalcServicesCount().ToString();
            labelServicecPrice.Text = order.CalcServicesPrice().ToString();
            labelClientSale.Text = order.ClientSale.ToString() + "%";
            labelFinalPrice.Text = order.FinalPrice.ToString();

            labelDateStart.Text = order.DateStart.Value.ToString();
            if (order.DatePrepayment.HasValue)
                labelDatePrepayment.Text = order.DatePrepayment.Value.ToString();
            else
                labelDatePrepayment.Text = "Не определена";
            if (order.DatePaid.HasValue)
                labelDatePaid.Text = order.DatePaid.Value.ToString();
            else
                labelDatePaid.Text = "Не определена";
            if (order.DateFinish.HasValue)
                labelDateFinished.Text = order.DateFinish.Value.ToString();
            else
                labelDateFinished.Text = "Не определена";
            if (order.DateCancel.HasValue)
                labelDateCanceled.Text = order.DateCancel.Value.ToString();
            else
                labelDateCanceled.Text = "Не определена";
            if (order.DateDiagnostic.HasValue)
                labelDateDiagnostic.Text = order.DateDiagnostic.Value.ToString();
            else
                labelDateDiagnostic.Text = "Не определена";
            if (order.DateClientAnswer.HasValue)
                labelDateAnswer.Text = order.DateClientAnswer.Value.ToString();
            else
                labelDateAnswer.Text = "Не определена";
            if (order.DateRepaired.HasValue)
                labelDateRepaired.Text = order.DateRepaired.Value.ToString();
            else
                labelDateRepaired.Text = "Не определена";

            tbComment.Text = order.ClientComment;

            FillServices();
        }

        private void FillServices()
        {
            List<OrderService> services = order.GetServices(
                (int)comboBoxShowServicesRows.SelectedItem,
                servicesCurrentPage,
                out servicesRowsCount);

            dataServies.Rows.Clear();
            for (int i = 0; i < services.Count; i++)
            {
                dataServies.Rows.Add(new DataGridViewRow());

                dataServies.Rows[i].Cells[0].Value = services[i].ServiceId;
                dataServies.Rows[i].Cells[1].Value = services[i].Service.Name;
                dataServies.Rows[i].Cells[2].Value = services[i].Service.Price;
                dataServies.Rows[i].Cells[3].Value = services[i].Quantity;
                dataServies.Rows[i].Cells[4].Value = services[i].Sale;
                dataServies.Rows[i].Cells[5].Value = services[i].Service.Price * services[i].Quantity - (services[i].Service.Price * services[i].Quantity * (services[i].Sale / 100));


            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)servicesRowsCount / (int)comboBoxShowServicesRows.SelectedItem);
            numericCurrentServicePage.Maximum = maxPage;

            if (numericCurrentServicePage.Maximum > 0)
                numericCurrentServicePage.Value = numericCurrentServicePage.Value == 0 ? 1 : numericCurrentServicePage.Value;

            labelServicesPageCout.Text = $"из {maxPage}";
        }

        private void manageButton1_Click(object sender, EventArgs e)
        {
            FormShowService formShowService = new FormShowService(true, ServicesList.GetById(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value), true));
            formShowService.ShowDialog();
        }

        private void manageButton2_Click(object sender, EventArgs e)
        {
            FormShowSparePart formShowSparePart = new FormShowSparePart(true, null);
            formShowSparePart.ShowDialog();
        }

        private void manageButton3_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormEditOrder editOrder = new FormEditOrder(order);
            editOrder.ShowDialog();

            FillForm();
        }

        private void ordersTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersTab.SelectedTab.Equals(logsPage))
            {

                FormOrdersLogs formOrdersLogs = new FormOrdersLogs(43, true);
                formOrdersLogs.TopLevel = false;
                formOrdersLogs.FormBorderStyle = FormBorderStyle.None;
                logsPage.Controls.Add(formOrdersLogs);
                //panelContent.Controls.Add(childForm);
                formOrdersLogs.Dock = DockStyle.Fill;
                formOrdersLogs.BringToFront();
                formOrdersLogs.Show();
            }
            else if (ordersTab.SelectedTab.Equals(visitsPage))
            {

                FormVisits formVisits = new FormVisits(34, true);
                formVisits.TopLevel = false;
                formVisits.FormBorderStyle = FormBorderStyle.None;
                visitsPage.Controls.Add(formVisits);
                formVisits.Dock = DockStyle.Fill;
                formVisits.BringToFront();
                formVisits.Show();
            }
        }

        private void linkPickedClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowClient formShowClient = new FormShowClient(true, ClientsList.GetById(order.Product.ClientId));
            formShowClient.ShowDialog();
        }

        private void labelPickedProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowProduct formShowProduct = new FormShowProduct(true, order.Product);
            formShowProduct.ShowDialog();
        }

        private void linkPickedMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowMaster formShowMaster = new FormShowMaster(true, MastersList.GetById(order.MasterId, true));
            formShowMaster.ShowDialog();
        }

        private void btnNextService_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value + 1 > numericCurrentServicePage.Maximum ? numericCurrentServicePage.Value : numericCurrentServicePage.Value + 1;
        }

        private void btnPrevService_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value - 1 < numericCurrentServicePage.Minimum ? numericCurrentServicePage.Value : numericCurrentServicePage.Value - 1;
        }

        private void comboBoxShowServicesRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillServices();
        }

        private void numericCurrentServicePage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = (int)numericCurrentServicePage.Value;           // если ввели дробное число, оно автоматически округлится
            servicesCurrentPage = (int)numericCurrentServicePage.Value;
            FillServices();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelWorkshop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowWorkshop formShowWorkshop = new FormShowWorkshop(true, order.Workshop);
            formShowWorkshop.ShowDialog();
        }
    }
}

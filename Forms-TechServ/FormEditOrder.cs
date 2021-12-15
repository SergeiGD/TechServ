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
    public partial class FormEditOrder : Form
    {
        Size pickedSize = new Size(991, 531);
        bool inOrder;

        public FormEditOrder(bool inOrder)
        {
            InitializeComponent();

            this.inOrder = inOrder;
            
        }

        private void OrdersTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ordersTab.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(744, 563);
            }
            else if(ordersTab.SelectedTab.Equals(servicesPage))
            {
                this.Size = pickedSize;
            }
            else if (ordersTab.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;

                FormSpareParts formSpareParts = new FormSpareParts(false, "asd");
                formSpareParts.TopLevel = false;
                formSpareParts.FormBorderStyle = FormBorderStyle.None;
                sparePartsPage.Controls.Add(formSpareParts);
                //panelContent.Controls.Add(childForm);
                formSpareParts.Dock = DockStyle.Fill;
                formSpareParts.BringToFront();
                formSpareParts.Show();
            }
            else if (ordersTab.SelectedTab.Equals(logsPage))
            {
                this.Size = pickedSize;

                FormOrdersLogs formOrdersLogs = new FormOrdersLogs(43, false);
                formOrdersLogs.TopLevel = false;
                formOrdersLogs.FormBorderStyle = FormBorderStyle.None;
                logsPage.Controls.Add(formOrdersLogs);
                //panelContent.Controls.Add(childForm);
                formOrdersLogs.Dock = DockStyle.Fill;
                formOrdersLogs.BringToFront();
                formOrdersLogs.Show();
            }
            else if (ordersTab.SelectedIndex == 4)
            {
                this.Size = pickedSize;
            }
        }

        private void FormEditOrder_ResizeEnd(object sender, EventArgs e)
        {
            if (!ordersTab.SelectedTab.Equals(generalPage))
            {
                pickedSize = this.Size;
            }
            
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            FormServices formServices = new FormServices(true);
            formServices.ShowDialog();
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            FormShowService formShowService = new FormShowService(true, null);
            formShowService.ShowDialog();
        }

        private void btnAddSparePart_Click(object sender, EventArgs e)
        {
            FormSpareParts formSpareParts = new FormSpareParts(true);
            formSpareParts.ShowDialog();
        }

        private void btnShowBatch_Click(object sender, EventArgs e)
        {
            FormShowSparePart formShowSparePart = new FormShowSparePart(true, null);
            formShowSparePart.ShowDialog();
        }

        private void FormEditOrder_Load(object sender, EventArgs e)
        {
            this.Size = new Size(744, 563);

            if (inOrder)
            {
                label3.Visible = false;
                tbAddress.Visible = false;
            }
            else
            {
                TabPage visitsPage = new TabPage("Выезды");
                ordersTab.TabPages.Add(visitsPage);

                FormVisits formVisits = new FormVisits(34, false);
                formVisits.TopLevel = false;
                formVisits.FormBorderStyle = FormBorderStyle.None;
                visitsPage.Controls.Add(formVisits);
                formVisits.Dock = DockStyle.Fill;
                formVisits.BringToFront();
                formVisits.Show();
            }
            
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }

        private void btnFindTech_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

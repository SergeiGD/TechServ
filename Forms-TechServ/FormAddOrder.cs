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
    public partial class FormAddOrder : Form
    {
        Size pickedSize = new Size(991, 525);
        bool inOrder;

        /*public FormAddInOrder()
        {
            InitializeComponent();

            this.Size = new Size(713, 313);
        }*/

        public FormAddOrder(bool inOrder)
        {
            InitializeComponent();

            this.inOrder = inOrder;

            
        }

        private void btnEditServices_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ordersTab.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(713, 496); 
            }
            else if(ordersTab.SelectedTab.Equals(servicesPage))
            {
                this.Size = pickedSize;
            }
            else if(ordersTab.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;
            }
        }

        private void FormAddInOrder_ResizeEnd(object sender, EventArgs e)
        {
            if (!ordersTab.SelectedTab.Equals(generalPage))
            {
                pickedSize = this.Size;
            }
        }

        private void manageButton2_Click(object sender, EventArgs e)
        {
            FormServices formServices = new FormServices(true);
            formServices.ShowDialog();
        }

        private void manageButton1_Click(object sender, EventArgs e)
        {
            FormShowService showService = new FormShowService(true, null);
            showService.ShowDialog();
        }

        private void manageButton5_Click(object sender, EventArgs e)
        {
            FormSpareParts formSpareParts = new FormSpareParts(true);
            formSpareParts.ShowDialog();
        }

        private void manageButton6_Click(object sender, EventArgs e)
        {
            FormShowSparePart formShowSparePart = new FormShowSparePart(true);
            formShowSparePart.ShowDialog();
        }

        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            this.Size = new Size(713, 496);


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

        /*private void FormAddInOrder_ResizeEnd(object sender, EventArgs e)
        {
            pickedSize = this.Size;
        }*/
    }
}

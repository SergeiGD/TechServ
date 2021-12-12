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
        bool inOrder;
        bool readOnly;
        public FormShowOrder(bool inOrder, bool readOnly)
        {
            InitializeComponent();

            this.inOrder = inOrder;
            this.readOnly = readOnly;
        }

        /*public FormShowOrder(string client)
        {
            this.Controls.Remove(panelEdit);
            this.Width = this.Width - panelEdit.Width;
        }

        public FormShowOrder(int product)
        {
            this.Controls.Remove(panelEdit);
            this.Width = this.Width - panelEdit.Width;
        }*/

        private void FormEditWorkshopOrder_Load(object sender, EventArgs e)
        {
            if (inOrder)
            {
                labelAddress.Visible = false;
                label34.Visible = false;
            }
            else
            {
                TabPage visitsPage = new TabPage("Выезды");
                ordersTab.TabPages.Add(visitsPage);

                FormVisits formVisits = new FormVisits(34, true);
                formVisits.TopLevel = false;
                formVisits.FormBorderStyle = FormBorderStyle.None;
                visitsPage.Controls.Add(formVisits);
                formVisits.Dock = DockStyle.Fill;
                formVisits.BringToFront();
                formVisits.Show();
                //visitsPage.Controls.Add(new FormVisits());
            }

            if (readOnly)
            {
                //MessageBox.Show(panelEdit.Parent.Name);
                panelEdit.Parent.Controls.Remove(panelEdit);
                //ordersTab.TabPages[0].Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
                //MessageBox.Show(panelEdit.Parent.Name);
            }
            
        }

        private void manageButton1_Click(object sender, EventArgs e)
        {
            FormShowService formShowService = new FormShowService(true);
            formShowService.ShowDialog();
        }

        private void manageButton2_Click(object sender, EventArgs e)
        {
            FormShowSparePart formShowSparePart = new FormShowSparePart(true);
            formShowSparePart.ShowDialog();
        }

        private void manageButton3_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormEditOrder editOrder = new FormEditOrder(inOrder);
            editOrder.ShowDialog();
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
        }

        private void linkPickedClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowClient formShowClient = new FormShowClient(true, null);
            formShowClient.ShowDialog();
        }

        private void labelPickedProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowProduct formShowProduct = new FormShowProduct(true, null);
            formShowProduct.ShowDialog();
        }

        private void linkPickedMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowMaster formShowMaster = new FormShowMaster(true, null);
            formShowMaster.ShowDialog();
        }

        
    }
}

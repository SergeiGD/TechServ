using System;
using System.Drawing;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.clients;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.forms.orders;
using Forms_TechServ.forms.products;

namespace Forms_TechServ.forms.clients
{
    public partial class FormShowClient : Form
    {

        Client client;
        Size pickedSize = new Size(1078, 600);
        bool readOnly;

        public FormShowClient(bool readOnly, Client client)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            this.client = client;
        }

        

        private void clientTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(502, 340);
            }
            else if (clientTabs.SelectedTab.Equals(productsPage))
            {
                this.Size = pickedSize;

                FormProducts formProducts = new FormProducts(true, client);

                
                formProducts.TopLevel = false;
                formProducts.FormBorderStyle = FormBorderStyle.None;
                productsPage.Controls.Add(formProducts);
                //panelContent.Controls.Add(childForm);
                formProducts.Dock = DockStyle.Fill;
                formProducts.BringToFront();
                formProducts.Show();
            }
            else if (clientTabs.SelectedTab.Equals(ordersPage))
            {
                

                FormOrders formOrders = new FormOrders(client);
                this.Size = pickedSize;
                formOrders.TopLevel = false;
                formOrders.FormBorderStyle = FormBorderStyle.None;
                ordersPage.Controls.Add(formOrders);
                //panelContent.Controls.Add(childForm);
                formOrders.Dock = DockStyle.Fill;
                formOrders.BringToFront();
                formOrders.Show();
            }
        }

        private void FormShowClient_ResizeEnd(object sender, EventArgs e)
        {
            if(!clientTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageClient manageClient = new FormManageClient(client);
            manageClient.ShowDialog();

            FillForm();
        }

        private void FormShowClient_Load(object sender, EventArgs e)
        {
            if (readOnly || (!UserSession.Can("edit_client") && !UserSession.Can("add_del_client")))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_client");
                deleteBtn.Enabled = UserSession.Can("add_del_client");
            }

            FillForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить этого клиента? Это также приведет к удалдению всей его техники", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {

                if (client.DelClient())
                {
                    MessageBox.Show("Клиент успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("У данного клиента есть активные заказы, пока его нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;
            }
        }

        private void FillForm()
        {
            labelID.Text = client.Id.ToString();
            labelName.Text = client.Name;
            labelPhoneNum.Text = client.PhoneNum;
            labelLastAddress.Text = client.GetLastAddress();
            labelOrdersCount.Text = client.CountClientOrders().ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

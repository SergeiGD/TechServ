using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TechServ
{
    public partial class FormManageClient : Form
    {
        Client client;
        Size pickedSize = new Size(1150, 481);

        public FormManageClient()
        {
            InitializeComponent();

            clientsTab.TabPages.Remove(productPage);
            //clientsTab.TabPages.Remove(ordersPage);

            client = new Client();

            btnAction.Text = "Добавить";
        }
        public FormManageClient(Client client)
        {
            InitializeComponent();


            this.client = client;

            btnAction.Text = "Сохранить";
        }

        private void clientsTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientsTab.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(459, 206);
            }
            else if (clientsTab.SelectedTab.Equals(productPage))
            {
                this.Size = pickedSize;

                FormProducts formProducts = new FormProducts(false, client);

                //formOrders.Controls.Remove(formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelControl").First());
                //formOrders.Size = formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelContent").First().Size;
                //formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelContent").First().Dock = DockStyle.Fill;
                formProducts.TopLevel = false;
                formProducts.FormBorderStyle = FormBorderStyle.None;
                productPage.Controls.Add(formProducts);
                //panelContent.Controls.Add(childForm);
                formProducts.Dock = DockStyle.Fill;
                formProducts.BringToFront();
                formProducts.Show();
            }
            /*else if(clientsTab.SelectedTab.Equals(ordersPage))
            {
                this.Size = pickedSize;

                FormOrders formOrders = new FormOrders("qwe", true);

                //formOrders.Controls.Remove(formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelControl").First());
                //formOrders.Size = formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelContent").First().Size;
                //formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelContent").First().Dock = DockStyle.Fill;
                formOrders.TopLevel = false;
                formOrders.FormBorderStyle = FormBorderStyle.None;
                clientsTab.TabPages[2].Controls.Add(formOrders);
                //clientsPage.Controls.Add(formOrders);
                //panelContent.Controls.Add(childForm);
                formOrders.Dock = DockStyle.Fill;
                formOrders.BringToFront();
                formOrders.Show();
            }*/

        }

        private void FormManageClient_ResizeEnd(object sender, EventArgs e)
        {
            if(!clientsTab.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                client.Name = tbName.Text;
                client.PhoneNum = tbPhoneNum.Text;

                if(client.Id == 0)
                {
                    client.AddClient();

                    DialogResult answer = MessageBox.Show($"Новый клиент успешно добавлен. ID - {client.Id}. Желаете добавить технику сейчас?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    this.Hide();
                    if (answer == DialogResult.Yes)
                    {
                        FormManageClient formManageClient = new FormManageClient(ClientsList.GetById(client.Id));
                        formManageClient.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    client.EditClient();

                    MessageBox.Show($"Клиент информация о клиенте успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbName.Text == "")
            {
                errorProvider.SetError(tbName, "Введите имя");
                return false;
            }
            if (!Regex.IsMatch(tbPhoneNum.Text, @"\d+"))
            {
                errorProvider.SetError(tbPhoneNum, "Введите номер числом");
                return false;
            }

            return true;
        }

        private void FormManageClient_Load(object sender, EventArgs e)
        {
            if(client.Id != 0)
            {
                tbName.Text = client.Name;
                tbPhoneNum.Text = client.PhoneNum;
            }
        }
    }
}

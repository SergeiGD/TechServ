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
    public partial class FormManageProduct : Form
    {
        Product product;
        //Size pickedSize = new Size(1078, 481);

        public FormManageProduct()
        {
            InitializeComponent();

            btnAction.Text = "Добавить";

            product = new Product();
        }

        public FormManageProduct(Product product)
        {
            InitializeComponent();

            btnAction.Text = "Сохранить";

            this.product = product;
        }

        public FormManageProduct(Client client)                 // добавление из клиента    (клиент зафиксирован и не может быть изменен)
        {
            InitializeComponent();

            btnAction.Text = "Добавить";

            product = new Product();

            tbClient.Text = client.Name;
            tbClient.Tag = client;

            btnFindClient.Enabled = false;
        }

        private void productsTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(productsTab.SelectedTab.Equals(genralPage))
            {
                this.Size = new Size(429, 204);
            }*/
            /*else if (productsTab.SelectedTab.Equals(ordersPage))
            {
                this.Size = pickedSize;

                FormOrders formOrders = new FormOrders(32, false);
                formOrders.TopLevel = false;
                formOrders.FormBorderStyle = FormBorderStyle.None;
                ordersPage.Controls.Add(formOrders);
                //panelContent.Controls.Add(childForm);
                formOrders.Dock = DockStyle.Fill;
                formOrders.BringToFront();
                formOrders.Show();
            }*/
        }

        private void FormManageProduct_ResizeEnd(object sender, EventArgs e)
        {
            //if(!productsTab.SelectedTab.Equals(genralPage))
                //pickedSize = this.Size;
        }

        private void btnFindCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true, true);
            formCategories.ShowDialog();

            tbCat.Text = formCategories?.category?.Name;
            tbCat.Tag = formCategories?.category;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();


            tbClient.Text = formClients?.client?.Name;
            tbClient.Tag = formClients?.client;
        }

        private bool CheckFields() 
        {
            errorProvider.Clear();
            if (tbName.Text == "")
            {
                errorProvider.SetError(tbName, "Введите имя");
                return false;
            }
            if(tbCat.Tag == null)
            {
                errorProvider.SetError(tbCat, "Выберите категорию");
                return false;
            }
            if (tbClient.Tag == null)
            {
                errorProvider.SetError(tbClient, "Выберите клиента");
                return false;
            }
            return true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                product.Name = tbName.Text;
                product.CategoryId = ((Category)tbCat.Tag).Id;
                product.ClientId = ((Client)tbClient.Tag).Id;

                if(product.Id == 0)
                {
                    product.AddProduct();
                    MessageBox.Show($"Новая техника успшено добавлена. ID - {product.Id}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    product.Category = (Category)tbCat.Tag;
                    product.Client = (Client)tbClient.Tag;

                    product.EditProduct();

                    MessageBox.Show($"Данные о технике успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void FormManageProduct_Load(object sender, EventArgs e)
        {
            if(product.Id != 0)
            {
                tbName.Text = product.Name;
                tbCat.Text = product.Category.Name;
                tbCat.Tag = product.Category;
                tbClient.Text = product.Client.Name;
                tbClient.Tag = product.Client;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

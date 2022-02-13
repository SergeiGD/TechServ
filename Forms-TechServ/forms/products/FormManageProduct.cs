using System;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.clients;
using Forms_TechServ.classes.products;
using Forms_TechServ.forms.categories;
using Forms_TechServ.forms.clients;

namespace Forms_TechServ.forms.products
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


        private void btnFindCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
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
                errorProvider.SetError(tbName, "Введите наименование");
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
                btnFindClient.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

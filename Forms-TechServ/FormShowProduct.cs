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
    public partial class FormShowProduct : Form
    {
        Product product;
        Size pickedSize = new Size(1078, 481);
        bool readOnly;

        /*public FormShowProduct()
        {
            InitializeComponent();
        }*/

        public FormShowProduct(/*string client, */bool readOnly, Product product)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.product = product;
        }

        

        private void FormShowProduct_Load(object sender, EventArgs e)
        {
            if (readOnly || (!UserSession.Can("edit_product") && !UserSession.Can("add_del_product")))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_product");
                deleteBtn.Enabled = UserSession.Can("add_del_product");
            }
            FillForm();

        }

        private void FillForm()
        {
            labelID.Text = product.Id.ToString();
            labelName.Text = product.Name;
            labelCat.Text = product.Category.Name;
            labelClient.Text = product.Client.Name;
            //labelCat.Tag = product.Category;
        }

        private void productTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(441, 260);
            }
            else if (productTabs.SelectedTab.Equals(historyPage))
            {
                //this.Size = new Size(1078, 481);
                this.Size = pickedSize;

                FormOrders formOrders = new FormOrders(3, true);

                formOrders.TopLevel = false;
                formOrders.FormBorderStyle = FormBorderStyle.None;
                historyPage.Controls.Add(formOrders);
                formOrders.Dock = DockStyle.Fill;
                formOrders.BringToFront();
                formOrders.Show();
            }
            
        }

        private void FormShowProduct_ResizeEnd(object sender, EventArgs e)
        {
            if(!productTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageProduct manageProduct = new FormManageProduct(product);
            manageProduct.ShowDialog();

            FillForm();
        }

        private void linkPickedClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowClient formShowClient = new FormShowClient(true, product.Client);
            formShowClient.ShowDialog();
        }

        private void linkPickedCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowCategory formShowCategory = new FormShowCategory(true, product.Category);                   /// во тут просмотр категории 
            formShowCategory.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить эту технику?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                product.DelProduct();

                MessageBox.Show("Техника успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}

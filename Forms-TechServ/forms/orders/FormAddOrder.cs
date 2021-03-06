using System;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.products;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.employees;
using Forms_TechServ.forms.products;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.orders
{
    public partial class FormAddOrder : Form
    {
        Order order;
        bool inOrder;


        public FormAddOrder(bool inOrder)
        {
            InitializeComponent();

            this.inOrder = inOrder;

            if (inOrder)
            {
                order = new Order();
            }
            else
            {
                order = new OrderAtHome();
            }

        }

       

        private void FormAddOrder_Load(object sender, EventArgs e)
        {


            if (inOrder)
            {
                label3.Visible = false;
                tbAddress.Visible = false;
            }

            radioAuto.Checked = true;
        }


        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();

            tbProduct.Text = formProducts?.product?.Name;
            tbProduct.Tag = formProducts?.product;

            Product pickedProduct = formProducts.product;

            if (pickedProduct != null && tbMaster.Tag != null &&
                !((Master) tbMaster.Tag).CheckMasterCategory(CategoriesList.GetById(pickedProduct.CategoryId, false)))
            {
                tbMaster.Tag = null;
                tbMaster.Clear();
            }

            if(formProducts.product != null && String.IsNullOrEmpty(tbAddress.Text))
            {
                string lastAddress = formProducts.product.Client.GetLastAddress();
                tbAddress.Text = lastAddress != "Не найден" ? lastAddress : "";
            }
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            if(tbWorkshop.Tag != null)
            {
                FormMasters formMasters;
                if (tbProduct.Tag != null)
                {
                    formMasters = new FormMasters(CategoriesList.GetById(((Product)tbProduct.Tag).CategoryId, false), (Workshop)tbWorkshop.Tag);
                    formMasters.ShowDialog();
                }
                else
                {
                    formMasters = new FormMasters(true, (Workshop)tbWorkshop.Tag);
                    formMasters.ShowDialog();
                }

                Master master = formMasters?.master;

                if (master != null && tbProduct.Tag != null)
                {
                    if (master.CheckMasterCategory(((Product)tbProduct.Tag).Category))
                    {
                        tbMaster.Text = formMasters?.master?.Name;
                        tbMaster.Tag = formMasters?.master;
                    }
                    else
                    {
                        MessageBox.Show("Данный мастер не обслуживает категорию выбранной техники");
                    }
                }
                else if (master != null)
                {
                    tbMaster.Text = formMasters?.master?.Name;
                    tbMaster.Tag = formMasters?.master;
                }
                
            }
            else
            {
                MessageBox.Show("Для начала выберите мастерскую");
            }
        }

        


        private bool CheckFields()
        {
            errorProvider.Clear();

            if(!inOrder && tbAddress.Text == "")
            {
                errorProvider.SetError(tbAddress, "Введите адрес");
                return false;
            }

            if (tbProduct.Tag == null)
            {
                errorProvider.SetError(btnFindProduct, "Выберите технику");
                return false;
            }

            if (tbWorkshop.Tag == null)
            {
                errorProvider.SetError(btnFindWorkshop, "Выберите мастерскую");
                return false;
            }

            

            if(radioManually.Checked && tbMaster.Tag == null)
            {
                errorProvider.SetError(btnFindMaster, "Выберите мастера");
                return false;
            }

            return true;
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;

            if (formWorkshops.workshop != null && tbMaster.Tag != null &&
                (formWorkshops.workshop).Id != ((Master) tbMaster.Tag).WorkshopId)
            {
                tbMaster.Tag = null;
                tbMaster.Clear();
            }
        }

        private void radioMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAuto.Checked)
            {
                tbMaster.Clear();
                tbMaster.Tag = null;
                btnFindMaster.Enabled = false;
            }
            else
            {
                btnFindMaster.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                if (!inOrder)
                {
                    ((OrderAtHome)order).Address = tbAddress.Text;
                }
                order.ProductId = ((Product)tbProduct.Tag).Id;
                order.WorkshopId = ((Workshop)tbWorkshop.Tag).Id;
                order.ClientComment = tbComment.Text;
                order.ManagerId = UserSession.GetLoggedInUser().Id;
                order.ClientSale = ((Product)tbProduct.Tag).Client.CalcSale();
                order.DateStart = DateTime.Now;
                order.Status = OrderStatus.WaitingForSpareParts;

                if (radioManually.Checked)
                {
                    order.MasterId = ((Master)tbMaster.Tag).Id;
                }
                else
                {
                    if(!order.FindMaster())
                    {
                        MessageBox.Show("Не удается найти мастера с требуемой категорией в выбранной мастерской", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                order.AddOrder();

                this.Hide();
                FormEditOrder formEditOrder = new FormEditOrder(OrdersList.GetById(order.Id));
                formEditOrder.ShowDialog();

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

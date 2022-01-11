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
        Order order;
        //Size pickedSize = new Size(991, 525);
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
            //this.Size = new Size(713, 496);


            if (inOrder)
            {
                label3.Visible = false;
                tbAddress.Visible = false;
            }

            radioAuto.Checked = true;
        }

        /*private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }*/

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();

            tbProduct.Text = formProducts?.product?.Name;
            tbProduct.Tag = formProducts?.product;
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            if(tbWorkshop.Tag != null)
            {
                FormMasters formMasters = new FormMasters(true, (Workshop)tbWorkshop.Tag);
                formMasters.ShowDialog();

                Master master = formMasters?.master;

                if (master != null)
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
        }

        private void radioMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAuto.Checked)
            {
                tbMaster.Clear();
                tbMaster.Tag = null;
                btnFindMaster.Enabled = false;
                //btnCleanMaster.Enabled = false;
            }
            else
            {
                btnFindMaster.Enabled = true;
                //btnCleanMaster.Enabled = true;
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
    }
}

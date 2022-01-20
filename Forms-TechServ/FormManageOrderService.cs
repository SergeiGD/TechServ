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
    public partial class FormManageOrderService : Form
    {
        public OrderService orderService;
        Service pickedService;
        public bool changed;

        public FormManageOrderService(Service pickedService/*, Order order*/)
        {
            InitializeComponent();

            orderService = new OrderService();
            this.pickedService = pickedService;
            //this.order = order;

            //btnAction.Text = "Добавить";
        }

        public FormManageOrderService(OrderService orderService/*, Order order*/)
        {
            InitializeComponent();

            this.orderService = orderService;

            tbComment.Text = orderService.MasterComment;
            numericQuantity.Value = orderService.Quantity;
            numericSale.Value = orderService.Sale;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            orderService.Quantity = (int)numericQuantity.Value;
            orderService.Sale = numericSale.Value;
            orderService.MasterComment = tbComment.Text;
            if(orderService.ServiceId == 0)
            {
                orderService.ServiceId = pickedService.Id;
            }

            changed = true;

            this.Close();
            
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            numericQuantity.Value = (int)numericQuantity.Value; // если ввели дробью, переделываем в обычное число
        }
    }
}

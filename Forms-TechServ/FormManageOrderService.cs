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

        public FormManageOrderService(Service pickedService)       // ЕСЛИ ДОБАВЛЯЕМ НОВУЮ УСЛУГУ
        {
            InitializeComponent();

            orderService = new OrderService();
            this.pickedService = pickedService;
            orderService.Price = this.pickedService.Price;

            labelPrice.Text = pickedService.Price.ToString();
        }

        public FormManageOrderService(OrderService orderService)   // ЕСЛИ ИЗМЕЯЕМ ДОБАВЛЕННУЮ РАНЕЕ
        {
            InitializeComponent();

            this.orderService = orderService;

            tbComment.Text = orderService.MasterComment;
            numericQuantity.Value = orderService.Quantity;
            numericSale.Value = orderService.Sale;

            labelPrice.Text = orderService.Price.ToString();
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

        private void btnPriceInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPriceInfo.SetToolTip(btnPriceInfo, "Цена формируется в момент добавления услуги в заказ, поэтому она может не совпадать с текущей ценой услуги");
        }
    }
}

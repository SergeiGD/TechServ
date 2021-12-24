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
    public partial class FormShowOrderLog : Form
    {
        OrderLog orderLog;
        public FormShowOrderLog(OrderLog orderLog)
        {
            InitializeComponent();

            this.orderLog = orderLog;
        }

        private void linkPickedOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowOrder formShowOrder = new FormShowOrder(true, OrdersList.GetById(orderLog.OrderId));                       // ВОТ ТУТ ТЭГ ПРИВЯЗАН ДОЛЖЕН БЫТЬ 
            formShowOrder.ShowDialog();
        }

        private void FormShowOrderLog_Load(object sender, EventArgs e)
        {
            labelID.Text = orderLog.Id.ToString();
            labelOrder.Text = orderLog.OrderId.ToString();
            labelDate.Text = orderLog.EventDate.ToString();
            tbLogText.Text = orderLog.EventDescription;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        public FormShowOrderLog()
        {
            InitializeComponent();
        }

        private void linkPickedOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowOrder formShowOrder = new FormShowOrder(true, null);                       // ВОТ ТУТ ТЭГ ПРИВЯЗАН ДОЛЖЕН БЫТЬ 
            formShowOrder.ShowDialog();
        }
    }
}

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
    public partial class FormManageVisit : Form
    {
        public FormManageVisit()
        {
            InitializeComponent();

            checkDone.Visible = false;
        }

        public FormManageVisit(string visit)
        {
            InitializeComponent();


        }

        private void btnFindOrder_Click(object sender, EventArgs e)
        {
            FormOutOrders formOutOrders = new FormOutOrders(true);
            formOutOrders.ShowDialog();
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();
        }
    }
}

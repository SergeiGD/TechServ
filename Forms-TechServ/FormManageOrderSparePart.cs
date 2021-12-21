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
    public partial class FormManageOrderSparePart : Form
    {
        public int quantity;
        public bool changed;

        public FormManageOrderSparePart()
        {
            InitializeComponent();
        }

        public FormManageOrderSparePart(int quantity)
        {
            InitializeComponent();

            this.quantity = quantity;

            numericQuantity.Value = quantity;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            quantity = (int)numericQuantity.Value;
            changed = true;

            this.Close();
        }
    }
}

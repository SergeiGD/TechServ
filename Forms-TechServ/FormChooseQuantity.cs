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
    public partial class FormChooseQuantity : Form
    {
        public int pickedQuantity = 0;
        public decimal pickedPrice = 0;
        public FormChooseQuantity()
        {
            InitializeComponent();
        }

        public FormChooseQuantity(int quantity, decimal price)
        {
            InitializeComponent();

            pickedQuantity = quantity;
            pickedPrice = price;
            numericQuantity.Value = quantity;
            numericPrice.Value = price;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
            pickedQuantity = (int)numericQuantity.Value;
            pickedPrice = numericPrice.Value;
            this.Close();
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            numericQuantity.Value = (int)numericQuantity.Value; // если ввели дробью, переделываем в обычное число
        }
    }
}

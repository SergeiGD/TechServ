using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TechServ
{
    public partial class FormPickOrderType : Form
    {
        public FormPickOrderType()
        {
            InitializeComponent();
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddOrder formAddOrder = new FormAddOrder(true);
            formAddOrder.FormClosed += (object s, FormClosedEventArgs args) => this.Close();
            formAddOrder.ShowDialog();

            /*var th = new Thread(() => Application.Run(new FormAddOrder(true)));
            th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
            th.Start();

            this.Close();*/
        }

        private void btnOutOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddOrder formAddOrder = new FormAddOrder(false);
            formAddOrder.FormClosed += (object s, FormClosedEventArgs args) => this.Close();
            formAddOrder.ShowDialog();
        }
    }
}

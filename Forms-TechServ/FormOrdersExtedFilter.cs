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
    public partial class FormOrdersExtedFilter : Form
    {
        public FormOrdersExtedFilter(bool inOrder)
        {
            InitializeComponent();

            if (inOrder)                                // ЕСЛИ ЗАКАЗ НЕ НА ДОМУ, ТО АДРЕС НЕ НУЖЕН, ПОЭТОМУ СКРЫВАЕМ И НЕМНОГО ДВИГАЕМ СЛЕДУЮЩИЙ ЭЛЕМЕНТ
            {
                label1.Visible = false;
                tbAddress.Visible = false;
                checkHideCanceled.Location = new Point(checkHideCanceled.Location.X, checkHideCanceled.Location.Y + 17);        
            }
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();
        }

        private void btnFindManager_Click(object sender, EventArgs e)
        {
            FormManagers formManagers = new FormManagers(true);
            formManagers.ShowDialog();
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

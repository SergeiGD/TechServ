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
    public partial class FormManageSparePart : Form
    {
        Size pickedSize = new Size(989, 408);
            
        public FormManageSparePart()                                                // ЕСЛИ ДОБАВИЛИ НОВУЮ ДЕТАЛИ, ТО ПОСЛЕ ДОБАВЛЕНИЯ ПРЕДЛАГАТЬ ЗАКАЗАТЬ СРАЗУ
        {
            InitializeComponent();

            //sparePartTabs.TabPages.Remove(stockPage);

            //checkPrepayment.Checked = false;
        }

        public FormManageSparePart(string sparePart)
        {
            InitializeComponent();
        }

        private void FormManageSparePart_Load(object sender, EventArgs e)
        {
            this.Size = new Size(437, 183);

            sparePartTabs.TabPages.Remove(stockPage);                                   // ВОТ ЭТА ХУЙНЯ ПРЯЧЕТ ВКЛАДКУ, ПОТОМ УБРАТЬ ВООБЩЕ ЕЕ НАДО
        }

        private void FormManageSparePart_ResizeEnd(object sender, EventArgs e)
        {
            if(!sparePartTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void sparePartTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sparePartTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(437, 183);
            }
            else if (sparePartTabs.SelectedTab.Equals(stockPage))
            {
                this.Size = pickedSize;

            }
        }

        private void btnAddToBatch_Click(object sender, EventArgs e)
        {
            FormManageBatch formManageBatch = new FormManageBatch();        // СДЕЛАТЬ ЧТОБ ПРИ ЭТОМ В ГРИД СРАЗУ ДОБАВЛЯЛАСЬ ЗАПЧАТЬ НА КОТОРОЙ 
            formManageBatch.ShowDialog();
        }

        private void checkPrepayment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrepayment.Checked)
            {
                numericPrepayment.Enabled = true;
            }
            else
            {
                numericPrepayment.Enabled = false;
            }
        }
    }
}

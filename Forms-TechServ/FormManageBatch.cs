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
    public partial class FormManageBatch : Form
    {
        Size pickedSize = new Size(804, 397);

        public FormManageBatch()
        {
            InitializeComponent();

            checkDelivered.Visible = false;          // лучше сделать ручную генерацию
        }

        public FormManageBatch(string batch)
        {
            InitializeComponent();

        }

        public FormManageBatch(int workshop)         // ЕСЛИ ИЗМЕНЕНИЯ ПРОИСХОДИТ ИЗ МАСТЕРСКОЙ  (formManageWorkshop)
        {
            InitializeComponent();

            checkDelivered.Visible = false;          // лучше сделать ручную генерацию

            btnCleanWorkshop.Enabled = false;
            btnFindWorkshop.Enabled = false;
        }

        private void FormManageBatch_Load(object sender, EventArgs e)
        {
            this.Size = new Size(456, 216);
        }

        private void btnShowSparePart_Click(object sender, EventArgs e)
        {
            FormShowSparePart formShowSparePart = new FormShowSparePart(true);
            formShowSparePart.ShowDialog();
        }

        private void btnAddSparePart_Click(object sender, EventArgs e)
        {
            FormSpareParts formSpareParts = new FormSpareParts(423, false);
            formSpareParts.ShowDialog();
        }

        private void FormManageBatch_ResizeEnd(object sender, EventArgs e)
        {
            if(!batchTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void batchTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (batchTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(456, 216);
            }
            else if (batchTabs.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;

            }
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

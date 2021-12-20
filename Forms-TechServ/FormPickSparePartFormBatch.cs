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
    public partial class FormPickSparePartFormBatch : Form
    {
        public FormPickSparePartFormBatch()
        {
            InitializeComponent();
        }

        private void pickBtn_Click(object sender, EventArgs e)
        {
            FormManageBatchSparePart formChoosePartsQuantity = new FormManageBatchSparePart(new SparePart());
            formChoosePartsQuantity.ShowDialog();

            this.Close();
        }

        private void btnFindBatch_Click(object sender, EventArgs e)
        {
            FormBatches formBatches = new FormBatches(true);
            formBatches.ShowDialog();
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

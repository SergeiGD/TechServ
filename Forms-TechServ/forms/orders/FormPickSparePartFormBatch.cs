using System;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.forms.batches;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.orders
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
            //FormBatches formBatches = new FormBatches(true);
            //formBatches.ShowDialog();
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

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
    public partial class FormShowBatch : Form
    {

        bool readOnly;
        Size pickedSize = new Size(800, 397);

        public FormShowBatch(bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;
        }

        private void FormShowBatch_Load(object sender, EventArgs e)
        {
            if (readOnly)
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            this.Size = new Size(438, 258);
        }

        

        private void btnShowSparePart_Click(object sender, EventArgs e)
        {
            FormShowSparePart formShowSparePart = new FormShowSparePart(true);
            formShowSparePart.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageBatch formManageBatch = new FormManageBatch("sad");
            formManageBatch.ShowDialog();
        }

        private void FormShowBatch_ResizeEnd(object sender, EventArgs e)
        {
            if(!batchTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void batchTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (batchTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(438, 258);
            }
            else if (batchTabs.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;


            }
        }

        private void labelPickedWorkshop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowWorkshop formShowWorkshop = new FormShowWorkshop(true, null);
            formShowWorkshop.ShowDialog();
        }
    }
}

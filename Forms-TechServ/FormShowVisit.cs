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
    public partial class FormShowVisit : Form
    {
        bool readOnly;

        public FormShowVisit(bool readOnly)
        {
            InitializeComponent();
            this.readOnly = readOnly;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            FormManageVisit formManageVisit = new FormManageVisit("qwe");
            formManageVisit.ShowDialog();
        }

        private void FormShowVisit_Load(object sender, EventArgs e)
        {
            if (readOnly)
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
        }

        private void linkPickedOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowOrder formShowOrder = new FormShowOrder(true, null);
            formShowOrder.ShowDialog();
        }

        private void linkPickedMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowMaster formShowMaster = new FormShowMaster(true, null);
            formShowMaster.ShowDialog();
        }

        private void linkPickedClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowClient formShowClient = new FormShowClient(true, null);
            formShowClient.ShowDialog();
        }
    }
}

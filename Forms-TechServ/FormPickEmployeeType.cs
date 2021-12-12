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
    public partial class FormPickEmployeeType : Form
    {

        public FormPickEmployeeType()
        {
            InitializeComponent();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageMaster formManageMaster = new FormManageMaster();
            formManageMaster.FormClosed += (object s, FormClosedEventArgs args) => this.Close();
            formManageMaster.ShowDialog();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageManager formManageManager = new FormManageManager();
            formManageManager.FormClosed += (object s, FormClosedEventArgs args) => this.Close();
            formManageManager.ShowDialog();
        }
    }
}

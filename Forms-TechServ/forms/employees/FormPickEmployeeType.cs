using System;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.workshops;

namespace Forms_TechServ.forms.employees
{
    public partial class FormPickEmployeeType : Form
    {
        Workshop workshop;
        public FormPickEmployeeType()                                          
        {
            InitializeComponent();


        }

        public FormPickEmployeeType(Workshop workshop)
        {
            InitializeComponent();

            this.workshop = workshop;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageMaster formManageMaster;
            if (workshop == null)
            {
                formManageMaster = new FormManageMaster();
            }
            else
            {
                formManageMaster = new FormManageMaster(workshop);
            }
            formManageMaster.FormClosed += (object s, FormClosedEventArgs args) => this.Close();
            formManageMaster.ShowDialog();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageManager formManageManager;
            if (workshop == null)
            {
                formManageManager = new FormManageManager();
            }
            else
            {
                formManageManager = new FormManageManager(workshop);
            }
            
            formManageManager.FormClosed += (object s, FormClosedEventArgs args) => this.Close();
            formManageManager.ShowDialog();
        }

        
    }
}

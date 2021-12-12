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
    public partial class FormOrdersLogs : Form
    {
        bool readOnly;

        public FormOrdersLogs()
        {
            InitializeComponent();

            readOnly = false;

            ManageButton btnDelete = new ManageButton();
            btnDelete.Text = "Удалить";
            panelControl.Controls.Add(btnDelete);

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormOrdersLogs(int oder, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            tbOrder.Enabled = false;
            btnFindOrder.Enabled = false;
            btnCleanOrder.Enabled = false;

            if (!readOnly)
            {
                ManageButton btnDelete = new ManageButton();
                btnDelete.Text = "Удалить";
                panelControl.Controls.Add(btnDelete);
                //btnDelete.Click += BtnManage_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click/*BtnShowInClient_Click*/;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }


        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowOrderLog formShowOrderLog = new FormShowOrderLog();
            formShowOrderLog.ShowDialog();
        }

        
    }
}

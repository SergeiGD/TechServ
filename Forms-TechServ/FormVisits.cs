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
    public partial class FormVisits : Form
    {
        bool readOnly;

        public FormVisits()
        {
            InitializeComponent();

            readOnly = false;

            ManageButton btnAdd = new ManageButton();
            btnAdd.Text = "Добавить";
            panelControl.Controls.Add(btnAdd);
            btnAdd.Click += BtnAdd_Click;

            ManageButton btnDone = new ManageButton();
            btnDone.Text = "Отментить как 'выполнен'";
            panelControl.Controls.Add(btnDone);

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

        public FormVisits(string master, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;
            }

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

        public FormVisits(int order, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;
            }

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

        

        private void FormVisits_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)       
        {

            FormManageVisit addVisit = new FormManageVisit();
            addVisit.ShowDialog();
        }

        /*private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageVisit manageVisit = new FormManageVisit();
            manageVisit.ShowDialog();
        }*/

        /*private void BtnEdit_Click(object sender, EventArgs e)
        {
            FormEditVisit editVisit = new FormEditVisit();
            editVisit.ShowDialog();
        }*/
        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowVisit showVisit = new FormShowVisit(readOnly);
            showVisit.ShowDialog();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();
        }

        private void btnFindOrder_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders(true);
            formOrders.ShowDialog();
        }

        /*private void BtnShowInOrder_Click(object sender, EventArgs e)
        {
            FormShowVisit showVisit = new FormShowVisit(readOnly);
            showVisit.ShowDialog();
        }*/
    }
}

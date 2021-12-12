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
    public partial class FormBatches : Form
    {
        bool readOnly;

        public FormBatches(bool forSearching)
        {
            InitializeComponent();

            readOnly = false;

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;
            }
            else
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManage_Click;

                ManageButton btnDelivered = new ManageButton();
                btnDelivered.Text = "Отменить как 'доставлен'";
                panelControl.Controls.Add(btnDelivered);
                //btnDelivered.Click += BtnManage_Click;

                ManageButton btnShow = new ManageButton();
                btnShow.Text = "Просмотреть";
                panelControl.Controls.Add(btnShow);
                btnShow.Click += BtnShow_Click;
            }

            

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);


            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormBatches(string workshop, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            tbWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;
            btnFindWorkshop.Enabled = false;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManageFromWorkshop_Click;            // если добавляем из мастерской (чтоб залочить ее выбор)

                ManageButton btnDelivered = new ManageButton();
                btnDelivered.Text = "Отменить как 'доставлен'";
                panelControl.Controls.Add(btnDelivered);
                //btnDelivered.Click += BtnManage_Click;
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

        private void FormBatches_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnPick_Click(object sender, EventArgs e)          // вот тут ретернить выбранного клиента
        {
            this.Close();
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageBatch manageBatch = new FormManageBatch();
            manageBatch.ShowDialog();
        }

        private void BtnManageFromWorkshop_Click(object sender, EventArgs e)
        {
            FormManageBatch manageBatch = new FormManageBatch(32);
            manageBatch.ShowDialog();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowBatch showBatch = new FormShowBatch(readOnly);
            showBatch.ShowDialog();
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

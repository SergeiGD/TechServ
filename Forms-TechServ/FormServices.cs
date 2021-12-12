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
    public partial class FormServices : Form
    {
        bool readOnly;

        public FormServices()
        {
            InitializeComponent();

            readOnly = false;

            ManageButton btnAdd = new ManageButton();
            btnAdd.Text = "Добавить";
            panelControl.Controls.Add(btnAdd);
            btnAdd.Click += BtnAddNewService_Click;

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

        public FormServices(int order, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddToOrder_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShowInOrder_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormServices(string category, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddNewService_Click;
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
        /*public FormServices(string category, bool readOnly)
        {
            InitializeComponent();

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddNewService_Click;
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
        }*/

        private void FormServices_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAddNewService_Click(object sender, EventArgs e)     // СОЗДАТЬ НОВУЮ УСЛУГУ
        {
            FormManageService addService = new FormManageService();
            addService.ShowDialog();
        }

        private void BtnAddToOrder_Click(object sender, EventArgs e)        // ВОТ ТУТ К ЗАКАЗУ ДОБАВИТЬ УСЛУГУ
        {
            FormChooseQuantity formChooseQuantity = new FormChooseQuantity();
            formChooseQuantity.ShowDialog();
            this.Close();
        }

        /*private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageService manageService = new FormManageService();
            manageService.ShowDialog();
        }*/

        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowService showService = new FormShowService(readOnly);
            showService.ShowDialog();
        }

        private void BtnShowInOrder_Click(object sender, EventArgs e)         // НУЖНО ЧТОБ ИЗ ЗАКАЗА НЕ МОГЛИ ИЗМЕНИТЬ УСЛУГУ ПРИ ПРОСМОТРЕ ВСЕХ УСЛУГ
        {
            FormShowService showService = new FormShowService(true);
            showService.ShowDialog();
        }

        private void btnFindCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
            formCategories.ShowDialog();
        }
    }
}

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
    public partial class FormOutOrders : Form
    {
        FormOrdersExtedFilter ordersExtedFilter = new FormOrdersExtedFilter(false);
        bool filterDeployed = false;
        Size filterBaseSize;
        bool readOnly;

        public FormOutOrders(bool forSearching)
        {
            InitializeComponent();

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
                //btnAdd.Location = new Point(0, 120);
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;


                ManageButton btnShow = new ManageButton();
                //btnShow.Location = new Point(0, 160);
                btnShow.Text = "Просмотреть";
                panelControl.Controls.Add(btnShow);
                btnShow.Click += BtnShow_Click;
            }

            

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);

            //MessageBox.Show(mainBtn[0].Name);

            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormOutOrders(string client, bool readOnly)
        {
            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;
            }
            /*ManageButton btnAdd = new ManageButton();
            btnAdd.Location = new Point(0, 120);
            btnAdd.Text = "Добавить";
            panelControl.Controls.Add(btnAdd);
            btnAdd.Click += BtnManage_Click;*/

            /*ManageButton btnEdit = new ManageButton();
            btnEdit.Location = new Point(0, 160);
            btnEdit.BackColor = Color.FromArgb(51, 225, 231);
            btnEdit.Text = "Изменить";
            btnEdit.Click += BtnManage_Click;*/

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

        public FormOutOrders(int product, bool readOnly)
        {
            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;
            }
            /*ManageButton btnAdd = new ManageButton();
            btnAdd.Location = new Point(0, 120);
            btnAdd.Text = "Добавить";
            panelControl.Controls.Add(btnAdd);
            btnAdd.Click += BtnManage_Click;*/

            /*ManageButton btnEdit = new ManageButton();
            btnEdit.Location = new Point(0, 160);
            btnEdit.BackColor = Color.FromArgb(51, 225, 231);
            btnEdit.Text = "Изменить";
            btnEdit.Click += BtnManage_Click;*/

            ManageButton btnShow = new ManageButton();
            btnShow.Location = new Point(0, 160);
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

        private void BtnPick_Click(object sender, EventArgs e)          // вот тут ретернить выбранного клиента
        {
            this.Close();
        }

        private void FormOutOrders_Load(object sender, EventArgs e)
        {
            filterBaseSize = panelFind.Size;
        }

        private void BtnAdd_Click(object sender, EventArgs e)        // !!!!ВОТ ТУТ АДРЕС БУДЕТ ИЛИ НЕТ!!!!
        {

            FormAddOrder addOrder = new FormAddOrder(false);
            addOrder.ShowDialog();
        }

        private void BtnShow_Click(object sender, EventArgs e)          // !!!!ВОТ ТУТ АДРЕС БУДЕТ ИЛИ НЕТ!!!!
        {
            FormShowOrder showOrder = new FormShowOrder(false, readOnly);
            showOrder.ShowDialog();
        }

        private void ExtendFilterBtn_Click(object sender, EventArgs e)
        {
            if (filterDeployed)
            {
                ordersExtedFilter.Hide();                           // СКРЫВАЕМ ФОРМУ СОРТИРОВКИ И УМЕНЬШАЕМ РАЗМЕР ПАНЕЛИ С СОРТИРОВКОЙ
                panelFind.Height = filterBaseSize.Height;
                dataOrders.Location = new Point(dataOrders.Location.X, panelFind.Height);                       // ВОЗВРАЩАЕМ РАЗМЕР ГРИДУ
                dataOrders.Height = dataOrders.Height + (ordersExtedFilter.Height - filterBaseSize.Height);
                filterDeployed = false;
            }
            else
            {

                ordersExtedFilter.TopLevel = false;
                ordersExtedFilter.FormBorderStyle = FormBorderStyle.None;

                panelFind.Height = ordersExtedFilter.Height;
                dataOrders.Location = new Point(dataOrders.Location.X, panelFind.Height);                       // ПЕРЕДВИГАЕМ И УМЕНЬШАЕМ ГРИД
                dataOrders.Height = dataOrders.Height - (ordersExtedFilter.Height - filterBaseSize.Height);

                Control progenitor = this.Parent;
                while (progenitor.Parent != null)                       // НАХОДИМ ГЛАВНУЮ ТЕКУЩУЮ ФОРМУ
                {
                    progenitor = progenitor.Parent;
                }
                progenitor.Width = progenitor.Width + (ordersExtedFilter.Width - panelFind.Width);      // РАСШИРЫЕМ ГЛАВНУЮ ТЕКУЩУЮ ФОРМУ (ЧТОБ ВЛЕЗ ФИЛЬТР)


                panelFind.Controls.Add(ordersExtedFilter);          // ФОРМА ФИЛЬТРА ПРОСТО ВСТАВЕТ ПОВЕРХ ТЕКУЩИХ ПОЛЕЙ СОРТИРОВКИ
                ordersExtedFilter.Dock = DockStyle.Fill;
                ordersExtedFilter.BringToFront();
                ordersExtedFilter.Show();

                filterDeployed = true;
            }
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

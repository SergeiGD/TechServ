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
    



    public partial class FormMain : Form
    {
        private Form activeForm;
        private NavButton activeBtn;
        private NavButton parentBtn;
        private int childernTotalHeight = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void ColorBtn(NavButton buttonClicked)
        {

            if(activeBtn != null)
            {
                activeBtn.BackColor = panelMenu.BackColor;
                if(parentBtn != null)
                {
                    parentBtn.BackColor = panelMenu.BackColor;
                }
            }
            activeBtn = buttonClicked;


            parentBtn = activeBtn.ParentButton;


            if(parentBtn != null)
            {
                parentBtn.BackColor = panelTheme.BackColor;

                foreach (Button button in parentBtn.Parent.Controls.OfType<NavButton>().Where(b => b.ParentButton != null && b.ParentButton.Equals(parentBtn)))
                {
                    button.BackColor = Color.FromArgb(91, 77, 101);
                }

                activeBtn.BackColor = Color.FromArgb(130, 116, 140); 
            }
            else
            {
                activeBtn.BackColor = panelTheme.BackColor;
            }


        }


        private void OpenChildForm(Form childForm, NavButton buttonClicked)
        {
            if (parentBtn != null && parentBtn.Equals(buttonClicked) || activeBtn != null && activeBtn.Equals(buttonClicked))
                return;

            ColorBtn(buttonClicked);
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            NavButton ordersBtn = new NavButton();
            ordersBtn.Text = "ЗАКАЗЫ";
            panelMenu.Controls.Add(ordersBtn);
            ordersBtn.Click += OrdersBtn_Click;

            NavButton visitsBtn = new NavButton();
            visitsBtn.Text = "ВЫЕЗДЫ";
            panelMenu.Controls.Add(visitsBtn);
            visitsBtn.Click += VisitsBtn_Click;

            /*if (UserSession.Can("edit_branch"))
            {
                NavButton clientsBtn = new NavButton();
                clientsBtn.Text = "КЛИЕНТЫ";
                panelMenu.Controls.Add(clientsBtn);
                clientsBtn.Click += ClientsBtn_Click;
            }*/

            NavButton clientsBtn = new NavButton();
            clientsBtn.Text = "КЛИЕНТЫ";
            panelMenu.Controls.Add(clientsBtn);
            clientsBtn.Click += ClientsBtn_Click;

            NavButton empsBtn = new NavButton();
            empsBtn.Text = "РАБОТНИКИ";
            panelMenu.Controls.Add(empsBtn);
            empsBtn.Click += EmpsBtn_Click;

            NavButton servicesBtn = new NavButton();
            servicesBtn.Text = "УСЛУГИ";
            panelMenu.Controls.Add(servicesBtn);
            servicesBtn.Click += ServicesBtn_Click;

            NavButton workshopsBtn = new NavButton();
            workshopsBtn.Text = "МАСТЕРСКИЕ";
            panelMenu.Controls.Add(workshopsBtn);
            workshopsBtn.Click += WorkshopsBtn_Click;

            NavButton batchesPartsBtn = new NavButton();
            batchesPartsBtn .Text = "ЗАПЧАСТИ И ПОСТАВКИ";
            panelMenu.Controls.Add(batchesPartsBtn);
            batchesPartsBtn.Click += BatchesPartsBtn_Click;

            NavButton categoriesBtn = new NavButton();
            categoriesBtn.Text = "КАТЕГОРИИ";
            panelMenu.Controls.Add(categoriesBtn);
            categoriesBtn.Click += CategoriesBtn_Click;

            NavButton statisticBtn = new NavButton();
            statisticBtn.Text = "СТАТИСТИКА";
            //panelMenu.Controls.Add(statisticBtn);                         // СТАТИСТИКА ПОКА НЕ РЕАЛИЗОВАНА, ПОТОМ ВЕРНУТЬ
            statisticBtn.Click += StatisticBtn_Click;

            

            NavButton[] mainBtn = panelMenu.Controls.OfType<NavButton>().ToArray();
            mainBtn[0].Location = new Point(0, panelLogo.Location.Y + panelLogo.Height);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        private void MoveBtns(Button buttonClicked)
        {
            foreach (Control button in panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton == null))   // т.к. ParentButton = null - это главные кнопки
            {

                if (button.Location.Y > buttonClicked.Location.Y)                 
                {

                    button.Location = new Point(button.Location.X, button.Location.Y + childernTotalHeight);
                }

            }
 
        }

        private void CleanChilderBtns()
        {
            Point position = new Point(0, 0);

            foreach (Control button in panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton != null).ToList())
            {
                panelMenu.Controls.Remove(button);
                position = button.Location;
            }

            foreach (Control button in panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton == null))
            {
                if (position != new Point(0, 0))
                {
                    if (button.Location.Y > position.Y)
                    {
                        button.Location = new Point(button.Location.X, button.Location.Y - childernTotalHeight);
                    }
                }
            }

        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            // ЕСЛИ УЖЕ НА ЭТОЙ ВКЛАДКЕ, ТО НЕ ГЕНЕРИРУЕМ КНОПКИ
            if (parentBtn != null && parentBtn.Equals((Button)sender) || activeBtn != null && activeBtn.Equals((Button)sender))
                return;

            // ЕСЛИ БЫЛИ ОТКРЫТА ДРУГАЯ ВКЛАДКА И ПОДЭЛЕМЕНТАМИ, ТО УБИРАЕМ ИХ
            CleanChilderBtns();
            childernTotalHeight = 0;

            // ОКРАШИВАЕМ КНОПКУ ВКЛАДКИ
            ColorBtn((NavButton)sender);

            NavButton ordersAllBtn = new NavButton((NavButton)sender);
            ordersAllBtn.Text = "все заказы";
            panelMenu.Controls.Add(ordersAllBtn);
            ordersAllBtn.Click += OrdersAllBtn_Click;
            childernTotalHeight += ordersAllBtn.Size.Height;

            NavButton ordersOutBtn = new NavButton((NavButton)sender);
            ordersOutBtn.Text = "на дому";
            panelMenu.Controls.Add(ordersOutBtn);
            ordersOutBtn.Click += OrdersOutBtn_Click;
            childernTotalHeight += ordersOutBtn.Size.Height;

            NavButton ordersInBtn = new NavButton((NavButton)sender);
            ordersInBtn.Text = "в мастерской";
            panelMenu.Controls.Add(ordersInBtn);
            ordersInBtn.Click += OrdersInBtn_Click;
            childernTotalHeight += ordersInBtn.Size.Height;

            NavButton ordersLogsBtn = new NavButton((NavButton)sender);
            ordersLogsBtn.Text = "логи заказов";
            panelMenu.Controls.Add(ordersLogsBtn);
            ordersLogsBtn.Click += OrdersLogsBtn_Click;
            childernTotalHeight += ordersLogsBtn.Size.Height;

            /*NavButton ordersVisitsBtn = new NavButton((NavButton)sender);
            ordersVisitsBtn.Text = "ВЫЕЗДЫ";
            panelMenu.Controls.Add(ordersVisitsBtn);
            ordersVisitsBtn.Click += OrdersVisitsBtn_Click;
            childernTotalHeight += ordersVisitsBtn.Size.Height;*/

            // РАЗМЕЩЕНИЕ ДОЧЕРНИХ КНОПОК
            NavButton[] childBtns = panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton != null && b.ParentButton.Equals((NavButton)sender)).ToArray();
            childBtns[0].Location = new Point(panelMenu.Width - childBtns[0].Width, ((Button)sender).Location.Y + ((Button)sender).Size.Height);
            for(int i = 1; i < childBtns.Count(); i++)
            {
                childBtns[i].Location = new Point(childBtns[0].Location.X, childBtns[i-1].Location.Y + childBtns[i - 1].Size.Height);
            }

            // ПЕРЕДВИГАЕМ ОСТАЛЬНЫЕ ГЛАВНЫХ НАВИГАЦИОННЫЕ КНОПКИ
            MoveBtns((Button)sender);

            // АКТИВИРУЕМ ПЕРВУЮ ВКЛАДКУ КАТЕГОРИИ
            OrdersAllBtn_Click(ordersAllBtn, new EventArgs());

        }


        private void OrdersAllBtn_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders(false);
            OpenChildForm(formOrders, (NavButton)sender);

        }
        private void OrdersOutBtn_Click(object sender, EventArgs e)
        {
            FormOutOrders formOutOrders = new FormOutOrders(false);
            OpenChildForm(formOutOrders,(NavButton)sender);
 
        }
        private void OrdersInBtn_Click(object sender, EventArgs e)
        {
            FormInOrders formInOrders = new FormInOrders(false);
            OpenChildForm(formInOrders, (NavButton)sender);
        }
        private void OrdersLogsBtn_Click(object sender, EventArgs e)
        {
            FormOrdersLogs formOrdersLogs = new FormOrdersLogs();
            OpenChildForm(formOrdersLogs, (NavButton)sender);
        }
        private void VisitsBtn_Click(object sender, EventArgs e)
        {
            CleanChilderBtns();
            FormVisits formVisits = new FormVisits();
            OpenChildForm(formVisits, (NavButton)sender);

        }
        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            if (parentBtn != null && parentBtn.Equals((Button)sender) || activeBtn != null && activeBtn.Equals((Button)sender))
                return;
            CleanChilderBtns();
            childernTotalHeight = 0;
            ColorBtn((NavButton)sender);


            NavButton clientsAllBtn = new NavButton((NavButton)sender);
            clientsAllBtn.Text = "список клиентов";
            panelMenu.Controls.Add(clientsAllBtn);
            clientsAllBtn.Click += ClientsAllBtn_Click;
            childernTotalHeight += clientsAllBtn.Size.Height;

            Button clientsProductsBtn = new NavButton((NavButton)sender);
            clientsProductsBtn.Text = "техника клиентов";
            panelMenu.Controls.Add(clientsProductsBtn);
            clientsProductsBtn.Click += ClientsProductsBtn_Click;
            childernTotalHeight += clientsProductsBtn.Size.Height;


            NavButton[] childBtns = panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton != null && b.ParentButton.Equals((NavButton)sender)).ToArray();
            childBtns[0].Location = new Point(panelMenu.Width - childBtns[0].Width, ((Button)sender).Location.Y + ((Button)sender).Size.Height);
            for (int i = 1; i < childBtns.Count(); i++)
            {
                childBtns[i].Location = new Point(childBtns[0].Location.X, childBtns[i - 1].Location.Y + childBtns[i - 1].Size.Height);
            }


            MoveBtns((Button)sender);
            ClientsAllBtn_Click(clientsAllBtn, new EventArgs());
        }
        private void ClientsAllBtn_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(false);
            OpenChildForm(formClients, (NavButton)sender);
        }
        private void ClientsProductsBtn_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(false);
            OpenChildForm(formProducts, (NavButton)sender);
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            CleanChilderBtns();
            FormServices formServices = new FormServices(false);
            OpenChildForm(formServices, (NavButton)sender);
        }

        private void BatchesPartsBtn_Click(object sender, EventArgs e)
        {
            if (parentBtn != null && parentBtn.Equals((Button)sender) || activeBtn != null && activeBtn.Equals((Button)sender))
                return;
            CleanChilderBtns();
            childernTotalHeight = 0;
            ColorBtn((NavButton)sender);

            NavButton sparePartsBtn = new NavButton((NavButton)sender);
            sparePartsBtn.Text = "детали";
            panelMenu.Controls.Add(sparePartsBtn);
            sparePartsBtn.Click += SparePartsBtn_Click;
            childernTotalHeight += sparePartsBtn.Size.Height;

            NavButton batchesBtn = new NavButton((NavButton)sender);
            batchesBtn.Text = "поставки";
            panelMenu.Controls.Add(batchesBtn);
            batchesBtn.Click += BatchesBtn_Click;
            childernTotalHeight += batchesBtn.Size.Height;


            NavButton[] childBtns = panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton != null && b.ParentButton.Equals((NavButton)sender)).ToArray();
            childBtns[0].Location = new Point(panelMenu.Width - childBtns[0].Width, ((Button)sender).Location.Y + ((Button)sender).Size.Height);
            for (int i = 1; i < childBtns.Count(); i++)
            {
                childBtns[i].Location = new Point(childBtns[0].Location.X, childBtns[i - 1].Location.Y + childBtns[i - 1].Size.Height);
            }


            MoveBtns((Button)sender);
            SparePartsBtn_Click(sparePartsBtn, new EventArgs());
        }
        private void SparePartsBtn_Click(object sender, EventArgs e)
        {
            FormSpareParts formSpareParts = new FormSpareParts(false);
            OpenChildForm(formSpareParts, (NavButton)sender);
        }
        private void BatchesBtn_Click(object sender, EventArgs e)
        {
            FormBatches formBatches = new FormBatches();
            OpenChildForm(formBatches, (NavButton)sender);
        }

        private void WorkshopsBtn_Click(object sender, EventArgs e)
        {
            CleanChilderBtns();
            FormWorkshops formWorkshops = new FormWorkshops(false);
            OpenChildForm(formWorkshops, (NavButton)sender);
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            CleanChilderBtns();
            FormCategories formCategories = new FormCategories(false);
            OpenChildForm(formCategories, (NavButton)sender);
        }

        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            if (parentBtn != null && parentBtn.Equals((Button)sender) || activeBtn != null && activeBtn.Equals((Button)sender))
                return;
            CleanChilderBtns();
            childernTotalHeight = 0;
            ColorBtn((NavButton)sender);


            NavButton workshopsStatBtn = new NavButton((NavButton)sender);
            workshopsStatBtn.Text = "мастерские";
            panelMenu.Controls.Add(workshopsStatBtn);
            workshopsStatBtn.Click += WorkshopsStatBtn_Click;
            childernTotalHeight += workshopsStatBtn.Size.Height;

            NavButton servicesStatBtn = new NavButton((NavButton)sender);
            servicesStatBtn.Text = "услуги";
            panelMenu.Controls.Add(servicesStatBtn);
            servicesStatBtn.Click += ServicesStatBtn_Click;
            childernTotalHeight += servicesStatBtn.Height;

            NavButton categoriesStatBtn = new NavButton((NavButton)sender);
            categoriesStatBtn.Text = "категории";
            panelMenu.Controls.Add(categoriesStatBtn);
            categoriesStatBtn.Click += CategoriesStatBtn_Click;
            childernTotalHeight += categoriesStatBtn.Height;


            NavButton[] childBtns = panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton != null && b.ParentButton.Equals((NavButton)sender)).ToArray();
            childBtns[0].Location = new Point(panelMenu.Width - childBtns[0].Width, ((Button)sender).Location.Y + ((Button)sender).Size.Height);
            for (int i = 1; i < childBtns.Count(); i++)
            {
                childBtns[i].Location = new Point(childBtns[0].Location.X, childBtns[i - 1].Location.Y + childBtns[i - 1].Size.Height);
            }


            MoveBtns((Button)sender);
            WorkshopsStatBtn_Click(workshopsStatBtn, new EventArgs());

        }

        private void WorkshopsStatBtn_Click(object sender, EventArgs e)
        {
            FormStatWorkshops statWorkshops = new FormStatWorkshops();
            OpenChildForm(statWorkshops, (NavButton)sender);
        }

        private void ServicesStatBtn_Click(object sender, EventArgs e)
        {
            Form fm = new Form();
            fm.BackColor = Color.Yellow;
            OpenChildForm(fm, (NavButton)sender);
        }

        private void CategoriesStatBtn_Click(object sender, EventArgs e)
        {
            Form fm = new Form();
            fm.BackColor = Color.Red;
            OpenChildForm(fm, (NavButton)sender);
        }


        private void EmpsBtn_Click(object sender, EventArgs e)
        {
            if (parentBtn != null && parentBtn.Equals((Button)sender) || activeBtn != null && activeBtn.Equals((Button)sender))
                return;
            CleanChilderBtns();
            childernTotalHeight = 0;
            ColorBtn((NavButton)sender);

            NavButton empsAllBtn = new NavButton((NavButton)sender);
            empsAllBtn.Text = "все сотрудники";
            panelMenu.Controls.Add(empsAllBtn);
            empsAllBtn.Click += empsAllBtn_Click;
            childernTotalHeight += empsAllBtn.Size.Height;

            NavButton empsManagersBtn = new NavButton((NavButton)sender);
            empsManagersBtn.Text = "менеджеры";
            panelMenu.Controls.Add(empsManagersBtn);
            empsManagersBtn.Click += empsManagersBtn_Click;
            childernTotalHeight += empsManagersBtn.Size.Height;

            NavButton empsMastersBtn = new NavButton((NavButton)sender);
            empsMastersBtn.Text = "мастера";
            panelMenu.Controls.Add(empsMastersBtn);
            empsMastersBtn.Click += empsMastersBtn_Click;
            childernTotalHeight += empsMastersBtn.Size.Height;



            NavButton[] childBtns = panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton != null && b.ParentButton.Equals((NavButton)sender)).ToArray();
            childBtns[0].Location = new Point(panelMenu.Width - childBtns[0].Width, ((Button)sender).Location.Y + ((Button)sender).Size.Height);
            for (int i = 1; i < childBtns.Count(); i++)
            {
                childBtns[i].Location = new Point(childBtns[0].Location.X, childBtns[i - 1].Location.Y + childBtns[i - 1].Size.Height);
            }


            MoveBtns((Button)sender);
            empsAllBtn_Click(empsAllBtn, new EventArgs());
        }

        private void empsAllBtn_Click(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            OpenChildForm(formEmployees, (NavButton)sender);
        }
        private void empsManagersBtn_Click(object sender, EventArgs e)
        {
            FormManagers formManagers = new FormManagers(false);
            OpenChildForm(formManagers, (NavButton)sender);

        }
        private void empsMastersBtn_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(false);
            OpenChildForm(formMasters, (NavButton)sender);

        }


    }

    
}

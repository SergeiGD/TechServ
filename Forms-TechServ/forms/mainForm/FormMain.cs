using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms_TechServ.classes.employees;
using Forms_TechServ.forms.batches;
using Forms_TechServ.forms.categories;
using Forms_TechServ.forms.clients;
using Forms_TechServ.forms.customControls;
using Forms_TechServ.forms.employees;
using Forms_TechServ.forms.employees.roles;
using Forms_TechServ.forms.orders;
using Forms_TechServ.forms.products;
using Forms_TechServ.forms.services;
using Forms_TechServ.forms.spareParts;
using Forms_TechServ.forms.statistics;
using Forms_TechServ.forms.visits;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.mainForm
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
            panelMenu.Controls.Add(statisticBtn);                         
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


            NavButton workshopsLoadStatBtn = new NavButton((NavButton)sender);
            workshopsLoadStatBtn.Text = "Нагрузка";
            panelMenu.Controls.Add(workshopsLoadStatBtn);
            workshopsLoadStatBtn.Click += WorkshopsLoadStatBtn_Click;
            childernTotalHeight += workshopsLoadStatBtn.Size.Height;

            NavButton workshopsProfitStatBtn = new NavButton((NavButton)sender);
            workshopsProfitStatBtn.Text = "Выручка";
            panelMenu.Controls.Add(workshopsProfitStatBtn);
            workshopsProfitStatBtn.Click += WorkshopsProfitStatBtn_Click;
            childernTotalHeight += workshopsProfitStatBtn.Height;

            NavButton servicesStatBtn = new NavButton((NavButton)sender);
            servicesStatBtn.Text = "Услуги";
            panelMenu.Controls.Add(servicesStatBtn);
            servicesStatBtn.Click += ServicesStatBtn_Click;
            childernTotalHeight += servicesStatBtn.Height;


            NavButton[] childBtns = panelMenu.Controls.OfType<NavButton>().Where(b => b.ParentButton != null && b.ParentButton.Equals((NavButton)sender)).ToArray();
            childBtns[0].Location = new Point(panelMenu.Width - childBtns[0].Width, ((Button)sender).Location.Y + ((Button)sender).Size.Height);
            for (int i = 1; i < childBtns.Count(); i++)
            {
                childBtns[i].Location = new Point(childBtns[0].Location.X, childBtns[i - 1].Location.Y + childBtns[i - 1].Size.Height);
            }


            MoveBtns((Button)sender);
            WorkshopsLoadStatBtn_Click(workshopsLoadStatBtn, new EventArgs());

        }

        private void WorkshopsLoadStatBtn_Click(object sender, EventArgs e)
        {
            FormStatWorkshopsLoad statWorkshopsLoad = new FormStatWorkshopsLoad();
            OpenChildForm(statWorkshopsLoad, (NavButton)sender);
        }

        private void WorkshopsProfitStatBtn_Click(object sender, EventArgs e)
        {
            FormStatWorkshopProfit statWorkshopProfit = new FormStatWorkshopProfit();
            OpenChildForm(statWorkshopProfit, (NavButton)sender);
        }

        private void ServicesStatBtn_Click(object sender, EventArgs e)
        {
            FormStatServices formStatServices = new FormStatServices();
            OpenChildForm(formStatServices, (NavButton)sender);
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

            NavButton rolesBtn = new NavButton((NavButton)sender);
            rolesBtn.Text = "должности";
            panelMenu.Controls.Add(rolesBtn);
            rolesBtn.Click += rolesBtn_Click;
            childernTotalHeight += rolesBtn.Size.Height;



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
            FormEmployees formEmployees = new FormEmployees(false);
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
        private void rolesBtn_Click(object sender, EventArgs e)
        {
            FormRoles formRoles = new FormRoles(false);
            OpenChildForm(formRoles, (NavButton)sender);

        }


    }

    
}

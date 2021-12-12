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
    public partial class FormSpareParts : Form
    {
        bool readOnly;

        public FormSpareParts(bool forSearching)
        {
            InitializeComponent();

            readOnly = false;

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();              // ИЩЕМ МЫ ТОЛЬКО ИЗ ЗАКАЗА
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                /*radioButton5.Checked = true;
                radioButton4.Enabled = false;
                numericUpDown5.Value = 1;
                numericUpDown5.Enabled = false;
                numericUpDown6.Value = 0;
                numericUpDown6.Enabled = false;*/

                groupStock.Enabled = false;

                ManageButton btnShow = new ManageButton();
                btnShow.Text = "Просмотреть";
                panelControl.Controls.Add(btnShow);
                btnShow.Click += BtnShowInOther_Click;
            }
            else
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManage_Click;

                ManageButton btnNewBatch = new ManageButton();
                btnNewBatch.Text = "Заказать";
                panelControl.Controls.Add(btnNewBatch);
                btnNewBatch.Click += BtnNewBatch_Click;


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

        public FormSpareParts(int batch, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Выбрать";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddToBatch_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShowInOther_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormSpareParts(string workshop, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Выбрать";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddToOrder_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShowInOther_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        private void BtnAddToBatch_Click(object sender, EventArgs e)                    // ДОБАВИТЬ К ПОСТАВКИ (ИЗ ДОБАВЛЕНИЯ НОВОЙ ПОСТАВКИ)
        {
            FormChooseQuantity formChooseQuantity = new FormChooseQuantity();
            formChooseQuantity.ShowDialog();
            this.Close();
        }

        private void BtnNewBatch_Click(object sender, EventArgs e)                  // СОЗДАТЬ НОВУЮ ПОСТАВКУ (ИЗ ДЕТАЛЕЙ)
        {                                                                            
            FormManageBatch formManageBatch = new FormManageBatch();                // СДЕЛАТЬ ЧТОБ ПРИ ЭТОМ В ГРИД СРАЗУ ДОБАВЛЯЛАСЬ ЗАПЧАТЬ НА КОТОРОЙ
            formManageBatch.ShowDialog();
        }

        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPick_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult dialogResult = MessageBox.Show(
                "Подобрать поставки автоматически (только из Вашей мастерской)?",
                "Подбор поставок",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );
            if (dialogResult.Equals(DialogResult.No))
            {
                FormPickSparePartFormBatch formPickSparePartFormBatch = new FormPickSparePartFormBatch();
                formPickSparePartFormBatch.ShowDialog();

                this.Close();
            }
            else if(dialogResult.Equals(DialogResult.Yes))
            {
                FormChooseQuantity formChoosePartsQuantity = new FormChooseQuantity();
                formChoosePartsQuantity.ShowDialog();

                this.Close();
            }
        }

        /*public FormSpareParts(string sparePart)         // ЧТОБ ПРИ ПРОСМОТРЕ КОЛ-ВА КОНКРЕТНОЙ ДЕТАЛИ (FormShowSparePart, Наличие) ЗАФИКСИРОВАТЬ ПОЛЯ СОРТИРОВКИ НА НЕЙ
        {
            InitializeComponent();

            readOnly = true;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManage_Click;
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

        private void FormSpareParts_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageSparePart manageSparePart = new FormManageSparePart();
            manageSparePart.ShowDialog();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowSparePart showSparePart = new FormShowSparePart(readOnly);
            showSparePart.ShowDialog();
        }

        private void BtnShowInOther_Click(object sender, EventArgs e)           // при просмотре из заказа/поставки
        {
            FormShowSparePart showSparePart = new FormShowSparePart(true);
            showSparePart.ShowDialog();
        }

        private void btnFIndWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();
        }
    }
}

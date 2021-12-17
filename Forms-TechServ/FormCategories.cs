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
    public partial class FormCategories : Form
    {
        bool readOnly;
        bool onlyEndPoints;
        public Category category;
        int rowsCount;
        int currentPage = 1;

        public FormCategories(bool forSearching, bool onlyEndPoints)
        {
            InitializeComponent();

            this.onlyEndPoints = onlyEndPoints;

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;
                dataCategories.CellMouseDoubleClick += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_category"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnAddNewCat_Click;

                    
                }

                readOnly = false;
                dataCategories.CellMouseDoubleClick += BtnShow_Click;

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

        public FormCategories(bool forSearching)
        {
            InitializeComponent();



            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;
                dataCategories.CellMouseDoubleClick += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_category"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnAddNewCat_Click;

                    dataCategories.CellMouseDoubleClick += BtnShow_Click;
                }

                readOnly = false;


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

        /*public FormCategories(Master master, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnPick_Click/*BtnAddToMaster_Click;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShowInMaster_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }*/

        private void BtnPick_Click(object sender, EventArgs e)
        {
            category = CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true);

            this.Close();                                               // и тут ретерн
        }

        private void BtnAddNewCat_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory();
            formManageCategory.ShowDialog();

            FillGrid();
        }

        

        private void BtnAddToMaster_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Наименование";
            DataGridViewTextBoxColumn parentCol = new DataGridViewTextBoxColumn();
            parentCol.Name = "Родительская категория";


            dataCategories.Columns.Add(idCol);
            dataCategories.Columns.Add(nameCol);
            dataCategories.Columns.Add(parentCol);

            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Наименованию");
            comboBoxSortBy.Items.Add("Родительской категории");
            //comboBoxSortBy.Items.Add("Номер телефона");
            comboBoxSortBy.SelectedIndex = 0;

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            

            FillGrid();
        }

        private void FillGrid()
        {
            // ЕСЛИ ФИЛЬТРЫ ПУСТЫЕ, ТО ПОЛУЧАЕМ ВСЕ ЗНАЧЕНИЯ
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            string sortBy = "Id";

            if (comboBoxSortBy.SelectedItem.ToString() == "id")
            {
                sortBy = "Id";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Наименованию")
            {
                sortBy = "Name";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Родительской категории")
            {
                sortBy = "ParentCategory";
            }

            List<Category> categories = CategoriesList.GetCategories(
                new Category()
                {
                    Id = id,
                    Name = tbName.Text,
                    ParentCategory = (Category)tbParentCat.Tag
                },
                onlyEndPoints,
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            // ЗАПОЛНЯЕМ ГРИД
            dataCategories.Rows.Clear();
            for (int i = 0; i < categories.Count; i++)
            {
                dataCategories.Rows.Add(new DataGridViewRow());

                dataCategories.Rows[i].Cells[0].Value = categories[i].Id;
                dataCategories.Rows[i].Cells[1].Value = categories[i].Name;
                dataCategories.Rows[i].Cells[2].Value = categories[i]?.ParentCategory?.Name;
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";
        }

        /*private void BtnManage_Click(object sernder, EventArgs e)
        {
            FormManageCategory manageCategory = new FormManageCategory();
            manageCategory.ShowDialog();
        }*/

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (dataCategories.SelectedRows.Count > 0)
            {
                FormShowCategory showCategory = new FormShowCategory(readOnly, CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true));
                showCategory.ShowDialog();

                FillGrid();
            }
            else
            {
                MessageBox.Show("Сначала выберите категорию");
            }
        }

        private void BtnShowInMaster_Click(object sender, EventArgs e)      // НУЖНО ЧТОБ БЫ ИЗ МАСТЕРА НЕ МОГЛИ ИЗМЕНИТЬ КАТЕГОРИЮ ПРИ ПРОСМОТРЕ ВСЕХ КАТЕГОРИЙ
        {
            if(dataCategories.SelectedRows.Count > 0)
            {
                FormShowCategory showCategory = new FormShowCategory(true, CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true));
                showCategory.ShowDialog();
            }
            else
            {
                MessageBox.Show("Сначала выберите категорию");
            }
        }

        private void bntFindParentCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true, false);
            formCategories.ShowDialog();

            tbParentCat.Text = formCategories?.category?.Name;
            tbParentCat.Tag = formCategories?.category;
        }

        private void btnAskOrDesk_Click(object sender, EventArgs e)
        {
            if ((bool)btnAskOrDesk.Tag)
            {
                btnAskOrDesk.Tag = false;
            }
            else
            {
                btnAskOrDesk.Tag = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnCleanParentCat_Click(object sender, EventArgs e)
        {
            tbParentCat.Clear();
            tbParentCat.Tag = null;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbParentCat.Clear();
            tbParentCat.Tag = null;

            FillGrid();
        }

        private void comboBoxShowRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void numericCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentPage.Value = (int)numericCurrentPage.Value;           // если ввели дробное число, оно автоматически округлится
            currentPage = (int)numericCurrentPage.Value;
            FillGrid();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
        }

        private void btnAskOrDesk_MouseHover(object sender, EventArgs e)
        {
            if ((bool)btnAskOrDesk.Tag)
            {
                toolTipCurrentSort.SetToolTip(btnAskOrDesk, "По возрастанию");
            }
            else
            {
                toolTipCurrentSort.SetToolTip(btnAskOrDesk, "По убыванию");
            }
        }

        /*private void dataCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShowCategory showCategory = new FormShowCategory(readOnly, CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true));
            showCategory.ShowDialog();

            FillGrid();
        }*/
    }
}

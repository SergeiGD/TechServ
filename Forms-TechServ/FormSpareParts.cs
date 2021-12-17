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
        public SparePart sparePart;
        public BatchSparePart batchSparePart;
        public Batch batch;
        int rowsCount;
        int currentPage = 1;
        // Order order;

        public FormSpareParts(bool forSearching)
        {
            InitializeComponent();

            

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();              // ИЩЕМ МЫ ТОЛЬКО ИЗ ЗАКАЗА
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPickToOrder_Click;

                dataSpareParts.CellMouseDoubleClick += BtnPickToOrder_Click; 

                readOnly = true;

                /*radioButton5.Checked = true;
                radioButton4.Enabled = false;
                numericUpDown5.Value = 1;
                numericUpDown5.Enabled = false;
                numericUpDown6.Value = 0;
                numericUpDown6.Enabled = false;*/

                groupStock.Enabled = false;

                //clearBtn.Click += clearBtnWithoutWorkshop_Click;
            }
            else
            {
                if (UserSession.Can("add_del_sparePart"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManage_Click;
                }

                readOnly = false;

                dataSpareParts.CellMouseDoubleClick += BtnShow_Click;

                clearBtn.Click += clearBtnAll_Click;

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

        public FormSpareParts(bool readOnly, Batch batch)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.batch = batch;

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

            dataSpareParts.CellMouseDoubleClick += BtnShowInOther_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormSpareParts(bool readOnly, Workshop workshop)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShowInOther_Click;

            dataSpareParts.CellMouseDoubleClick += BtnShowInOther_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }

            
            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;
            btnFIndWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;

            clearBtn.Click += clearBtnWithoutWorkshop_Click;
        }

        public FormSpareParts(bool readOnly, string order)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            if (!readOnly && UserSession.Can("add_del_batch"))
            {
                ManageButton btnNewBatch = new ManageButton();
                btnNewBatch.Text = "Добавить";
                panelControl.Controls.Add(btnNewBatch);
                btnNewBatch.Click += BtnAddToOrder_Click;
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


            /*tbWorkshop.Text = order.Workshop.Location;
            tbWorkshop.Tag = order.Workshop;*/

            btnFIndWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;
            clearBtn.Click += clearBtnWithoutWorkshop_Click;
        }

        private void BtnAddToBatch_Click(object sender, EventArgs e)                    // ДОБАВИТЬ К ПОСТАВКИ (ИЗ ДОБАВЛЕНИЯ НОВОЙ ПОСТАВКИ)
        {
            int pickedSparePartId = SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)).Id;

            if (BatchesSparePartsList.GetById(batch.Id, pickedSparePartId) != null)
            {
                MessageBox.Show("Деталь этого типа уже есть в поставке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormChooseQuantity formChooseQuantity = new FormChooseQuantity();
                formChooseQuantity.ShowDialog();


                if (formChooseQuantity.pickedQuantity > 0)
                {
                    batchSparePart = new BatchSparePart()
                    {
                        Quantity = formChooseQuantity.pickedQuantity,
                        UnitPrice = formChooseQuantity.pickedPrice,
                        SparePartId = pickedSparePartId,
                    };
                }
                else
                {
                    batchSparePart = null;
                }


                this.Close();
            }
            
        }

        private void BtnNewBatch_Click(object sender, EventArgs e)                  // СОЗДАТЬ НОВУЮ ПОСТАВКУ (ИЗ ДЕТАЛЕЙ)
        {                                                                            
            FormManageBatch formManageBatch = new FormManageBatch();                // СДЕЛАТЬ ЧТОБ ПРИ ЭТОМ В ГРИД СРАЗУ ДОБАВЛЯЛАСЬ ЗАПЧАТЬ НА КОТОРОЙ
            formManageBatch.ShowDialog();
        }

        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            FormSpareParts formSpareParts = new FormSpareParts(true);
            formSpareParts.ShowDialog();
        }

        private void BtnPickToOrder_Click(object sender, EventArgs e)
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
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";
            DataGridViewTextBoxColumn prepaymentCol = new DataGridViewTextBoxColumn();
            prepaymentCol.Name = "Предоплата клиента";
            DataGridViewTextBoxColumn inStockCountCol = new DataGridViewTextBoxColumn();
            inStockCountCol.Name = "Кол-во в наличии";


            dataSpareParts.Columns.Add(idCol);
            dataSpareParts.Columns.Add(nameCol);
            dataSpareParts.Columns.Add(prepaymentCol);
            dataSpareParts.Columns.Add(inStockCountCol);


            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Наименованию");
            comboBoxSortBy.Items.Add("Предоплате");
            //comboBoxSortBy.Items.Add("Наличию");
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
            else if (comboBoxSortBy.SelectedItem.ToString() == "Предоплате")
            {
                sortBy = "ClientPrepayment";
            }
            /*else if (comboBoxSortBy.SelectedItem.ToString() == "Наличию")
            {
                sortBy = "ClientPrepayment";
            }*/

            //
            //  ДЛЯ ОРДЕРА ЗАПОЛНЕНИЕ ТУТ НАДО БУДЕТ! order != null ?
            //


            //MessageBox.Show(numericStockFrom.Value.ToString());
            List<SparePart> spareParts = SparePartsList.GetSpareParts(
                new SparePart() 
                {
                    Id = id,
                    Name = tbName.Text,
                    ClientPrepayment = radioBtnWithout.Checked ? -1 : numericPrepaymentFrom.Value
                },
                new SparePart()
                {
                    ClientPrepayment = numericPrepaymentUntil.Value
                },
                (Workshop)tbWorkshop.Tag,
                (int)numericStockFrom.Value,
                (int)numericStockUntil.Value,
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataSpareParts.Rows.Clear();
            for (int i = 0; i < spareParts.Count; i++)
            {
                dataSpareParts.Rows.Add(new DataGridViewRow());

                dataSpareParts.Rows[i].Cells[0].Value = spareParts[i].Id;
                dataSpareParts.Rows[i].Cells[1].Value = spareParts[i].Name;
                dataSpareParts.Rows[i].Cells[2].Value = spareParts[i].ClientPrepayment;
                dataSpareParts.Rows[i].Cells[3].Value = spareParts[i].GetCountInStock((Workshop)tbWorkshop.Tag);                         // вот сюда кол-во в наличие

            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageSparePart manageSparePart = new FormManageSparePart();
            manageSparePart.ShowDialog();

            FillGrid();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowSparePart showSparePart = new FormShowSparePart(readOnly, SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)));
            showSparePart.ShowDialog();

            FillGrid();
        }

        private void BtnShowInOther_Click(object sender, EventArgs e)           // при просмотре из заказа/поставки
        {
            FormShowSparePart showSparePart = new FormShowSparePart(true, SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)));
            showSparePart.ShowDialog();
        }

        /*private void BtnShowInWorkshop_Click(object sender, EventArgs e)           // при просмотре из заказа/поставки
        {
            FormShowSparePart showSparePart = new FormShowSparePart(true);
            showSparePart.ShowDialog();
        }*/

        private void btnFIndWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
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

        private void clearBtnAll_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            radioBtnRequied.Checked = true;
            numericPrepaymentFrom.Value = 0;
            numericPrepaymentUntil.Value = 0;
            numericStockFrom.Value = 0;
            numericStockUntil.Value = 0;
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;

            FillGrid();
        }

        private void clearBtnWithoutWorkshop_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            radioBtnRequied.Checked = true;
            numericPrepaymentFrom.Value = 0;
            numericPrepaymentUntil.Value = 0;
            numericStockFrom.Value = 0;
            numericStockUntil.Value = 0;

            FillGrid();
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

        

        private void btnPrepaymentInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPrepaymentInfo.SetToolTip(btnPrepaymentInfo, "Ноль - до скольки угодно");
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

        private void btnCleanWorkshop_Click(object sender, EventArgs e)
        {
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;
        }

        
    }
}

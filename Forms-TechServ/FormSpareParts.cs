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
                btnPick.Click += BtnPick_Click;

                dataSpareParts.CellMouseDoubleClick += BtnPick_Click; 

                readOnly = true;


                groupStock.Enabled = false;

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



        public FormSpareParts(bool forSearching, Workshop workshop)
        {
            InitializeComponent();

            readOnly = true;

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();              // ИЩЕМ МЫ ТОЛЬКО ИЗ ЗАКАЗА
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                dataSpareParts.CellMouseDoubleClick += BtnPick_Click; 



                groupStock.Enabled = false;

                //clearBtn.Click += clearBtnWithoutWorkshop_Click;
            }
            else
            {
                dataSpareParts.CellMouseDoubleClick += BtnShowInOther_Click;
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

            
            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;
            btnFIndWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;

            clearBtn.Click += clearBtnWithoutWorkshop_Click;
        }


        private void BtnPick_Click(object sender, EventArgs e)                    // ДОБАВИТЬ К ПОСТАВКИ (ИЗ ДОБАВЛЕНИЯ НОВОЙ ПОСТАВКИ)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataSpareParts.SelectedRows.Count > 0)
            {
                sparePart = SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("Сначала выберите деталь");
                
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
            DataGridViewTextBoxColumn inTransitCountCol = new DataGridViewTextBoxColumn();
            inTransitCountCol.Name = "Кол-во в заказанных";

            dataSpareParts.Columns.Add(idCol);
            dataSpareParts.Columns.Add(nameCol);
            dataSpareParts.Columns.Add(prepaymentCol);
            dataSpareParts.Columns.Add(inStockCountCol);
            dataSpareParts.Columns.Add(inTransitCountCol);

            if (UserSession.Can("add_del_sparePart") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataSpareParts.Columns.Add(delCol);

                dataSpareParts.CellContentClick += DelCol_Click;
            }


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
                dataSpareParts.Rows[i].Cells[4].Value = spareParts[i].GetCountInTransit((Workshop)tbWorkshop.Tag);                         // вот сюда кол-во в пути

                if (dataSpareParts.Columns.Count > 5)
                {
                    dataSpareParts.Rows[i].Cells[5].Value = "Удалить";
                    dataSpareParts.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataSpareParts.Rows[i].Cells[5].Style.ForeColor = Color.White;

                }

            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                SparePart sparePartToDel = SparePartsList.GetById((int)dataSpareParts.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить запчасть с id {sparePartToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (sparePartToDel.DelSparePart())
                    {
                        MessageBox.Show("Запчать успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Есть не истраченные запчасти этого типа, пока ее удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageSparePart manageSparePart = new FormManageSparePart();
            manageSparePart.ShowDialog();

            FillGrid();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataSpareParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите деталь");
            }
            else
            {
                FormShowSparePart showSparePart = new FormShowSparePart(readOnly, SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)));
                showSparePart.ShowDialog();

                FillGrid();
            }
            
        }

        private void BtnShowInOther_Click(object sender, EventArgs e)           // при просмотре из заказа/поставки
        {
            FormShowSparePart showSparePart = new FormShowSparePart(true, SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)));
            showSparePart.ShowDialog();
        }



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

﻿using System;
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
        int rowsCount;
        int currentPage = 1;
        public Batch batch;
        Workshop workshop;
        SparePart sparePart;

        public FormBatches()
        {
            InitializeComponent();

            readOnly = true;

            if (UserSession.Can("add_del_batch"))
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnManage_Click;

                
            }

            if (UserSession.Can("edit_batch"))
            {
                readOnly = false;
                ManageButton btnDelivered = new ManageButton();
                btnDelivered.Text = "Отменить как 'доставлен'";
                panelControl.Controls.Add(btnDelivered);
                btnDelivered.Click += btnDelivered_Click;
            }

            //btnDelivered.Click += BtnManage_Click;
            dataBatches.CellMouseDoubleClick += BtnShow_Click;

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

            btnClean.Click += btnCleanAll_Click;
        }

        public FormBatches(SparePart sparePart, Workshop workshop)
        {
            InitializeComponent();

            this.sparePart = sparePart;

            ManageButton btnPick = new ManageButton();
            btnPick.Text = "Выбрать";
            panelControl.Controls.Add(btnPick);
            btnPick.Click += BtnPick_Click;

            dataBatches.CellMouseDoubleClick += BtnPick_Click;

            readOnly = true;

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

            btnClean.Click += btnCleanAll_Click;

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;
        }

        public FormBatches(Workshop workshop, bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            tbWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;
            btnFindWorkshop.Enabled = false;

            if (!readOnly)
            {
                if (UserSession.Can("add_del_batch"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManageFromWorkshop_Click;            // если добавляем из мастерской (чтоб залочить ее выбор)
                }

                if (UserSession.Can("edit_batch"))
                {
                    ManageButton btnDelivered = new ManageButton();
                    btnDelivered.Text = "Отменить как 'доставлен'";
                    panelControl.Controls.Add(btnDelivered);
                    btnDelivered.Click += btnDelivered_Click;
                }



            }

            dataBatches.CellMouseDoubleClick += BtnShow_Click;

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

            this.workshop = workshop;

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;
            btnCleanWorkshop.Enabled = false;
            btnFindWorkshop.Enabled = false;

            btnClean.Click += btnCleanInWorkshop_Click;
        }

        private void FormBatches_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn trackNumCol = new DataGridViewTextBoxColumn();
            trackNumCol.Name = "Трэкномер";
            DataGridViewTextBoxColumn workshopCol = new DataGridViewTextBoxColumn();
            workshopCol.Name = "Мастерская";

            DataGridViewTextBoxColumn infoCol = new DataGridViewTextBoxColumn();
            if (sparePart != null)
            {
                infoCol.Name = "Кол-во деталей";
            }
            else
            {
                infoCol.Name = "Цена";
            }

            
            DataGridViewTextBoxColumn deliveredCol = new DataGridViewTextBoxColumn();
            deliveredCol.Name = "Дата прибытия";
            deliveredCol.SortMode = DataGridViewColumnSortMode.NotSortable;             // сортируем только с помощью отдельного поля для сортировки, т.к. разные типы данных могут быть

            dataBatches.Columns.Add(idCol);
            dataBatches.Columns.Add(trackNumCol);
            dataBatches.Columns.Add(workshopCol);
            dataBatches.Columns.Add(infoCol);
            dataBatches.Columns.Add(deliveredCol);

            if (UserSession.Can("add_del_branch") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataBatches.Columns.Add(delCol);

                dataBatches.CellContentClick += DelCol_Click;
            }

            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Трэкномеру");
            comboBoxSortBy.Items.Add("Цене");
            comboBoxSortBy.Items.Add("Дате прибытия");
            //comboBoxSortBy.Items.Add("Номер телефона");
            comboBoxSortBy.SelectedIndex = 0;

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            datePickerFrom.Format = DateTimePickerFormat.Custom;
            datePickerFrom.CustomFormat = " ";
            datePickerUntil.Format = DateTimePickerFormat.Custom;
            datePickerUntil.CustomFormat = " ";

            FillGrid();
        }


        private void FillGrid()
        {
            // ЕСЛИ ФИЛЬТРЫ ПУСТЫЕ, ТО ПОЛУЧАЕМ ВСЕ ЗНАЧЕНИЯ
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            string sortBy = "Id";

            if (comboBoxSortBy.SelectedItem.ToString() == "Трэкномеру")
            {
                sortBy = "TrackNumber";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Цене")
            {
                sortBy = "Price";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Дате прибытия")
            {
                sortBy = "DateDelivered";
            }

            DateTime? dateFrom;
            if(datePickerFrom.Format == DateTimePickerFormat.Custom)
            {
                dateFrom = null;
            }
            else
            {
                dateFrom = datePickerFrom.Value;
            }
            DateTime? dateUntil;
            if (datePickerUntil.Format == DateTimePickerFormat.Custom)
            {
                dateUntil = null;
            }
            else
            {
                dateUntil = datePickerUntil.Value;
            }

            List<Batch> batches;
            if (sparePart != null) 
            {
                batches = BatchesList.GetBatchesWithSparePart(
                    new Batch()
                    {
                        Id = id,
                        TrackNumber = tbTrackNum.Text,
                        DateDelivered = dateFrom,
                        Price = numericPriceFrom.Value,
                        Workshop = (Workshop)tbWorkshop.Tag
                    },
                    new Batch()
                    {
                        DateDelivered = dateUntil,
                        Price = numericPriceUntil.Value
                    },
                    sparePart,
                    (bool)btnAskOrDesk.Tag,
                    sortBy,
                    (int)comboBoxShowRows.SelectedItem,
                    currentPage,
                    out rowsCount
                    );
            }
            else
            {
                batches = BatchesList.GetBatches(
                    new Batch()
                    {
                        Id = id,
                        TrackNumber = tbTrackNum.Text,
                        DateDelivered = dateFrom,
                        Price = numericPriceFrom.Value,
                        Workshop = (Workshop)tbWorkshop.Tag
                    },
                    new Batch()
                    {
                        DateDelivered = dateUntil,
                        Price = numericPriceUntil.Value
                    },
                    (bool)btnAskOrDesk.Tag,
                    sortBy,
                    (int)comboBoxShowRows.SelectedItem,
                    currentPage,
                    out rowsCount
                    );
            }
            

            dataBatches.Rows.Clear();
            for (int i = 0; i < batches.Count; i++)
            {
                dataBatches.Rows.Add(new DataGridViewRow());

                dataBatches.Rows[i].Cells[0].Value = batches[i].Id;
                dataBatches.Rows[i].Cells[1].Value = batches[i].TrackNumber;
                dataBatches.Rows[i].Cells[2].Value = batches[i].Workshop.Location;
                if (sparePart != null)
                {
                    dataBatches.Rows[i].Cells[3].Value = batches[i].GetCountLeft(sparePart);
                }
                else
                {
                    dataBatches.Rows[i].Cells[3].Value = batches[i].Price;
                }

                if (batches[i].DateDelivered.HasValue)
                {
                    dataBatches.Rows[i].Cells[4].Value = batches[i].DateDelivered;
                }
                else
                {
                    dataBatches.Rows[i].Cells[4].Value = "В пути";
                }

                if (dataBatches.Columns.Count > 5)
                {
                    dataBatches.Rows[i].Cells[5].Value = "Удалить";
                    dataBatches.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataBatches.Rows[i].Cells[5].Style.ForeColor = Color.White;
                }
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if(numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";

        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Batch batchToDel = BatchesList.GetById((int)dataBatches.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить поставку с id {batchToDel.Id}? Это также приведет к удалению деталей из этой поставки из заказов, где они уже зарезервированы", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (batchToDel.DelBatch())
                    {
                        MessageBox.Show("Поставка успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Нельзя удалить уже прибывшую поставку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnPick_Click(object sender, EventArgs e)          // вот тут ретернить выбранного клиента
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataBatches.SelectedRows.Count > 0)
            {
                batch = BatchesList.GetById((int)dataBatches.SelectedRows[0].Cells[0].Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Для начала выберите поставку");
            }
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageBatch manageBatch = new FormManageBatch();
            manageBatch.ShowDialog();

            FillGrid();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы уверены, что хотите отметить ВСЕ выбранные поставки как доставленные?", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(answer == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataBatches.SelectedRows)
                {
                    Batch anotherBatch = BatchesList.GetById(Convert.ToInt32(dataBatches.Rows[row.Index].Cells[0].Value));
                    if (!anotherBatch.DateDelivered.HasValue)
                    {
                        anotherBatch.DateDelivered = DateTime.Now;
                        anotherBatch.EditBatch();
                    }
                }

                FillGrid();
            }

            
        }

        private void BtnManageFromWorkshop_Click(object sender, EventArgs e)
        {
            FormManageBatch manageBatch = new FormManageBatch(workshop);
            manageBatch.ShowDialog();

            FillGrid();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataBatches.SelectedRows.Count > 0)
            {
                FormShowBatch showBatch = new FormShowBatch(readOnly, BatchesList.GetById(Convert.ToInt32(dataBatches.SelectedRows[0].Cells[0].Value)));
                showBatch.ShowDialog();

                FillGrid();
            }
            else
            {
                MessageBox.Show("Для начала выберите поставку");
            }
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private void datePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            datePickerFrom.Format = DateTimePickerFormat.Short;
            
        }

        private void btnCleanWorkshop_Click(object sender, EventArgs e)
        {
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnCleanAll_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbTrackNum.Clear();
            datePickerFrom.Format = DateTimePickerFormat.Custom;
            datePickerFrom.CustomFormat = " ";
            datePickerUntil.Format = DateTimePickerFormat.Custom;
            datePickerUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            tbWorkshop.Clear();
            tbWorkshop.Tag = null;

            FillGrid();
        }

        private void btnCleanInWorkshop_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbTrackNum.Clear();
            datePickerFrom.Format = DateTimePickerFormat.Custom;
            datePickerFrom.CustomFormat = " ";
            datePickerUntil.Format = DateTimePickerFormat.Custom;
            datePickerUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;

            FillGrid();
        }

        private void btnCleanFrom_Click(object sender, EventArgs e)
        {
            datePickerFrom.Format = DateTimePickerFormat.Custom;
            datePickerFrom.CustomFormat = " ";
        }

        private void btnCleanUntil_Click(object sender, EventArgs e)
        {
            datePickerUntil.Format = DateTimePickerFormat.Custom;
            datePickerUntil.CustomFormat = " ";
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

        private void btnPriceInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPriceInfo.SetToolTip(btnPriceInfo, "Ноль - до скольки угодно");
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

        private void datePickerUntil_ValueChanged(object sender, EventArgs e)
        {
            datePickerUntil.Format = DateTimePickerFormat.Short;
        }

        

        /*private void dataBatches_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShowBatch showBatch = new FormShowBatch(readOnly, BatchesList.GetById(Convert.ToInt32(dataBatches.SelectedRows[0].Cells[0].Value)));
            showBatch.ShowDialog();

            FillGrid();
        }*/
    }
}

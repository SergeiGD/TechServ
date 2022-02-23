using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.batches;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.customControls;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.batches
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

            btnClean.Click += btnOrder_Click;

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;

            tbWorkshop.Enabled = false;
            btnCleanWorkshop.Enabled = false;
            btnFindWorkshop.Enabled = false;
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
            DataGridViewTextBoxColumn statusCol = new DataGridViewTextBoxColumn();
            statusCol.Name = "Статус";

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
            dataBatches.Columns.Add(statusCol);
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
            comboBoxSortBy.Items.Add("Статусу");
            comboBoxSortBy.SelectedIndex = 0;

            foreach (BatchStatus status in Enum.GetValues(typeof(BatchStatus)))
            {
                if (status == BatchStatus.Неопределенный) continue;
                if(sparePart != null && status == BatchStatus.Создана) continue;
                comboBoxStatus.Items.Add(status);
            }
            comboBoxStatus.SelectedItem = null;

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
            if (!int.TryParse(tbID.Text, out id) || id < 0) id = 0;                                // получаем введенное для сортировки id

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
            else if (comboBoxSortBy.SelectedItem.ToString() == "Статусу")
            {
                sortBy = "Status";
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
            if (sparePart != null)                                                      // ЕСЛИ ВЫЗВАЛИ ИЗ ДЕТАЛИ
            {
                batches = BatchesList.GetBatchesWithSparePart(
                    new Batch()
                    {
                        Id = id,
                        TrackNumber = tbTrackNum.Text,
                        DateDelivered = dateFrom,
                        Price = numericPriceFrom.Value,
                        Workshop = (Workshop)tbWorkshop.Tag,
                        Status = comboBoxStatus.SelectedItem == null ? BatchStatus.Неопределенный : (BatchStatus)comboBoxStatus.SelectedItem
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
                        Workshop = (Workshop)tbWorkshop.Tag,
                        Status = comboBoxStatus.SelectedItem == null ? BatchStatus.Неопределенный : (BatchStatus)comboBoxStatus.SelectedItem
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
                if (sparePart != null)                                              // ЕСЛИ ВЫЗВАЛИ ИЗ ДЕТАЛИ, ТО КОЛОНКА ОТВЕЧАЕТ ЗА КОЛ-ВО ОСТАВШИХСЯ, ИНАЧЕ ЗА ЦЕНУ
                {
                    dataBatches.Rows[i].Cells[3].Value = batches[i].GetCountLeft(sparePart);
                }
                else
                {
                    dataBatches.Rows[i].Cells[3].Value = batches[i].Price;
                }

                dataBatches.Rows[i].Cells[4].Value = batches[i].Status;

                if (batches[i].DateDelivered.HasValue)
                {
                    dataBatches.Rows[i].Cells[5].Value = batches[i].DateDelivered;
                }
                else
                {
                    dataBatches.Rows[i].Cells[5].Value = "Нет";
                }

                if (dataBatches.Columns.Count > 6)
                {
                    dataBatches.Rows[i].Cells[6].Value = "Удалить";
                    dataBatches.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataBatches.Rows[i].Cells[6].Style.ForeColor = Color.White;
                }
            }

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
                string isSpent = batchToDel.IsSpent() ? "нету" : "есть";
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить поставку с id {batchToDel.Id}? Неизрасходованные детали - {isSpent}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    List<string> ordersInUse;
                    if (batchToDel.DelBatch(out ordersInUse))
                    {
                        MessageBox.Show("Поставка успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show($"Детали из этой поставки уже используются в заказах {String.Join(" ", ordersInUse)}, ее удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int errorDelivered = 0;
                int errorNotConfirmed = 0;
                foreach (DataGridViewRow row in dataBatches.SelectedRows)
                {
                    Batch anotherBatch = BatchesList.GetById(Convert.ToInt32(dataBatches.Rows[row.Index].Cells[0].Value));

                    if(anotherBatch.Status == BatchStatus.Прибыла)
                    {
                        errorDelivered++;
                        continue;
                    }

                    if(anotherBatch.Status == BatchStatus.Создана)
                    {
                        errorNotConfirmed++;
                        continue;
                    }

                    anotherBatch.DateDelivered = DateTime.Now;
                    anotherBatch.Status = BatchStatus.Прибыла;
                    anotherBatch.EditBatch();
                }

                if (errorDelivered == 0 && errorNotConfirmed == 0) 
                {
                    MessageBox.Show("Все поставки упешно отмечены как доставленные", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show($"{errorDelivered + errorNotConfirmed} не могут быть отмечены как доставленные: {Environment.NewLine} {errorDelivered} - уже отмечены как доставленные; {Environment.NewLine} {errorNotConfirmed} - не подтверждены;", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            comboBoxStatus.SelectedItem = null;

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
            comboBoxStatus.SelectedItem = null;

            FillGrid();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbTrackNum.Clear();
            datePickerFrom.Format = DateTimePickerFormat.Custom;
            datePickerFrom.CustomFormat = " ";
            datePickerUntil.Format = DateTimePickerFormat.Custom;
            datePickerUntil.CustomFormat = " ";
            numericPriceFrom.Value = 0;
            numericPriceUntil.Value = 0;
            comboBoxStatus.SelectedItem = null;

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

        private void btnCleanStatus_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedItem = null;
        }

        private void btnIdInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipIdInfo.SetToolTip(btnIdInfo, "id может быть только целом положительным числом");
        }
    }
}

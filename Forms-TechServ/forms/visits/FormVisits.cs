using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.classes.visits;
using Forms_TechServ.forms.customControls;
using Forms_TechServ.forms.employees;
using Forms_TechServ.forms.orders;

namespace Forms_TechServ.forms.visits
{
    public partial class FormVisits : Form
    {
        bool readOnly;
        int rowsCount;
        int currentPage = 1;
        OrderAtHome order;
        Master master;

        public FormVisits()
        {
            InitializeComponent();

            readOnly = true;

            if (UserSession.Can("add_del_visit"))
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;
            }
            if (UserSession.Can("edit_visit"))
            {
                ManageButton btnDone = new ManageButton();
                btnDone.Text = "Отментить как 'выполнен'";
                btnDone.Click += BtnDone_Click;
                panelControl.Controls.Add(btnDone);

                readOnly = false;
            }
            

            

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            dataVisits.CellMouseDoubleClick += BtnShow_Click;

            btnClean.Click += cleanAll_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }

        }

        public FormVisits(bool readOnly, OrderAtHome order)
        {
            InitializeComponent();

            
            this.readOnly = readOnly;

            if (!readOnly && UserSession.Can("add_del_visit"))
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += BtnAddFromOrder_Click;
            }
            if (!readOnly && UserSession.Can("edit_visit1"))
            {
                ManageButton btnDone = new ManageButton();
                btnDone.Text = "Отментить как 'выполнен'";
                btnDone.Click += BtnDone_Click;
                panelControl.Controls.Add(btnDone);

                readOnly = false;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            dataVisits.CellMouseDoubleClick += BtnShow_Click;

            btnClean.Click += cleanInOrder_Click;

            this.order = order;
            tbOrder.Text = order.Id.ToString();
            tbOrder.Tag = order;
            btnCleanOrder.Enabled = false;
            btnFindOrder.Enabled = false;
            
            btnCleanMaster.Enabled = false;
            btnFindMaster.Enabled = false;


            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        public FormVisits(Master master)
        {
            InitializeComponent();


            this.readOnly = true;

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += BtnShow_Click;

            dataVisits.CellMouseDoubleClick += BtnShow_Click;

            btnClean.Click += cleanInMaster_Click;

            this.master = master;
            tbMaster.Text = master.Name;
            tbMaster.Tag = master;
            btnCleanMaster.Enabled = false;
            btnFindMaster.Enabled = false;


            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }



        private void FormVisits_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn orderCol = new DataGridViewTextBoxColumn();
            orderCol.Name = "Заказ";
            DataGridViewTextBoxColumn doneCol = new DataGridViewTextBoxColumn();
            doneCol.Name = "Выполнен";
            DataGridViewTextBoxColumn dateCol = new DataGridViewTextBoxColumn();
            dateCol.Name = "Дата";
            DataGridViewTextBoxColumn timeCol = new DataGridViewTextBoxColumn();
            timeCol.Name = "Расчетное время";

            dataVisits.Columns.Add(idCol);
            dataVisits.Columns.Add(orderCol);
            dataVisits.Columns.Add(doneCol);
            dataVisits.Columns.Add(dateCol);
            dataVisits.Columns.Add(timeCol);

            if (UserSession.Can("add_del_visit") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataVisits.Columns.Add(delCol);

                dataVisits.CellContentClick += DelCol_Click;
            }

            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Дате");
            comboBoxSortBy.Items.Add("Требуемому времени");
            comboBoxSortBy.SelectedIndex = 0;

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            SetDefDates();
            

            FillGrid();
        }

        private void FillGrid()
        {
            int id;
            if (!int.TryParse(tbID.Text, out id) || id < 0) id = 0;                                // получаем введенное для сортировки id

            string sortBy = "Id";

            if (comboBoxSortBy.SelectedItem.ToString() == "id")
            {
                sortBy = "Id";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Дате")
            {
                sortBy = "DateVisit";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Требуемому времени")
            {
                sortBy = "CalcEstimatedTime()";
            }

            List<Visit> visits = VisitsList.GetVisits(
                new Visit() 
                {
                    Id = id,
                    Order = (OrderAtHome)tbOrder.Tag,
                    Done = !checkNotFinished.Checked,
                    DateVisit = datePickerFrom.Value
                },
                new Visit() 
                {
                    DateVisit = datePickerUntil.Value
                },
                (Master)tbMaster.Tag,
                tbAddress.Text,
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataVisits.Rows.Clear();
            for (int i = 0; i < visits.Count; i++)
            {
                dataVisits.Rows.Add(new DataGridViewRow());

                dataVisits.Rows[i].Cells[0].Value = visits[i].Id;
                dataVisits.Rows[i].Cells[1].Value = visits[i].OrderId;
                if (visits[i].Done)
                {
                    dataVisits.Rows[i].Cells[2].Value = "Да";
                }
                else
                {
                    dataVisits.Rows[i].Cells[2].Value = "Нет";
                }
                dataVisits.Rows[i].Cells[3].Value = visits[i].DateVisit;
                dataVisits.Rows[i].Cells[4].Value = visits[i].CalcEstimatedTime();

                if (dataVisits.Columns.Count > 5)
                {
                    dataVisits.Rows[i].Cells[5].Value = "Удалить";
                    dataVisits.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataVisits.Rows[i].Cells[5].Style.ForeColor = Color.White;

                }
            }
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Visit visitToDel = VisitsList.GetById((int)dataVisits.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить выезд с id {visitToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (visitToDel.DelVisit())
                    {
                        MessageBox.Show("Выезд был удален", "Успешно удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void BtnAdd_Click(object sender, EventArgs e)       
        {

            FormManageVisit addVisit = new FormManageVisit();
            addVisit.ShowDialog();

            FillGrid();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {

            if(dataVisits.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Вы уверены, что хотите пометить как выполненные ВСЕ выбранные выезды?", "Подтверидите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes)
                {
                    bool changeState = false;
                    DialogResult changeStateAnswer = MessageBox.Show("Желаете также отметить услуги этих выездов как 'выполненные'??", "Подтверидите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(changeStateAnswer == DialogResult.Yes)
                    {
                        changeState = true;
                    }
                    foreach (DataGridViewRow row in dataVisits.SelectedRows)
                    {
                        Visit anotherVisit = VisitsList.GetById(Convert.ToInt32(dataVisits.Rows[row.Index].Cells[0].Value));
                        if (!anotherVisit.Done)
                        {
                            anotherVisit.Done = true;
                            anotherVisit.EditVisit();
                            if (changeState)
                            {
                                foreach (OrderService service in anotherVisit.GetVisitOrderServices())
                                {
                                    service.Done = true;
                                    anotherVisit.Order.EditService(service);
                                }
                            }
                        }
                    }

                    FillGrid();
                }
            }
        }

        private void BtnAddFromOrder_Click(object sender, EventArgs e)
        {

            FormManageVisit addVisit = new FormManageVisit(order);
            addVisit.ShowDialog();

            FillGrid();
        }


        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataVisits.SelectedRows.Count > 0)
            {
                FormShowVisit showVisit = new FormShowVisit(readOnly, VisitsList.GetById((int)dataVisits.SelectedRows[0].Cells[0].Value));
                showVisit.ShowDialog();

                FillGrid();
            }
            else
            {
                MessageBox.Show("Для начала выберите выезд");
            }
        }


        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();

            tbMaster.Tag = formMasters?.master;
            tbMaster.Text = formMasters?.master?.Name;
        }

        private void btnFindOrder_Click(object sender, EventArgs e)
        {
            FormOutOrders formOrders = new FormOutOrders(true);
            formOrders.ShowDialog();

            tbOrder.Tag = formOrders?.order;
            tbOrder.Text = formOrders?.order?.Id.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void SetDefDates()
        {
            if (order == null)
            {
                datePickerFrom.Value = DateTime.Now;
                datePickerUntil.Value = DateTime.Now.AddDays(30);
            }
            else
            {
                datePickerFrom.Value = order.DateStart.Value;
                if (order.DateFinish.HasValue) datePickerUntil.Value = order.DateFinish.Value;
                if (order.DateCancel.HasValue) datePickerUntil.Value = order.DateCancel.Value;
                if (!order.DateFinish.HasValue && !order.DateCancel.HasValue) datePickerUntil.Value = order.DateStart.Value.AddDays(30);
            }
        }

        private void cleanAll_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAddress.Clear();
            checkNotFinished.Checked = false;
            tbMaster.Clear();
            tbMaster.Tag = null;
            tbOrder.Clear();
            tbOrder.Tag = null;
            SetDefDates();

            FillGrid();
        }

        private void cleanInOrder_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAddress.Clear();
            checkNotFinished.Checked = false;
            tbMaster.Clear();
            tbMaster.Tag = null;
            SetDefDates();

            FillGrid();
        }

        private void cleanInMaster_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAddress.Clear();
            checkNotFinished.Checked = false;
            tbOrder.Clear();
            tbOrder.Tag = null;
            SetDefDates(); 

            FillGrid();
        }

        private void btnCleanMaster_Click(object sender, EventArgs e)
        {
            tbMaster.Tag = null;
            tbMaster.Clear();
        }

        private void btnCleanOrder_Click(object sender, EventArgs e)
        {
            tbOrder.Tag = null;
            tbOrder.Clear();
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

        private void btnIdInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipIdInfo.SetToolTip(btnIdInfo, "id может быть только целом положительным числом");
        }
    }
}

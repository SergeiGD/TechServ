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
    public partial class FormOrdersLogs : Form
    {
        bool readOnly;
        Order order;
        int rowsCount;
        int currentPage = 1;

        public FormOrdersLogs(bool readOnly, Order order)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.order = order;

            if (!readOnly && UserSession.Can("del_orderLog"))
            {
                ManageButton btnDelete = new ManageButton();
                btnDelete.Text = "Удалить выделенные";
                panelControl.Controls.Add(btnDelete);
                btnDelete.Click += BtnDelete_Click;
            }

            dataOrderLogs.CellDoubleClick += BtnShow_Click;
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

        


        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataOrderLogs.SelectedRows.Count > 0)
            {
                FormShowOrderLog formShowOrderLog = new FormShowOrderLog(order.GetOrderLog((int)dataOrderLogs.SelectedRows[0].Cells[0].Value));
                formShowOrderLog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите событие");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(dataOrderLogs.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Вы уверены, что хотите удалить ВСЕ выбранные события?", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    int deleted = 0;
                    foreach (DataGridViewRow row in dataOrderLogs.SelectedRows)
                    {
                        OrderLog orderLog = order.GetOrderLog((int)dataOrderLogs.Rows[row.Index].Cells[0].Value);
                        orderLog.DelOrderLog();
                        deleted++;
                    }

                    FillGrid();
                    MessageBox.Show($"{deleted} события были удалены");
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите событие");
            }
        }

        private void FormOrdersLogs_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            idCol.Width = (int)(dataOrderLogs.Width * 0.2);
            DataGridViewTextBoxColumn descripCol = new DataGridViewTextBoxColumn();
            descripCol.Name = "Описание события";
            descripCol.Width = (int)(dataOrderLogs.Width * 0.5);
            DataGridViewTextBoxColumn dateCol = new DataGridViewTextBoxColumn();
            dateCol.Name = "Дата события";
            dateCol.Width = dataOrderLogs.Width - idCol.Width - descripCol.Width;
            dateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataOrderLogs.Columns.Add(idCol);
            dataOrderLogs.Columns.Add(descripCol);
            dataOrderLogs.Columns.Add(dateCol);

            if (UserSession.Can("del_orderLog") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataOrderLogs.Columns.Add(delCol);

                dataOrderLogs.CellContentClick += DelCol_Click;
            }

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            datePickerFrom.Value = order.DateStart.Value;
            datePickerUnti.Value = order.DateStart.Value.AddMonths(6);

            FillGrid();
        }

        private void FillGrid()
        {
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            List<OrderLog> orderLogs = order.GetOrderLogs(
                new OrderLog()
                {
                    Id = id,
                    EventDate = datePickerFrom.Value
                },
                new OrderLog()
                {
                    EventDate = datePickerUnti.Value
                },
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataOrderLogs.Rows.Clear();
            for (int i = 0; i < orderLogs.Count; i++)
            {
                dataOrderLogs.Rows.Add(new DataGridViewRow());

                dataOrderLogs.Rows[i].Cells[0].Value = orderLogs[i].Id;
                dataOrderLogs.Rows[i].Cells[1].Value = orderLogs[i].EventDescription;
                dataOrderLogs.Rows[i].Cells[2].Value = orderLogs[i].EventDate;

                if (dataOrderLogs.Columns.Count > 3)
                {
                    dataOrderLogs.Rows[i].Cells[3].Value = "Удалить";
                    dataOrderLogs.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataOrderLogs.Rows[i].Cells[3].Style.ForeColor = Color.White;

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
                OrderLog orderLogToDel = order.GetOrderLog((int)dataOrderLogs.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить событие с id {orderLogToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (orderLogToDel.DelOrderLog())
                    {
                        MessageBox.Show("Событие успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            datePickerFrom.Value = order.DateStart.Value;
            datePickerUnti.Value = order.DateStart.Value.AddMonths(6);

            FillGrid();
        }
    }
}

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
    public partial class FormClients : Form
    {
        public Client client;
        bool readOnly;
        int rowsCount;
        int currentPage = 1;


        public FormClients(bool forSearching)
        {
            InitializeComponent();


            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;
                dataClients.CellMouseDoubleClick += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_client"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManage_Click;

                    
                }

                dataClients.CellMouseDoubleClick += BtnShow_Click;

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




        private void FormClients_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";
            DataGridViewTextBoxColumn phoneCol = new DataGridViewTextBoxColumn();
            phoneCol.Name = "Номер телефона";
            DataGridViewTextBoxColumn ordersCountCol = new DataGridViewTextBoxColumn();
            ordersCountCol.Name = "Кол-во заказов (завершенных)";


            dataClients.Columns.Add(idCol);
            dataClients.Columns.Add(nameCol);
            dataClients.Columns.Add(phoneCol);
            dataClients.Columns.Add(ordersCountCol);

            if (UserSession.Can("add_del_client") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataClients.Columns.Add(delCol);

                dataClients.CellContentClick += DelCol_Click;
            }


            btnAskOrDesk.Tag = true;

            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Имени");
            comboBoxSortBy.Items.Add("Кол-ву заказов");
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
            else if (comboBoxSortBy.SelectedItem.ToString() == "Имени")
            {
                sortBy = "Name";
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Кол-ву заказов")
            {
                sortBy = ".CountClientOrders()";
            }

            List<Client> clients = ClientsList.GetClients(
                new Client() 
                { 
                    Id = id,
                    Name = tbName.Text,
                    PhoneNum = tbPhoneNum.Text
                },
                (int)numericOrdersFrom.Value,
                (int)numericOrdersUntil.Value,
                (bool)btnAskOrDesk.Tag,
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataClients.Rows.Clear();
            for (int i = 0; i < clients.Count; i++)
            {
                dataClients.Rows.Add(new DataGridViewRow());

                dataClients.Rows[i].Cells[0].Value = clients[i].Id;
                dataClients.Rows[i].Cells[1].Value = clients[i].Name;
                dataClients.Rows[i].Cells[2].Value = clients[i].PhoneNum;
                dataClients.Rows[i].Cells[3].Value = clients[i].CountClientOrders();

                if (dataClients.Columns.Count > 4)
                {
                    dataClients.Rows[i].Cells[4].Value = "Удалить";
                    dataClients.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataClients.Rows[i].Cells[4].Style.ForeColor = Color.White;

                }

            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";

        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageClient manageClient = new FormManageClient();
            manageClient.ShowDialog();

            FillGrid();
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Client clientToDel = ClientsList.GetById((int)dataClients.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить клиента с id {clientToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (clientToDel.DelClient())
                    {
                        MessageBox.Show("Клиент успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("У данного клиента есть активные заказы, пока его нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnPick_Click(object sender, EventArgs e)       
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataClients.SelectedRows.Count > 0)
            {
                client = ClientsList.GetById(Convert.ToInt32(dataClients.SelectedRows[0].Cells[0].Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("Для начала выберите клиента");
            }
                                                           
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataClients.SelectedRows.Count > 0)
            {
                FormShowClient showClient = new FormShowClient(readOnly, ClientsList.GetById(Convert.ToInt32(dataClients.SelectedRows[0].Cells[0].Value)));
                showClient.ShowDialog();

                FillGrid();
            }
            else
            {
                MessageBox.Show("Для начала выберите клиента");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbPhoneNum.Clear();
            numericOrdersFrom.Value = 0;
            numericOrdersUntil.Value = 0;


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

        private void dataClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShowClient showClient = new FormShowClient(readOnly, ClientsList.GetById(Convert.ToInt32(dataClients.SelectedRows[0].Cells[0].Value)));
            showClient.ShowDialog();

            FillGrid();
        }
    }
}

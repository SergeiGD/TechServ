using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Forms_TechServ
{

    public partial class FormWorkshops : Form
    {
        bool readOnly;
        public Workshop workshop;                                       
        int rowsCount;
        int currentPage = 1;

        public FormWorkshops(bool forSearching)
        {
            InitializeComponent();

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += BtnPick_Click;

                dataWorkshops.CellMouseDoubleClick += BtnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_branch"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += BtnManage_Click;
                }

                readOnly = false;

                dataWorkshops.CellMouseDoubleClick += BtnShow_Click;
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

        private void FormWorkshops_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn locationCol = new DataGridViewTextBoxColumn();
            locationCol.Name = "Адрес";
            DataGridViewTextBoxColumn phoneCol = new DataGridViewTextBoxColumn();
            phoneCol.Name = "Номер телефона";
            dataWorkshops.Columns.Add(idCol);
            dataWorkshops.Columns.Add(locationCol);
            dataWorkshops.Columns.Add(phoneCol);

            if (UserSession.Can("add_del_branch") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataWorkshops.Columns.Add(delCol);

                dataWorkshops.CellContentClick += DelCol_Click;
            }

            btnAskOrDesk.Tag = true;

            //ComboBox
            comboBoxSortBy.Items.Add("id");
            comboBoxSortBy.Items.Add("Адрес");
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
            if (!int.TryParse(tbID.Text, out id) || id < 0) id = 0;                                            // получаем введенное для сортировки id
            
            string sortBy = "Id";

            if(comboBoxSortBy.SelectedItem.ToString() == "id")
            {
                sortBy = "Id";
            }
            else if(comboBoxSortBy.SelectedItem.ToString() == "Адрес")
            {
                sortBy = "Location";
            }

            List<Workshop> workshops = WorkshopsList.GetWorkshops(new Workshop()                       // Загружаем роли, с указанными сортировками
            {
                Id = id,
                Location = tbAddress.Text,
                PhoneNum = tbPhoneNum.Text
            }, 
                (bool)btnAskOrDesk.Tag, 
                sortBy,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount);

            // ЗАПОЛНЯЕМ ГРИД
            dataWorkshops.Rows.Clear();
            for (int i = 0; i < workshops.Count; i++)
            {
                dataWorkshops.Rows.Add(new DataGridViewRow());

                dataWorkshops.Rows[i].Cells[0].Value = workshops[i].Id;
                dataWorkshops.Rows[i].Cells[1].Value = workshops[i].Location;
                dataWorkshops.Rows[i].Cells[2].Value = workshops[i].PhoneNum;

                if (dataWorkshops.Columns.Count > 3)
                {
                    dataWorkshops.Rows[i].Cells[3].Value = "Удалить";
                    dataWorkshops.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataWorkshops.Rows[i].Cells[3].Style.ForeColor = Color.White;

                }
            }

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
                Workshop workshopToDel = WorkshopsList.GetById((int)dataWorkshops.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить филиал с id {workshopToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (workshopToDel.DelWorkshop())
                    {
                        MessageBox.Show("Филиал успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("В данном филиале еще числятся сотрудники/неизрасходованные детали/незавершенные заказы, пока его нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (dataWorkshops.SelectedRows.Count > 0)
            {
                workshop = WorkshopsList.GetById(Convert.ToInt32(dataWorkshops.SelectedRows[0].Cells[0].Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("Для начала выберите мастерскую");
            }

                                                         
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            FormManageWorkshop manageWorkshop = new FormManageWorkshop();
            manageWorkshop.ShowDialog();

            FillGrid();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataWorkshops.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите мастерскую");
            }
            else
            {

                FormShowWorkshop showWorkshop = new FormShowWorkshop(readOnly, WorkshopsList.GetById(Convert.ToInt32(dataWorkshops.SelectedRows[0].Cells[0].Value)));
                showWorkshop.ShowDialog();

                FillGrid();
            }

            
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAddress.Clear();
            tbPhoneNum.Clear();

            FillGrid();
        }

        private void btnAskOrDesk_Click(object sender, EventArgs e)
        {
            if((bool)btnAskOrDesk.Tag == true)
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
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

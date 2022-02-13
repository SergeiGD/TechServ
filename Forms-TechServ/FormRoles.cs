using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TechServ
{
    public partial class FormRoles : Form
    {
        public Role pickedRole;
        Employee employee;
        int currentPage = 1;
        int rowsCount;
        bool readOnly;

        public FormRoles(bool forSearching)
        {
            InitializeComponent();

            if (forSearching)
            {
                ManageButton btnPick = new ManageButton();
                btnPick.Text = "Выбрать";
                panelControl.Controls.Add(btnPick);
                btnPick.Click += btnPick_Click;

                dataPosition.CellMouseDoubleClick += btnPick_Click;

                readOnly = true;
            }
            else
            {
                if (UserSession.Can("add_del_role"))
                {
                    ManageButton btnAdd = new ManageButton();
                    btnAdd.Text = "Добавить";
                    panelControl.Controls.Add(btnAdd);
                    btnAdd.Click += btnAdd_Click;
                }

                dataPosition.CellMouseDoubleClick += btnShow_Click;

                readOnly = false;
            }

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += btnShow_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }

        }

        public FormRoles(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            ManageButton btnPick = new ManageButton();
            btnPick.Text = "Выбрать";
            panelControl.Controls.Add(btnPick);
            btnPick.Click += btnPick_Click;

            dataPosition.CellMouseDoubleClick += btnPick_Click;

            readOnly = true;

            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += btnShow_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        

        private void btnPick_Click(object sender, EventArgs e)
        {
            //var row = dataPosition.SelectedRows;
            if(dataPosition.SelectedRows.Count > 0)
            {
                pickedRole = RolesList.GetById(Convert.ToInt32(dataPosition.SelectedRows[0].Cells[0].Value));
                this.Close();

            }
            else
            {
                MessageBox.Show("Для начала выберите роль");
            }
        }

        private void FormFindEmpPosition_Load(object sender, EventArgs e)
        {
            // СТРОИМ СТОЛБЦЫ ГРИДА
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Наименование";
            DataGridViewTextBoxColumn typeCol = new DataGridViewTextBoxColumn();
            typeCol.Name = "Принадлежность";
            dataPosition.Columns.Add(idCol);
            dataPosition.Columns.Add(nameCol);
            dataPosition.Columns.Add(typeCol);

            if (UserSession.Can("add_del_role") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataPosition.Columns.Add(delCol);

                dataPosition.CellContentClick += DelCol_Click;
            }

            foreach (RoleType role in Enum.GetValues(typeof(RoleType)))
            {
                if (role == RoleType.Неопределенно) continue;
                comboBoxRoleType.Items.Add(role);

            }
            comboBoxRoleType.SelectedItem = null;

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

            List<Role> positions = RolesList.GetRoles(new Role()                       // Загружаем роли, с указанными сортировками
                {
                    Id = id,
                    Name = tbName.Text,
                    RoleType = comboBoxRoleType.SelectedItem == null ? RoleType.Неопределенно : (RoleType)comboBoxRoleType.SelectedItem
                },
                employee,
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            // ЗАПОЛНЯЕМ ГРИД
            dataPosition.Rows.Clear();
            for (int i = 0; i < positions.Count; i++)
            {
                dataPosition.Rows.Add(new DataGridViewRow());

                dataPosition.Rows[i].Cells[0].Value = positions[i].Id;
                dataPosition.Rows[i].Cells[1].Value = positions[i].Name;
                dataPosition.Rows[i].Cells[2].Value = positions[i].RoleType;

                if (dataPosition.Columns.Count > 3)
                {
                    dataPosition.Rows[i].Cells[3].Value = "Удалить";
                    dataPosition.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataPosition.Rows[i].Cells[3].Style.ForeColor = Color.White;

                }
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }



        private void btnFind_Click(object sender, EventArgs e)
        {

            FillGrid();

        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Role roleToDel = RolesList.GetById((int)dataPosition.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить роль с id {roleToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (roleToDel.DelRole())
                    {
                        MessageBox.Show("Роль успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Эту роль нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormManageRole formManageRole = new FormManageRole();
            formManageRole.ShowDialog();

            FillGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ОЧИЩАЕМ ПОЛЯ ДЛЯ СОРТИРОВКИ И ПЕРЕЗАПОЛНЯЕМ ГРИД
            tbID.Clear();
            tbName.Clear();
            comboBoxRoleType.SelectedItem = null;

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


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataPosition.SelectedRows.Count > 0)
            {
                FormShowRole formShowRole = new FormShowRole(readOnly, RolesList.GetById((int)dataPosition.SelectedRows[0].Cells[0].Value));
                formShowRole.ShowDialog();

                FillGrid();


            }
            else
            {
                MessageBox.Show("Для начала выберите роль");
            }
        }

        private void btnCleanRoleType_Click(object sender, EventArgs e)
        {
            comboBoxRoleType.SelectedItem = null;
        }

        private void btnIdInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipIdInfo.SetToolTip(btnIdInfo, "id может быть только целом положительным числом");
        }
    }
}

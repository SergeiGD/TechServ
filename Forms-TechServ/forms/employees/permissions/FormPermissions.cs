using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.employees.permissions
{
    public partial class FormPermissions : Form
    {
        bool readOnly;
        Role role;
        int rowsCount;
        int currentPage = 1;
        public Permission permission;

        public FormPermissions(bool readOnly, Role role)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.role = role;

            if (!readOnly && UserSession.Can("edit_role"))
            {
                ManageButton btnAdd = new ManageButton();
                btnAdd.Text = "Добавить";
                panelControl.Controls.Add(btnAdd);
                btnAdd.Click += btnAdd_Click;

                ManageButton btnDel = new ManageButton();
                btnDel.Text = "Удалить";
                panelControl.Controls.Add(btnDel);
                btnDel.Click += btnDel_Click;

                ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
                mainBtn[0].Location = new Point(0, 0);
                for (int i = 1; i < mainBtn.Count(); i++)
                {
                    mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
                }
            }
        }

        public FormPermissions()
        {
            InitializeComponent();

            readOnly = true;

            ManageButton btnPick = new ManageButton();
            btnPick.Text = "Выбрать";
            panelControl.Controls.Add(btnPick);
            btnPick.Click += btnPick_Click;

            dataPermissions.CellMouseDoubleClick += btnPick_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        private void FormPermissions_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";

            dataPermissions.Columns.Add(idCol);
            dataPermissions.Columns.Add(nameCol);

            if (UserSession.Can("edit_role") && !readOnly)
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataPermissions.Columns.Add(delCol);

                dataPermissions.CellContentClick += DelCol_Click;
            }

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            FillGrid();
        }

        private void FillGrid()
        {
            int id;
            if (!int.TryParse(tbID.Text, out id) || id < 0) id = 0;

            List<Permission> permissions;

            if (role != null)
            {
                permissions = role.GetPermissions(
                new Permission()
                {
                    Id = id,
                    Name = tbName.Text
                },
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );
            }
            else
            {
                permissions = PermissionsList.GetPermissions(
                new Permission()
                {
                    Id = id,
                    Name = tbName.Text
                },
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );
            }

            dataPermissions.Rows.Clear();
            for (int i = 0; i < permissions.Count; i++)
            {
                dataPermissions.Rows.Add(new DataGridViewRow());

                dataPermissions.Rows[i].Cells[0].Value = permissions[i].Id;
                dataPermissions.Rows[i].Cells[1].Value = permissions[i].Name;

                if (dataPermissions.Columns.Count > 2)
                {
                    dataPermissions.Rows[i].Cells[2].Value = "Удалить";
                    dataPermissions.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataPermissions.Rows[i].Cells[2].Style.ForeColor = Color.White;

                }
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormPermissions formPermissions = new FormPermissions();
            formPermissions.ShowDialog();

            if(formPermissions.permission == null)
            {
                return;
            }

            if (role.CheckPermission(formPermissions.permission))
            {
                MessageBox.Show("У этой роли уже есть эти права", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (role.AddPermission(formPermissions.permission))
                {
                    MessageBox.Show("Право успешно добавлено к роли", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillGrid();
                }
                else
                {
                    MessageBox.Show("Произошла непридвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataPermissions.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show($"Вы уверены что хотите убрать ВСЕ выделенные права из роли?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    int deleted = 0;
                    foreach (DataGridViewRow row in dataPermissions.SelectedRows)
                    {
                        Permission anotherPermission = PermissionsList.GetById(Convert.ToInt32(dataPermissions.Rows[row.Index].Cells[0].Value));
                        role.DelPermission(anotherPermission);
                        deleted++;
                    }
                    FillGrid();
                    MessageBox.Show($"{deleted} прав были удалены");
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите хотя бы одно право");
            }
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Permission permissionToDel = PermissionsList.GetById((int)dataPermissions.SelectedRows[0].Cells[0].Value);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить из роли право с id {permissionToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (role.DelPermission(permissionToDel))
                    {
                        MessageBox.Show("Право успешно удалено из роли");
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Произошла непридвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if(dataPermissions.SelectedRows.Count > 0)
            {
                permission = PermissionsList.GetById((int)dataPermissions.SelectedRows[0].Cells[0].Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Для начала выберите роль");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();

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

        private void btnIdInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipIdInfo.SetToolTip(btnIdInfo, "id может быть только целом положительным числом");
        }
    }
}

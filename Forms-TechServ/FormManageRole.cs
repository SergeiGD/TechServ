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
    public partial class FormManageRole : Form
    {

        Role role;
        Size pickedSize = new Size(1078, 600);



        public FormManageRole()
        {
            InitializeComponent();

            roleTabs.TabPages.Remove(permissionsPage);
            btnAction.Text = "Сохранить и добавить права";
            role = new Role();

        }

        public FormManageRole(Role role)
        {
            InitializeComponent();

            btnAction.Text = "Сохранить общую информацию";
            this.role = role;

            this.FormClosing += CheckPermissions;
        }

        private void FormManageRole_Load(object sender, EventArgs e)
        {
            this.Size = new Size(518, 254);

            foreach (RoleType role in Enum.GetValues(typeof(RoleType)))
            {
                if (role == RoleType.Неопределенно) continue;
                comboBoxRoleType.Items.Add(role);

            }
            comboBoxRoleType.SelectedItem = null;

            if (role.Id != 0)
            {
                tbName.Text = role.Name;
                comboBoxRoleType.SelectedItem = role.RoleType;
            }
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbName.Text == "")
            {
                errorProvider.SetError(tbName, "Введите наименование");
                return false;
            }

            if (comboBoxRoleType.SelectedItem == null)
            {
                errorProvider.SetError(comboBoxRoleType, "Выберите тип роли");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                role.Name = tbName.Text;
                role.RoleType = (RoleType)comboBoxRoleType.SelectedItem;

                if(role.Id == 0)
                {
                    role.AddRole();
                    this.Hide();
                    FormManageRole formManageRole = new FormManageRole(RolesList.GetById(role.Id));
                    formManageRole.ShowDialog();
                }
                else
                {
                    role.EditRole();
                    MessageBox.Show($"Данные о роли успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
        }

        private void CheckPermissions(object sender, CancelEventArgs e)
        {
            if (role.CalcPermissionsCount() == 0)
            {
                DialogResult answer = MessageBox.Show("Вы не добавили никаких прав для роли, если Вы ее сейчас закроете, то данная роль автоматически удалится. Продолжить в любом случае?", "ВНИМАНИЕ!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    role.DelRole();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void roleTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(518, 254);
            }
            else if (roleTabs.SelectedTab.Equals(permissionsPage))
            {
                this.Size = pickedSize;

                FormPermissions formPermissions = new FormPermissions(false, role);


                formPermissions.TopLevel = false;
                formPermissions.FormBorderStyle = FormBorderStyle.None;
                permissionsPage.Controls.Add(formPermissions);
                formPermissions.Dock = DockStyle.Fill;
                formPermissions.BringToFront();
                formPermissions.Show();
            }
        }
    }
}

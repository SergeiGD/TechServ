using System;
using System.Drawing;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.forms.employees.permissions;

namespace Forms_TechServ.forms.employees.roles
{
    public partial class FormShowRole : Form
    {
        private readonly Size pickedSize = new Size(1078, 600);
        private readonly bool readOnly;
        private readonly Role role;

        public FormShowRole(bool readOnly, Role role)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.role = role;
            if (role.Id == 1) this.readOnly = true;
        }

        private void roleTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleTabs.SelectedTab.Equals(generalPage))
            {
                Size = new Size(586, 246);
            }
            else if (roleTabs.SelectedTab.Equals(permissionsPage))
            {
                Size = pickedSize;

                var formPermissions = new FormPermissions(true, role);


                formPermissions.TopLevel = false;
                formPermissions.FormBorderStyle = FormBorderStyle.None;
                permissionsPage.Controls.Add(formPermissions);
                formPermissions.Dock = DockStyle.Fill;
                formPermissions.BringToFront();
                formPermissions.Show();
            }
        }

        private void FormShowRole_Load(object sender, EventArgs e)
        {
            if (readOnly || !UserSession.Can("edit_role") && !UserSession.Can("add_del_role"))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                Width = Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_role");
                deleteBtn.Enabled = UserSession.Can("add_del_role");
            }

            FillForm();
        }

        private void FillForm()
        {
            labelID.Text = role.Id.ToString();
            labelName.Text = role.Name;
            labelType.Text = role.RoleType.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Вы действительно хотите удалить эту роль?", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                if (role.DelRole())
                {
                    MessageBox.Show("Роль успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Данную роль удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var formManageRole = new FormManageRole(role);
            formManageRole.ShowDialog();

            FillForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
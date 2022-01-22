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
    public partial class FormShowRole : Form
    {
        Role role;
        Size pickedSize = new Size(1078, 600);
        bool readOnly;

        public FormShowRole(bool readOnly, Role role)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            this.role = role;
        }

        private void roleTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(586, 246);
            }
            else if (roleTabs.SelectedTab.Equals(permissionsPage))
            {
                this.Size = pickedSize;

                FormPermissions formPermissions = new FormPermissions(true, role);


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
            if (readOnly || (!UserSession.Can("edit_role") && !UserSession.Can("add_del_role")))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
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
            labelType.Text = role.RoleType.GetRoleTypeString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить эту роль?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {

                if (role.DelRole())
                {
                    MessageBox.Show("Роль успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Данную роль удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageRole formManageRole = new FormManageRole(role);
            formManageRole.ShowDialog();

            FillForm();
        }
    }
}

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
    public partial class FormShowManager : Form
    {
        Manager manager;
        Size pickedSize = new Size(1078, 481);

        bool readOnly;

        public FormShowManager(bool readOnly, Manager manager)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            this.manager = manager;
        }

        

        private void FormShowManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(695, 357);

            if (readOnly || (!UserSession.Can("edit_employee") && !UserSession.Can("add_del_employee")))      // если просто просмотр или нету прав на изменения
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_employee");
                deleteBtn.Enabled = UserSession.Can("add_del_employee");
            }

            /*using(TechContext db = new TechContext())
            {
                db.Entry(manager).Reference("Workshop").Load();
            }*/

            FillForm();
        }

        private void FillForm()
        {
            labelID.Text = manager.Id.ToString();
            labelName.Text = manager.Name;
            labelPhoneNum.Text = manager.PhoneNum;
            labelRemotely.Text = manager.Remotely ? "Да" : "Нет";
            labelSalary.Text = manager.Salary.ToString();
            if (UserSession.Can("edit_employee"))                       // скрываем пароль, если нету прав на редактирование сотрудника
            {
                labelPassword.Text = manager.Password;                  
            }
            else
            {
                labelPassword.Text = "******";
            }
            labelPosition.Text = manager.Role.Name;
            labelWorkshop.Text = manager.Workshop.Location;
            tbAdditionInfo.Text = manager.AdditionalInfo;
        }

        private void managerTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (managerTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(695, 357);
            }
            else if (managerTabs.SelectedTab.Equals(timetablePage))
            {
                this.Size = pickedSize;

                FormEmpTimetalbe formTimetalbe = new FormEmpTimetalbe(manager, true);

                formTimetalbe.TopLevel = false;
                formTimetalbe.FormBorderStyle = FormBorderStyle.None;
                timetablePage.Controls.Add(formTimetalbe);
                formTimetalbe.Dock = DockStyle.Fill;
                formTimetalbe.BringToFront();
                formTimetalbe.Show();

            }
            else if (managerTabs.SelectedTab.Equals(ordersPage))
            {
                this.Size = pickedSize;

                FormOrders formOrders = new FormOrders(manager);

                formOrders.TopLevel = false;
                formOrders.FormBorderStyle = FormBorderStyle.None;
                ordersPage.Controls.Add(formOrders);
                formOrders.Dock = DockStyle.Fill;
                formOrders.BringToFront();
                formOrders.Show();
            }
        }

        private void FormShowManager_ResizeEnd(object sender, EventArgs e)
        {
            if(!managerTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageManager formManageManager = new FormManageManager(manager);
            formManageManager.ShowDialog();

            FillForm();
        }

        private void linkPickedWorkshop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowWorkshop formShowWorkshop = new FormShowWorkshop(true, manager.Workshop);
            formShowWorkshop.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить этого сотрудника?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(answer == DialogResult.Yes)
            {
                manager.DelManager();

                MessageBox.Show("Сотрудник успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}

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
    public partial class FormManageManager : Form
    {
        Manager manager;
        Size pickedSize = new Size(1078, 481);

        //TabPage ordersPage = new TabPage("Заказы");

        public FormManageManager()
        {
            InitializeComponent();

            manager = new Manager();

            btnAction.Text = "Добавить";
        }

        public FormManageManager(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            btnAction.Text = "Сохранить";

            //managerTabs.TabPages.Add(ordersPage);
        }

        public FormManageManager(Workshop workshop)                  // добавление к конкретной мастерской
        {
            InitializeComponent();

            //masterTabs.TabPages.Add(ordersPage);
            //masterTabs.TabPages.Add(visitsPage);

            //this.master = master;
            manager = new Manager();
            btnAction.Text = "Сохранить";

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;

            btnFindWorkshop.Enabled = false;
        }

        private void managerTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (managerTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(776, 303);
            }
            else if (managerTabs.SelectedTab.Equals(timetablePage))
            {
                this.Size = pickedSize;

                FormEmpTimetalbe formTimetalbe = new FormEmpTimetalbe(manager, false);

                formTimetalbe.TopLevel = false;
                formTimetalbe.FormBorderStyle = FormBorderStyle.None;
                timetablePage.Controls.Add(formTimetalbe);
                formTimetalbe.Dock = DockStyle.Fill;
                formTimetalbe.BringToFront();
                formTimetalbe.Show();
            }
            /*else if (managerTabs.SelectedTab.Equals(ordersPage))
            {
                this.Size = pickedSize;

                FormOrders formOrders = new FormOrders("ad", false);

                formOrders.TopLevel = false;
                formOrders.FormBorderStyle = FormBorderStyle.None;
                ordersPage.Controls.Add(formOrders);
                formOrders.Dock = DockStyle.Fill;
                formOrders.BringToFront();
                formOrders.Show();
            }*/
        }

        private void FormManageManager_ResizeEnd(object sender, EventArgs e)
        {
            if(!managerTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void addTimetableBtn_Click(object sender, EventArgs e)
        {
            //FormAddEmployeeTimetable formAddEmployeeTimetable = new FormAddEmployeeTimetable(manager);
            //formAddEmployeeTimetable.ShowDialog();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                manager.Name = tbName.Text;
                manager.PhoneNum = tbPhoneNum.Text;
                manager.Password = tbPassword.Text;
                manager.Salary = numericSalary.Value;

                //manager.Role = null;                                    // чтоб не было конфликта свойств при изменение, сбрасываем свойство Role и ставим выбранное id

                manager.RoleId = ((Role)tbPosition.Tag).Id;

                //manager.Role = (Role)tbPosition.Tag;

                //manager.Workshop = null;                                // чтоб не было конфликта свойств при изменение, сбрасываем свойство Workshop и ставим выбранное id

                manager.WorkshopId = ((Workshop)tbWorkshop.Tag).Id;

                //manager.Workshop = (Workshop)tbWorkshop.Tag;
                
                manager.AdditionalInfo = tbInfo.Text;

                if(manager.Id == 0)
                {
                    manager.AddManager();

                    MessageBox.Show($"Новый сотрудник успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    manager.Role = (Role)tbPosition.Tag;                // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их
                    manager.Workshop = (Workshop)tbWorkshop.Tag;        // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их

                    manager.EditManager();

                    MessageBox.Show($"Данные о сотруднике успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Заполните корректно все обязательные поля!", "Неверное данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormFindEmpPosition formFindEmpPosition = new FormFindEmpPosition();
            formFindEmpPosition.ShowDialog();

            tbPosition.Text = formFindEmpPosition?.pickedRole?.Name;
            tbPosition.Tag = formFindEmpPosition?.pickedRole;
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbName.Text == "")
            {
                errorProvider.SetError(tbName, "Введите имя");
                return false;
            }
            if (!Regex.IsMatch(tbPhoneNum.Text, @"\d+"))
            {
                errorProvider.SetError(tbPhoneNum, "Введите номер числом");
                return false;
            }

            /*if (tbPassword.Text == "")
            {
                errorProvider.SetError(tbPassword, "Введите пароль");
                return false;
            }*/

            if (tbPosition.Tag == null)
            {
                errorProvider.SetError(btnFindPosition, "Выберите должность");
                return false;
            }
            if (tbWorkshop.Tag == null)
            {
                errorProvider.SetError(btnFindWorkshop, "Выберите филиал");
                return false;
            }

            return true;
        }

        private void FormManageManager_Load(object sender, EventArgs e)
        {
            if(manager.Id != 0)
            {
                tbName.Text = manager.Name;
                tbPhoneNum.Text = manager.PhoneNum;
                tbPassword.Text = manager.Password;     // скрывать если нету прав и рид онли
                numericSalary.Value = manager.Salary;
                tbPosition.Text = manager.Role.Name;
                tbPosition.Tag = manager.Role;
                tbWorkshop.Text = manager.Workshop.Location;
                tbWorkshop.Tag = manager.Workshop;
                tbInfo.Text = manager.AdditionalInfo;
            }
        }
    }
}

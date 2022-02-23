using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.employees.roles;
using Forms_TechServ.forms.employees.timetables;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.employees
{
    public partial class FormManageManager : Form
    {
        Manager manager;
        Size pickedSize = new Size(1078, 481);


        public FormManageManager()
        {
            InitializeComponent();

            manager = new Manager();

            btnAction.Text = "Добавить";

            managerTabs.TabPages.Remove(timetablePage);
        }

        public FormManageManager(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            btnAction.Text = "Сохранить общую информацию";

        }

        public FormManageManager(Workshop workshop)                  // добавление к конкретной мастерской
        {
            InitializeComponent();

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
                this.Size = new Size(776, 342); 
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
        }

        private void FormManageManager_ResizeEnd(object sender, EventArgs e)
        {
            if(!managerTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                manager.Name = tbName.Text;
                manager.PhoneNum = tbPhoneNum.Text;
                manager.Password = tbPassword.Text;
                manager.Salary = numericSalary.Value;
                manager.Remotely = checkBoxRemotely.Checked;

                manager.RoleId = ((Role)tbPosition.Tag).Id;
                manager.WorkshopId = ((Workshop)tbWorkshop.Tag).Id;
                
                manager.AdditionalInfo = tbInfo.Text;

                if(manager.Id == 0)
                {
                    if(manager.AddEmployee())
                    {
                        DialogResult answer = MessageBox.Show($"Новый сотрудник успешно добавлен. ID - {manager.Id}. Желаете добавить расписание?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        this.Hide();
                        if (answer == DialogResult.Yes)
                        {
                            FormManageManager formManageManager = new FormManageManager(ManagersList.GetById(manager.Id, true));
                            formManageManager.ShowDialog();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Сотрудник с таким номером телефона уже есть в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    manager.Role = (Role)tbPosition.Tag;                // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их
                    manager.Workshop = (Workshop)tbWorkshop.Tag;        // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их

                    if(manager.EditEmployee())
                    {
                        MessageBox.Show($"Данные о сотруднике успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Сотрудник с таким номером телефона уже есть в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Заполните корректно все обязательные поля!", "Неверное данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormRoles formFindEmpPosition = new FormRoles(manager);
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
                checkBoxRemotely.Checked = manager.Remotely;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

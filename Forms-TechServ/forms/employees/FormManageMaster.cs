using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.categories;
using Forms_TechServ.forms.employees.roles;
using Forms_TechServ.forms.employees.timetables;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.employees
{
    public partial class FormManageMaster : Form
    {
        Master master;
        int currentPage = 1;
        int rowsCount;
        Size pickedSize = new Size(1078, 481);


        public FormManageMaster()
        {
            InitializeComponent();

            master = new Master();
            btnAction.Text = "Добавить";

            masterTabs.TabPages.Remove(categoriesPage);
            masterTabs.TabPages.Remove(timetablePage);
        }

        public FormManageMaster(Master master)
        {
            InitializeComponent();

            btnAction.Text = "Сохранить общую информацию";

            this.master = master;
        }

        public FormManageMaster(Workshop workshop)                  // добавление к конкретной мастерской
        {
            InitializeComponent();

            master = new Master();
            btnAction.Text = "Сохранить";

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;

            btnFindWorkshop.Enabled = false;
        }



        private void masterTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (masterTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(776, 325);
            }
            else if (masterTabs.SelectedTab.Equals(categoriesPage))
            {
                this.Size = pickedSize;

   
            }
            else if(masterTabs.SelectedTab.Equals(timetablePage))
            {
                this.Size = pickedSize;

                FormEmpTimetalbe formTimetalbe = new FormEmpTimetalbe(master, false);

                formTimetalbe.TopLevel = false;
                formTimetalbe.FormBorderStyle = FormBorderStyle.None;
                timetablePage.Controls.Add(formTimetalbe);
                formTimetalbe.Dock = DockStyle.Fill;
                formTimetalbe.BringToFront();
                formTimetalbe.Show();
            }

        }

        private void FormManageMaster_ResizeEnd(object sender, EventArgs e)
        {
            if(!masterTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }


        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
            formCategories.ShowDialog();

            if(formCategories.category != null)
            {
                
                if (master.CheckMasterCategory(formCategories.category))
                {
                    MessageBox.Show("У мастера уже есть эта категория", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    master.AddMasterCategory(formCategories.category);
                    FillCategories();
                    MessageBox.Show("Новая категория успешно сохранена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }

        private void showCategoryBtn_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataCategories.SelectedRows.Count > 0)
            {
                FormShowCategory formShowCategory = new FormShowCategory(true, CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true));                       // вот тут просмотр
                formShowCategory.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите категорию");
            }
        }


        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormRoles formFindEmpPosition = new FormRoles(master);
            formFindEmpPosition.ShowDialog();

            tbPosition.Text = formFindEmpPosition?.pickedRole?.Name;
            tbPosition.Tag = formFindEmpPosition?.pickedRole;
            //formFindEmpPosition.pickedRole;
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                master.Name = tbName.Text;
                master.PhoneNum = tbPhoneNum.Text;
                master.Password = tbPassword.Text;
                master.Salary = numericSalary.Value;
                master.RoleId = ((Role)tbPosition.Tag).Id;
                master.WorkshopId = ((Workshop)tbWorkshop.Tag).Id;
                master.AdditionalInfo = tbInfo.Text;

                if (master.Id == 0)
                {
                    if (master.AddEmployee())
                    {
                        DialogResult answer = MessageBox.Show($"Новый сотрудник успешно добавлен. ID - {master.Id}. Желаете добавить расписание и категории?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        this.Hide();
                        if (answer == DialogResult.Yes)
                        {
                            FormManageMaster formManageMaster = new FormManageMaster(MastersList.GetById(master.Id, true));
                            formManageMaster.ShowDialog();
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
                    master.Role = (Role)tbPosition.Tag;                // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их
                    master.Workshop = (Workshop)tbWorkshop.Tag;        // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их

                    if (master.EditEmployee())
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

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbName.Text == "")
            {
                errorProvider.SetError(tbName, "Введите имя");
                return false;
            }
            if (tbPhoneNum.Text.Length < 14)
            {
                errorProvider.SetError(tbPhoneNum, "Введите номер полностью");
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

        private void FormManageMaster_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";

            dataCategories.Columns.Add(idCol);
            dataCategories.Columns.Add(nameCol);

            DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
            delCol.FlatStyle = FlatStyle.Flat;
            delCol.Name = "Удалить";
            dataCategories.Columns.Add(delCol);

            dataCategories.CellContentClick += DelCol_Click;

            comboBoxShowCatRows.Items.Add(5);
            comboBoxShowCatRows.Items.Add(20);
            comboBoxShowCatRows.Items.Add(30);
            comboBoxShowCatRows.Items.Add(40);
            comboBoxShowCatRows.SelectedIndex = 2;

            if (master.Id != 0)
            {
                tbName.Text = master.Name;
                tbPhoneNum.Text = master.PhoneNum;
                tbPassword.Text = master.Password;     // скрывать если нету прав и рид онли
                numericSalary.Value = master.Salary;
                tbPosition.Text = master.Role.Name;
                tbPosition.Tag = master.Role;
                tbWorkshop.Text = master.Workshop.Location;
                tbWorkshop.Tag = master.Workshop;
                tbInfo.Text = master.AdditionalInfo;

                FillCategories();
                //List<Category> categories = master.GetMasterCategories();
            }
        }

        private void FillCategories()
        {
            dataCategories.Rows.Clear();

            List<Category> cats = master.GetMasterCategories((int)comboBoxShowCatRows.SelectedItem, currentPage, out rowsCount);


            for (int i = 0; i < cats.Count; i++)
            {
                dataCategories.Rows.Add(new DataGridViewRow());

                dataCategories.Rows[i].Cells[0].Value = cats[i].Id;
                dataCategories.Rows[i].Cells[1].Value = cats[i].Name;

                if (dataCategories.Columns.Count > 2)
                {
                    dataCategories.Rows[i].Cells[2].Value = "Удалить";
                    dataCategories.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataCategories.Rows[i].Cells[2].Style.ForeColor = Color.White;

                }
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowCatRows.SelectedItem);
            numericCurrentCatPage.Maximum = maxPage;

            if (numericCurrentCatPage.Maximum > 0)
                numericCurrentCatPage.Value = numericCurrentCatPage.Value == 0 ? 1 : numericCurrentCatPage.Value;

            labelCatPagesCount.Text = $"из {maxPage}";
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Category categoryToDel = CategoriesList.GetById((int)dataCategories.SelectedRows[0].Cells[0].Value, false);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить у мастера категорию с id {categoryToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (master.DelMasterCategory(categoryToDel))
                    {
                        MessageBox.Show("Категорию у мастера успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillCategories();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void comboBoxShowCatRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCategories();
        }

        private void numericCurrentCatPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentCatPage.Value = (int)numericCurrentCatPage.Value;           // если ввели дробное число, оно автоматически округлится
            currentPage = (int)numericCurrentCatPage.Value;
            FillCategories();
        }

        private void btnNextCat_Click(object sender, EventArgs e)
        {
            numericCurrentCatPage.Value = numericCurrentCatPage.Value + 1 > numericCurrentCatPage.Maximum ? numericCurrentCatPage.Value : numericCurrentCatPage.Value + 1;
        }

        private void btnPrevCat_Click(object sender, EventArgs e)
        {
            numericCurrentCatPage.Value = numericCurrentCatPage.Value + 1 > numericCurrentCatPage.Maximum ? numericCurrentCatPage.Value : numericCurrentCatPage.Value + 1;
        }


        private void dataCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShowCategory formShowCategory = new FormShowCategory(true, CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true));                       // вот тут просмотр
            formShowCategory.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

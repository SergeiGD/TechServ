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
    public partial class FormManageMaster : Form
    {
        //Workshop workshop;
        Master master;
        //List<Category> catsToBeAdded = new List<Category>();
        int currentPage = 1;
        int rowsCount;
        Size pickedSize = new Size(1078, 481);

        //TabPage ordersPage = new TabPage("Заказы");
        //TabPage visitsPage = new TabPage("Выезды");

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

            //masterTabs.TabPages.Add(ordersPage);
            //masterTabs.TabPages.Add(visitsPage);

            //this.master = master;
            btnAction.Text = "Сохранить";

            this.master = master;
        }

        public FormManageMaster(Workshop workshop)                  // добавление к конкретной мастерской
        {
            InitializeComponent();

            //masterTabs.TabPages.Add(ordersPage);
            //masterTabs.TabPages.Add(visitsPage);

            //this.master = master;
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

                /*FormCategories formCategories = new FormCategories(3, false);

                formCategories.TopLevel = false;
                formCategories.FormBorderStyle = FormBorderStyle.None;
                categoriesPage.Controls.Add(formCategories);
                formCategories.Dock = DockStyle.Fill;
                formCategories.BringToFront();
                formCategories.Show();*/
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
            /*else if (masterTabs.SelectedTab.Equals(ordersPage))
            {
                this.Size = pickedSize;

                FormOrders formOrders = new FormOrders("ad", false);

                formOrders.TopLevel = false;
                formOrders.FormBorderStyle = FormBorderStyle.None;
                ordersPage.Controls.Add(formOrders);
                formOrders.Dock = DockStyle.Fill;
                formOrders.BringToFront();
                formOrders.Show();
            }
            else if (masterTabs.SelectedTab.Equals(visitsPage))
            {
                this.Size = pickedSize;

                FormVisits formVisits = new FormVisits("asd", false);

                formVisits.TopLevel = false;
                formVisits.FormBorderStyle = FormBorderStyle.None;
                visitsPage.Controls.Add(formVisits);
                formVisits.Dock = DockStyle.Fill;
                formVisits.BringToFront();
                formVisits.Show();
            }*/
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

            //Category cat = formCategories.category;
            if(formCategories.category != null)
            {
                //catsToBeAdded.Add(formCategories.category);
                
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

        private void addTimetableBtn_Click(object sender, EventArgs e)
        {
            //FormAddEmployeeTimetable formAddEmployeeTimetable = new FormAddEmployeeTimetable(master);
            //formAddEmployeeTimetable.ShowDialog();
        }

        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            FormFindEmpPosition formFindEmpPosition = new FormFindEmpPosition();
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
                    master.AddMaster();

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
                    master.Role = (Role)tbPosition.Tag;                // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их
                    master.Workshop = (Workshop)tbWorkshop.Tag;        // чтоб не было конфликта нав. свойств при изменение, вручную полностью сменим их

                    master.EditMaster();

                    MessageBox.Show($"Данные о сотруднике успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
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

        private void FormManageMaster_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";

            dataCategories.Columns.Add(idCol);
            dataCategories.Columns.Add(nameCol);

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
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowCatRows.SelectedItem);
            numericCurrentCatPage.Maximum = maxPage;

            if (numericCurrentCatPage.Maximum > 0)
                numericCurrentCatPage.Value = numericCurrentCatPage.Value == 0 ? 1 : numericCurrentCatPage.Value;

            labelCatPagesCount.Text = $"из {maxPage}";
        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы уверены что хотите убрать эту категорию у мастера?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if(answer == DialogResult.Yes)
            {
                if (dataCategories.SelectedRows.Count > 0)
                {
                    if (master.DelMasterCategory(CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true)))
                    {
                        FillCategories();
                        MessageBox.Show("Категория успешно удалена");
                    }
                    else
                    {
                        MessageBox.Show("У мастера нету такой категории", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Для начала выберите категорию");
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

        /*private void deleteTimetableBtn_Click(object sender, EventArgs e)
        {

        }*/

        private void dataCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShowCategory formShowCategory = new FormShowCategory(true, CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true));                       // вот тут просмотр
            formShowCategory.ShowDialog();
        }
    }
}

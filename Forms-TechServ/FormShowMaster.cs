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

    public partial class FormShowMaster : Form
    {
        Master master;
        Size pickedSize = new Size(1078, 481);
        int currentPage = 1;
        int rowsCount;
        bool readOnly;

        public FormShowMaster(bool readOnly, Master master)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            this.master = master;
        }

        private void FormShowMaster_Load(object sender, EventArgs e)
        {
            this.Size = new Size(672, 323);
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

            /*if (UserSession.Can("edit_employee"))
            {
                editBtn.Enabled = true;
            }
            else
            {
                editBtn.Visible = false;
            }

            if (UserSession.Can("add_del_employee"))
            {
                deleteBtn.Visible = true;
            }
            else
            {
                deleteBtn.Visible = false;
            }*/

            FillForm();
        }

        private void FillForm()
        {
            labelID.Text = master.Id.ToString();
            labelName.Text = master.Name;
            labelPhoneNum.Text = master.PhoneNum;
            labelSalary.Text = master.Salary.ToString();
            if (UserSession.Can("edit_employee"))                       // скрываем пароль, если нету прав на редактирование сотрудника
            {
                labelPassword.Text = master.Password;
            }
            else
            {
                labelPassword.Text = "******";
            }
            labelPosition.Text = master.Role.Name;
            labelWorkshop.Text = master.Workshop.Location;
            tbAdditionInfo.Text = master.AdditionalInfo;


            FillCategories();
        }

        private void masterTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (masterTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(672, 323);
            }
            else if (masterTabs.SelectedTab.Equals(categoriesPage))
            {
                this.Size = pickedSize;

                /*FormCategories formCategories = new FormCategories(3, true);

                formCategories.TopLevel = false;
                formCategories.FormBorderStyle = FormBorderStyle.None;
                categoriesPage.Controls.Add(formCategories);
                formCategories.Dock = DockStyle.Fill;
                formCategories.BringToFront();
                formCategories.Show();*/

            }
            else if (masterTabs.SelectedTab.Equals(timetablePage))
            {
                this.Size = pickedSize;

                FormEmpTimetalbe formTimetalbe = new FormEmpTimetalbe(master, true);

                formTimetalbe.TopLevel = false;
                formTimetalbe.FormBorderStyle = FormBorderStyle.None;
                timetablePage.Controls.Add(formTimetalbe);
                formTimetalbe.Dock = DockStyle.Fill;
                formTimetalbe.BringToFront();
                formTimetalbe.Show();

                /*FormCategories formCategories = new FormCategories(3, true);

                formCategories.TopLevel = false;
                formCategories.FormBorderStyle = FormBorderStyle.None;
                categoriesPage.Controls.Add(formCategories);
                formCategories.Dock = DockStyle.Fill;
                formCategories.BringToFront();
                formCategories.Show();*/
            }
            else if (masterTabs.SelectedTab.Equals(ordersPage))
            {
                this.Size = pickedSize;

                FormOrders formOrders = new FormOrders("ad", true);

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

                FormVisits formVisits = new FormVisits(master);

                formVisits.TopLevel = false;
                formVisits.FormBorderStyle = FormBorderStyle.None;
                visitsPage.Controls.Add(formVisits);
                formVisits.Dock = DockStyle.Fill;
                formVisits.BringToFront();
                formVisits.Show();
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageMaster formManageMaster = new FormManageMaster(master);
            formManageMaster.ShowDialog();

            FillForm();
        }

        private void btnShowCat_Click(object sender, EventArgs e)
        {
            if(dataCategories.SelectedRows.Count > 0)
            {
                FormShowCategory formShowCategory = new FormShowCategory(true, CategoriesList.GetById(Convert.ToInt32(dataCategories.SelectedRows[0].Cells[0].Value), true));                       // вот тут просмотр
                formShowCategory.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите категорию");
            }
        }

        private void labelWorkshop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowWorkshop formShowWorkshop = new FormShowWorkshop(true, master.Workshop);
            formShowWorkshop.ShowDialog();
        }

        private void FormShowMaster_ResizeEnd(object sender, EventArgs e)
        {
            if (!masterTabs.SelectedTab.Equals(generalPage))
            {
                pickedSize = this.Size;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить этого сотрудника?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                master.DelMaster();

                MessageBox.Show("Сотрудник успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                return;
            }
        }

        private void comboBoxShowCatRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCategories();
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
    }
}

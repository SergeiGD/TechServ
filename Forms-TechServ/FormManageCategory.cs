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
    public partial class FormManageCategory : Form
    {
        Category category;
        Size pickedSize = new Size(1078, 481);

        public FormManageCategory()                                     // ЕСЛИ ДОБАВЛЯЕМ 
        {
            InitializeComponent();

            categoriesTab.TabPages.Remove(servicesPage);

            category = new Category();
            actionBtn.Text = "Добавить";
        }

        public FormManageCategory(Category category)                      // ЕСЛИ ИЗМЕНЯЕМ
        {
            InitializeComponent();

            this.category = category;
            actionBtn.Text = "Сохранить";
        }

        private void categoriesTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesTab.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(489, 208);
            }
            else if (categoriesTab.SelectedTab.Equals(servicesPage))
            {
                this.Size = pickedSize;

                FormServices formServices = new FormServices(false, category);

                //formOrders.Controls.Remove(formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelControl").First());
                //formOrders.Size = formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelContent").First().Size;
                //formOrders.Controls.OfType<Panel>().Where(p => p.Name == "panelContent").First().Dock = DockStyle.Fill;
                formServices.TopLevel = false;
                formServices.FormBorderStyle = FormBorderStyle.None;
                servicesPage.Controls.Add(formServices);
                //panelContent.Controls.Add(childForm);
                formServices.Dock = DockStyle.Fill;
                formServices.BringToFront();
                formServices.Show();
            }
        }

        private void FormManageCategory_ResizeEnd(object sender, EventArgs e)
        {
            if(!categoriesTab.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void btnFinaParentCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
            formCategories.ShowDialog();

            if(formCategories.category != null && category.Id == formCategories.category.Id)
            {
                MessageBox.Show("Категория не может быть родительской по отношению к самой себе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbParentCat.Text = formCategories?.category?.Name;
                tbParentCat.Tag = formCategories?.category;
            }
            
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                category.Name = tbName.Text;
                category.ParentCategoryId = ((Category)tbParentCat?.Tag)?.Id;

                if(category.Id == 0)
                {
                    category.AddCategory();

                    DialogResult answer = MessageBox.Show($"Новая категория успешно добавлена. ID - {category.Id}. Желаете добавить сразу же добавить услуги?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    this.Hide();

                    if (answer == DialogResult.Yes)
                    {
                        FormManageCategory formManageCategory = new FormManageCategory(CategoriesList.GetById(category.Id, true));
                        formManageCategory.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    category.ParentCategory = (Category)tbParentCat?.Tag;

                    category.EditCategory();
                    MessageBox.Show($"Данные о категории успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCleanParentCat_Click(object sender, EventArgs e)
        {
            tbParentCat.Clear();
            tbParentCat.Tag = null;
        }

        private void FormManageCategory_Load(object sender, EventArgs e)
        {
            if(category.Id != 0)
            {
                tbName.Text = category.Name;
                tbParentCat.Text = category?.ParentCategory?.Name;
                tbParentCat.Tag = category?.ParentCategory;
            }
        }
    }
}

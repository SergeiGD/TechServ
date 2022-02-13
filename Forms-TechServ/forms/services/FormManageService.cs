using System;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.services;
using Forms_TechServ.forms.categories;

namespace Forms_TechServ.forms.services
{
    public partial class FormManageService : Form
    {
        Service service;
        public FormManageService()
        {
            InitializeComponent();
            btnAction.Text = "Добавить";

            service = new Service();
        }

        public FormManageService(Service service)
        {
            InitializeComponent();
            btnAction.Text = "Сохранить";

            this.service = service;
        }

        public FormManageService(Category category)                     // добавление из категории    (категория зафиксирована и не может быть изменена)
        {
            InitializeComponent();
            btnAction.Text = "Сохранить";

            service = new Service();

            tbCat.Text = category.Name;
            tbCat.Tag = category;
            btnFindCat.Enabled = false;
        }

        private void btnFindCat_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(true);
            formCategories.ShowDialog();

            tbCat.Text = formCategories?.category?.Name;
            tbCat.Tag = formCategories?.category;
        }
        
        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbName.Text == "")
            {
                errorProvider.SetError(tbName, "Введите наименование");
                return false;
            }
            if(tbCat.Tag == null)
            {
                errorProvider.SetError(btnFindCat, "Выберите категорию");
                return false;
            }

            return true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                service.Name = tbName.Text;
                service.Price = numeriсPrice.Value;
                service.AvgServiceTime = TimeSpan.FromMinutes((double)numericAvgTime.Value);
                service.CategoryId = ((Category)tbCat.Tag).Id;
                service.Description = tbDescription.Text;

                if(service.Id == 0)
                {
                    service.AddService();
                    MessageBox.Show($"Новая услуга успшено добавлена. ID - {service.Id}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    service.Category = (Category)tbCat.Tag;
                    service.EditSerive();

                    MessageBox.Show($"Данные о технике успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void FormManageService_Load(object sender, EventArgs e)
        {
            if(service.Id != 0)
            {
                tbName.Text = service.Name;
                tbCat.Text = service.Category.Name;
                tbCat.Tag = service.Category;
                numeriсPrice.Value = service.Price;
                numericAvgTime.Value = (decimal)service.AvgServiceTime.TotalMinutes;
                tbDescription.Text = service.Description;
            }
        }

        private void btnPriceInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPriceInfo.SetToolTip(btnPriceInfo, "Цена на услугу в заказе формируется в момент добавления услуги в заказ, поэтому цена в заказах может не совпадать с указанной ценой");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

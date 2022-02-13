using System;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.services;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.forms.categories;

namespace Forms_TechServ.forms.services
{
    public partial class FormShowService : Form
    {
        private readonly bool readOnly;
        private readonly Service service;

        public FormShowService(bool readOnly, Service service)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            this.service = service;
        }

        /*public FormShowService(int order)               // ПРИ УДАЛЕНИЕ БУДЕТ ДВА МЕТОДА И В КОНСТРУТКРАХ СОБЫТИЯ К НИМ ПРИВЯЗЫВАТЬСЯ
        {
            InitializeComponent();

            readOnly = true;

            
        }*/


        private void FormShowService_Load(object sender, EventArgs e)
        {
            if (readOnly || !UserSession.Can("edit_service") && !UserSession.Can("add_del_service"))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                Width = Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_service");
                deleteBtn.Enabled = UserSession.Can("add_del_service");
            }

            FillForm();
            /*EditButton editButton = new EditButton();
            editButton.Text = "Редактировать";
            panelEdit.Controls.Add(editButton);

            EditButton deleteButton = new EditButton();
            deleteButton.Text = "Удалить";
            panelEdit.Controls.Add(deleteButton);

            EditButton cancelButton = new EditButton();
            cancelButton.Text = "Закрыть";
            panelEdit.Controls.Add(cancelButton);

            int size = (panelEdit.Height / 3) / 2;
            EditButton[] mainBtn = panelEdit.Controls.OfType<EditButton>().ToArray();
            mainBtn[0].Location = new Point(0, size);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height + size);
            }*/
        }

        private void FillForm()
        {
            labelID.Text = service.Id.ToString();
            labelName.Text = service.Name;
            labelCat.Text = service.Category.Name;
            labelPrice.Text = service.Price.ToString();
            labelAvgTime.Text = service.AvgServiceTime.ToString();
            tbDescription.Text = service.Description;
            //labelCat.Tag = product.Category;
        }

        private void linkPickedCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formShowCategory = new FormShowCategory(true, service.Category); // во тут просмотр категории
            formShowCategory.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var formManageService = new FormManageService(service);
            formManageService.ShowDialog();

            FillForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Вы действительно хотите удалить эту услугу?", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                service.DelService();

                MessageBox.Show("Услуга успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
            }
        }

        private void btnPriceInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPriceInfo.SetToolTip(btnPriceInfo,
                "Цена на услугу в заказе формируется в момент добавления услуги в заказ, поэтому цена в заказах может не совпадать с указанной ценой");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
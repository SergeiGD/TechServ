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
    public partial class FormShowService : Form
    {
        bool readOnly;
        public FormShowService(bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;
        }

        /*public FormShowService(int order)               // ПРИ УДАЛЕНИЕ БУДЕТ ДВА МЕТОДА И В КОНСТРУТКРАХ СОБЫТИЯ К НИМ ПРИВЯЗЫВАТЬСЯ
        {
            InitializeComponent();

            readOnly = true;

            
        }*/


        private void FormShowService_Load(object sender, EventArgs e)
        {

            if (readOnly)
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
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

        private void linkPickedCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowCategory formShowCategory = new FormShowCategory(true, null);               // во тут просмотр категории
            formShowCategory.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageService formManageService = new FormManageService("asd");
            formManageService.ShowDialog();
        }
    }
}

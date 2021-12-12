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
    public partial class FormShowCategory : Form
    {
        Category category;
        Size pickedSize = new Size(1078, 481);
        bool readOnly;

        public FormShowCategory(bool readOnly, Category category)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.category = category;
        }

        private void FormShowCategory_Load(object sender, EventArgs e)
        {
            if (readOnly || (!UserSession.Can("edit_category") && !UserSession.Can("add_del_category")))      // если просто просмотр или нету прав на изменения
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_category");
                deleteBtn.Enabled = UserSession.Can("add_del_category");
            }

            FillForm();
        }

        private void FillForm()
        {
            labelID.Text = category.Id.ToString();
            labelName.Text = category.Name;

            using (TechContext db = new TechContext())                                      // заполнение дерева
            {
                treeCats.Nodes.Clear();
                Category currentCat = db.Categories.Find(category.Id);
                TreeNode currentNode = new TreeNode(currentCat.Name);
                db.Entry(currentCat).Reference(c => c.ParentCategory).Load();

                while (currentCat.ParentCategory != null)
                {

                    currentCat = currentCat.ParentCategory;
                    db.Entry(currentCat).Reference(c => c.ParentCategory).Load();

                    TreeNode newNode = new TreeNode(currentCat.Name);
                    newNode.Nodes.Add(currentNode);

                    currentNode = newNode;

                }

                treeCats.Nodes.Add(currentNode);
                treeCats.ExpandAll();
            }
         

            labelParentCat.Text = category.ParentCategory == null ? "Отсутствует" : category.ParentCategory.Name;
        }

        private void servicesTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesTab.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(452, 396);
            }
            else if (categoriesTab.SelectedTab.Equals(servicesPage))
            {
                //this.Size = new Size(1078, 481);
                this.Size = pickedSize;

                FormServices formServices = new FormServices("asd", true);

                formServices.TopLevel = false;
                formServices.FormBorderStyle = FormBorderStyle.None;
                servicesPage.Controls.Add(formServices);
                formServices.Dock = DockStyle.Fill;
                formServices.BringToFront();
                formServices.Show();
            }
        }

        private void FormShowCategory_ResizeEnd(object sender, EventArgs e)
        {
            if(!categoriesTab.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory(category);
            formManageCategory.ShowDialog();

            FillForm();
        }

        private void labelParentCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(category.ParentCategory != null)
            {
                FormShowCategory formShowCategory = new FormShowCategory(true, category.ParentCategory);
                formShowCategory.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить эту категорию?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                if (category.DelCategory())
                {
                    MessageBox.Show("Сотрудник успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("У данной категории есть дочерние элементы, пока ее нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;
            }
        }
    }
}

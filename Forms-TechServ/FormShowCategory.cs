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
            treeCats.Nodes.Clear();
            labelParentCat.Text = category.ParentCategory == null ? "Отсутствует" : category.ParentCategory.Name;


            // ПОСТРОЕНИЯ ИЕРАРХИЧЕСКОГО ДЕРЕВА КАТЕГОРИЙ
            treeCats.Nodes.Clear();
            LinkedList<Category> categoriesBranch = category.GetWholeBranch();

            Category firstCat = categoriesBranch.First();

            TreeNode newNode = null;


            Gethildern(firstCat);
            // РЕКУРСИЕЙ ИЩЕМ ВСЕ ДОЧЕРИНИЕ ЭЛЕМЕНТЫ
            void Gethildern(Category childCat)
            {
                

                foreach (Category subItem in categoriesBranch.Where(c => c.ParentCategoryId == childCat.Id))
                {
                    
                    Gethildern(subItem);


                    // НАЧИНАЕТСЯ ФОРМИРОВАНИЕ С САМОГО КОНЦА
                    // ЕСЛИ У ТЕКУЩЕГО ЭЛЕМЕНТА УЖЕ ЕСТЬ ДОЧЕРНИЕ ЭЛЕМЕНТЫ В ДЕРЕВЕ, ТО ДОБАВЛЯЕМ ИХ К НЕМУ
                    if (newNode != null && newNode.Tag != null && (int)newNode.Tag == subItem.Id)
                    {
                        newNode = new TreeNode(subItem.Name) { Name = subItem.Name, Tag = subItem.ParentCategoryId };
                        

                        List<TreeNode> tempNodes = new List<TreeNode>();
                        foreach(TreeNode item in treeCats.Nodes)
                        {
                            if((int)item.Tag == subItem.Id)
                            {
                                newNode.Nodes.Add((TreeNode)item.Clone());
                            }
                            else
                            {
                                tempNodes.Add((TreeNode)item.Clone());
                            }
                        }
                        treeCats.Nodes.Clear();
                        treeCats.Nodes.Add(newNode);
                        treeCats.Nodes.AddRange(tempNodes.ToArray());
                    }
                    // ИНАЧЕ ДОБАВЛЯЕМ КАК ОТДЕЛЬНЫЙ УЗЕЛ
                    else
                    {
                        newNode = new TreeNode(subItem.Name) { Name = subItem.Name, Tag = subItem.ParentCategoryId };
                        
                        treeCats.Nodes.Add(newNode);
                    }  

                }

            }

            // Т.К. В ДЕРЕВЕ ПОКА НЕТУ САМОГО ГЛАВНОГО (ПЕРВОГО) ЭЛЕМЕНТА, ДОБАВИМ ЕГО
            TreeNode mainParent = new TreeNode(firstCat.Name) { Name = firstCat.Name };
            foreach (TreeNode node in treeCats.Nodes)
            {
                mainParent.Nodes.Add((TreeNode)node.Clone());
            }
            treeCats.Nodes.Clear();
            treeCats.Nodes.Add(mainParent);
            


            // ЕСЛИ ТЕКУЩАЯ КАТЕГОРИЯ НЕ ЯВЛЯЕТСЯ ВЕРХНЕЙ В ВЕТКЕ, ТО ИЩЕМ И ВЫДЕЛЯЕМ, А ТАКЖЕ СВОРЧАЕМ ЕЕ ДОЧЕРНИЕ УЗЛЫ
            if (category.Name != firstCat.Name)
            {
                TreeNode itemNode = null;
                foreach (TreeNode node in treeCats.Nodes)
                {
                    itemNode = FindNodeByName(category.Name, node);
                    if (itemNode != null) break;
                }

                treeCats.ExpandAll();
                itemNode.Collapse(false);
                itemNode.BackColor = Color.Yellow;
                
            }
            // ИНАЧЕ ПРОСТО ВЫДЕЛЯЕМ КАТЕГОРИЮ
            else
            {
                treeCats.Nodes[0].BackColor = Color.Yellow;
            }

            // РЕКУРСИВНЫЙ МЕТОД ДЛЯ ПОИСК УЗЛА ПО ИМЕНИ
            TreeNode FindNodeByName(string itemName, TreeNode rootNode)
            {
                foreach (TreeNode node in rootNode.Nodes)
                {
                    if (node.Name.Equals(itemName)) return node;
                    TreeNode next = FindNodeByName(itemName, node);
                    if (next != null) return next;
                }
                return null;
            }



            
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

                FormServices formServices = new FormServices(true, category);

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

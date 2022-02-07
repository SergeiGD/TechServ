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
    public partial class FormManageSparePart : Form
    {
        Size pickedSize = new Size(989, 408);
        SparePart sparePart;
        /*int rowsCount;
        int currentPage = 1;*/

        public FormManageSparePart()                                                // ЕСЛИ ДОБАВИЛИ НОВУЮ ДЕТАЛИ, ТО ПОСЛЕ ДОБАВЛЕНИЯ ПРЕДЛАГАТЬ ЗАКАЗАТЬ СРАЗУ
        {
            InitializeComponent();

            //sparePartTabs.TabPages.Remove(stockPage);

            sparePart = new SparePart();
            btnAction.Text = "Добавить";
            //sparePartTabs.TabPages.Remove(stockPage);

            //checkPrepayment.Checked = false;
        }

        public FormManageSparePart(SparePart sparePart)
        {
            InitializeComponent();

            this.sparePart = sparePart;
            btnAction.Text = "Сохранить";
        }

        private void FormManageSparePart_Load(object sender, EventArgs e)
        {
            this.Size = new Size(437, 183);

            

            if (sparePart.Id != 0)
            {
                tbName.Text = sparePart.Name;
                numericPrepayment.Value = sparePart.ClientPrepayment;

                /*comboBoxShowRows.Items.Add(5);
                comboBoxShowRows.Items.Add(20);
                comboBoxShowRows.Items.Add(30);
                comboBoxShowRows.Items.Add(40);
                comboBoxShowRows.SelectedIndex = 2;*/

                //FillInStock();
            }
        }

        /*private void FillInStock()
        {
            List<Workshop> workshops = WorkshopsList.GetWorkshops(new Workshop(), true, "Id", (int)comboBoxShowRows.SelectedItem, currentPage, out rowsCount);

            dataInStock.Rows.Clear();

            for (int i = 0; i < workshops.Count; i++)
            {
                dataInStock.Rows.Add(new DataGridViewRow());

                dataInStock.Rows[i].Cells[0].Value = workshops[i].Id;
                dataInStock.Rows[i].Cells[1].Value = workshops[i].Location;
                dataInStock.Rows[i].Cells[2].Value = workshops[i].PhoneNum;
                //dataInStock.Rows[i].Cells[3].Value = workshops[i].GetCountInStock((Workshop)tbWorkshop.Tag);                         // вот сюда кол-во в наличие
                dataInStock.Rows[i].Cells[3].Value = sparePart.GetCountInStock(workshops[i]);
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";
        }*/

        private void FormManageSparePart_ResizeEnd(object sender, EventArgs e)
        {
            if(!sparePartTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void sparePartTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (sparePartTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(437, 183);
            }
            else if (sparePartTabs.SelectedTab.Equals(stockPage))
            {
                this.Size = pickedSize;

            }*/
        }

        private void btnAddToBatch_Click(object sender, EventArgs e)
        {
            FormManageBatch formManageBatch = new FormManageBatch();        // СДЕЛАТЬ ЧТОБ ПРИ ЭТОМ В ГРИД СРАЗУ ДОБАВЛЯЛАСЬ ЗАПЧАТЬ НА КОТОРОЙ 
            formManageBatch.ShowDialog();
        }

        

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbName.Text == null && tbName.Text == string.Empty)
            {
                errorProvider.SetError(tbName, "Введите наименование");
                return false;
            }
            return true;
        }

        private void btnPrepaymentInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPrepayment.SetToolTip(btnPrepaymentInfo, "Ноль, если не нужна");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                sparePart.Name = tbName.Text;
                sparePart.ClientPrepayment = numericPrepayment.Value;

                if(sparePart.Id == 0)
                {
                    if (sparePart.AddSparePart())
                    {
                        MessageBox.Show($"Новая запчасть успешно добавлен. ID - {sparePart.Id}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (sparePart.EditSparePart())
                    {
                        MessageBox.Show("Информация о запчасти успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка обноваления", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

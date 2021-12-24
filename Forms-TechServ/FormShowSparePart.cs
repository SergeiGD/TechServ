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
    public partial class FormShowSparePart : Form
    {
        SparePart sparePart;
        bool readOnly;
        int rowsCount;
        int currentPage = 1;
        Size pickedSize = new Size(772, 392);

        public FormShowSparePart(bool readOnly, SparePart sparePart)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.sparePart = sparePart;
        }

        private void FormShowSparePart_Load(object sender, EventArgs e)
        {
            if (readOnly || (!UserSession.Can("edit_sparePart") && !UserSession.Can("add_del_sparePart")))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_sparePart");
                deleteBtn.Enabled = UserSession.Can("add_del_sparePart");
            }

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            FillForm();
            this.Size = new Size(550, 217);
        }

        private void FillForm()
        {
            labelID.Text = sparePart.Id.ToString();
            labelName.Text = sparePart.Name;
            labelPrepayment.Text = sparePart.ClientPrepayment.ToString();

            FillInStock();
        }

        private void FillInStock()
        {
            List<Workshop> workshops = WorkshopsList.GetWorkshops(new Workshop(), true, "Id", (int)comboBoxShowRows.SelectedItem, currentPage, out rowsCount);

            dataInStock.Rows.Clear();

            for(int i = 0; i < workshops.Count; i++)
            {
                dataInStock.Rows.Add(new DataGridViewRow());

                dataInStock.Rows[i].Cells[0].Value = workshops[i].Id;
                dataInStock.Rows[i].Cells[1].Value = workshops[i].Location;
                dataInStock.Rows[i].Cells[2].Value = workshops[i].PhoneNum;
                //dataInStock.Rows[i].Cells[3].Value = workshops[i].GetCountInStock((Workshop)tbWorkshop.Tag);                         // вот сюда кол-во в наличие
                dataInStock.Rows[i].Cells[3].Value = sparePart.GetCountInStock(workshops[i]);
                dataInStock.Rows[i].Cells[4].Value = sparePart.GetCountInTransit(workshops[i]);                         // вот сюда кол-во в пути
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void sparePartTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sparePartTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(550, 217);
            }
            else if (sparePartTabs.SelectedTab.Equals(stockPage))
            {
                this.Size = pickedSize;

                /*FormSpareParts formSpareParts= new FormSpareParts("ad");


                formSpareParts.TopLevel = false;
                formSpareParts.FormBorderStyle = FormBorderStyle.None;
                stockPage.Controls.Add(formSpareParts);
                //panelContent.Controls.Add(childForm);
                formSpareParts.Dock = DockStyle.Fill;
                formSpareParts.BringToFront();
                formSpareParts.Show();*/
            }
        }

        private void FormShowSparePart_ResizeEnd(object sender, EventArgs e)
        {
            pickedSize = this.Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageSparePart formManageSparePart = new FormManageSparePart(sparePart);
            formManageSparePart.ShowDialog();

            FillForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить эту запачать?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //sparePart.DelSparePart();
                if (sparePart.DelSparePart())
                {
                    MessageBox.Show("Запчать успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Есть не истраченные запчасти этого типа, пока ее удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataInStock_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShowWorkshop formShowWorkshop = new FormShowWorkshop(true, WorkshopsList.GetById(Convert.ToInt32(dataInStock.SelectedRows[0].Cells[0].Value)));
            formShowWorkshop.ShowDialog();
        }
    }
}

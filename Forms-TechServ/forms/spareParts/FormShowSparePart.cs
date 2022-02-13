using System;
using System.Drawing;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.classes.workshops;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.spareParts
{
    public partial class FormShowSparePart : Form
    {
        private readonly int currentPage = 1;
        private Size pickedSize = new Size(772, 392);
        private readonly bool readOnly;
        private int rowsCount;
        private readonly SparePart sparePart;

        public FormShowSparePart(bool readOnly, SparePart sparePart)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.sparePart = sparePart;
        }

        private void FormShowSparePart_Load(object sender, EventArgs e)
        {
            if (readOnly || !UserSession.Can("edit_sparePart") && !UserSession.Can("add_del_sparePart"))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                Width = Width - panelEdit.Width;
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
            Size = new Size(550, 217);
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
            var workshops = WorkshopsList.GetWorkshops(new Workshop(), true, "Id", (int) comboBoxShowRows.SelectedItem,
                currentPage, out rowsCount);

            dataInStock.Rows.Clear();

            for (var i = 0; i < workshops.Count; i++)
            {
                dataInStock.Rows.Add(new DataGridViewRow());

                dataInStock.Rows[i].Cells[0].Value = workshops[i].Id;
                dataInStock.Rows[i].Cells[1].Value = workshops[i].Location;
                dataInStock.Rows[i].Cells[2].Value = workshops[i].PhoneNum;
                //dataInStock.Rows[i].Cells[3].Value = workshops[i].GetCountInStock((Workshop)tbWorkshop.Tag);                         // вот сюда кол-во в наличие
                dataInStock.Rows[i].Cells[3].Value = sparePart.GetCountInStock(workshops[i]);
                dataInStock.Rows[i].Cells[4].Value =
                    sparePart.GetCountInTransit(workshops[i]); // вот сюда кол-во в пути
            }

            var maxPage = (int) Math.Ceiling((double) rowsCount / (int) comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void sparePartTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sparePartTabs.SelectedTab.Equals(generalPage))
                Size = new Size(550, 217);
            else if (sparePartTabs.SelectedTab.Equals(stockPage))
                Size = pickedSize;
            /*FormSpareParts formSpareParts= new FormSpareParts("ad");


                formSpareParts.TopLevel = false;
                formSpareParts.FormBorderStyle = FormBorderStyle.None;
                stockPage.Controls.Add(formSpareParts);
                //panelContent.Controls.Add(childForm);
                formSpareParts.Dock = DockStyle.Fill;
                formSpareParts.BringToFront();
                formSpareParts.Show();*/
        }

        private void FormShowSparePart_ResizeEnd(object sender, EventArgs e)
        {
            pickedSize = Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var formManageSparePart = new FormManageSparePart(sparePart);
            formManageSparePart.ShowDialog();

            FillForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Вы действительно хотите удалить эту запачать?", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //sparePart.DelSparePart();
                if (sparePart.DelSparePart())
                {
                    MessageBox.Show("Запчать успешно удалена", "Готово", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Есть не истраченные запчасти этого типа, пока ее удалить нельзя", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataInStock_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var formShowWorkshop = new FormShowWorkshop(true,
                WorkshopsList.GetById(Convert.ToInt32(dataInStock.SelectedRows[0].Cells[0].Value)));
            formShowWorkshop.ShowDialog();
        }
    }
}
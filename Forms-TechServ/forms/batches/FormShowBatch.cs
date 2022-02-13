using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.batches;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.forms.spareParts;
using Forms_TechServ.forms.workshops;

namespace Forms_TechServ.forms.batches
{
    public partial class FormShowBatch : Form
    {
        Batch batch;
        int rowsCount;
        int currentPage = 1;
        bool readOnly;
        Size pickedSize = new Size(800, 397);

        public FormShowBatch(bool readOnly, Batch batch)
        {
            InitializeComponent();

            this.readOnly = readOnly;

            this.batch = batch;
        }

        private void FormShowBatch_Load(object sender, EventArgs e)
        {
            this.Size = new Size(438, 305);

            if (readOnly || (!UserSession.Can("edit_batch") && !UserSession.Can("add_del_batch")))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_batch");
                deleteBtn.Enabled = UserSession.Can("add_del_batch");
            }

            comboBoxShowSparePartsRows.Items.Add(5);
            comboBoxShowSparePartsRows.Items.Add(20);
            comboBoxShowSparePartsRows.Items.Add(30);
            comboBoxShowSparePartsRows.Items.Add(40);
            comboBoxShowSparePartsRows.SelectedIndex = 2;

            FillForm();

        }

        private void FillForm()
        {
            labelID.Text = batch.Id.ToString();
            labelTrackNum.Text = batch.TrackNumber;
            labelWorkshop.Text = batch.Workshop.Location;
            labelStatus.Text = batch.Status.ToString();
            if (batch.DateDelivered.HasValue)
            {
                labelDelivered.Text = batch.DateDelivered.Value.ToShortDateString();
            }
            else
            {
                labelDelivered.Text = "В пути";
            }

            FillSpareParts();
        }

        private void FillSpareParts()
        {
            List<BatchSparePart> spareParts = batch.GetSpareParts(
                (int)comboBoxShowSparePartsRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataSpareParts.Rows.Clear();
            for (int i = 0; i < spareParts.Count; i++)
            {
                dataSpareParts.Rows.Add(new DataGridViewRow());

                dataSpareParts.Rows[i].Cells[0].Value = spareParts[i].SparePartId;
                dataSpareParts.Rows[i].Cells[1].Value = spareParts[i].SparePart.Name;
                dataSpareParts.Rows[i].Cells[2].Value = spareParts[i].UnitPrice;
                dataSpareParts.Rows[i].Cells[3].Value = spareParts[i].Quantity;
                dataSpareParts.Rows[i].Cells[4].Value = spareParts[i].Batch.GetCountLeft(spareParts[i].SparePart);
                dataSpareParts.Rows[i].Cells[5].Value = spareParts[i].Quantity * spareParts[i].UnitPrice;

            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowSparePartsRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void btnShowSparePart_Click(object sender, EventArgs e)
        {
            if (dataSpareParts.SelectedRows.Count > 0)
            {
                FormShowSparePart formShowSparePart = new FormShowSparePart(true, SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)));
                formShowSparePart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageBatch formManageBatch = new FormManageBatch(batch);
            formManageBatch.ShowDialog();

            if (batch.DelTime.HasValue)
            {
                this.Close();
            }
            else
            {
                FillForm();
            }
            
        }

        private void FormShowBatch_ResizeEnd(object sender, EventArgs e)
        {
            if(!batchTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void batchTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (batchTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(438, 305);
            }
            else if (batchTabs.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;


            }
        }

        private void labelPickedWorkshop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowWorkshop formShowWorkshop = new FormShowWorkshop(true, batch.Workshop);
            formShowWorkshop.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string isSpent = batch.IsSpent() ? "нету" : "есть";
            DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить эту поставку? Неизрасходованные детали - {isSpent}", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                List<string> ordersInUse;
                if (batch.DelBatch(out ordersInUse))
                {
                    MessageBox.Show("Поставка успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Детали из этой поставки уже используются в заказах {String.Join(" ", ordersInUse)}, ее удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        private void dataSpareParts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShowSparePart formShowSparePart = new FormShowSparePart(true, SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)));
            formShowSparePart.ShowDialog();
        }
    }
}

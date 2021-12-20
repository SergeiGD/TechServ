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
    public partial class FormManageBatch : Form
    {
        Batch batch;
        Size pickedSize = new Size(804, 397);
        int rowsCount;
        int currentPage = 1;

        public FormManageBatch()
        {
            InitializeComponent();

            batchTabs.TabPages.Remove(sparePartsPage);
            btnAction.Text = "Сохранить и добавить детали";
            checkDelivered.Visible = false;
            batch = new Batch();
        }

        public FormManageBatch(Batch batch)
        {
            InitializeComponent();

            btnAction.Text = "Сохранить";
            this.batch = batch;

            // ЕСЛИ ПРИБЫЛА БОЛЬШЕ, ЧЕМ ДВА ДНЯ НАЗАД, ИЗМЕНИТЬ СОСТОЯНИЯ ПРИБЫТИЯ НЕЛЬЗЯ
            if(batch.DateDelivered.HasValue && batch.DateDelivered.Value.AddDays(2) <= DateTime.Now)
            {
                checkDelivered.Enabled = false;
                //btnFindWorkshop.Enabled = false;
            }

            this.FormClosing += CheckSpareParts;
            /*ManageButton btnAdd = new ManageButton();
            btnAdd.Text = "Добавить";
            panelControl.Controls.Add(btnAdd);
            btnAdd.Click += btnAddSparePart_Click;

            ManageButton btnDel = new ManageButton();
            btnDel.Text = "Удалить";
            panelControl.Controls.Add(btnDel);
            btnDel.Click += btnDeleteSparePart_Click;


            ManageButton btnShow = new ManageButton();
            btnShow.Text = "Просмотреть";
            panelControl.Controls.Add(btnShow);
            btnShow.Click += btnShowSparePart_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);


            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }*/
        }

        public FormManageBatch(Workshop workshop)         // ЕСЛИ ИЗМЕНЕНИЯ ПРОИСХОДИТ ИЗ МАСТЕРСКОЙ  (formManageWorkshop)
        {
            InitializeComponent();

            checkDelivered.Visible = false;          // лучше сделать ручную генерацию

            btnFindWorkshop.Enabled = false;
            batchTabs.TabPages.Remove(sparePartsPage);

            tbWorkshop.Text = workshop.Location;
            tbWorkshop.Tag = workshop;
            batch = new Batch();
        }

        public FormManageBatch(Workshop workshop, SparePart sparePart)         // ЕСЛИ ИЗМЕНЕНИЯ ПРОИСХОДИТ ИЗ МАСТЕРСКОЙ  (formManageWorkshop)
        {
            InitializeComponent();

            checkDelivered.Visible = false;          
            btnFindWorkshop.Enabled = false;
        }

        private void FormManageBatch_Load(object sender, EventArgs e)
        {
            this.Size = new Size(456, 216);

            if(batch.Id != 0)
            {
                tbTrackNum.Text = batch.TrackNumber;
                tbWorkshop.Text = batch.Workshop.Location;
                tbWorkshop.Tag = batch.Workshop;
                if (batch.DateDelivered.HasValue)
                {
                    checkDelivered.Checked = true;
                }

                comboBoxShowSparePartsRows.Items.Add(5);
                comboBoxShowSparePartsRows.Items.Add(20);
                comboBoxShowSparePartsRows.Items.Add(30);
                comboBoxShowSparePartsRows.Items.Add(40);
                comboBoxShowSparePartsRows.SelectedIndex = 2;

                FillSpareParts();
            }
        }

        private void CheckSpareParts(object sender, CancelEventArgs e)
        {
            if (batch.CalcSparePartsCount() == 0)
            {
                DialogResult answer = MessageBox.Show("В этой поставке нету деталей, если Вы ее сейчас закроете, то данная поставка автоматически удалится. Продолжить в любом случае?", "ВНИМАНИЕ!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(answer == DialogResult.Yes)
                {
                    batch.DelBatch();

                    //MessageBox.Show(this.Owner.Name);
                    //this.Owner.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbTrackNum.Text == "")
            {
                errorProvider.SetError(tbTrackNum, "Введите трэкномер");
                return false;
            }

            if (tbWorkshop.Tag == null)
            {
                errorProvider.SetError(tbWorkshop, "Выберите мастерскую");
                return false;
            }

            return true;
        }

        private void btnShowSparePart_Click(object sender, EventArgs e)
        {
            if(dataSpareParts.SelectedRows.Count > 0)
            {
                FormShowSparePart formShowSparePart = new FormShowSparePart(true, SparePartsList.GetById(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)));
                formShowSparePart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
        }

        private void btnAddSparePart_Click(object sender, EventArgs e)
        {
            FormSpareParts formSpareParts = new FormSpareParts(true);
            formSpareParts.ShowDialog();

            if(formSpareParts.sparePart == null)
            {
                return;
            }

            //BatchSparePart batchSpare = null;

            if (batch.CheckSparePart(formSpareParts.sparePart))
            {
                MessageBox.Show("Деталь этого типа уже есть в поставке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormManageBatchSparePart formManageBatchSparePart = new FormManageBatchSparePart(formSpareParts.sparePart);
                formManageBatchSparePart.ShowDialog();


                if (!formManageBatchSparePart.changed)
                {
                    return;
                }

                if (batch.AddSparePart(formManageBatchSparePart.batchSparePart))
                {
                    MessageBox.Show($"Деталь успешно добавлена в постаку", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillSpareParts();
                }
                else
                {
                    MessageBox.Show("Эта поставку уже прибыла, ее изменить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            
        }

        private void FormManageBatch_ResizeEnd(object sender, EventArgs e)
        {
            if(!batchTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void batchTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (batchTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(456, 216);
            }
            else if (batchTabs.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;

            }
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
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
                dataSpareParts.Rows[i].Cells[4].Value = spareParts[i].Quantity * spareParts[i].UnitPrice;

            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowSparePartsRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                batch.TrackNumber = tbTrackNum.Text;
                batch.WorkshopId = ((Workshop)tbWorkshop.Tag).Id;

                if(batch.Id == 0)
                {

                    batch.AddBatch();
                    this.Hide();
                    FormManageBatch formManageBatch = new FormManageBatch(BatchesList.GetById(batch.Id));
                    formManageBatch.ShowDialog();
                }
                else
                {
                    if(checkDelivered.Checked && !batch.DateDelivered.HasValue)
                    {
                        batch.DateDelivered = DateTime.Now;
                    }
                    if (!checkDelivered.Checked && batch.DateDelivered.HasValue)
                    {
                        batch.DateDelivered = null;
                    }

                    batch.Workshop = (Workshop)tbWorkshop.Tag;
                    batch.EditBatch();
                    MessageBox.Show($"Данные о поставке успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void btnDeleteSparePart_Click(object sender, EventArgs e)
        {
            if(dataSpareParts.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Вы уверены что хотите убрать эту деталь из поставки?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (batch.DelSparePart(batch.GetSparePart(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)))/*BatchesSparePartsList.GetById(batch.Id, Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)).DelBatchSparePart()*/)
                    {
                        FillSpareParts();
                        MessageBox.Show("Деталь успешно удалена из поставки", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Эта поставку уже прибыла, ее изменить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите детали");
            }
        }

        private void dataSpareParts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BatchSparePart batchSparePart = batch.GetSparePart(Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value));
            FormManageBatchSparePart formManageBatchSparePart = new FormManageBatchSparePart(batchSparePart);//batchSparePart.Quantity, batchSparePart.UnitPrice);
            formManageBatchSparePart.ShowDialog();

            if (!formManageBatchSparePart.changed)
            {
                return;
            }

            if (batch.EditSparePart(formManageBatchSparePart.batchSparePart))
            {
                FillSpareParts();
                MessageBox.Show("Данные о детали успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Эта поставку уже прибыла, ее изменить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
        }

        private void numericCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentPage.Value = (int)numericCurrentPage.Value;           // если ввели дробное число, оно автоматически округлится
            currentPage = (int)numericCurrentPage.Value;
            FillSpareParts();
        }

        private void comboBoxShowSparePartsRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSpareParts();
        }
    }
}

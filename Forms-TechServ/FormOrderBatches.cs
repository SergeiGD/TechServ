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
    public partial class FormOrderBatches : Form
    {
        OrderSparePart orderSparePart;
        bool readOnly;
        

        public FormOrderBatches(bool readOnly, OrderSparePart orderSparePart)
        {
            InitializeComponent();

            this.orderSparePart = orderSparePart;
            this.readOnly = readOnly;

            if (!readOnly)
            {
                ManageButton btnAddBatch = new ManageButton();
                btnAddBatch.Text = "Добавить";
                panelControl.Controls.Add(btnAddBatch);
                btnAddBatch.Click += btnAddBatch_Click;

                ManageButton btnDelBatch = new ManageButton();
                btnDelBatch.Text = "Удалить";
                panelControl.Controls.Add(btnDelBatch);
                btnDelBatch.Click += btnDelBatch_Click;
            }

            ManageButton btnShowBatch = new ManageButton();
            btnShowBatch.Text = "Просмотреть поставку";
            panelControl.Controls.Add(btnShowBatch);
            btnShowBatch.Click += btnShowBatch_Click;

            ManageButton[] mainBtn = panelControl.Controls.OfType<ManageButton>().ToArray();
            mainBtn[0].Location = new Point(0, 0);
            for (int i = 1; i < mainBtn.Count(); i++)
            {
                mainBtn[i].Location = new Point(0, mainBtn[i - 1].Location.Y + mainBtn[i - 1].Size.Height);
            }
        }

        private void FormOrderBatches_Load(object sender, EventArgs e)
        {

            FillBatches();
        }

        private void FillBatches()
        {
            dataBatches.Rows.Clear();
            Dictionary<Batch, int> batchesInfo = orderSparePart.GetBatchesInfo();
            int i = 0;

            foreach (KeyValuePair<Batch, int> item in batchesInfo)
            {
                dataBatches.Rows.Add(new DataGridViewRow());

                
                dataBatches.Rows[i].Cells[0].Value = orderSparePart.SparePart.Name;
                dataBatches.Rows[i].Cells[1].Value = item.Key.Id;
                dataBatches.Rows[i].Cells[2].Value = item.Value;
                dataBatches.Rows[i].Cells[3].Value = item.Key.GetSparePart(orderSparePart.SparePart.Id).UnitPrice;
                dataBatches.Rows[i].Cells[4].Value = orderSparePart.CalcBatchPrice(item.Key);
                dataBatches.Rows[i].Cells[5].Value = item.Key.DateDelivered.HasValue ? "Да" : "Нет";

                i++;
            }


           
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            FormBatches formBatches = new FormBatches(orderSparePart.SparePart, orderSparePart.Order.Workshop);
            formBatches.ShowDialog();

            if(formBatches.batch == null)
            {
                return;
            }

            if (orderSparePart.CheckBatch(formBatches.batch))
            {
                MessageBox.Show("Из этой поставки уже выбранны детали этого типа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormManageOrderSparePart formManageOrderSparePart = new FormManageOrderSparePart();
                formManageOrderSparePart.ShowDialog();

                if (!formManageOrderSparePart.changed)
                {
                    return;
                }

                if(orderSparePart.AddBatchInfo(formBatches.batch, formManageOrderSparePart.quantity))
                {
                    MessageBox.Show("Деталь успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillBatches();
                }
                else
                {
                    MessageBox.Show("В выбранной поставке недостаточно деталей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelBatch_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить эту поставку с деталями выбранного типа из заказа?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                if (dataBatches.SelectedRows.Count > 0)
                {
                    orderSparePart.DelBatchInfo(BatchesList.GetById((int)dataBatches.SelectedRows[0].Cells[1].Value));
                    FillBatches();
                }
                else
                {
                    MessageBox.Show("Для начала выберите поставку");
                }
            }
            
        }

        

        private void dataBatches_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (readOnly)
            {
                return;
            }

            FormManageOrderSparePart formManageOrderSparePart = new FormManageOrderSparePart((int)dataBatches.SelectedRows[0].Cells[2].Value);
            formManageOrderSparePart.ShowDialog();

            if (!formManageOrderSparePart.changed)
            {
                return;
            }

            if (orderSparePart.EditQuantity(BatchesList.GetById((int)dataBatches.SelectedRows[0].Cells[1].Value), formManageOrderSparePart.quantity))
            {
                MessageBox.Show("Количетсво деталей успешно изменено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillBatches();
            }
            else
            {
                MessageBox.Show("В выбранной поставке недостаточно деталей или получено недопустипое значние", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowBatch_Click(object sender, EventArgs e)
        {
            if(dataBatches.SelectedRows.Count > 0)
            {
                FormShowBatch formShowBatch = new FormShowBatch(true, BatchesList.GetById((int)dataBatches.SelectedRows[0].Cells[1].Value));
                formShowBatch.Show();
            }
            else
            {
                MessageBox.Show("Для начала выберите поставку");
            }
        }
    }
}

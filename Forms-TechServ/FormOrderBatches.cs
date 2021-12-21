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

        

        public FormOrderBatches(OrderSparePart orderSparePart)
        {
            InitializeComponent();

            this.orderSparePart = orderSparePart;
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
            FormBatches formBatches = new FormBatches(orderSparePart.SparePart);
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
            if(answer = DialogResult.Yes)
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

        private void dataBatches_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
                MessageBox.Show("В выбранной поставке недостаточно деталей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //orderSparePart.EditQuantity(BatchesList.GetById((int)dataBatches.SelectedRows[0].Cells[1].Value), formManageOrderSparePart.quantity);
        }
    }
}

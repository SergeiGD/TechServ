﻿using System;
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
    public partial class FormManageBatchSparePart : Form
    {
        public BatchSparePart batchSparePart;
        SparePart sparePart;
        public bool changed;


        public FormManageBatchSparePart(SparePart sparePart)
        {
            InitializeComponent();

            batchSparePart = new BatchSparePart();
            this.sparePart = sparePart;
        }

        public FormManageBatchSparePart(BatchSparePart batchSparePart)
        {
            InitializeComponent();

            this.batchSparePart = batchSparePart;
            this.sparePart = SparePartsList.GetById(batchSparePart.SparePartId);
            numericPrice.Value = batchSparePart.UnitPrice;
            numericQuantity.Value = batchSparePart.Quantity;
        }

        public FormManageBatchSparePart(int quantity, decimal price)
        {
            InitializeComponent();


            numericQuantity.Value = quantity;
            numericPrice.Value = price;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (numericPrice.Value < sparePart.ClientPrepayment)
            {
                DialogResult answer = MessageBox.Show($"Введенная цена меньше необходимой цены предоплаты детали ({sparePart.ClientPrepayment}). Вы точно хотите продолжить?", "Подтвердите корректность данных", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (answer != DialogResult.Yes)
                {
                    numericPrice.Value = numericPrice.Minimum;
                    return;
                }

            }

            if (batchSparePart.SparePartId == 0)
            {
                batchSparePart.SparePartId = sparePart.Id;

            }
            batchSparePart.Quantity = (int)numericQuantity.Value;
            batchSparePart.UnitPrice = numericPrice.Value;
            

            changed = true;


            this.Close();
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            numericQuantity.Value = (int)numericQuantity.Value; // если ввели дробью, переделываем в обычное число
        }
    }
}

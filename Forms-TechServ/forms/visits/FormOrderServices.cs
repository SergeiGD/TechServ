using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.services;

namespace Forms_TechServ.forms.visits
{
    // ФОРМА ДЛЯ ВЫБОРА УСЛУГ (ИЗ ЗАКАЗА) ДЛЯ ВЫЕЗДА
    public partial class FormOrderServices : Form
    {
        OrderAtHome order;
        public Service service;

        int servicesRowsCount;
        int servicesCurrentPage = 1;

        public FormOrderServices(OrderAtHome order)
        {
            InitializeComponent();

            this.order = order;
        }

        

        private void FormOrderServices_Load(object sender, EventArgs e)
        {
            comboBoxShowServicesRows.Items.Add(5);
            comboBoxShowServicesRows.Items.Add(20);
            comboBoxShowServicesRows.Items.Add(30);
            comboBoxShowServicesRows.Items.Add(40);
            comboBoxShowServicesRows.SelectedIndex = 2;

            FillGrid();
        }

        private void FillGrid()
        {
            List<OrderService> services = order.GetServices(
                true,
                (int)comboBoxShowServicesRows.SelectedItem,
                servicesCurrentPage,
                out servicesRowsCount);

            dataServies.Rows.Clear();
            for (int i = 0; i < services.Count; i++)
            {
                dataServies.Rows.Add(new DataGridViewRow());

                dataServies.Rows[i].Cells[0].Value = services[i].ServiceId;
                dataServies.Rows[i].Cells[1].Value = services[i].Service.Name;
                dataServies.Rows[i].Cells[2].Value = services[i].Quantity;
                dataServies.Rows[i].Cells[3].Value = services[i].Service.AvgServiceTime;
                dataServies.Rows[i].Cells[4].Value = services[i].Done ? "Да" : "Нет";

            }

            int maxPage = (int)Math.Ceiling((double)servicesRowsCount / (int)comboBoxShowServicesRows.SelectedItem);
            numericCurrentServicePage.Maximum = maxPage;

            if (numericCurrentServicePage.Maximum > 0)
                numericCurrentServicePage.Value = numericCurrentServicePage.Value == 0 ? 1 : numericCurrentServicePage.Value;

            labelServicesPageCout.Text = $"из {maxPage}";
        }

        private void btnNextServ_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value + 1 > numericCurrentServicePage.Maximum ? numericCurrentServicePage.Value : numericCurrentServicePage.Value + 1;
        }

        private void btnPrevServ_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value - 1 < numericCurrentServicePage.Minimum ? numericCurrentServicePage.Value : numericCurrentServicePage.Value - 1;
        }

        private void comboBoxShowServicesRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void numericCurrentServicePage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = (int)numericCurrentServicePage.Value;           // если ввели дробное число, оно автоматически округлится
            servicesCurrentPage = (int)numericCurrentServicePage.Value;
            FillGrid();
        }

        private void dataServies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            service = ServicesList.GetById((int)dataServies.SelectedRows[0].Cells[0].Value, false);

            this.Close();
        }
    }
}

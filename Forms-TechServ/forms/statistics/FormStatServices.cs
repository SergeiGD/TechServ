using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.services;

namespace Forms_TechServ.forms.statistics
{
    public partial class FormStatServices : Form
    {
        public FormStatServices()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value > dateTimePickerUntil.Value)
            {
                MessageBox.Show("Дата начала периода не может быть меньше даты конца", "Неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chartServices.Series[0].Points.Clear();

            List<Service> services = ServicesList.GetService();

            int point = 0;

            for (int i = 0; i < services.Count; i++)
            {
                int count = services[i].CountInOrders(dateTimePickerFrom.Value, dateTimePickerUntil.Value);
                if(count == 0)
                {
                    continue;
                }
                chartServices.Series[0].Points.AddXY(services[i].Name, count);
                chartServices.Series[0].Points[point].Label = services[i].Name;
                point++;
            }
        }

        private void FormStatServices_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Now.AddDays(-14);
            dateTimePickerUntil.Value = DateTime.Now;
        }
    }
}

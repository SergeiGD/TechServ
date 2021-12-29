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
    public partial class FormStatServices : Form
    {
        public FormStatServices()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            chartServices.Series[0].Points.Clear();

            //chartProfit.ChartAreas[0].AxisX.Title = "Мастерская";
            //chartProfit.ChartAreas[0].AxisY.Title = "Нагрузка";

            //chartProfit.ChartAreas[0].AxisX.Interval = 1;

            List<Service> services = ServicesList.GetService();
            for (int i = 0; i < services.Count; i++)
            {
                int count = services[i].CountInOrders(dateTimePickerFrom.Value, dateTimePickerUntil.Value);
                if(count == 0)
                {
                    continue;
                }
                chartServices.Series[0].Points.AddXY(services[i].Name, count);
                chartServices.Series[0].Points[i].Label = services[i].Name;
            }
        }

        private void FormStatServices_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Now.AddDays(-14);
            dateTimePickerUntil.Value = DateTime.Now;
        }
    }
}

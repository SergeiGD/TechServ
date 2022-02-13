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
    public partial class FormStatWorkshopProfit : Form
    {
        public FormStatWorkshopProfit()
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

            chartProfit.Series[0].Points.Clear();

            chartProfit.ChartAreas[0].AxisX.Title = "Мастерская";
            chartProfit.ChartAreas[0].AxisY.Title = "Выручка";

            chartProfit.ChartAreas[0].AxisX.Interval = 1;

            List<Workshop> workshops = WorkshopsList.GetWorkshops();
            for (int i = 0; i < workshops.Count; i++)
            {
                decimal profit = workshops[i].CalcProfit(dateTimePickerFrom.Value, dateTimePickerUntil.Value);
                chartProfit.Series[0].Points.AddXY(workshops[i].Location, profit);
                chartProfit.Series[0].Points[i].Label = profit.ToString();
            }
        }

        private void FormStatWorkshopProfit_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Now.AddDays(-14);
            dateTimePickerUntil.Value = DateTime.Now;
        }

        
    }
}

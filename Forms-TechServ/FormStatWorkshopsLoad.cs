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
    public partial class FormStatWorkshopsLoad : Form
    {
        public FormStatWorkshopsLoad()
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

            chartLoad.Series[0].Points.Clear();

            chartLoad.ChartAreas[0].AxisX.Title = "Мастерская";
            chartLoad.ChartAreas[0].AxisY.Title = "Нагрузка";

            chartLoad.ChartAreas[0].AxisX.Interval = 1;

            List<Workshop> workshops = WorkshopsList.GetWorkshops();
            for (int i = 0; i < workshops.Count; i++)
            {
                double load = workshops[i].CalcLoad(dateTimePickerFrom.Value, dateTimePickerUntil.Value);
                chartLoad.Series[0].Points.AddXY(workshops[i].Location, load);
                chartLoad.Series[0].Points[i].Label = load.ToString();
            }
        }

        private void FormStatWorkshops_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Now.AddDays(-14);
            dateTimePickerUntil.Value = DateTime.Now;
        }
    }
}

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
    public partial class FormPermissions : Form
    {
        Role role;
        int rowsCount;
        int currentPage = 1;

        public FormPermissions(Role role)
        {
            InitializeComponent();

            this.role = role;
        }

        private void FormPermissions_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "id";
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.Name = "Имя";

            dataPermissions.Columns.Add(idCol);
            dataPermissions.Columns.Add(nameCol);

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            FillGrid();
        }

        private void FillGrid()
        {
            int id;
            int.TryParse(tbID.Text, out id);

            List<Permission> permissions = role.GetPermissions(
                new Permission()
                {
                    Id = id,
                    Name = tbName.Text
                },
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            dataPermissions.Rows.Clear();
            for (int i = 0; i < permissions.Count; i++)
            {
                dataPermissions.Rows.Add(new DataGridViewRow());

                dataPermissions.Rows[i].Cells[0].Value = permissions[i].Id;
                dataPermissions.Rows[i].Cells[1].Value = permissions[i].Name;
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;

            if (numericCurrentPage.Maximum > 0)
                numericCurrentPage.Value = numericCurrentPage.Value == 0 ? 1 : numericCurrentPage.Value;

            labelPageCount.Text = $"из {maxPage}";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();

            FillGrid();
        }

        private void comboBoxShowRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void numericCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentPage.Value = (int)numericCurrentPage.Value;           // если ввели дробное число, оно автоматически округлится
            currentPage = (int)numericCurrentPage.Value;
            FillGrid();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value + 1 > numericCurrentPage.Maximum ? numericCurrentPage.Value : numericCurrentPage.Value + 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            numericCurrentPage.Value = numericCurrentPage.Value - 1 < numericCurrentPage.Minimum ? numericCurrentPage.Value : numericCurrentPage.Value - 1;
        }
    }
}

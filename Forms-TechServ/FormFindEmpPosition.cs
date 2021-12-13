using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TechServ
{
    public partial class FormFindEmpPosition : Form
    {
        public Role pickedRole;
        int pickedRowIndex;
        int currentPage = 1;
        int rowsCount;

        public FormFindEmpPosition()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            //var row = dataPosition.SelectedRows;

            pickedRole = RolesList.GetById(Convert.ToInt32(dataPosition.Rows[pickedRowIndex].Cells[0].Value));
            this.Close();
        }

        private void FormFindEmpPosition_Load(object sender, EventArgs e)
        {
            // СТРОИМ СТОЛБЦЫ ГРИДА
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            dataPosition.Columns.Add(idCol);
            dataPosition.Columns.Add(nameCol);

            comboBoxShowRows.Items.Add(5);
            comboBoxShowRows.Items.Add(20);
            comboBoxShowRows.Items.Add(30);
            comboBoxShowRows.Items.Add(40);
            comboBoxShowRows.SelectedIndex = 2;

            FillGrid();
        }

        private void FillGrid()                                             
        {
            // ЕСЛИ ФИЛЬТРЫ ПУСТЫЕ, ТО ПОЛУЧАЕМ ВСЕ ЗНАЧЕНИЯ
            int id;
            int.TryParse(tbID.Text, out id);                                // получаем введенное для сортировки id

            List<Role> positions = RolesList.GetRoles(new Role()                       // Загружаем роли, с указанными сортировками
            {
                Id = id,
                Name = tbName.Text
            },
                (int)comboBoxShowRows.SelectedItem,
                currentPage,
                out rowsCount
                );

            // ЗАПОЛНЯЕМ ГРИД
            dataPosition.Rows.Clear();
            for (int i = 0; i < positions.Count; i++)
            {
                dataPosition.Rows.Add(new DataGridViewRow());

                dataPosition.Rows[i].Cells[0].Value = positions[i].Id;
                dataPosition.Rows[i].Cells[1].Value = positions[i].Name;
            }

            int maxPage = (int)Math.Ceiling((double)rowsCount / (int)comboBoxShowRows.SelectedItem);
            numericCurrentPage.Maximum = maxPage;
            labelPageCount.Text = $"из {maxPage}";
        }


        private void dataPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pickedRowIndex = e.RowIndex;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            FillGrid();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ОЧИЩАЕМ ПОЛЯ ДЛЯ СОРТИРОВКИ И ПЕРЕЗАПОЛНЯЕМ ГРИД
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

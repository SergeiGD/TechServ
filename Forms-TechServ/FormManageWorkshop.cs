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
    public partial class FormManageWorkshop : Form
    {
        Workshop workshop;

        Size pickedSize = new Size(1078, 481);
        TabPage empsPage = new TabPage("Сотрудники");
        TabPage batchesPage = new TabPage("Поставки");

        public FormManageWorkshop()
        {
            InitializeComponent();

            this.Size = new Size(494, 187);

            workshop = new Workshop();                      // ЕСЛИ ДОБАВЛЯЕМ НОВЫЙ

            btnAction.Text = "Добавить";
        }

        public FormManageWorkshop(Workshop workshop)
        {
            InitializeComponent();

            this.Size = new Size(494, 187);

            workshopTabs.TabPages.Add(empsPage);
            workshopTabs.TabPages.Add(batchesPage);

            this.workshop = workshop;

            btnAction.Text = "Сохранить";

        }

        private void workshopTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workshopTabs.SelectedIndex == 0)
            {
                this.Size = new Size(494, 187);
            }
            else if (workshopTabs.SelectedIndex == 1)
            {
                this.Size = new Size(808, 399);

                /*FormProducts formProducts = new FormProducts(false, "qwe");

                formProducts.TopLevel = false;
                formProducts.FormBorderStyle = FormBorderStyle.None;
                tabPage2.Controls.Add(formProducts);
                //panelContent.Controls.Add(childForm);
                formProducts.Dock = DockStyle.Fill;
                formProducts.BringToFront();
                formProducts.Show();*/
            }
            else if (workshopTabs.SelectedIndex == 2)
            {
                this.Size = pickedSize;

                FormEmployees formEmployees = new FormEmployees(false, workshop);


                formEmployees.TopLevel = false;
                formEmployees.FormBorderStyle = FormBorderStyle.None;
                workshopTabs.TabPages[2].Controls.Add(formEmployees);
                formEmployees.Dock = DockStyle.Fill;
                formEmployees.BringToFront();
                formEmployees.Show();
            }
            else if (workshopTabs.SelectedTab.Equals(batchesPage))
            {
                this.Size = pickedSize;

                FormBatches formBatches = new FormBatches("asd", false);

               

                formBatches.TopLevel = false;
                formBatches.FormBorderStyle = FormBorderStyle.None;
                batchesPage.Controls.Add(formBatches);
                formBatches.Dock = DockStyle.Fill;
                formBatches.BringToFront();
                formBatches.Show();
            }
        }

        private void FormManageWorkshop_ResizeEnd(object sender, EventArgs e)
        {
            if(!workshopTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }

        private void manageButton1_Click(object sender, EventArgs e)
        {
            FormManageWorkshopTimetable formAddWorkshopTimetable = new FormManageWorkshopTimetable();
            formAddWorkshopTimetable.ShowDialog();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                workshop.Location = tbAddress.Text;
                workshop.PhoneNum = tbPhoneNum.Text;

                if(workshop.Id == 0)
                {
                    workshop.AddWorkshop();

                    MessageBox.Show($"Новый филиал успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    workshop.EditWorkshop();

                    MessageBox.Show($"Данные о филиале успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                
            }
            
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbAddress.Text == "")
            {
                errorProvider.SetError(tbAddress, "Введите адрес");
                return false;
            }
            if (!Regex.IsMatch(tbPhoneNum.Text, @"\d+"))
            {
                errorProvider.SetError(tbPhoneNum, "Введите номер числом");
                return false;
            }

            return true;
        }

        private void FormManageWorkshop_Load(object sender, EventArgs e)
        {
            if(workshop.Id != 0)
            {
                tbAddress.Text = workshop.Location;
                tbPhoneNum.Text = workshop.PhoneNum;
            }
            
        }
    }
}

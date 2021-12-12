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
    
    public partial class FormShowWorkshop : Form
    {
        Workshop workshop;
        bool readOnly;
        Size pickedSize = new Size(1078, 481);

        public FormShowWorkshop(bool readOnly, Workshop workshop)
        {
            InitializeComponent();

            //this.Size = new Size(638, 270);
            this.readOnly = readOnly;

            this.workshop = workshop;
        }

        private void FormShowWorkshop_Load(object sender, EventArgs e)
        {
            this.Size = new Size(684, 302);
            if (readOnly || (!UserSession.Can("edit_branch") && !UserSession.Can("add_del_branch")))      // если просто просмотр или нету прав на изменения
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_branch");
                deleteBtn.Enabled = UserSession.Can("add_del_branch");
            }

            FillForm();
        }

        private void FillForm()
        {
            labelID.Text = workshop.Id.ToString();
            labelAddress.Text = workshop.Location;
            labelPhoneNum.Text = workshop.PhoneNum;
        }

        private void workshopTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workshopTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(684, 302); 
            }
            else if (workshopTabs.SelectedTab.Equals(timetablePage))
            {
                this.Size = pickedSize;//new Size(638, 397);
            }
            else if (workshopTabs.SelectedTab.Equals(employeesPage))
            {
                this.Size = pickedSize;

                FormEmployees formEmployees = new FormEmployees(true, "workshop");

                formEmployees.TopLevel = false;
                formEmployees.FormBorderStyle = FormBorderStyle.None;
                employeesPage.Controls.Add(formEmployees);
                formEmployees.Dock = DockStyle.Fill;
                formEmployees.BringToFront();
                formEmployees.Show();
            }
            else if (workshopTabs.SelectedTab.Equals(batchesPage))
            {
                this.Size = pickedSize;

                FormBatches formBatches = new FormBatches("asd", true);
                formBatches.TopLevel = false;
                formBatches.FormBorderStyle = FormBorderStyle.None;
                batchesPage.Controls.Add(formBatches);
                formBatches.Dock = DockStyle.Fill;
                formBatches.BringToFront();
                formBatches.Show();
            }
        }

        private void FormShowWorkshop_ResizeEnd(object sender, EventArgs e)
        {
            pickedSize = this.Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageWorkshop formManageWorkshop = new FormManageWorkshop(workshop);
            formManageWorkshop.ShowDialog();

            FillForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить этот филиал?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {

                if (workshop.DelWorkshop())
                {
                    MessageBox.Show("Филиал успешно удалено", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("В данном филиале еще числятся сотрудник, пока его нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
   
            }
            else
            {
                return;
            }
        }
    }
}

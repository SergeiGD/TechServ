using System;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.forms.batches;

namespace Forms_TechServ.forms.spareParts
{
    public partial class FormManageSparePart : Form
    {
        SparePart sparePart;


        public FormManageSparePart()                                                
        {
            InitializeComponent();


            sparePart = new SparePart();
            btnAction.Text = "Добавить";

        }

        public FormManageSparePart(SparePart sparePart)
        {
            InitializeComponent();

            this.sparePart = sparePart;
            btnAction.Text = "Сохранить";
        }

        private void FormManageSparePart_Load(object sender, EventArgs e)
        {
         

            if (sparePart.Id != 0)
            {
                tbName.Text = sparePart.Name;
                numericPrepayment.Value = sparePart.ClientPrepayment;

            }
        }


        private void btnAddToBatch_Click(object sender, EventArgs e)
        {
            FormManageBatch formManageBatch = new FormManageBatch();        // СДЕЛАТЬ ЧТОБ ПРИ ЭТОМ В ГРИД СРАЗУ ДОБАВЛЯЛАСЬ ЗАПЧАТЬ НА КОТОРОЙ 
            formManageBatch.ShowDialog();
        }

        

        private bool CheckFields()
        {
            errorProvider.Clear();
            if (tbName.Text == null && tbName.Text == string.Empty)
            {
                errorProvider.SetError(tbName, "Введите наименование");
                return false;
            }
            return true;
        }

        private void btnPrepaymentInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipPrepayment.SetToolTip(btnPrepaymentInfo, "Ноль, если не нужна");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                sparePart.Name = tbName.Text;
                sparePart.ClientPrepayment = numericPrepayment.Value;

                if(sparePart.Id == 0)
                {
                    if (sparePart.AddSparePart())
                    {
                        MessageBox.Show($"Новая запчасть успешно добавлен. ID - {sparePart.Id}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (sparePart.EditSparePart())
                    {
                        MessageBox.Show("Информация о запчасти успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка обноваления", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

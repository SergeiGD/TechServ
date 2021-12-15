﻿using System;
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
    public partial class FormShowSparePart : Form
    {
        SparePart sparePart;
        bool readOnly;
        Size pickedSize = new Size(772, 392);

        public FormShowSparePart(bool readOnly, SparePart sparePart)
        {
            InitializeComponent();

            this.readOnly = readOnly;
            this.sparePart = sparePart;
        }

        private void FormShowSparePart_Load(object sender, EventArgs e)
        {
            if (readOnly || (!UserSession.Can("edit_sparePart") && !UserSession.Can("add_del_sparePart")))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_sparePart");
                deleteBtn.Enabled = UserSession.Can("add_del_sparePart");
            }

            FillForm();
            this.Size = new Size(550, 217);
        }

        private void FillForm()
        {
            labelID.Text = sparePart.Id.ToString();
            labelName.Text = sparePart.Name;
            labelPrepayment.Text = sparePart.ClientPrepayment.ToString();
        }

        private void sparePartTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sparePartTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(550, 217);
            }
            else if (sparePartTabs.SelectedTab.Equals(stockPage))
            {
                this.Size = pickedSize;

                /*FormSpareParts formSpareParts= new FormSpareParts("ad");


                formSpareParts.TopLevel = false;
                formSpareParts.FormBorderStyle = FormBorderStyle.None;
                stockPage.Controls.Add(formSpareParts);
                //panelContent.Controls.Add(childForm);
                formSpareParts.Dock = DockStyle.Fill;
                formSpareParts.BringToFront();
                formSpareParts.Show();*/
            }
        }

        private void FormShowSparePart_ResizeEnd(object sender, EventArgs e)
        {
            pickedSize = this.Size;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormManageSparePart formManageSparePart = new FormManageSparePart(sparePart);
            formManageSparePart.ShowDialog();

            FillForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы действительно хотите удалить эту запачать?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //sparePart.DelSparePart();
                if (sparePart.DelSparePart())
                {
                    MessageBox.Show("Запчать успешно удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Есть не истраченные запчасти этого типа, пока ее удалить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

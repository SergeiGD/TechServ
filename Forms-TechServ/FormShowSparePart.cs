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
    public partial class FormShowSparePart : Form
    {

        bool readOnly;
        Size pickedSize = new Size(772, 392);

        public FormShowSparePart(bool readOnly)
        {
            InitializeComponent();

            this.readOnly = readOnly;
        }

        private void FormShowSparePart_Load(object sender, EventArgs e)
        {
            if (readOnly)
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                this.Width = this.Width - panelEdit.Width;
            }
            this.Size = new Size(390, 217);
        }

        private void sparePartTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sparePartTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(390, 217);
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
            FormManageSparePart formManageSparePart = new FormManageSparePart("asd");
            formManageSparePart.ShowDialog();
        }
    }
}

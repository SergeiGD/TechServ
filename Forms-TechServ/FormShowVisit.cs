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
    public partial class FormShowVisit : Form
    {
        bool readOnly;
        Visit visit;

        int servicesRowsCount;
        int servicesCurrentPage = 1;

        public FormShowVisit(bool readOnly, Visit visit)
        {
            InitializeComponent();
            this.readOnly = readOnly;
            this.visit = visit;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            FormManageVisit formManageVisit = new FormManageVisit(visit);
            formManageVisit.ShowDialog();

            FillForm();
        }

        private void FormShowVisit_Load(object sender, EventArgs e)
        {
            if (readOnly || (!UserSession.Can("edit_visit") && !UserSession.Can("add_del_visit")))
            {
                panelEdit.Parent.Controls.Remove(panelEdit);
                //this.Width = this.Width - panelEdit.Width;
            }
            else
            {
                editBtn.Enabled = UserSession.Can("edit_visit");
                deleteBtn.Enabled = UserSession.Can("add_del_visit");
            }

            comboBoxShowServicesRows.Items.Add(5);
            comboBoxShowServicesRows.Items.Add(10);
            comboBoxShowServicesRows.Items.Add(20);
            comboBoxShowServicesRows.SelectedIndex = 1;

            dataServies.CellMouseDoubleClick += btnShowService_Click;

            FillForm();
        }

        private void FillForm()
        {
            labelID.Text = visit.Id.ToString();
            labelOrder.Text = visit.Order.Id.ToString();
            labelClient.Text = visit.Order.Product.Client.Name;
            labelMaster.Text = visit.Order.Master.Name;
            labelProduct.Text = visit.Order.Product.Name;
            labelAddress.Text = visit.Order.Address;
            labelDate.Text = visit.DateVisit.ToString();
            tbComment.Text = visit.MasterComment;
            if (visit.Done)
            {
                labelDone.Text = "Да";
            }
            else
            {
                labelDone.Text = "Нет";
            }

            labelEstimatedTime.Text = visit.CalcEstimatedTime().ToString();

            FillServices();
        }


        private void FillServices()
        {
            List<OrderService> services = visit.GetVisitOrderServices(
                (int)comboBoxShowServicesRows.SelectedItem,
                servicesCurrentPage,
                out servicesRowsCount);

            dataServies.Rows.Clear();
            for (int i = 0; i < services.Count; i++)
            {
                dataServies.Rows.Add(new DataGridViewRow());

                dataServies.Rows[i].Cells[0].Value = services[i].ServiceId;
                dataServies.Rows[i].Cells[1].Value = services[i].Service.Name;
                dataServies.Rows[i].Cells[2].Value = services[i].Quantity;
                dataServies.Rows[i].Cells[3].Value = TimeSpan.FromTicks(services[i].Service.AvgServiceTime.Ticks * services[i].Quantity);


            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)servicesRowsCount / (int)comboBoxShowServicesRows.SelectedItem);
            numericCurrentServicePage.Maximum = maxPage;

            if (numericCurrentServicePage.Maximum > 0)
                numericCurrentServicePage.Value = numericCurrentServicePage.Value == 0 ? 1 : numericCurrentServicePage.Value;

            labelServicesPageCout.Text = $"из {maxPage}";
        }


        private void linkPickedOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowOrder formShowOrder = new FormShowOrder(true, OrderAtHomeList.GetById(visit.OrderId));
            formShowOrder.ShowDialog();
        }

        /*private void linkPickedMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowMaster formShowMaster = new FormShowMaster(true, null);
            formShowMaster.ShowDialog();
        }*/

        private void linkPickedClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowClient formShowClient = new FormShowClient(true, ClientsList.GetById(visit.Order.Product.ClientId));
            formShowClient.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowProduct formShowProduct = new FormShowProduct(true, ProductsList.GetById(visit.Order.ProductId, true));
            formShowProduct.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы уверены, что хотите удалить этот выезд?", "Подтвердите дейтсвие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                visit.DelVisit();
                MessageBox.Show("Выезд был удален", "Успешно удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs)e).RowIndex == -1)
            {
                return;             // если кликнули по хеадеру грида
            }

            if (dataServies.SelectedRows.Count > 0)
            {
                FormShowService formShowService = new FormShowService(true, ServicesList.GetById((int)dataServies.SelectedRows[0].Cells[0].Value, true));
                formShowService.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите услугу");
            }
        }

        private void btnNextService_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value + 1 > numericCurrentServicePage.Maximum ? numericCurrentServicePage.Value : numericCurrentServicePage.Value + 1;
        }

        private void btnPrevService_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value - 1 < numericCurrentServicePage.Minimum ? numericCurrentServicePage.Value : numericCurrentServicePage.Value - 1;
        }

        private void comboBoxShowServicesRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillServices();
        }

        private void numericCurrentServicePage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = (int)numericCurrentServicePage.Value;           // если ввели дробное число, оно автоматически округлится
            servicesCurrentPage = (int)numericCurrentServicePage.Value;
            FillServices();
        }

        private void labelMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowMaster formShowMaster = new FormShowMaster(true, MastersList.GetById(visit.Order.MasterId, true));
            formShowMaster.ShowDialog();
        }
    }
}

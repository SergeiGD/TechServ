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
    public partial class FormEditOrder : Form
    {
        Size pickedSize = new Size(991, 531);
        Order order;
        bool inOrder;
        int servicesRowsCount;
        int servicesCurrentPage = 1;
        int sparePartsRowsCount;
        int sparePartsCurrentPage = 1;

        public FormEditOrder(Order order)
        {
            InitializeComponent();

            this.order = order;
            if (order.GetType() != typeof(OrderAtHome))
            {
                this.inOrder = true;
                ordersTab.TabPages.Remove(visitsPage);
            }
                
            
        }

        private void OrdersTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ordersTab.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(700, 520);
            }
            else if(ordersTab.SelectedTab.Equals(servicesPage))
            {
                this.Size = pickedSize;
            }
            else if (ordersTab.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;

                /*FormSpareParts formSpareParts = new FormSpareParts(false, "asd");
                formSpareParts.TopLevel = false;
                formSpareParts.FormBorderStyle = FormBorderStyle.None;
                sparePartsPage.Controls.Add(formSpareParts);
                //panelContent.Controls.Add(childForm);
                formSpareParts.Dock = DockStyle.Fill;
                formSpareParts.BringToFront();
                formSpareParts.Show();*/
            }
            else if (ordersTab.SelectedTab.Equals(logsPage))
            {
                this.Size = pickedSize;

                FormOrdersLogs formOrdersLogs = new FormOrdersLogs(43, false);
                formOrdersLogs.TopLevel = false;
                formOrdersLogs.FormBorderStyle = FormBorderStyle.None;
                logsPage.Controls.Add(formOrdersLogs);
                //panelContent.Controls.Add(childForm);
                formOrdersLogs.Dock = DockStyle.Fill;
                formOrdersLogs.BringToFront();
                formOrdersLogs.Show();
            }
            else if (ordersTab.SelectedTab.Equals(visitsPage))
            {
                this.Size = pickedSize;

                FormVisits formVisits = new FormVisits(34, false);
                formVisits.TopLevel = false;
                formVisits.FormBorderStyle = FormBorderStyle.None;
                visitsPage.Controls.Add(formVisits);
                formVisits.Dock = DockStyle.Fill;
                formVisits.BringToFront();
                formVisits.Show();
            }
        }

        private void FormEditOrder_ResizeEnd(object sender, EventArgs e)
        {
            if (!ordersTab.SelectedTab.Equals(generalPage))
            {
                pickedSize = this.Size;
            }
            
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            FormServices formServices = new FormServices(/*CategoriesList.GetById(order.Product.CategoryId, true)*/ true);
            formServices.ShowDialog();

            if(formServices.service == null)
            {
                return;
            }

            //OrderService orderService = null;

            if (order.CheckService(formServices.service))
            {
                MessageBox.Show("Эта услуга уже есть в заказе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormManageOrderService formManageOrderService = new FormManageOrderService(formServices.service);
                formManageOrderService.ShowDialog();

                if (!formManageOrderService.changed)
                {
                    return;
                }

                if (order.AddService(formManageOrderService.orderService))
                {
                    FillServices();
                    RecalcFields();
                    MessageBox.Show($"Услуга успешно добавлена в заказ", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
        }

        private void btnAddSparePart_Click(object sender, EventArgs e)
        {
            FormSpareParts formSpareParts = new FormSpareParts(true, order.Workshop);
            formSpareParts.ShowDialog();

            if(formSpareParts.sparePart == null)
            {
                return;
            }

            if (order.CheckSparePart(formSpareParts.sparePart))
            {
                MessageBox.Show("Эта деталь уже есть в заказе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrderSparePart sparePart = new OrderSparePart()
                {
                    Order = order,
                    SparePart = formSpareParts.sparePart
                };

                DialogResult dialogResult = MessageBox.Show("Желаете подобрать поставки автоматически (только из Вашей мастерской)?", "Выберите способ добавления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    FormManageOrderSparePart formManageOrderSparePart = new FormManageOrderSparePart();
                    formManageOrderSparePart.ShowDialog();

                    if(!formManageOrderSparePart.changed)
                    {
                        return;
                    }

                    if (sparePart.FindBatchesAuto(formManageOrderSparePart.quantity))
                    {
                        MessageBox.Show("Деталь успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillSpareParts();
                    }
                    else
                    {
                        MessageBox.Show("В Вашей мастеркой нету выбранного количества этой детали", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    FormOrderBatches formOrderBatches = new FormOrderBatches(sparePart);
                    formOrderBatches.ShowDialog();

                    FillSpareParts();
                }

            }

        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            if(dataServies.SelectedRows.Count > 0)
            {
                FormShowService formShowService = new FormShowService(true, ServicesList.GetById(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value), true));
                formShowService.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите услугу");
            }
        }

        

        private void btnShowBatch_Click(object sender, EventArgs e)
        {
            if(dataSpareParts.SelectedRows.Count > 0)
            {
                FormShowSparePart formShowSparePart = new FormShowSparePart(true, SparePartsList.GetById((int)dataSpareParts.SelectedRows[0].Cells[0].Value));
                formShowSparePart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
        }

        private void FormEditOrder_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 520);

            //comboBoxStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            foreach(OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                comboBoxStatus.Items.Add(status.GetStatusString());
            }

            comboBoxShowServicesRows.Items.Add(5);
            comboBoxShowServicesRows.Items.Add(20);
            comboBoxShowServicesRows.Items.Add(30);
            comboBoxShowServicesRows.Items.Add(40);
            comboBoxShowServicesRows.SelectedIndex = 2;

            comboBoxShowSparePartsRows.Items.Add(5);
            comboBoxShowSparePartsRows.Items.Add(20);
            comboBoxShowSparePartsRows.Items.Add(30);
            comboBoxShowSparePartsRows.Items.Add(40);
            comboBoxShowSparePartsRows.SelectedIndex = 2;

            if (inOrder)
            {
                label3.Visible = false;
                tbAddress.Visible = false;
            }
            else
            {
                tbAddress.Text = ((OrderAtHome)order).Address;
            }

            tbProduct.Text = order.Product.Name;
            tbProduct.Tag = order.Product;
            tbMaster.Text = order.Master.Name;
            tbMaster.Tag = order.Master;
            tbWorkshop.Text = order.Workshop.Location;
            tbWorkshop.Tag = order.Workshop;
            tbComment.Text = order.ClientComment;
            labelSale.Text = order.ClientSale.ToString();
            //labelPrepayment.Text = order.Prepayment.ToString();
            //labelServicesCount.Text = order.CalcServicesCount().ToString(); 

            if (order.DateDiagnostic.HasValue)
            {
                checkDiagnosted.Checked = true;
            }
            if (order.DatePrepayment.HasValue)
            {
                checkPrepaid.Checked = true;
            }
            if (order.DateRepaired.HasValue)
            {
                checkReadpied.Checked = true;
            }
            if (order.DatePaid.HasValue)
            {
                checkPaid.Checked = true;
            }

        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();

            tbProduct.Text = formProducts?.product?.Name;
            tbProduct.Tag = formProducts?.product;
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();

            tbMaster.Text = formMasters?.master.Name;
            tbMaster.Tag = formMasters?.master;
        }

        private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }

        private void btnAutoMaster_MouseHover(object sender, EventArgs e)
        {
            toolTipFindAuto.SetToolTip(btnAutoMaster, "Найти автоматически");
        }

        private void FillServices()
        {
            List<OrderService> services = order.GetServices(
                (int)comboBoxShowServicesRows.SelectedItem,
                servicesCurrentPage,
                out servicesRowsCount);

            dataServies.Rows.Clear();
            for (int i = 0; i < services.Count; i++)
            {
                dataServies.Rows.Add(new DataGridViewRow());

                dataServies.Rows[i].Cells[0].Value = services[i].ServiceId;
                dataServies.Rows[i].Cells[1].Value = services[i].Service.Name;
                dataServies.Rows[i].Cells[2].Value = services[i].Service.Price;
                dataServies.Rows[i].Cells[3].Value = services[i].Quantity;
                dataServies.Rows[i].Cells[4].Value = services[i].Sale;
                dataServies.Rows[i].Cells[5].Value = services[i].Service.Price * services[i].Quantity - (services[i].Service.Price * services[i].Quantity * (services[i].Sale / 100));


            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)servicesRowsCount / (int)comboBoxShowServicesRows.SelectedItem);
            numericCurrentServicePage.Maximum = maxPage;

            if (numericCurrentServicePage.Maximum > 0)
                numericCurrentServicePage.Value = numericCurrentServicePage.Value == 0 ? 1 : numericCurrentServicePage.Value;

            labelServicesPageCout.Text = $"из {maxPage}";
        }

        private void FillSpareParts()
        {
            List<OrderSparePart> spareParts = order.GetSpareParts(
                (int)comboBoxShowSparePartsRows.SelectedItem,
                sparePartsCurrentPage,
                out sparePartsRowsCount);

            dataSpareParts.Rows.Clear();
            for (int i = 0; i < spareParts.Count; i++)
            {
                

                dataSpareParts.Rows.Add(new DataGridViewRow());

                dataSpareParts.Rows[i].Cells[0].Value = spareParts[i].SparePart.Id;
                dataSpareParts.Rows[i].Cells[1].Value = spareParts[i].SparePart.Name;
                //dataSpareParts.Rows[i].Cells[2].Value = item.Key.Id;
                dataSpareParts.Rows[i].Cells[2].Value = spareParts[i].CalcSparePartsQuanity();
                dataSpareParts.Rows[i].Cells[3].Value = spareParts[i].CalcPrice();
                dataSpareParts.Rows[i].Cells[4].Value = spareParts[i].CheckBatchesDelivered() ? "Да" : "Нет";

                


            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)sparePartsRowsCount / (int)comboBoxShowSparePartsRows.SelectedItem);
            numericCurrentSparePartPage.Maximum = maxPage;

            if (numericCurrentSparePartPage.Maximum > 0)
                numericCurrentSparePartPage.Value = numericCurrentSparePartPage.Value == 0 ? 1 : numericCurrentSparePartPage.Value;

            labelSparePartsPageCount.Text = $"из {maxPage}";
        }


        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if(dataServies.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Вы уверены что хотите убрать эту услугу из заказа?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (order.DelService(order.GetService(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value)))/*BatchesSparePartsList.GetById(batch.Id, Convert.ToInt32(dataSpareParts.SelectedRows[0].Cells[0].Value)).DelBatchSparePart()*/)
                    {
                        FillServices();
                        RecalcFields();
                        MessageBox.Show("Услуга успешно удалена из заказа", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show("Для начала выберите услугу");
            }
        }

        private void dataServies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderService orderService = order.GetService(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value));
            FormManageOrderService formManageOrderService = new FormManageOrderService(orderService);//batchSparePart.Quantity, batchSparePart.UnitPrice);
            formManageOrderService.ShowDialog();

            if (!formManageOrderService.changed)
            {
                return;
            }

            if (order.EditService(formManageOrderService.orderService))
            {
                FillServices();
                RecalcFields();
                MessageBox.Show("Данные об услуге успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnNextServ_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value + 1 > numericCurrentServicePage.Maximum ? numericCurrentServicePage.Value : numericCurrentServicePage.Value + 1;
        }

        private void btnPrevServ_Click(object sender, EventArgs e)
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

        private void RecalcFields()
        {
            labelServicesCount.Text = order.CalcServicesCount().ToString();
            labelServicesPrice.Text = order.CalcServicesPrice().ToString();
            labelFinalPrice.Text = order.CalcFinalPrice().ToString();
            //labelSale.Text = order.ClientSale.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxShowSparePartsRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSpareParts();
        }

        private void numericCurrentSparePartPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentSparePartPage.Value = (int)numericCurrentSparePartPage.Value;           // если ввели дробное число, оно автоматически округлится
            sparePartsCurrentPage = (int)numericCurrentSparePartPage.Value;
            FillSpareParts();
        }

        private void dataSpareParts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataSpareParts.SelectedRows.Count > 0)
            {
                FormOrderBatches formOrderBatches = new FormOrderBatches(order.GetSparePart((int)dataSpareParts.SelectedRows[0].Cells[0].Value));
                formOrderBatches.ShowDialog();

                FillSpareParts();
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
        }

        private void btnNextSparePart_Click(object sender, EventArgs e)
        {
            numericCurrentSparePartPage.Value = numericCurrentSparePartPage.Value + 1 > numericCurrentSparePartPage.Maximum ? numericCurrentSparePartPage.Value : numericCurrentSparePartPage.Value + 1;
        }

        private void btnPrevSparePart_Click(object sender, EventArgs e)
        {
            numericCurrentSparePartPage.Value = numericCurrentSparePartPage.Value - 1 < numericCurrentSparePartPage.Minimum ? numericCurrentSparePartPage.Value : numericCurrentSparePartPage.Value - 1;
        }

        private void btnDelSparePart_Click(object sender, EventArgs e)
        {
            if(dataSpareParts.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Вы уверен что хотите удалить эту деталь из заказа?", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes)
                {
                    OrderSparePart sparePart = order.GetSparePart((int)dataSpareParts.SelectedRows[0].Cells[0].Value);
                    sparePart.DelSparePart();
                    MessageBox.Show("Деталь успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillSpareParts();
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
        }
    }
}

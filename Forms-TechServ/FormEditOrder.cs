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
        bool lockedState;

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
                this.Size = new Size(700, 565);
            }
            else if(ordersTab.SelectedTab.Equals(servicesPage))
            {
                this.Size = pickedSize;

                FillServices();
            }
            else if (ordersTab.SelectedTab.Equals(sparePartsPage))
            {
                this.Size = pickedSize;

                FillSpareParts();
            }
            else if (ordersTab.SelectedTab.Equals(logsPage))
            {
                this.Size = pickedSize;

                FormOrdersLogs formOrdersLogs = new FormOrdersLogs(false, order);
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

                FormVisits formVisits = new FormVisits(false, (OrderAtHome)order);
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
                        RecalcFields();
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
            this.Size = new Size(700, 565);

            //comboBoxStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            

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

            //tbProduct.Text = order.Product.Name;
            //tbProduct.Tag = order.Product;
            tbMaster.Text = order.Master.Name;
            tbMaster.Tag = order.Master;
            //tbWorkshop.Text = order.Workshop.Location;
            //tbWorkshop.Tag = order.Workshop;
            tbComment.Text = order.ClientComment;
            labelSale.Text = order.ClientSale.ToString() + "%";
            //labelPrepayment.Text = order.Prepayment.ToString();
            //labelServicesCount.Text = order.CalcServicesCount().ToString(); 
            labelLeftToPay.Text = (order.FinalPrice - order.PrepaymentMade).ToString();
            numericPaid.Value = order.PrepaymentMade;
            labelProduct.Text = order.Product.Name;

            //comboBoxStatus.Items.Add(OrderStatus.WaitingForAnswer.GetStatusString());
            if (order.DateDiagnostic.HasValue)
            {
                checkDiagnosted.Checked = true;
            }
            else
            {
                checkAnswer.Checked = false;
                checkAnswer.Enabled = false;
            }

            if (order.DatePrepayment.HasValue)
            {
                checkPrepaid.Checked = true;
            }
            

            if (order.DateClientAnswer.HasValue)
            {
                checkAnswer.Checked = true;
            }
            if (order.DateRepaired.HasValue)
            {
                checkRepaired.Checked = true;
            }
            if (order.DatePaid.HasValue)
            {
                checkPaid.Checked = true;
            }

            

            // БИНЬДИМ СОБЫТИЯ ВРУЧНУЮ, ЧТО ОНИ НЕ СРАБОТАЛИ ПРИ НАЧАЛЬНОЙ ЗАГРУЗКЕ ДАННЫХ В ФОРМУ
            checkDiagnosted.CheckedChanged += checkDiagnosted_CheckedChanged;
            checkPrepaid.CheckedChanged += checkPrepaid_CheckedChanged;
            checkRepaired.CheckedChanged += checkRepaired_CheckedChanged;
            //checkPaid.CheckedChanged += checkPaid_CheckedChanged;

            comboBoxStatus.Items.Add(OrderStatus.WaitingForDiagnostic.GetStatusString());
            if (checkDiagnosted.Checked)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForAnswer.GetStatusString());
            }
            if(order.PrepaymentRequired > order.PrepaymentMade)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForPrepayment.GetStatusString());
            }
            comboBoxStatus.Items.Add(OrderStatus.WaitingForSpareParts.GetStatusString());
            if (order.PrepaymentRequired == 0 || checkPrepaid.Checked)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRepairing.GetStatusString());
            }
            if (numericPaid.Value > 0)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRefund.GetStatusString());
            }
            if (checkPaid.Checked && checkRepaired.Checked)
            {
                comboBoxStatus.Items.Add(OrderStatus.Finished.GetStatusString());
            }
            comboBoxStatus.Items.Add(OrderStatus.WaitingForPayment.GetStatusString());
            comboBoxStatus.Items.Add(OrderStatus.Canceled.GetStatusString());

            comboBoxStatus.SelectedItem = order.Status.GetStatusString();

            RecalcFields();
        }

        

        /*private void ControlStatus()
        {
            
            comboBoxStatus.Items.Add(OrderStatus.WaitingForDiagnostic.GetStatusString());
            if (checkDiagnosted.Checked)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForAnswer.GetStatusString());
            }
            if (order.PrepaymentRequired > order.PrepaymentMade)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForPrepayment.GetStatusString());
            }
            comboBoxStatus.Items.Add(OrderStatus.WaitingForSpareParts.GetStatusString());
            if (order.PrepaymentRequired == 0 || checkPrepaid.Checked)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRepairing.GetStatusString());
            }
            if (order.PrepaymentMade > 0)
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRefund.GetStatusString());
            }
            if (checkPaid.Checked && checkRepaired.Checked)
            {
                comboBoxStatus.Items.Add(OrderStatus.Finished.GetStatusString());
            }
            comboBoxStatus.Items.Add(OrderStatus.Canceled.GetStatusString());
        }*/

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients(true);
            formClients.ShowDialog();
        }

        /*private void btnFindProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(true);
            formProducts.ShowDialog();

            tbProduct.Text = formProducts?.product?.Name;
            tbProduct.Tag = formProducts?.product;
        }*/

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Смена мастера в заказе приведет с удалению ВСЕХ выездов и задач, связанных с этим закаом, хотите продолжить?", "ВНИМАНИЕ!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(answer == DialogResult.Yes)
            {
                FormMasters formMasters = new FormMasters(true, order.Workshop);
                formMasters.ShowDialog();

                tbMaster.Text = formMasters?.master.Name;
                tbMaster.Tag = formMasters?.master;
            }
            
        }

        /*private void btnFindWorkshop_Click(object sender, EventArgs e)
        {
            FormWorkshops formWorkshops = new FormWorkshops(true);
            formWorkshops.ShowDialog();

            tbWorkshop.Text = formWorkshops?.workshop?.Location;
            tbWorkshop.Tag = formWorkshops?.workshop;
        }*/

        private void btnAutoMaster_MouseHover(object sender, EventArgs e)
        {
            toolTipFindAuto.SetToolTip(btnAutoMaster, "Найти автоматически");
        }

        private void FillServices()
        {
            List<OrderService> services = order.GetServices(
                false,
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
                dataServies.Rows[i].Cells[6].Value = services[i].Done ? "Да" : "Нет";

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
                DialogResult answer = MessageBox.Show($"Вы уверены что хотите убрать услугу с id {dataServies.SelectedRows[0].Cells[0].Value} из заказа?", "Подтвердите действие", MessageBoxButtons.YesNo);
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
            if (lockedState)
            {
                return;
            }
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
            labelPrepaymentRequired.Text = order.PrepaymentRequired.ToString();
            labelServicesCount.Text = order.CalcServicesCount().ToString();

            labelServicesPrice.Text = order.CalcServicesPrice().ToString();

            labelSparePartsCount.Text = order.CalcSparePartsCount().ToString();

            labelSparePartsPrice.Text = order.CalcSparePartsPrice().ToString();

            labelFinalPrice.Text = order.FinalPrice.ToString();
            labelLeftToPay.Text = (order.FinalPrice - numericPaid.Value).ToString();
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
            if (lockedState)
            {
                return;
            }
            if (dataSpareParts.SelectedRows.Count > 0)
            {
                FormOrderBatches formOrderBatches = new FormOrderBatches(order.GetSparePart((int)dataSpareParts.SelectedRows[0].Cells[0].Value));
                formOrderBatches.ShowDialog();

                FillSpareParts();
                RecalcFields();
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
                    RecalcFields();
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!inOrder && (tbAddress.Text == null || tbAddress.Text == string.Empty))
            {
                MessageBox.Show("Адрес не может быть не указанным");
            }
            else if(!inOrder)
            {
                ((OrderAtHome)order).Address = tbAddress.Text;
            }

            if(order.MasterId != ((Master)tbMaster.Tag).Id)
            {
                if (!inOrder)
                {
                    foreach(Visit visit in ((OrderAtHome)order).GetVisits())
                    {
                        visit.DelVisit();
                    }
                }
            }

            order.MasterId = ((Master)tbMaster.Tag).Id;
            order.Master = (Master)tbMaster.Tag;
            order.ClientComment = tbComment.Text;
            order.PrepaymentMade = numericPaid.Value;

            if (!order.DateDiagnostic.HasValue && checkDiagnosted.Checked)
            {
                order.DateDiagnostic = DateTime.Now;
            }
            else if (order.DateDiagnostic.HasValue && !checkDiagnosted.Checked)
            {
                order.DateDiagnostic = null;
            }

            if (!order.DateClientAnswer.HasValue && checkAnswer.Checked)
            {
                order.DateClientAnswer = DateTime.Now;
            }
            else if (order.DateClientAnswer.HasValue && !checkAnswer.Checked)
            {
                order.DateClientAnswer = null;
            }

            if (!order.DatePrepayment.HasValue && checkPrepaid.Checked)
            {
                order.DatePrepayment = DateTime.Now;
            }
            else if (order.DatePrepayment.HasValue && !checkPrepaid.Checked)
            {
                order.DatePrepayment = null;
            }

            if (!order.DatePaid.HasValue && checkPaid.Checked)
            {
                order.DatePaid = DateTime.Now;
            }
            else if (order.DatePaid.HasValue && !checkPaid.Checked)
            {
                order.DatePaid = null;
            }

            if (!order.DateRepaired.HasValue && checkRepaired.Checked)
            {
                order.DateRepaired = DateTime.Now;
            }
            else if (order.DateRepaired.HasValue && !checkRepaired.Checked)
            {
                order.DateRepaired = null;
            }

            if (!order.DateFinish.HasValue && comboBoxStatus.SelectedItem.ToString() == OrderStatus.Finished.GetStatusString()) 
            {
                order.DateFinish = DateTime.Now;
            }
            else if (order.DateFinish.HasValue && comboBoxStatus.SelectedItem.ToString() != OrderStatus.Finished.GetStatusString())
            {
                order.DateFinish = null;
            }

            if (!order.DateCancel.HasValue && comboBoxStatus.SelectedItem.ToString() == OrderStatus.Canceled.GetStatusString())
            {
                order.DateCancel = DateTime.Now;
            }
            else if (order.DateCancel.HasValue && comboBoxStatus.SelectedItem.ToString() != OrderStatus.Canceled.GetStatusString())
            {
                order.DateCancel = null;
            }

            order.Status = StatusStringExtensions.GetStatusEnum(comboBoxStatus.SelectedItem.ToString());

            if (order.EditOrder())
            {
                MessageBox.Show("Информация о заказе успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка сохранения данных", "Что-то пошло не так ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAutoMaster_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Смена мастера в заказе приведет с удалению ВСЕХ выездов и задач, связанных с этим закаом, хотите продолжить?", "ВНИМАНИЕ!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                if (!order.FindMaster())
                {
                    MessageBox.Show("Не удается найти мастера с требуемой категорией", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbMaster.Text = order.Master.Name;
                    tbMaster.Tag = order.Master;
                }
            }
                /*DialogResult answer = MessageBox.Show("Подобрать мастера автоматически?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {

                if (!order.FindMaster())
                {
                    MessageBox.Show("Не удается найти мастера с требуемой категорией", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbMaster.Text = order.Master.Name;
                    tbMaster.Tag = order.Master;
                }
            }*/
        }

        private void checkPrepaid_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPrepaid.Checked && numericPaid.Value < order.PrepaymentRequired)
            {
                DialogResult answer = MessageBox.Show("Указанная сумма внесенной предоплаты меньше расчитываемой суммы необходимой предоплаты, Вы уверены, что хотите продолжить?", "подтвердите дейтсвие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(answer != DialogResult.Yes)
                {
                    checkPrepaid.Checked = false;
                }
            }

            if (order.PrepaymentRequired == 0 || checkPrepaid.Checked && !comboBoxStatus.Items.Contains(OrderStatus.WaitingForRepairing.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRepairing.GetStatusString());
            }
            else if (comboBoxStatus.Items.Contains(OrderStatus.WaitingForRepairing.GetStatusString()))
            {
                comboBoxStatus.Items.Remove(OrderStatus.WaitingForRepairing.GetStatusString());
            }
        }

        private void numericPaid_ValueChanged(object sender, EventArgs e)
        {
            labelLeftToPay.Text = (order.FinalPrice - numericPaid.Value).ToString();
            if(numericPaid.Value > 0 && !comboBoxStatus.Items.Contains(OrderStatus.WaitingForRefund.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRefund.GetStatusString());
            }
            else if (comboBoxStatus.Items.Contains(OrderStatus.WaitingForRefund.GetStatusString()))
            {
                comboBoxStatus.Items.Remove(OrderStatus.WaitingForRefund.GetStatusString());
            }
        }

        private void checkDiagnosted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDiagnosted.Checked)
            {
                checkAnswer.Enabled = true;
            }
            else
            {
                checkAnswer.Checked = false;
                checkAnswer.Enabled = false;
            }
            if (checkDiagnosted.Checked && !comboBoxStatus.Items.Contains(OrderStatus.WaitingForAnswer.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForAnswer.GetStatusString());
            }
            else if (comboBoxStatus.Items.Contains(OrderStatus.WaitingForAnswer.GetStatusString()))
            {
                comboBoxStatus.Items.Remove(OrderStatus.WaitingForAnswer.GetStatusString());
            }
        }

        private void checkRepaired_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRepaired.Checked)
            {
                foreach(OrderSparePart sparePart in order.GetSpareParts())
                {
                    if (!sparePart.CheckBatchesDelivered())
                    {
                        DialogResult answer = MessageBox.Show("Еще не все указанные для ремонта детали прибыли, Вы уверены, что все верно и хотите продолжить?", "Подтвердите операцию", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if(answer != DialogResult.Yes)
                        {
                            checkRepaired.Checked = false;
                            
                        }
                        break;
                    }
                }
            }

            if (checkPaid.Checked && checkRepaired.Checked && !comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.Finished.GetStatusString());
            }
            else if (comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
            {
                comboBoxStatus.Items.Remove(OrderStatus.Finished.GetStatusString());
            }
        }

        private void checkPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPaid.Checked && checkRepaired.Checked && !comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.Finished.GetStatusString());
            }
            else if (comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
            {
                comboBoxStatus.Items.Remove(OrderStatus.Finished.GetStatusString());
            }
        }

        private void labelProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowProduct formShowProduct = new FormShowProduct(true, ProductsList.GetById(order.ProductId, true));
            formShowProduct.ShowDialog();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxStatus.SelectedItem.ToString() == OrderStatus.Finished.GetStatusString() || comboBoxStatus.SelectedItem.ToString() == OrderStatus.Canceled.GetStatusString())
            {
                LockUnlockFields(false);
            }
            else
            {
                LockUnlockFields(true);
            }
        }

        private void LockUnlockFields(bool unlock)
        {
            
            tbAddress.Enabled = unlock;
            btnFindMaster.Enabled = unlock;
            btnAutoMaster.Enabled = unlock;
            numericPaid.Enabled = unlock;

            if (!checkDiagnosted.Checked)
            {
                checkAnswer.Enabled = false;
            }
            else
            {
                checkAnswer.Enabled = unlock;
            }
            
            checkDiagnosted.Enabled = unlock;
            checkPrepaid.Enabled = unlock;
            checkRepaired.Enabled = unlock;
            checkPaid.Enabled = unlock;
            tbComment.Enabled = unlock;
            btnAddService.Enabled = unlock;
            btnDeleteService.Enabled = unlock;
            btnAddSparePart.Enabled = unlock;
            btnDelSparePart.Enabled = unlock;

            if (unlock)
            {
                lockedState = false;
            }
            else
            {
                lockedState = true;
            }
            //if(unlock && dataServies.CellContentDoubleClick)
        }

        private void btnDoneService_Click(object sender, EventArgs e)
        {
            if(dataServies.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Вы уверены, что хотите отметить ВСЕ выбранные услуги, как оказанные?", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataServies.SelectedRows)
                    {
                        OrderService anotherService = order.GetService(Convert.ToInt32(dataServies.Rows[row.Index].Cells[0].Value));
                        if (!anotherService.Done)
                        {
                            anotherService.Done = true;
                            order.EditService(anotherService);
                        }
                    }

                    FillServices();
                }
            }
        }

        private void manageButton1_Click(object sender, EventArgs e)
        {
            if (dataServies.SelectedRows.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Вы уверены, что хотите отметить ВСЕ выбранные услуги, как не оказанные?", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataServies.SelectedRows)
                    {
                        OrderService anotherService = order.GetService(Convert.ToInt32(dataServies.Rows[row.Index].Cells[0].Value));
                        if (anotherService.Done)
                        {
                            anotherService.Done = false;
                            order.EditService(anotherService);
                        }
                    }

                    FillServices();
                }
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Forms_TechServ.classes;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.employees;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.products;
using Forms_TechServ.classes.services;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.classes.UserSession;
using Forms_TechServ.forms.clients;
using Forms_TechServ.forms.employees;
using Forms_TechServ.forms.ordersLogs;
using Forms_TechServ.forms.products;
using Forms_TechServ.forms.services;
using Forms_TechServ.forms.spareParts;
using Forms_TechServ.forms.visits;

namespace Forms_TechServ.forms.orders
{
    public partial class FormEditOrder : Form
    {
        private readonly bool inOrder;
        private bool lockedState;
        private readonly Order order;
        private Size pickedSize = new Size(991, 531);
        private int servicesCurrentPage = 1;
        private int servicesRowsCount;
        private int sparePartsCurrentPage = 1;
        private int sparePartsRowsCount;

        public FormEditOrder(Order order)
        {
            InitializeComponent();

            this.order = order;
            if (order.GetType() != typeof(OrderAtHome))
            {
                inOrder = true;
                ordersTab.TabPages.Remove(visitsPage);
            }
        }

        private void OrdersTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersTab.SelectedTab.Equals(generalPage))
            {
                Size = new Size(700, 565);
            }
            else if (ordersTab.SelectedTab.Equals(servicesPage))
            {
                Size = pickedSize;

                FillServices();
            }
            else if (ordersTab.SelectedTab.Equals(sparePartsPage))
            {
                Size = pickedSize;

                FillSpareParts();
            }
            else if (ordersTab.SelectedTab.Equals(logsPage))
            {
                Size = pickedSize;

                var formOrdersLogs = new FormOrdersLogs(false, order);
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
                Size = pickedSize;

                var formVisits = new FormVisits(false, (OrderAtHome) order);
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
            if (!ordersTab.SelectedTab.Equals(generalPage)) pickedSize = Size;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var formServices = new FormServices(CategoriesList.GetById(order.Product.CategoryId, false));
            formServices.ShowDialog();

            if (formServices.service == null) return;


            if (order.CheckService(formServices.service))
            {
                MessageBox.Show("Эта услуга уже есть в заказе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var formManageOrderService = new FormManageOrderService(formServices.service);
                formManageOrderService.ShowDialog();

                if (!formManageOrderService.changed) return;

                if (order.AddService(formManageOrderService.orderService))
                {
                    FillServices();
                    RecalcFields();
                    MessageBox.Show("Услуга успешно добавлена в заказ", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Получены недопустимые значения", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddSparePart_Click(object sender, EventArgs e)
        {
            var formSpareParts = new FormSpareParts(true, order.Workshop);
            formSpareParts.ShowDialog();

            if (formSpareParts.sparePart == null) return;

            if (order.CheckSparePart(formSpareParts.sparePart))
            {
                MessageBox.Show("Эта деталь уже есть в заказе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sparePart = new OrderSparePart
                {
                    Order = order,
                    SparePart = formSpareParts.sparePart
                };

                var dialogResult =
                    MessageBox.Show("Желаете подобрать поставки автоматически (только из Вашей мастерской)?",
                        "Выберите способ добавления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var formManageOrderSparePart = new FormManageOrderSparePart();
                    formManageOrderSparePart.ShowDialog();

                    if (!formManageOrderSparePart.changed) return;

                    if (sparePart.FindBatchesAuto(formManageOrderSparePart.quantity))
                    {
                        MessageBox.Show("Деталь успешно добавлена", "Успех", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        FillSpareParts();
                        RecalcFields();
                    }
                    else
                    {
                        MessageBox.Show("В этой мастеркой нету выбранного количества этой детали", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var formOrderBatches = new FormOrderBatches(false, sparePart);
                    formOrderBatches.ShowDialog();

                    FillSpareParts();
                }
            }
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            if (dataServies.SelectedRows.Count > 0)
            {
                var formShowService = new FormShowService(true,
                    ServicesList.GetById(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value), true));
                formShowService.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите услугу");
            }
        }


        private void btnShowBatch_Click(object sender, EventArgs e)
        {
            if (dataSpareParts.SelectedRows.Count > 0)
            {
                var formShowSparePart = new FormShowSparePart(true,
                    SparePartsList.GetById((int) dataSpareParts.SelectedRows[0].Cells[0].Value));
                formShowSparePart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
        }

        private void FormEditOrder_Load(object sender, EventArgs e)
        {
            Size = new Size(700, 565);

            var delServiceCol = new DataGridViewButtonColumn();
            delServiceCol.FlatStyle = FlatStyle.Flat;
            delServiceCol.Name = "Удалить";
            dataServies.Columns.Add(delServiceCol);
            dataServies.CellContentClick += DelServiceCol_Click;

            var delSparePartCol = new DataGridViewButtonColumn();
            delSparePartCol.FlatStyle = FlatStyle.Flat;
            delSparePartCol.Name = "Удалить";
            dataSpareParts.Columns.Add(delSparePartCol);
            dataSpareParts.CellContentClick += DelSparePartCol_Click;

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
                tbAddress.Text = ((OrderAtHome) order).Address;
            }

            tbMaster.Text = order.Master.Name;
            tbMaster.Tag = order.Master;
            tbComment.Text = order.ClientComment;
            labelSale.Text = order.ClientSale + "%";
            labelLeftToPay.Text = (order.FinalPrice - order.PrepaymentMade).ToString();
            numericPaid.Value = order.PrepaymentMade;
            labelProduct.Text = order.Product.Name;

            if (order.DateDiagnostic.HasValue)
            {
                checkDiagnosted.Checked = true;
            }
            else
            {
                checkAnswer.Checked = false;
                checkAnswer.Enabled = false;
            }

            if (order.DatePrepayment.HasValue) checkPrepaid.Checked = true;


            if (order.DateClientAnswer.HasValue) checkAnswer.Checked = true;
            if (order.DateRepaired.HasValue) checkRepaired.Checked = true;
            if (order.DatePaid.HasValue) checkPaid.Checked = true;


            // БИНЬДИМ СОБЫТИЯ ВРУЧНУЮ, ЧТО ОНИ НЕ СРАБОТАЛИ ПРИ НАЧАЛЬНОЙ ЗАГРУЗКЕ ДАННЫХ В ФОРМУ
            checkDiagnosted.CheckedChanged += checkDiagnosted_CheckedChanged;
            checkPrepaid.CheckedChanged += checkPrepaid_CheckedChanged;
            checkRepaired.CheckedChanged += checkRepaired_CheckedChanged;

            comboBoxStatus.Items.Add(OrderStatus.WaitingForDiagnostic.GetStatusString());

            if (checkDiagnosted.Checked) comboBoxStatus.Items.Add(OrderStatus.WaitingForAnswer.GetStatusString());

            comboBoxStatus.Items.Add(OrderStatus.WaitingForPrepayment.GetStatusString());

            comboBoxStatus.Items.Add(OrderStatus.WaitingForSpareParts.GetStatusString());

            if (order.PrepaymentRequired == 0 || checkPrepaid.Checked)
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRepairing.GetStatusString());

            if (numericPaid.Value > 0) comboBoxStatus.Items.Add(OrderStatus.WaitingForRefund.GetStatusString());

            if (checkPaid.Checked && checkRepaired.Checked)
                comboBoxStatus.Items.Add(OrderStatus.Finished.GetStatusString());

            comboBoxStatus.Items.Add(OrderStatus.WaitingForPayment.GetStatusString());

            comboBoxStatus.Items.Add(OrderStatus.Canceled.GetStatusString());


            comboBoxStatus.SelectedItem = order.Status.GetStatusString();

            dataSpareParts.CellMouseDoubleClick += btnEditSparePartBatches_Click;

            RecalcFields();
        }


        private void btnFindClient_Click(object sender, EventArgs e)
        {
            var formClients = new FormClients(true);
            formClients.ShowDialog();
        }


        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            if (order is OrderAtHome orderAtHome && orderAtHome.GetVisits().Count > 0)
            {
                answer = MessageBox.Show(
                    "Смена мастера в заказе приведет с удалению ВСЕХ выездов, связанных с этим заказом, хотите продолжить?",
                    "ВНИМАНИЕ!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes && !UserSession.Can("add_del_visit"))
                {
                    MessageBox.Show("У Вас нету права для удаления выездов", "Недостаточно прав", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else answer = DialogResult.Yes;

            if (answer == DialogResult.Yes)
            {
                var formMasters = new FormMasters(CategoriesList.GetById(order.Product.CategoryId, false), order.Workshop);
                formMasters.ShowDialog();

                var newMaster = formMasters?.master;

                if (newMaster == null) return;

                if (newMaster.CheckMasterCategory(CategoriesList.GetById(order.Product.CategoryId, false)))
                {
                    tbMaster.Text = formMasters?.master?.Name;
                    tbMaster.Tag = formMasters?.master;
                }
                else
                {
                    MessageBox.Show("Данный мастер не обслуживает категорию выбранной техники");
                }
            }
        }


        private void btnAutoMaster_MouseHover(object sender, EventArgs e)
        {
            toolTipFindAuto.SetToolTip(btnAutoMaster, "Найти автоматически");
        }

        private void FillServices()
        {
            var services = order.GetServices(
                false,
                (int) comboBoxShowServicesRows.SelectedItem,
                servicesCurrentPage,
                out servicesRowsCount);

            dataServies.Rows.Clear();
            for (var i = 0; i < services.Count; i++)
            {
                dataServies.Rows.Add(new DataGridViewRow());

                dataServies.Rows[i].Cells[0].Value = services[i].ServiceId;
                dataServies.Rows[i].Cells[1].Value = services[i].Service.Name;
                dataServies.Rows[i].Cells[2].Value = services[i].Price;
                dataServies.Rows[i].Cells[3].Value = services[i].Quantity;
                dataServies.Rows[i].Cells[4].Value = services[i].Sale;
                dataServies.Rows[i].Cells[5].Value = services[i].CalcFullPrice();
                dataServies.Rows[i].Cells[6].Value = services[i].Done ? "Да" : "Нет";

                if (dataServies.Columns.Count > 7)
                {
                    dataServies.Rows[i].Cells[7].Value = "Удалить";
                    dataServies.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataServies.Rows[i].Cells[7].Style.ForeColor = Color.White;
                }
            }

            var maxPage = (int) Math.Ceiling((double) servicesRowsCount / (int) comboBoxShowServicesRows.SelectedItem);
            numericCurrentServicePage.Maximum = maxPage;

            if (numericCurrentServicePage.Maximum > 0)
                numericCurrentServicePage.Value =
                    numericCurrentServicePage.Value == 0 ? 1 : numericCurrentServicePage.Value;

            labelServicesPageCout.Text = $"из {maxPage}";
        }

        private void FillSpareParts()
        {
            var spareParts = order.GetSpareParts(
                (int) comboBoxShowSparePartsRows.SelectedItem,
                sparePartsCurrentPage,
                out sparePartsRowsCount);

            dataSpareParts.Rows.Clear();
            for (var i = 0; i < spareParts.Count; i++)
            {
                dataSpareParts.Rows.Add(new DataGridViewRow());

                dataSpareParts.Rows[i].Cells[0].Value = spareParts[i].SparePart.Id;
                dataSpareParts.Rows[i].Cells[1].Value = spareParts[i].SparePart.Name;
                dataSpareParts.Rows[i].Cells[2].Value = spareParts[i].CalcSparePartsQuanity();
                dataSpareParts.Rows[i].Cells[3].Value = spareParts[i].CalcPrice();
                dataSpareParts.Rows[i].Cells[4].Value = spareParts[i].CheckBatchesDelivered() ? "Да" : "Нет";

                if (dataSpareParts.Columns.Count > 5)
                {
                    dataSpareParts.Rows[i].Cells[5].Value = "Удалить";
                    dataSpareParts.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataSpareParts.Rows[i].Cells[5].Style.ForeColor = Color.White;
                }
            }

            var maxPage =
                (int) Math.Ceiling((double) sparePartsRowsCount / (int) comboBoxShowSparePartsRows.SelectedItem);
            numericCurrentSparePartPage.Maximum = maxPage;

            if (numericCurrentSparePartPage.Maximum > 0)
                numericCurrentSparePartPage.Value =
                    numericCurrentSparePartPage.Value == 0 ? 1 : numericCurrentSparePartPage.Value;

            labelSparePartsPageCount.Text = $"из {maxPage}";
        }


        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dataServies.SelectedRows.Count > 0)
            {
                var answer = MessageBox.Show("Вы уверены что хотите убрать ВСЕ выделенные услуги из заказа?",
                    "Подтвердите действие", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    var deletedCount = 0;
                    foreach (DataGridViewRow row in dataServies.SelectedRows)
                    {
                        var anotherService =
                            order.GetService(Convert.ToInt32(dataServies.Rows[row.Index].Cells[0].Value));
                        order.DelService(anotherService);
                        deletedCount++;
                    }

                    FillServices();
                    RecalcFields();
                    MessageBox.Show($"{deletedCount} услуг были удалены");
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите хотя бы одну услугу");
            }
        }

        private void DelServiceCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (lockedState) return;

            var grid = (DataGridView) sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var serviceToDel = order.GetService((int) dataServies.SelectedRows[0].Cells[0].Value);
                var answer =
                    MessageBox.Show($"Вы действительно хотите удалить из заказа услугу с id {serviceToDel.ServiceId}",
                        "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (order.DelService(serviceToDel))
                    {
                        FillServices();
                        RecalcFields();
                        MessageBox.Show("Услуга успешно удалена из заказа", "Готово", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataServies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lockedState || e.RowIndex == -1) return;
            var orderService = order.GetService(Convert.ToInt32(dataServies.SelectedRows[0].Cells[0].Value));
            var formManageOrderService =
                new FormManageOrderService(orderService); //batchSparePart.Quantity, batchSparePart.UnitPrice);
            formManageOrderService.ShowDialog();

            if (!formManageOrderService.changed) return;

            if (order.EditService(formManageOrderService.orderService))
            {
                FillServices();
                RecalcFields();
                MessageBox.Show("Данные об услуге успешно изменены", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Получены недопустимые значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextServ_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value + 1 > numericCurrentServicePage.Maximum
                ? numericCurrentServicePage.Value
                : numericCurrentServicePage.Value + 1;
        }

        private void btnPrevServ_Click(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value = numericCurrentServicePage.Value - 1 < numericCurrentServicePage.Minimum
                ? numericCurrentServicePage.Value
                : numericCurrentServicePage.Value - 1;
        }

        private void comboBoxShowServicesRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillServices();
        }

        private void numericCurrentServicePage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentServicePage.Value =
                (int) numericCurrentServicePage.Value; // если ввели дробное число, оно автоматически округлится
            servicesCurrentPage = (int) numericCurrentServicePage.Value;
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

            ChangeStatus();

            if (!checkPrepaid.Checked && order.PrepaymentRequired > 0)
                checkRepaired.Enabled = false;
            else
                checkRepaired.Enabled = true;
        }

        private void ChangeStatus()
        {
            if ((order.PrepaymentRequired == 0 || checkPrepaid.Checked) &&
                !comboBoxStatus.Items.Contains(OrderStatus.WaitingForRepairing.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRepairing.GetStatusString());
            }
            else if (order.PrepaymentRequired != 0 && !checkPrepaid.Checked &&
                     comboBoxStatus.Items.Contains(OrderStatus.WaitingForRepairing.GetStatusString()))
            {
                if (comboBoxStatus.SelectedItem.ToString() == OrderStatus.WaitingForRepairing.GetStatusString())
                {
                    order.Status = OrderStatus.WaitingForSpareParts;
                    order.EditOrder();
                    comboBoxStatus.SelectedItem = OrderStatus.WaitingForSpareParts.GetStatusString();
                }

                comboBoxStatus.Items.Remove(OrderStatus.WaitingForRepairing.GetStatusString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxShowSparePartsRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSpareParts();
        }

        private void numericCurrentSparePartPage_ValueChanged(object sender, EventArgs e)
        {
            numericCurrentSparePartPage.Value =
                (int) numericCurrentSparePartPage.Value; // если ввели дробное число, оно автоматически округлится
            sparePartsCurrentPage = (int) numericCurrentSparePartPage.Value;
            FillSpareParts();
        }


        private void btnNextSparePart_Click(object sender, EventArgs e)
        {
            numericCurrentSparePartPage.Value =
                numericCurrentSparePartPage.Value + 1 > numericCurrentSparePartPage.Maximum
                    ? numericCurrentSparePartPage.Value
                    : numericCurrentSparePartPage.Value + 1;
        }

        private void btnPrevSparePart_Click(object sender, EventArgs e)
        {
            numericCurrentSparePartPage.Value =
                numericCurrentSparePartPage.Value - 1 < numericCurrentSparePartPage.Minimum
                    ? numericCurrentSparePartPage.Value
                    : numericCurrentSparePartPage.Value - 1;
        }

        private void btnDelSparePart_Click(object sender, EventArgs e)
        {
            if (dataSpareParts.SelectedRows.Count > 0)
            {
                var answer = MessageBox.Show("Вы уверен что хотите удалить ВСЕ выделенные детали из заказа?",
                    "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    var deletedCount = 0;
                    foreach (DataGridViewRow row in dataSpareParts.SelectedRows)
                    {
                        var anotherSparePart =
                            order.GetSparePart(Convert.ToInt32(dataSpareParts.Rows[row.Index].Cells[0].Value));
                        anotherSparePart.DelSparePart();
                        deletedCount++;
                    }

                    FillSpareParts();
                    RecalcFields();
                    MessageBox.Show($"{deletedCount} деталей были удалены");
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите хотя бы одну деталь");
            }
        }

        private void DelSparePartCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView) sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var sparePartToDel = order.GetSparePart((int) dataSpareParts.SelectedRows[0].Cells[0].Value);
                var answer =
                    MessageBox.Show(
                        $"Вы действительно хотите удалить из заказа деталь с id {sparePartToDel.SparePart.Id}",
                        "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (sparePartToDel.DelSparePart())
                    {
                        FillSpareParts();
                        RecalcFields();
                        MessageBox.Show("Деталь успешно удалена из заказа", "Готово", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!inOrder && (tbAddress.Text == null || tbAddress.Text == string.Empty))
                MessageBox.Show("Адрес не может быть не указанным");
            else if (!inOrder) ((OrderAtHome) order).Address = tbAddress.Text;

            if (order.MasterId != ((Master) tbMaster.Tag).Id)                                                   // если сменими мастера, то удаляем все выезды на заказ
                if (!inOrder)
                    foreach (var visit in ((OrderAtHome) order).GetVisits())
                        visit.DelVisit();

            order.MasterId = ((Master) tbMaster.Tag).Id;
            order.Master = (Master) tbMaster.Tag;
            order.ClientComment = tbComment.Text;
            order.PrepaymentMade = numericPaid.Value;

            if (!order.DateDiagnostic.HasValue && checkDiagnosted.Checked)
                order.DateDiagnostic = DateTime.Now;
            else if (order.DateDiagnostic.HasValue && !checkDiagnosted.Checked) order.DateDiagnostic = null;

            if (!order.DateClientAnswer.HasValue && checkAnswer.Checked)
                order.DateClientAnswer = DateTime.Now;
            else if (order.DateClientAnswer.HasValue && !checkAnswer.Checked) order.DateClientAnswer = null;

            if (!order.DatePrepayment.HasValue && checkPrepaid.Checked)
                order.DatePrepayment = DateTime.Now;
            else if (order.DatePrepayment.HasValue && !checkPrepaid.Checked) order.DatePrepayment = null;

            if (!order.DatePaid.HasValue && checkPaid.Checked)
                order.DatePaid = DateTime.Now;
            else if (order.DatePaid.HasValue && !checkPaid.Checked) order.DatePaid = null;

            if (!order.DateRepaired.HasValue && checkRepaired.Checked)
                order.DateRepaired = DateTime.Now;
            else if (order.DateRepaired.HasValue && !checkRepaired.Checked) order.DateRepaired = null;

            if (!order.DateFinish.HasValue &&
                comboBoxStatus.SelectedItem.ToString() == OrderStatus.Finished.GetStatusString())
            {
                if (!order.CheckServicesDone())
                {
                    var answer = MessageBox.Show(
                        "В заказе есть услуги, не помеченные как выполенные, желатете автоматически отметить все услуги в заказе, как выполненные?",
                        "Выберите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                        foreach (var service in order.GetServices(true))
                        {
                            service.Done = true;
                            order.EditService(service);
                        }

                    if (answer == DialogResult.Cancel) return;

                    order.DateFinish = DateTime.Now;
                }
            }
            else if (order.DateFinish.HasValue &&
                     comboBoxStatus.SelectedItem.ToString() != OrderStatus.Finished.GetStatusString())
            {
                order.DateFinish = null;
            }

            if (!order.DateCancel.HasValue &&
                comboBoxStatus.SelectedItem.ToString() == OrderStatus.Canceled.GetStatusString())
            {
                var answer =
                    MessageBox.Show(
                        "Желаете также автоматически удалить все запчасти из заказа, чтоб освободить их для других заказов?",
                        "Выберите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    foreach (var sparePart in order.GetSpareParts())
                        sparePart.DelSparePart();

                order.DateCancel = DateTime.Now;
            }
            else if (order.DateCancel.HasValue &&
                     comboBoxStatus.SelectedItem.ToString() != OrderStatus.Canceled.GetStatusString())
            {
                order.DateCancel = null;
            }

            order.Status = StatusStringExtensions.GetStatusEnum(comboBoxStatus.SelectedItem.ToString());

            if (order.EditOrder())
            {
                MessageBox.Show("Информация о заказе успешно изменена", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка сохранения данных", "Что-то пошло не так ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAutoMaster_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            if (order is OrderAtHome orderAtHome && orderAtHome.GetVisits().Count > 0)
            {
                answer = MessageBox.Show(
                    "Смена мастера в заказе приведет с удалению ВСЕХ выездов, связанных с этим заказом, хотите продолжить?",
                    "ВНИМАНИЕ!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes && !UserSession.Can("add_del_visit"))
                {
                    MessageBox.Show("У Вас нету права для удаления выездов", "Недостаточно прав", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else answer = DialogResult.Yes;

            if (answer == DialogResult.Yes)
            {
                if (!order.FindMaster())
                {
                    MessageBox.Show("Не удается найти мастера с требуемой категорией", "Что-то пошло не так",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newMaster = MastersList.GetById(order.MasterId, false);
                tbMaster.Text = newMaster.Name;
                tbMaster.Tag = newMaster;
            }
        }

        private void checkPrepaid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrepaid.Checked && numericPaid.Value < order.PrepaymentRequired)
            {
                var answer =
                    MessageBox.Show(
                        "Указанная сумма внесенной предоплаты меньше расчитываемой суммы необходимой предоплаты, Вы уверены, что хотите продолжить?",
                        "подтвердите дейтсвие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (answer != DialogResult.Yes) checkPrepaid.Checked = false;
            }


            if (!checkPrepaid.Checked && order.PrepaymentRequired > 0)
            {
                checkRepaired.Enabled = false;
                checkRepaired.Checked = false;
            }
            else
            {
                checkRepaired.Enabled = true;
            }

            if ((order.PrepaymentRequired == 0 || checkPrepaid.Checked) &&
                !comboBoxStatus.Items.Contains(OrderStatus.WaitingForRepairing.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRepairing.GetStatusString());
            }
            else if (order.PrepaymentRequired != 0 && !checkPrepaid.Checked &&
                     comboBoxStatus.Items.Contains(OrderStatus.WaitingForRepairing.GetStatusString()))
            {
                if (comboBoxStatus.SelectedItem.ToString() == OrderStatus.WaitingForRepairing.GetStatusString())
                    comboBoxStatus.SelectedItem = OrderStatus.WaitingForSpareParts.GetStatusString();
                comboBoxStatus.Items.Remove(OrderStatus.WaitingForRepairing.GetStatusString());
            }
        }

        private void numericPaid_ValueChanged(object sender, EventArgs e)
        {
            labelLeftToPay.Text = (order.FinalPrice - numericPaid.Value).ToString();
            if (numericPaid.Value > 0 && !comboBoxStatus.Items.Contains(OrderStatus.WaitingForRefund.GetStatusString()))
            {
                comboBoxStatus.Items.Add(OrderStatus.WaitingForRefund.GetStatusString());
            }
            else if (numericPaid.Value == 0 &&
                     comboBoxStatus.Items.Contains(OrderStatus.WaitingForRefund.GetStatusString()))
            {
                if (comboBoxStatus.SelectedItem.ToString() == OrderStatus.WaitingForRefund.GetStatusString())
                    comboBoxStatus.SelectedItem = OrderStatus.WaitingForSpareParts.GetStatusString();
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

            if (checkDiagnosted.Checked &&
                !comboBoxStatus.Items.Contains(OrderStatus.WaitingForAnswer.GetStatusString()))
                comboBoxStatus.Items.Add(OrderStatus.WaitingForAnswer.GetStatusString());
            else if (comboBoxStatus.Items.Contains(OrderStatus.WaitingForAnswer.GetStatusString()))
                comboBoxStatus.Items.Remove(OrderStatus.WaitingForAnswer.GetStatusString());
        }

        private void checkRepaired_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRepaired.Checked)
                foreach (var sparePart in order.GetSpareParts())
                    if (!sparePart.CheckBatchesDelivered())
                    {
                        MessageBox.Show(
                            "Еще не все указанные для ремонта детали прибыли, пока это действие сделать навозможно",
                            "Невозможная операция", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        checkRepaired.Checked = false;
                        break;
                    }

            if (checkPaid.Checked && checkRepaired.Checked &&
                !comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
                comboBoxStatus.Items.Add(OrderStatus.Finished.GetStatusString());
            else if (comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
                comboBoxStatus.Items.Remove(OrderStatus.Finished.GetStatusString());
        }

        private void checkPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPaid.Checked && checkRepaired.Checked &&
                !comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
                comboBoxStatus.Items.Add(OrderStatus.Finished.GetStatusString());
            else if (comboBoxStatus.Items.Contains(OrderStatus.Finished.GetStatusString()))
                comboBoxStatus.Items.Remove(OrderStatus.Finished.GetStatusString());
        }

        private void labelProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formShowProduct = new FormShowProduct(true, ProductsList.GetById(order.ProductId, true));
            formShowProduct.ShowDialog();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem.ToString() == OrderStatus.Finished.GetStatusString() ||
                comboBoxStatus.SelectedItem.ToString() == OrderStatus.Canceled.GetStatusString())
                LockUnlockFields(false);
            else
                LockUnlockFields(true);
        }

        private void LockUnlockFields(bool unlock)
        {
            tbAddress.Enabled = unlock;
            btnFindMaster.Enabled = unlock;
            btnAutoMaster.Enabled = unlock;
            numericPaid.Enabled = unlock;

            if (!checkDiagnosted.Checked)
                checkAnswer.Enabled = false;
            else
                checkAnswer.Enabled = unlock;

            if (!checkPrepaid.Checked && order.PrepaymentRequired > 0)
                checkRepaired.Enabled = false;
            else
                checkRepaired.Enabled = unlock;

            checkDiagnosted.Enabled = unlock;
            checkPrepaid.Enabled = unlock;
            checkPaid.Enabled = unlock;
            tbComment.Enabled = unlock;
            btnAddService.Enabled = unlock;
            btnDeleteService.Enabled = unlock;
            btnAddSparePart.Enabled = unlock;
            btnDelSparePart.Enabled = unlock;


            if (unlock)
                lockedState = false;
            else
                lockedState = true;
        }

        private void btnDoneService_Click(object sender, EventArgs e)
        {
            if (dataServies.SelectedRows.Count > 0)
            {
                var answer = MessageBox.Show("Вы уверены, что хотите отметить ВСЕ выбранные услуги, как оказанные?",
                    "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataServies.SelectedRows)
                    {
                        var anotherService =
                            order.GetService(Convert.ToInt32(dataServies.Rows[row.Index].Cells[0].Value));
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
                var answer = MessageBox.Show("Вы уверены, что хотите отметить ВСЕ выбранные услуги, как не оказанные?",
                    "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataServies.SelectedRows)
                    {
                        var anotherService =
                            order.GetService(Convert.ToInt32(dataServies.Rows[row.Index].Cells[0].Value));
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

        private void btnEditSparePartBatches_Click(object sender, EventArgs e)
        {
            if (e is DataGridViewCellMouseEventArgs && ((DataGridViewCellMouseEventArgs) e).RowIndex == -1)
                return; // если кликнули по хеадеру грида
            if (dataSpareParts.SelectedRows.Count > 0)
            {
                // ЕСЛИ ФОРМА ЗАБЛОКИРОВАНА (ЗАКАЗ ЗАВЕРШЕН/ОТМЕНЕН), ТО ОТКРЫВАЕМ ТОЛЬКО ПРОСМОТР БЕЗ РЕДАКТИВАРОНИЯ ЗА СЧЕТ lockedState
                var formOrderBatches = new FormOrderBatches(lockedState,
                    order.GetSparePart((int) dataSpareParts.SelectedRows[0].Cells[0].Value));
                formOrderBatches.ShowDialog();

                FillSpareParts();
                RecalcFields();
            }
            else
            {
                MessageBox.Show("Для начала выберите деталь");
            }
        }
    }
}
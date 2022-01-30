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
    public partial class FormManageVisit : Form
    {
        Visit visit;

        int servicesRowsCount;
        int servicesCurrentPage = 1;
        //670; 292
        Size pickedSize = new Size(810, 390);

        public FormManageVisit()
        {
            InitializeComponent();

            btnAction.Text = "Сохранить и добавить услуги";

            checkDone.Visible = false;
            visit = new Visit();
        }

        public FormManageVisit(Visit visit)
        {
            InitializeComponent();

            btnAction.Text = "Сохранить";

            btnFindOrder.Visible = false;
            this.visit = visit;
        }

        public FormManageVisit(OrderAtHome order)
        {
            InitializeComponent();

            btnAction.Text = "Добавить";

            tbOrder.Text = order.Id.ToString();
            tbOrder.Tag = order;
            btnFindOrder.Visible = false;
            labelMaster.Text = order.Master.Name;
            checkDone.Visible = false;
            visit = new Visit();
        }

        private void btnFindOrder_Click(object sender, EventArgs e)
        {
            FormOutOrders formOutOrders = new FormOutOrders(true);
            formOutOrders.ShowDialog();

            tbOrder.Text = formOutOrders?.order?.Id.ToString();
            tbOrder.Tag = formOutOrders?.order;

            if(formOutOrders.order != null)
            {
                labelMaster.Text = formOutOrders.order.Master.Name;
            }
        }

        private void btnFindMaster_Click(object sender, EventArgs e)
        {
            FormMasters formMasters = new FormMasters(true);
            formMasters.ShowDialog();
        }

        private void FormManageVisit_Load(object sender, EventArgs e)
        {
            this.Size = new Size(670, 292);
            checkDone.Checked = false;
            if (visit.Id != 0)
            {
                labelMaster.Text = visit.Order.Master.Name;
                labelMaster.Tag = visit.Order.Master;
                tbOrder.Text = visit.OrderId.ToString();
                tbOrder.Tag = visit.Order;
                datePickerVisitDate.Value = visit.DateVisit;
                checkDone.Checked = visit.Done;
                tbComment.Text = visit.MasterComment;
                labelEstimatedTime.Text = visit.CalcEstimatedTime().ToString();

                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
                delCol.FlatStyle = FlatStyle.Flat;
                delCol.Name = "Удалить";
                dataServies.Columns.Add(delCol);

                dataServies.CellContentClick += DelCol_Click;

                comboBoxShowServicesRows.Items.Add(5);
                comboBoxShowServicesRows.Items.Add(10);
                comboBoxShowServicesRows.Items.Add(20);
                comboBoxShowServicesRows.SelectedIndex = 1;

                dataServies.CellMouseDoubleClick += btnShowService_Click;

                FillServices();
            }
            else
            {
                visitTabs.TabPages.Remove(servicesPage);
                labelEstimatedTime.Visible = false;
                labelTime.Visible = false;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                visit.OrderId = ((OrderAtHome)tbOrder.Tag).Id;
                visit.DateVisit = datePickerVisitDate.Value;
                visit.MasterComment = tbComment.Text;
                
                //visit.Done = checkDone.Checked;

                if(visit.Id == 0)
                {
                    if (visit.AddVisit())
                    {
                        this.Hide();
                        FormManageVisit formManageVisit = new FormManageVisit(VisitsList.GetById(visit.Id));
                        formManageVisit.ShowDialog();
                        //MessageBox.Show($"Новый выезд успешно добавлен. ID - {visit.Id}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Мастер, обслуживающий этот заказ не работает в выбранное время или в это время у него другой выезд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    visit.Order = (OrderAtHome)tbOrder.Tag;

                    bool doneStateBeforeSafe = visit.Done;
                    visit.Done = checkDone.Checked;

                    if (visit.EditVisit())
                    {
                        // ЕСЛИ ИЗМЕНЕНИЯ УСПЕШНО ПРИМЕНЕНЫ, ТО ПРЕДЛАГАЕМ ИЗМЕНИТЬ СОСТОЯНИЯ УСЛУГ В ЗАКАЗЕ
                        if (doneStateBeforeSafe == false && checkDone.Checked)
                        {
                            DialogResult answer = MessageBox.Show("Желаете также отметить услуги этотого выезда как 'выполненные'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (answer == DialogResult.Yes)
                            {
                                foreach (OrderService service in visit.GetVisitOrderServices())
                                {
                                    service.Done = true;
                                    visit.Order.EditService(service);
                                }
                            }
                        }

                        if (doneStateBeforeSafe == true && !checkDone.Checked)
                        {
                            DialogResult answer = MessageBox.Show("Желаете также отметить услуги этотого выезда как 'не выполненные'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (answer == DialogResult.Yes)
                            {
                                foreach (OrderService service in visit.GetVisitOrderServices())
                                {
                                    service.Done = false;
                                    visit.Order.EditService(service);
                                }
                            }
                        }

                        MessageBox.Show($"Данные о выезде успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Мастер, обслуживающий этот заказ не работает в выбранное время или в это время у него другой выезд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool CheckFields()
        {
            errorProvider.Clear();
            if(tbOrder.Tag == null)
            {
                errorProvider.SetError(btnFindOrder, "Выберите заказ");
                return false;
            }
            if(datePickerVisitDate.Value < ((OrderAtHome)tbOrder.Tag).DateStart)
            {
                errorProvider.SetError(datePickerVisitDate, "Дата выезда не может быть меньше даты начала заказа");
                return false;
            }
            return true;
        }

        private void labelMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(tbOrder.Tag == null)
            {
                return;
            }
            else
            {
                FormShowMaster formShowMaster = new FormShowMaster(true, MastersList.GetById(((OrderAtHome)tbOrder.Tag).MasterId, true));
                formShowMaster.ShowDialog();
            }
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

                if (dataServies.Columns.Count > 4)
                {
                    dataServies.Rows[i].Cells[4].Value = "Удалить";
                    dataServies.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(231, 57, 9);
                    dataServies.Rows[i].Cells[4].Style.ForeColor = Color.White;

                }
            }

            //int maxPage = (rowsCount / (int)comboBoxShowRows.SelectedItem) == 0 ? 1 : (int)Math.Ceiling(Convert.ToDouble( (double)rowsCount / (int)comboBoxShowRows.SelectedItem));
            int maxPage = (int)Math.Ceiling((double)servicesRowsCount / (int)comboBoxShowServicesRows.SelectedItem);
            numericCurrentServicePage.Maximum = maxPage;

            if (numericCurrentServicePage.Maximum > 0)
                numericCurrentServicePage.Value = numericCurrentServicePage.Value == 0 ? 1 : numericCurrentServicePage.Value;

            labelServicesPageCout.Text = $"из {maxPage}";
        }

        private void DelCol_Click(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Service serviceToDel = ServicesList.GetById((int)dataServies.SelectedRows[0].Cells[0].Value, false);
                DialogResult answer = MessageBox.Show($"Вы действительно хотите удалить из выезда услугу с id {serviceToDel.Id}", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (visit.DelService(serviceToDel))
                    {
                        MessageBox.Show("Услуга успешно удалена из выезда", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillServices();
                        labelEstimatedTime.Text = visit.CalcEstimatedTime().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            FormOrderServices formOrderServices = new FormOrderServices(visit.Order);
            formOrderServices.ShowDialog();

            if(formOrderServices.service == null)
            {
                return;
            }

            if (visit.CheckService(formOrderServices.service))
            {
                MessageBox.Show("В этом выезде уже есть эта услуга");
            }
            else
            {
                if(VisitsList.IsAlreadyPlanned(visit.OrderId, formOrderServices.service.Id))
                {
                    DialogResult answer = MessageBox.Show("Эту услугу к этому заказу уже планируется оказать в другом заказе, продолжить в любом случае?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(answer != DialogResult.Yes)
                    {
                        return;
                    }
                }

                if (visit.AddService(formOrderServices.service))
                {
                    MessageBox.Show("Услуга добавлена к выезду", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillServices();
                    labelEstimatedTime.Text = visit.CalcEstimatedTime().ToString();
                }
                else
                {
                    MessageBox.Show("Мастер не успеет закончить закончить выезд до конца смены/следующего выезда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnDelService_Click(object sender, EventArgs e)
        {
            if (dataServies.SelectedRows.Count > 0)
            {
                
                DialogResult answer = MessageBox.Show("Вы уверены, что хотите удалить ВСЕ выделенные услуги из выезда?", "Подтверидте действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes)
                {
                    int deleted = 0;
                    foreach (DataGridViewRow row in dataServies.SelectedRows)
                    {
                        Service anotherService = ServicesList.GetById((int)dataServies.Rows[row.Index].Cells[0].Value, false);
                        visit.DelService(anotherService);
                        deleted++;
                    }

                    FillServices();
                    labelEstimatedTime.Text = visit.CalcEstimatedTime().ToString();
                    MessageBox.Show($"{deleted} услуг были удалены");
                }
                
            }
            else
            {
                MessageBox.Show("Для начала выберите хотя бы одну услугу");
            }
        }

        private void visitTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visitTabs.SelectedTab.Equals(generalPage))
            {
                this.Size = new Size(670, 292);
            }
            else if (visitTabs.SelectedTab.Equals(servicesPage))
            {
                this.Size = pickedSize;
            }
        }

        /*private void FormManageVisit_ResizeEnd(object sender, EventArgs e)
        {
            if (!visitTabs.SelectedTab.Equals(generalPage))
                pickedSize = this.Size;
        }*/
    }
}

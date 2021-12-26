
namespace Forms_TechServ
{
    partial class FormEditOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ordersTab = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelProduct = new System.Windows.Forms.LinkLabel();
            this.checkPaid = new System.Windows.Forms.CheckBox();
            this.checkAnswer = new System.Windows.Forms.CheckBox();
            this.labelLeftToPay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupPrepayment = new System.Windows.Forms.GroupBox();
            this.numericPaid = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPrepaymentRequired = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.labelSparePartsPrice = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.labelSparePartsCount = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.labelServicesPrice = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.labelServicesCount = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.checkPrepaid = new System.Windows.Forms.CheckBox();
            this.checkRepaired = new System.Windows.Forms.CheckBox();
            this.checkDiagnosted = new System.Windows.Forms.CheckBox();
            this.btnAutoMaster = new FontAwesome.Sharp.IconButton();
            this.btnFindMaster = new FontAwesome.Sharp.IconButton();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tbMaster = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.servicesPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowServicesRows = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelServicesPageCout = new System.Windows.Forms.Label();
            this.numericCurrentServicePage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNextServ = new System.Windows.Forms.Button();
            this.btnPrevServ = new System.Windows.Forms.Button();
            this.dataServies = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteService = new Forms_TechServ.ManageButton();
            this.btnAddService = new Forms_TechServ.ManageButton();
            this.btnShowService = new Forms_TechServ.ManageButton();
            this.sparePartsPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxShowSparePartsRows = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSparePartsPageCount = new System.Windows.Forms.Label();
            this.numericCurrentSparePartPage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNextSparePart = new System.Windows.Forms.Button();
            this.btnPrevSparePart = new System.Windows.Forms.Button();
            this.dataSpareParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelSparePart = new Forms_TechServ.ManageButton();
            this.btnAddSparePart = new Forms_TechServ.ManageButton();
            this.btnShowSparePart = new Forms_TechServ.ManageButton();
            this.logsPage = new System.Windows.Forms.TabPage();
            this.visitsPage = new System.Windows.Forms.TabPage();
            this.toolTipFindAuto = new System.Windows.Forms.ToolTip(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDoneService = new Forms_TechServ.ManageButton();
            this.manageButton1 = new Forms_TechServ.ManageButton();
            this.ordersTab.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.groupPrepayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaid)).BeginInit();
            this.servicesPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).BeginInit();
            this.panel2.SuspendLayout();
            this.sparePartsPage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentSparePartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.generalPage);
            this.ordersTab.Controls.Add(this.servicesPage);
            this.ordersTab.Controls.Add(this.sparePartsPage);
            this.ordersTab.Controls.Add(this.logsPage);
            this.ordersTab.Controls.Add(this.visitsPage);
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(0, 0);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.SelectedIndex = 0;
            this.ordersTab.Size = new System.Drawing.Size(975, 525);
            this.ordersTab.TabIndex = 0;
            this.ordersTab.SelectedIndexChanged += new System.EventHandler(this.OrdersTab_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelProduct);
            this.generalPage.Controls.Add(this.checkPaid);
            this.generalPage.Controls.Add(this.checkAnswer);
            this.generalPage.Controls.Add(this.labelLeftToPay);
            this.generalPage.Controls.Add(this.label9);
            this.generalPage.Controls.Add(this.groupPrepayment);
            this.generalPage.Controls.Add(this.labelSale);
            this.generalPage.Controls.Add(this.label45);
            this.generalPage.Controls.Add(this.labelSparePartsPrice);
            this.generalPage.Controls.Add(this.label43);
            this.generalPage.Controls.Add(this.labelSparePartsCount);
            this.generalPage.Controls.Add(this.label41);
            this.generalPage.Controls.Add(this.labelServicesPrice);
            this.generalPage.Controls.Add(this.label39);
            this.generalPage.Controls.Add(this.labelServicesCount);
            this.generalPage.Controls.Add(this.label31);
            this.generalPage.Controls.Add(this.label10);
            this.generalPage.Controls.Add(this.labelFinalPrice);
            this.generalPage.Controls.Add(this.checkPrepaid);
            this.generalPage.Controls.Add(this.checkRepaired);
            this.generalPage.Controls.Add(this.checkDiagnosted);
            this.generalPage.Controls.Add(this.btnAutoMaster);
            this.generalPage.Controls.Add(this.btnFindMaster);
            this.generalPage.Controls.Add(this.tbAddress);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.btnSave);
            this.generalPage.Controls.Add(this.comboBoxStatus);
            this.generalPage.Controls.Add(this.tbMaster);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.tbComment);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.label26);
            this.generalPage.Controls.Add(this.label21);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(967, 499);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(92, 54);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(55, 13);
            this.labelProduct.TabIndex = 191;
            this.labelProduct.TabStop = true;
            this.labelProduct.Text = "linkLabel1";
            this.labelProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelProduct_LinkClicked);
            // 
            // checkPaid
            // 
            this.checkPaid.AutoSize = true;
            this.checkPaid.Location = new System.Drawing.Point(288, 162);
            this.checkPaid.Name = "checkPaid";
            this.checkPaid.Size = new System.Drawing.Size(112, 17);
            this.checkPaid.TabIndex = 190;
            this.checkPaid.Text = "Оплата получена";
            this.checkPaid.UseVisualStyleBackColor = true;
            this.checkPaid.CheckedChanged += new System.EventHandler(this.checkPaid_CheckedChanged);
            // 
            // checkAnswer
            // 
            this.checkAnswer.AutoSize = true;
            this.checkAnswer.Location = new System.Drawing.Point(288, 54);
            this.checkAnswer.Name = "checkAnswer";
            this.checkAnswer.Size = new System.Drawing.Size(143, 17);
            this.checkAnswer.TabIndex = 189;
            this.checkAnswer.Text = "Ответ клиента получен";
            this.checkAnswer.UseVisualStyleBackColor = true;
            // 
            // labelLeftToPay
            // 
            this.labelLeftToPay.AutoSize = true;
            this.labelLeftToPay.Location = new System.Drawing.Point(112, 390);
            this.labelLeftToPay.Name = "labelLeftToPay";
            this.labelLeftToPay.Size = new System.Drawing.Size(41, 13);
            this.labelLeftToPay.TabIndex = 188;
            this.labelLeftToPay.Text = "label11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 187;
            this.label9.Text = "К оплате:";
            // 
            // groupPrepayment
            // 
            this.groupPrepayment.Controls.Add(this.numericPaid);
            this.groupPrepayment.Controls.Add(this.label44);
            this.groupPrepayment.Controls.Add(this.label8);
            this.groupPrepayment.Controls.Add(this.labelPrepaymentRequired);
            this.groupPrepayment.Location = new System.Drawing.Point(22, 414);
            this.groupPrepayment.Name = "groupPrepayment";
            this.groupPrepayment.Size = new System.Drawing.Size(197, 79);
            this.groupPrepayment.TabIndex = 186;
            this.groupPrepayment.TabStop = false;
            this.groupPrepayment.Text = "Предоплата";
            // 
            // numericPaid
            // 
            this.numericPaid.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericPaid.Location = new System.Drawing.Point(87, 53);
            this.numericPaid.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPaid.Name = "numericPaid";
            this.numericPaid.Size = new System.Drawing.Size(85, 20);
            this.numericPaid.TabIndex = 170;
            this.numericPaid.ValueChanged += new System.EventHandler(this.numericPaid_ValueChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 57);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(53, 13);
            this.label44.TabIndex = 1;
            this.label44.Text = "Внесено:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Требуется:";
            // 
            // labelPrepaymentRequired
            // 
            this.labelPrepaymentRequired.AutoSize = true;
            this.labelPrepaymentRequired.Location = new System.Drawing.Point(84, 24);
            this.labelPrepaymentRequired.Name = "labelPrepaymentRequired";
            this.labelPrepaymentRequired.Size = new System.Drawing.Size(13, 13);
            this.labelPrepaymentRequired.TabIndex = 169;
            this.labelPrepaymentRequired.Text = "0";
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(112, 320);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(41, 13);
            this.labelSale.TabIndex = 179;
            this.labelSale.Text = "label46";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(19, 320);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(91, 13);
            this.label45.TabIndex = 178;
            this.label45.Text = "Скидка клиента:";
            // 
            // labelSparePartsPrice
            // 
            this.labelSparePartsPrice.AutoSize = true;
            this.labelSparePartsPrice.Location = new System.Drawing.Point(112, 283);
            this.labelSparePartsPrice.Name = "labelSparePartsPrice";
            this.labelSparePartsPrice.Size = new System.Drawing.Size(41, 13);
            this.labelSparePartsPrice.TabIndex = 177;
            this.labelSparePartsPrice.Text = "label44";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(19, 283);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 13);
            this.label43.TabIndex = 176;
            this.label43.Text = "Цена за детали:";
            // 
            // labelSparePartsCount
            // 
            this.labelSparePartsCount.AutoSize = true;
            this.labelSparePartsCount.Location = new System.Drawing.Point(113, 246);
            this.labelSparePartsCount.Name = "labelSparePartsCount";
            this.labelSparePartsCount.Size = new System.Drawing.Size(41, 13);
            this.labelSparePartsCount.TabIndex = 175;
            this.labelSparePartsCount.Text = "label42";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(20, 246);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(88, 13);
            this.label41.TabIndex = 174;
            this.label41.Text = "Кол-во деталей:";
            // 
            // labelServicesPrice
            // 
            this.labelServicesPrice.AutoSize = true;
            this.labelServicesPrice.Location = new System.Drawing.Point(112, 206);
            this.labelServicesPrice.Name = "labelServicesPrice";
            this.labelServicesPrice.Size = new System.Drawing.Size(41, 13);
            this.labelServicesPrice.TabIndex = 173;
            this.labelServicesPrice.Text = "label40";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(19, 206);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(87, 13);
            this.label39.TabIndex = 172;
            this.label39.Text = "Цена за услуги:";
            // 
            // labelServicesCount
            // 
            this.labelServicesCount.AutoSize = true;
            this.labelServicesCount.Location = new System.Drawing.Point(113, 166);
            this.labelServicesCount.Name = "labelServicesCount";
            this.labelServicesCount.Size = new System.Drawing.Size(41, 13);
            this.labelServicesCount.TabIndex = 171;
            this.labelServicesCount.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 166);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 13);
            this.label31.TabIndex = 170;
            this.label31.Text = "Кол-во услуг:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 166;
            this.label10.Text = "Конечная цена:";
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.Location = new System.Drawing.Point(113, 356);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(37, 13);
            this.labelFinalPrice.TabIndex = 167;
            this.labelFinalPrice.Text = "33333";
            // 
            // checkPrepaid
            // 
            this.checkPrepaid.AutoSize = true;
            this.checkPrepaid.Location = new System.Drawing.Point(288, 89);
            this.checkPrepaid.Name = "checkPrepaid";
            this.checkPrepaid.Size = new System.Drawing.Size(136, 17);
            this.checkPrepaid.TabIndex = 165;
            this.checkPrepaid.Text = "Предоплата получена";
            this.checkPrepaid.UseVisualStyleBackColor = true;
            // 
            // checkRepaired
            // 
            this.checkRepaired.AutoSize = true;
            this.checkRepaired.Location = new System.Drawing.Point(288, 124);
            this.checkRepaired.Name = "checkRepaired";
            this.checkRepaired.Size = new System.Drawing.Size(115, 17);
            this.checkRepaired.TabIndex = 161;
            this.checkRepaired.Text = "Ремонт проведен";
            this.checkRepaired.UseVisualStyleBackColor = true;
            // 
            // checkDiagnosted
            // 
            this.checkDiagnosted.AutoSize = true;
            this.checkDiagnosted.Location = new System.Drawing.Point(288, 19);
            this.checkDiagnosted.Name = "checkDiagnosted";
            this.checkDiagnosted.Size = new System.Drawing.Size(150, 17);
            this.checkDiagnosted.TabIndex = 159;
            this.checkDiagnosted.Text = "Диагностика проведена";
            this.checkDiagnosted.UseVisualStyleBackColor = true;
            // 
            // btnAutoMaster
            // 
            this.btnAutoMaster.FlatAppearance.BorderSize = 0;
            this.btnAutoMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoMaster.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAutoMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnAutoMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAutoMaster.IconSize = 17;
            this.btnAutoMaster.Location = new System.Drawing.Point(245, 89);
            this.btnAutoMaster.Name = "btnAutoMaster";
            this.btnAutoMaster.Size = new System.Drawing.Size(18, 18);
            this.btnAutoMaster.TabIndex = 157;
            this.btnAutoMaster.UseVisualStyleBackColor = true;
            this.btnAutoMaster.Click += new System.EventHandler(this.btnAutoMaster_Click);
            this.btnAutoMaster.MouseHover += new System.EventHandler(this.btnAutoMaster_MouseHover);
            // 
            // btnFindMaster
            // 
            this.btnFindMaster.FlatAppearance.BorderSize = 0;
            this.btnFindMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMaster.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindMaster.IconSize = 17;
            this.btnFindMaster.Location = new System.Drawing.Point(221, 88);
            this.btnFindMaster.Name = "btnFindMaster";
            this.btnFindMaster.Size = new System.Drawing.Size(18, 18);
            this.btnFindMaster.TabIndex = 158;
            this.btnFindMaster.UseVisualStyleBackColor = true;
            this.btnFindMaster.Click += new System.EventHandler(this.btnFindMaster_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(95, 17);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(105, 20);
            this.tbAddress.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Адрес:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(530, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 150;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(530, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 40);
            this.btnSave.TabIndex = 149;
            this.btnSave.Text = "Сохранить общую информацию";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(95, 122);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(168, 21);
            this.comboBoxStatus.TabIndex = 148;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // tbMaster
            // 
            this.tbMaster.Enabled = false;
            this.tbMaster.Location = new System.Drawing.Point(95, 87);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.ReadOnly = true;
            this.tbMaster.Size = new System.Drawing.Size(120, 20);
            this.tbMaster.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "Техника";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(288, 222);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(197, 213);
            this.tbComment.TabIndex = 143;
            this.tbComment.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 139;
            this.label7.Text = "Статус:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(329, 206);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 13);
            this.label26.TabIndex = 142;
            this.label26.Text = "Комментарий клиента";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 140;
            this.label21.Text = "Мастер";
            // 
            // servicesPage
            // 
            this.servicesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.servicesPage.Controls.Add(this.panel1);
            this.servicesPage.Controls.Add(this.panel2);
            this.servicesPage.Location = new System.Drawing.Point(4, 22);
            this.servicesPage.Name = "servicesPage";
            this.servicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.servicesPage.Size = new System.Drawing.Size(967, 499);
            this.servicesPage.TabIndex = 1;
            this.servicesPage.Text = "Услуги";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxShowServicesRows);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelServicesPageCout);
            this.panel1.Controls.Add(this.numericCurrentServicePage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNextServ);
            this.panel1.Controls.Add(this.btnPrevServ);
            this.panel1.Controls.Add(this.dataServies);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 499);
            this.panel1.TabIndex = 6;
            // 
            // comboBoxShowServicesRows
            // 
            this.comboBoxShowServicesRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowServicesRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowServicesRows.FormattingEnabled = true;
            this.comboBoxShowServicesRows.Location = new System.Drawing.Point(539, 471);
            this.comboBoxShowServicesRows.Name = "comboBoxShowServicesRows";
            this.comboBoxShowServicesRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowServicesRows.TabIndex = 12;
            this.comboBoxShowServicesRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowServicesRows_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(426, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Показывать по";
            // 
            // labelServicesPageCout
            // 
            this.labelServicesPageCout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelServicesPageCout.AutoSize = true;
            this.labelServicesPageCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelServicesPageCout.Location = new System.Drawing.Point(309, 471);
            this.labelServicesPageCout.Name = "labelServicesPageCout";
            this.labelServicesPageCout.Size = new System.Drawing.Size(36, 17);
            this.labelServicesPageCout.TabIndex = 10;
            this.labelServicesPageCout.Text = "из S";
            // 
            // numericCurrentServicePage
            // 
            this.numericCurrentServicePage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentServicePage.Location = new System.Drawing.Point(258, 472);
            this.numericCurrentServicePage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentServicePage.Name = "numericCurrentServicePage";
            this.numericCurrentServicePage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentServicePage.TabIndex = 9;
            this.numericCurrentServicePage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentServicePage.ValueChanged += new System.EventHandler(this.numericCurrentServicePage_ValueChanged);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(180, 471);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 8;
            this.label28.Text = "Страница";
            // 
            // btnNextServ
            // 
            this.btnNextServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextServ.FlatAppearance.BorderSize = 0;
            this.btnNextServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextServ.Location = new System.Drawing.Point(652, 459);
            this.btnNextServ.Name = "btnNextServ";
            this.btnNextServ.Size = new System.Drawing.Size(130, 40);
            this.btnNextServ.TabIndex = 4;
            this.btnNextServ.Text = "Следующая →";
            this.btnNextServ.UseVisualStyleBackColor = false;
            this.btnNextServ.Click += new System.EventHandler(this.btnNextServ_Click);
            // 
            // btnPrevServ
            // 
            this.btnPrevServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevServ.FlatAppearance.BorderSize = 0;
            this.btnPrevServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevServ.Location = new System.Drawing.Point(0, 459);
            this.btnPrevServ.Name = "btnPrevServ";
            this.btnPrevServ.Size = new System.Drawing.Size(130, 40);
            this.btnPrevServ.TabIndex = 3;
            this.btnPrevServ.Text = "← Предыдущая";
            this.btnPrevServ.UseVisualStyleBackColor = false;
            this.btnPrevServ.Click += new System.EventHandler(this.btnPrevServ_Click);
            // 
            // dataServies
            // 
            this.dataServies.AllowUserToAddRows = false;
            this.dataServies.AllowUserToDeleteRows = false;
            this.dataServies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataServies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataServies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataServies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.column_sale,
            this.Column5,
            this.Column7});
            this.dataServies.Location = new System.Drawing.Point(0, 0);
            this.dataServies.Name = "dataServies";
            this.dataServies.ReadOnly = true;
            this.dataServies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataServies.Size = new System.Drawing.Size(782, 459);
            this.dataServies.TabIndex = 1;
            this.dataServies.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataServies_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.manageButton1);
            this.panel2.Controls.Add(this.btnDoneService);
            this.panel2.Controls.Add(this.btnDeleteService);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.btnShowService);
            this.panel2.Location = new System.Drawing.Point(782, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 503);
            this.panel2.TabIndex = 5;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDeleteService.FlatAppearance.BorderSize = 0;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteService.Location = new System.Drawing.Point(0, 40);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(185, 40);
            this.btnDeleteService.TabIndex = 2;
            this.btnDeleteService.Text = "Удалить";
            this.btnDeleteService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddService.Location = new System.Drawing.Point(0, 0);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(185, 40);
            this.btnAddService.TabIndex = 1;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnShowService
            // 
            this.btnShowService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowService.FlatAppearance.BorderSize = 0;
            this.btnShowService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowService.Location = new System.Drawing.Point(0, 80);
            this.btnShowService.Name = "btnShowService";
            this.btnShowService.Size = new System.Drawing.Size(185, 40);
            this.btnShowService.TabIndex = 0;
            this.btnShowService.Text = "Просмотреть";
            this.btnShowService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowService.UseVisualStyleBackColor = false;
            this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);
            // 
            // sparePartsPage
            // 
            this.sparePartsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.sparePartsPage.Controls.Add(this.panel3);
            this.sparePartsPage.Controls.Add(this.panel4);
            this.sparePartsPage.Location = new System.Drawing.Point(4, 22);
            this.sparePartsPage.Name = "sparePartsPage";
            this.sparePartsPage.Padding = new System.Windows.Forms.Padding(3);
            this.sparePartsPage.Size = new System.Drawing.Size(967, 499);
            this.sparePartsPage.TabIndex = 2;
            this.sparePartsPage.Text = "Детали";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.comboBoxShowSparePartsRows);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labelSparePartsPageCount);
            this.panel3.Controls.Add(this.numericCurrentSparePartPage);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnNextSparePart);
            this.panel3.Controls.Add(this.btnPrevSparePart);
            this.panel3.Controls.Add(this.dataSpareParts);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 499);
            this.panel3.TabIndex = 7;
            // 
            // comboBoxShowSparePartsRows
            // 
            this.comboBoxShowSparePartsRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowSparePartsRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowSparePartsRows.FormattingEnabled = true;
            this.comboBoxShowSparePartsRows.Location = new System.Drawing.Point(539, 471);
            this.comboBoxShowSparePartsRows.Name = "comboBoxShowSparePartsRows";
            this.comboBoxShowSparePartsRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowSparePartsRows.TabIndex = 14;
            this.comboBoxShowSparePartsRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowSparePartsRows_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(426, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Показывать по";
            // 
            // labelSparePartsPageCount
            // 
            this.labelSparePartsPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSparePartsPageCount.AutoSize = true;
            this.labelSparePartsPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelSparePartsPageCount.Location = new System.Drawing.Point(309, 471);
            this.labelSparePartsPageCount.Name = "labelSparePartsPageCount";
            this.labelSparePartsPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelSparePartsPageCount.TabIndex = 10;
            this.labelSparePartsPageCount.Text = "из S";
            // 
            // numericCurrentSparePartPage
            // 
            this.numericCurrentSparePartPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentSparePartPage.Location = new System.Drawing.Point(258, 472);
            this.numericCurrentSparePartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentSparePartPage.Name = "numericCurrentSparePartPage";
            this.numericCurrentSparePartPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentSparePartPage.TabIndex = 9;
            this.numericCurrentSparePartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentSparePartPage.ValueChanged += new System.EventHandler(this.numericCurrentSparePartPage_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(180, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Страница";
            // 
            // btnNextSparePart
            // 
            this.btnNextSparePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextSparePart.FlatAppearance.BorderSize = 0;
            this.btnNextSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextSparePart.Location = new System.Drawing.Point(652, 459);
            this.btnNextSparePart.Name = "btnNextSparePart";
            this.btnNextSparePart.Size = new System.Drawing.Size(130, 40);
            this.btnNextSparePart.TabIndex = 4;
            this.btnNextSparePart.Text = "Следующая →";
            this.btnNextSparePart.UseVisualStyleBackColor = false;
            this.btnNextSparePart.Click += new System.EventHandler(this.btnNextSparePart_Click);
            // 
            // btnPrevSparePart
            // 
            this.btnPrevSparePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevSparePart.FlatAppearance.BorderSize = 0;
            this.btnPrevSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevSparePart.Location = new System.Drawing.Point(0, 459);
            this.btnPrevSparePart.Name = "btnPrevSparePart";
            this.btnPrevSparePart.Size = new System.Drawing.Size(130, 40);
            this.btnPrevSparePart.TabIndex = 3;
            this.btnPrevSparePart.Text = "← Предыдущая";
            this.btnPrevSparePart.UseVisualStyleBackColor = false;
            this.btnPrevSparePart.Click += new System.EventHandler(this.btnPrevSparePart_Click);
            // 
            // dataSpareParts
            // 
            this.dataSpareParts.AllowUserToAddRows = false;
            this.dataSpareParts.AllowUserToDeleteRows = false;
            this.dataSpareParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSpareParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSpareParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpareParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6});
            this.dataSpareParts.Location = new System.Drawing.Point(0, 0);
            this.dataSpareParts.MultiSelect = false;
            this.dataSpareParts.Name = "dataSpareParts";
            this.dataSpareParts.ReadOnly = true;
            this.dataSpareParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSpareParts.Size = new System.Drawing.Size(782, 459);
            this.dataSpareParts.TabIndex = 1;
            this.dataSpareParts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataSpareParts_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Общая цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Прибыли";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnDelSparePart);
            this.panel4.Controls.Add(this.btnAddSparePart);
            this.panel4.Controls.Add(this.btnShowSparePart);
            this.panel4.Location = new System.Drawing.Point(782, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 499);
            this.panel4.TabIndex = 6;
            // 
            // btnDelSparePart
            // 
            this.btnDelSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDelSparePart.FlatAppearance.BorderSize = 0;
            this.btnDelSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelSparePart.Location = new System.Drawing.Point(0, 40);
            this.btnDelSparePart.Name = "btnDelSparePart";
            this.btnDelSparePart.Size = new System.Drawing.Size(185, 40);
            this.btnDelSparePart.TabIndex = 2;
            this.btnDelSparePart.Text = "Удалить";
            this.btnDelSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSparePart.UseVisualStyleBackColor = false;
            this.btnDelSparePart.Click += new System.EventHandler(this.btnDelSparePart_Click);
            // 
            // btnAddSparePart
            // 
            this.btnAddSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAddSparePart.FlatAppearance.BorderSize = 0;
            this.btnAddSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddSparePart.Location = new System.Drawing.Point(0, 0);
            this.btnAddSparePart.Name = "btnAddSparePart";
            this.btnAddSparePart.Size = new System.Drawing.Size(185, 40);
            this.btnAddSparePart.TabIndex = 1;
            this.btnAddSparePart.Text = "Добавить";
            this.btnAddSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSparePart.UseVisualStyleBackColor = false;
            this.btnAddSparePart.Click += new System.EventHandler(this.btnAddSparePart_Click);
            // 
            // btnShowSparePart
            // 
            this.btnShowSparePart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowSparePart.FlatAppearance.BorderSize = 0;
            this.btnShowSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowSparePart.Location = new System.Drawing.Point(0, 80);
            this.btnShowSparePart.Name = "btnShowSparePart";
            this.btnShowSparePart.Size = new System.Drawing.Size(185, 40);
            this.btnShowSparePart.TabIndex = 0;
            this.btnShowSparePart.Text = "Просмотреть";
            this.btnShowSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowSparePart.UseVisualStyleBackColor = false;
            this.btnShowSparePart.Click += new System.EventHandler(this.btnShowBatch_Click);
            // 
            // logsPage
            // 
            this.logsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.logsPage.Location = new System.Drawing.Point(4, 22);
            this.logsPage.Name = "logsPage";
            this.logsPage.Padding = new System.Windows.Forms.Padding(3);
            this.logsPage.Size = new System.Drawing.Size(967, 499);
            this.logsPage.TabIndex = 3;
            this.logsPage.Text = "История";
            // 
            // visitsPage
            // 
            this.visitsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.visitsPage.Location = new System.Drawing.Point(4, 22);
            this.visitsPage.Name = "visitsPage";
            this.visitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.visitsPage.Size = new System.Drawing.Size(967, 499);
            this.visitsPage.TabIndex = 4;
            this.visitsPage.Text = "Выезды";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена за одну";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // column_sale
            // 
            this.column_sale.HeaderText = "Скидка";
            this.column_sale.Name = "column_sale";
            this.column_sale.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Общая цена";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Сделано";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnDoneService
            // 
            this.btnDoneService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoneService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDoneService.FlatAppearance.BorderSize = 0;
            this.btnDoneService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoneService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDoneService.Location = new System.Drawing.Point(0, 120);
            this.btnDoneService.Name = "btnDoneService";
            this.btnDoneService.Size = new System.Drawing.Size(185, 40);
            this.btnDoneService.TabIndex = 3;
            this.btnDoneService.Text = "Отметить как \'сделано\'";
            this.btnDoneService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoneService.UseVisualStyleBackColor = false;
            this.btnDoneService.Click += new System.EventHandler(this.btnDoneService_Click);
            // 
            // manageButton1
            // 
            this.manageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.manageButton1.FlatAppearance.BorderSize = 0;
            this.manageButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.manageButton1.Location = new System.Drawing.Point(0, 160);
            this.manageButton1.Name = "manageButton1";
            this.manageButton1.Size = new System.Drawing.Size(185, 45);
            this.manageButton1.TabIndex = 4;
            this.manageButton1.Text = "Отметить как \'не сделано\'";
            this.manageButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageButton1.UseVisualStyleBackColor = false;
            this.manageButton1.Click += new System.EventHandler(this.manageButton1_Click);
            // 
            // FormEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(975, 525);
            this.Controls.Add(this.ordersTab);
            this.Name = "FormEditOrder";
            this.Text = "FormEditOrder";
            this.Load += new System.EventHandler(this.FormEditOrder_Load);
            this.ResizeEnd += new System.EventHandler(this.FormEditOrder_ResizeEnd);
            this.ordersTab.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.groupPrepayment.ResumeLayout(false);
            this.groupPrepayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaid)).EndInit();
            this.servicesPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).EndInit();
            this.panel2.ResumeLayout(false);
            this.sparePartsPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentSparePartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ordersTab;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage servicesPage;
        private System.Windows.Forms.TabPage sparePartsPage;
        private System.Windows.Forms.TabPage logsPage;
        private FontAwesome.Sharp.IconButton btnAutoMaster;
        private FontAwesome.Sharp.IconButton btnFindMaster;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox tbMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkRepaired;
        private System.Windows.Forms.CheckBox checkDiagnosted;
        private System.Windows.Forms.CheckBox checkPrepaid;
        private System.Windows.Forms.Panel panel2;
        private ManageButton btnDeleteService;
        private ManageButton btnAddService;
        private ManageButton btnShowService;
        private System.Windows.Forms.Panel panel4;
        private ManageButton btnDelSparePart;
        private ManageButton btnAddSparePart;
        private ManageButton btnShowSparePart;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label labelSparePartsPrice;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label labelSparePartsCount;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label labelServicesPrice;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label labelServicesCount;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label labelPrepaymentRequired;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxShowServicesRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelServicesPageCout;
        private System.Windows.Forms.NumericUpDown numericCurrentServicePage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNextServ;
        private System.Windows.Forms.Button btnPrevServ;
        private System.Windows.Forms.DataGridView dataServies;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxShowSparePartsRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSparePartsPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentSparePartPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNextSparePart;
        private System.Windows.Forms.Button btnPrevSparePart;
        private System.Windows.Forms.DataGridView dataSpareParts;
        private System.Windows.Forms.ToolTip toolTipFindAuto;
        private System.Windows.Forms.TabPage visitsPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupPrepayment;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLeftToPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericPaid;
        private System.Windows.Forms.CheckBox checkPaid;
        private System.Windows.Forms.CheckBox checkAnswer;
        private System.Windows.Forms.LinkLabel labelProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private ManageButton btnDoneService;
        private ManageButton manageButton1;
    }
}
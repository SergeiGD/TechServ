
namespace Forms_TechServ
{
    partial class FormAddOrder
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
            this.ordersTab = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioManually = new System.Windows.Forms.RadioButton();
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.tbMaster = new System.Windows.Forms.TextBox();
            this.btnFindMaster = new FontAwesome.Sharp.IconButton();
            this.btnCleanMaster = new FontAwesome.Sharp.IconButton();
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
            this.labelPrepayment = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.btnCleanTech = new FontAwesome.Sharp.IconButton();
            this.btnFindTech = new FontAwesome.Sharp.IconButton();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkHighPrior = new System.Windows.Forms.CheckBox();
            this.tbTech = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.servicesPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteService = new Forms_TechServ.ManageButton();
            this.btnAddService = new Forms_TechServ.ManageButton();
            this.btnShowService = new Forms_TechServ.ManageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowServicesRows = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelServicesPages = new System.Windows.Forms.Label();
            this.numericCurrentService = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNextServ = new System.Windows.Forms.Button();
            this.btnPrevServ = new System.Windows.Forms.Button();
            this.dataServies = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartsPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteSparePart = new Forms_TechServ.ManageButton();
            this.btnAddSparePart = new Forms_TechServ.ManageButton();
            this.btnShowSparePart = new Forms_TechServ.ManageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxShowSparePartsRows = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSparePartsPages = new System.Windows.Forms.Label();
            this.numericCurrentSparePart = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNextSparePart = new System.Windows.Forms.Button();
            this.btnPrevSparePart = new System.Windows.Forms.Button();
            this.dataSpareParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTab.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.servicesPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).BeginInit();
            this.sparePartsPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentSparePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.generalPage);
            this.ordersTab.Controls.Add(this.servicesPage);
            this.ordersTab.Controls.Add(this.sparePartsPage);
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(0, 0);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.SelectedIndex = 0;
            this.ordersTab.Size = new System.Drawing.Size(975, 457);
            this.ordersTab.TabIndex = 0;
            this.ordersTab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.groupBox1);
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
            this.generalPage.Controls.Add(this.labelPrepayment);
            this.generalPage.Controls.Add(this.label35);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.labelFinalPrice);
            this.generalPage.Controls.Add(this.btnCleanTech);
            this.generalPage.Controls.Add(this.btnFindTech);
            this.generalPage.Controls.Add(this.tbAddress);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.btnAdd);
            this.generalPage.Controls.Add(this.checkHighPrior);
            this.generalPage.Controls.Add(this.tbTech);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.tbComment);
            this.generalPage.Controls.Add(this.label26);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(967, 431);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioManually);
            this.groupBox1.Controls.Add(this.radioAuto);
            this.groupBox1.Controls.Add(this.tbMaster);
            this.groupBox1.Controls.Add(this.btnFindMaster);
            this.groupBox1.Controls.Add(this.btnCleanMaster);
            this.groupBox1.Location = new System.Drawing.Point(23, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 80);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мастер";
            // 
            // radioManually
            // 
            this.radioManually.AutoSize = true;
            this.radioManually.Location = new System.Drawing.Point(6, 52);
            this.radioManually.Name = "radioManually";
            this.radioManually.Size = new System.Drawing.Size(67, 17);
            this.radioManually.TabIndex = 1;
            this.radioManually.TabStop = true;
            this.radioManually.Text = "Вручную";
            this.radioManually.UseVisualStyleBackColor = true;
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Location = new System.Drawing.Point(6, 28);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(103, 17);
            this.radioAuto.TabIndex = 0;
            this.radioAuto.TabStop = true;
            this.radioAuto.Text = "Автоматически";
            this.radioAuto.UseVisualStyleBackColor = true;
            // 
            // tbMaster
            // 
            this.tbMaster.Location = new System.Drawing.Point(73, 51);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.ReadOnly = true;
            this.tbMaster.Size = new System.Drawing.Size(105, 20);
            this.tbMaster.TabIndex = 123;
            // 
            // btnFindMaster
            // 
            this.btnFindMaster.FlatAppearance.BorderSize = 0;
            this.btnFindMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMaster.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindMaster.IconSize = 17;
            this.btnFindMaster.Location = new System.Drawing.Point(184, 52);
            this.btnFindMaster.Name = "btnFindMaster";
            this.btnFindMaster.Size = new System.Drawing.Size(18, 18);
            this.btnFindMaster.TabIndex = 135;
            this.btnFindMaster.UseVisualStyleBackColor = true;
            this.btnFindMaster.Click += new System.EventHandler(this.btnFindMaster_Click);
            // 
            // btnCleanMaster
            // 
            this.btnCleanMaster.FlatAppearance.BorderSize = 0;
            this.btnCleanMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanMaster.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanMaster.IconSize = 17;
            this.btnCleanMaster.Location = new System.Drawing.Point(208, 53);
            this.btnCleanMaster.Name = "btnCleanMaster";
            this.btnCleanMaster.Size = new System.Drawing.Size(18, 18);
            this.btnCleanMaster.TabIndex = 134;
            this.btnCleanMaster.UseVisualStyleBackColor = true;
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(113, 372);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(41, 13);
            this.labelSale.TabIndex = 149;
            this.labelSale.Text = "label46";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(20, 372);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(91, 13);
            this.label45.TabIndex = 148;
            this.label45.Text = "Скидка клиента:";
            // 
            // labelSparePartsPrice
            // 
            this.labelSparePartsPrice.AutoSize = true;
            this.labelSparePartsPrice.Location = new System.Drawing.Point(113, 335);
            this.labelSparePartsPrice.Name = "labelSparePartsPrice";
            this.labelSparePartsPrice.Size = new System.Drawing.Size(41, 13);
            this.labelSparePartsPrice.TabIndex = 147;
            this.labelSparePartsPrice.Text = "label44";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(20, 335);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 13);
            this.label43.TabIndex = 146;
            this.label43.Text = "Цена за детали:";
            // 
            // labelSparePartsCount
            // 
            this.labelSparePartsCount.AutoSize = true;
            this.labelSparePartsCount.Location = new System.Drawing.Point(114, 298);
            this.labelSparePartsCount.Name = "labelSparePartsCount";
            this.labelSparePartsCount.Size = new System.Drawing.Size(41, 13);
            this.labelSparePartsCount.TabIndex = 145;
            this.labelSparePartsCount.Text = "label42";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(21, 298);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(88, 13);
            this.label41.TabIndex = 144;
            this.label41.Text = "Кол-во деталей:";
            // 
            // labelServicesPrice
            // 
            this.labelServicesPrice.AutoSize = true;
            this.labelServicesPrice.Location = new System.Drawing.Point(113, 258);
            this.labelServicesPrice.Name = "labelServicesPrice";
            this.labelServicesPrice.Size = new System.Drawing.Size(41, 13);
            this.labelServicesPrice.TabIndex = 143;
            this.labelServicesPrice.Text = "label40";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(20, 258);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(87, 13);
            this.label39.TabIndex = 142;
            this.label39.Text = "Цена за услуги:";
            // 
            // labelServicesCount
            // 
            this.labelServicesCount.AutoSize = true;
            this.labelServicesCount.Location = new System.Drawing.Point(114, 218);
            this.labelServicesCount.Name = "labelServicesCount";
            this.labelServicesCount.Size = new System.Drawing.Size(41, 13);
            this.labelServicesCount.TabIndex = 141;
            this.labelServicesCount.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(21, 218);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 13);
            this.label31.TabIndex = 140;
            this.label31.Text = "Кол-во услуг:";
            // 
            // labelPrepayment
            // 
            this.labelPrepayment.AutoSize = true;
            this.labelPrepayment.Location = new System.Drawing.Point(113, 186);
            this.labelPrepayment.Name = "labelPrepayment";
            this.labelPrepayment.Size = new System.Drawing.Size(13, 13);
            this.labelPrepayment.TabIndex = 139;
            this.labelPrepayment.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(21, 186);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 13);
            this.label35.TabIndex = 138;
            this.label35.Text = "Предоплата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 136;
            this.label4.Text = "Конечная цена:";
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.Location = new System.Drawing.Point(113, 406);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(37, 13);
            this.labelFinalPrice.TabIndex = 137;
            this.labelFinalPrice.Text = "33333";
            // 
            // btnCleanTech
            // 
            this.btnCleanTech.FlatAppearance.BorderSize = 0;
            this.btnCleanTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanTech.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanTech.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanTech.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanTech.IconSize = 17;
            this.btnCleanTech.Location = new System.Drawing.Point(231, 40);
            this.btnCleanTech.Name = "btnCleanTech";
            this.btnCleanTech.Size = new System.Drawing.Size(18, 18);
            this.btnCleanTech.TabIndex = 132;
            this.btnCleanTech.UseVisualStyleBackColor = true;
            // 
            // btnFindTech
            // 
            this.btnFindTech.FlatAppearance.BorderSize = 0;
            this.btnFindTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindTech.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindTech.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindTech.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindTech.IconSize = 17;
            this.btnFindTech.Location = new System.Drawing.Point(207, 40);
            this.btnFindTech.Name = "btnFindTech";
            this.btnFindTech.Size = new System.Drawing.Size(18, 18);
            this.btnFindTech.TabIndex = 133;
            this.btnFindTech.UseVisualStyleBackColor = true;
            this.btnFindTech.Click += new System.EventHandler(this.btnFindTech_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(96, 11);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(105, 20);
            this.tbAddress.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Адрес:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(527, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 127;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(527, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 40);
            this.btnAdd.TabIndex = 126;
            this.btnAdd.Text = "СОЗДАТЬ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // checkHighPrior
            // 
            this.checkHighPrior.AutoSize = true;
            this.checkHighPrior.Location = new System.Drawing.Point(23, 157);
            this.checkHighPrior.Name = "checkHighPrior";
            this.checkHighPrior.Size = new System.Drawing.Size(126, 17);
            this.checkHighPrior.TabIndex = 124;
            this.checkHighPrior.Text = "Высокий приоритет";
            this.checkHighPrior.UseVisualStyleBackColor = true;
            // 
            // tbTech
            // 
            this.tbTech.Location = new System.Drawing.Point(96, 40);
            this.tbTech.Name = "tbTech";
            this.tbTech.ReadOnly = true;
            this.tbTech.Size = new System.Drawing.Size(104, 20);
            this.tbTech.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Техника";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(284, 69);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(197, 261);
            this.tbComment.TabIndex = 89;
            this.tbComment.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(325, 53);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 13);
            this.label26.TabIndex = 88;
            this.label26.Text = "Комментарий клиента";
            // 
            // servicesPage
            // 
            this.servicesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.servicesPage.Controls.Add(this.panel2);
            this.servicesPage.Controls.Add(this.panel1);
            this.servicesPage.Location = new System.Drawing.Point(4, 22);
            this.servicesPage.Name = "servicesPage";
            this.servicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.servicesPage.Size = new System.Drawing.Size(967, 431);
            this.servicesPage.TabIndex = 1;
            this.servicesPage.Text = "Услуги";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnDeleteService);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.btnShowService);
            this.panel2.Location = new System.Drawing.Point(782, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 435);
            this.panel2.TabIndex = 4;
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
            this.btnAddService.Click += new System.EventHandler(this.manageButton2_Click);
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
            this.btnShowService.Click += new System.EventHandler(this.manageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxShowServicesRows);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelServicesPages);
            this.panel1.Controls.Add(this.numericCurrentService);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNextServ);
            this.panel1.Controls.Add(this.btnPrevServ);
            this.panel1.Controls.Add(this.dataServies);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 431);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxShowServicesRows
            // 
            this.comboBoxShowServicesRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowServicesRows.FormattingEnabled = true;
            this.comboBoxShowServicesRows.Location = new System.Drawing.Point(539, 403);
            this.comboBoxShowServicesRows.Name = "comboBoxShowServicesRows";
            this.comboBoxShowServicesRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowServicesRows.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(426, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Показывать по";
            // 
            // labelServicesPages
            // 
            this.labelServicesPages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelServicesPages.AutoSize = true;
            this.labelServicesPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelServicesPages.Location = new System.Drawing.Point(309, 403);
            this.labelServicesPages.Name = "labelServicesPages";
            this.labelServicesPages.Size = new System.Drawing.Size(36, 17);
            this.labelServicesPages.TabIndex = 10;
            this.labelServicesPages.Text = "из S";
            // 
            // numericCurrentService
            // 
            this.numericCurrentService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentService.Location = new System.Drawing.Point(258, 404);
            this.numericCurrentService.Name = "numericCurrentService";
            this.numericCurrentService.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentService.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(180, 403);
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
            this.btnNextServ.Location = new System.Drawing.Point(652, 391);
            this.btnNextServ.Name = "btnNextServ";
            this.btnNextServ.Size = new System.Drawing.Size(130, 40);
            this.btnNextServ.TabIndex = 4;
            this.btnNextServ.Text = "Следующая →";
            this.btnNextServ.UseVisualStyleBackColor = false;
            // 
            // btnPrevServ
            // 
            this.btnPrevServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevServ.FlatAppearance.BorderSize = 0;
            this.btnPrevServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevServ.Location = new System.Drawing.Point(0, 391);
            this.btnPrevServ.Name = "btnPrevServ";
            this.btnPrevServ.Size = new System.Drawing.Size(130, 40);
            this.btnPrevServ.TabIndex = 3;
            this.btnPrevServ.Text = "← Предыдущая";
            this.btnPrevServ.UseVisualStyleBackColor = false;
            // 
            // dataServies
            // 
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
            this.Column5});
            this.dataServies.Location = new System.Drawing.Point(0, 0);
            this.dataServies.Name = "dataServies";
            this.dataServies.Size = new System.Drawing.Size(782, 391);
            this.dataServies.TabIndex = 1;
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
            // 
            // column_sale
            // 
            this.column_sale.HeaderText = "Скидка";
            this.column_sale.Name = "column_sale";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Общая цена";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // sparePartsPage
            // 
            this.sparePartsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.sparePartsPage.Controls.Add(this.panel3);
            this.sparePartsPage.Controls.Add(this.panel4);
            this.sparePartsPage.Location = new System.Drawing.Point(4, 22);
            this.sparePartsPage.Name = "sparePartsPage";
            this.sparePartsPage.Padding = new System.Windows.Forms.Padding(3);
            this.sparePartsPage.Size = new System.Drawing.Size(967, 431);
            this.sparePartsPage.TabIndex = 2;
            this.sparePartsPage.Text = "Детали";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnDeleteSparePart);
            this.panel3.Controls.Add(this.btnAddSparePart);
            this.panel3.Controls.Add(this.btnShowSparePart);
            this.panel3.Location = new System.Drawing.Point(782, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 435);
            this.panel3.TabIndex = 4;
            // 
            // btnDeleteSparePart
            // 
            this.btnDeleteSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDeleteSparePart.FlatAppearance.BorderSize = 0;
            this.btnDeleteSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteSparePart.Location = new System.Drawing.Point(0, 40);
            this.btnDeleteSparePart.Name = "btnDeleteSparePart";
            this.btnDeleteSparePart.Size = new System.Drawing.Size(185, 40);
            this.btnDeleteSparePart.TabIndex = 2;
            this.btnDeleteSparePart.Text = "Удалить";
            this.btnDeleteSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSparePart.UseVisualStyleBackColor = false;
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
            this.btnAddSparePart.Click += new System.EventHandler(this.manageButton5_Click);
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
            this.btnShowSparePart.Click += new System.EventHandler(this.manageButton6_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.comboBoxShowSparePartsRows);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.labelSparePartsPages);
            this.panel4.Controls.Add(this.numericCurrentSparePart);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnNextSparePart);
            this.panel4.Controls.Add(this.btnPrevSparePart);
            this.panel4.Controls.Add(this.dataSpareParts);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 431);
            this.panel4.TabIndex = 3;
            // 
            // comboBoxShowSparePartsRows
            // 
            this.comboBoxShowSparePartsRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowSparePartsRows.FormattingEnabled = true;
            this.comboBoxShowSparePartsRows.Location = new System.Drawing.Point(539, 403);
            this.comboBoxShowSparePartsRows.Name = "comboBoxShowSparePartsRows";
            this.comboBoxShowSparePartsRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowSparePartsRows.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(426, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Показывать по";
            // 
            // labelSparePartsPages
            // 
            this.labelSparePartsPages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSparePartsPages.AutoSize = true;
            this.labelSparePartsPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelSparePartsPages.Location = new System.Drawing.Point(309, 403);
            this.labelSparePartsPages.Name = "labelSparePartsPages";
            this.labelSparePartsPages.Size = new System.Drawing.Size(36, 17);
            this.labelSparePartsPages.TabIndex = 10;
            this.labelSparePartsPages.Text = "из S";
            // 
            // numericCurrentSparePart
            // 
            this.numericCurrentSparePart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentSparePart.Location = new System.Drawing.Point(258, 404);
            this.numericCurrentSparePart.Name = "numericCurrentSparePart";
            this.numericCurrentSparePart.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentSparePart.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(180, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Страница";
            // 
            // btnNextSparePart
            // 
            this.btnNextSparePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextSparePart.FlatAppearance.BorderSize = 0;
            this.btnNextSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextSparePart.Location = new System.Drawing.Point(652, 391);
            this.btnNextSparePart.Name = "btnNextSparePart";
            this.btnNextSparePart.Size = new System.Drawing.Size(130, 40);
            this.btnNextSparePart.TabIndex = 4;
            this.btnNextSparePart.Text = "Следующая →";
            this.btnNextSparePart.UseVisualStyleBackColor = false;
            // 
            // btnPrevSparePart
            // 
            this.btnPrevSparePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevSparePart.FlatAppearance.BorderSize = 0;
            this.btnPrevSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevSparePart.Location = new System.Drawing.Point(0, 391);
            this.btnPrevSparePart.Name = "btnPrevSparePart";
            this.btnPrevSparePart.Size = new System.Drawing.Size(130, 40);
            this.btnPrevSparePart.TabIndex = 3;
            this.btnPrevSparePart.Text = "← Предыдущая";
            this.btnPrevSparePart.UseVisualStyleBackColor = false;
            // 
            // dataSpareParts
            // 
            this.dataSpareParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSpareParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSpareParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpareParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6});
            this.dataSpareParts.Location = new System.Drawing.Point(0, 0);
            this.dataSpareParts.Name = "dataSpareParts";
            this.dataSpareParts.Size = new System.Drawing.Size(782, 391);
            this.dataSpareParts.TabIndex = 1;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "id поставки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Общая цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "В наличии";
            this.Column6.Name = "Column6";
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(975, 457);
            this.Controls.Add(this.ordersTab);
            this.MaximizeBox = false;
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            this.Load += new System.EventHandler(this.FormAddOrder_Load);
            this.ResizeEnd += new System.EventHandler(this.FormAddInOrder_ResizeEnd);
            this.ordersTab.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.servicesPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).EndInit();
            this.sparePartsPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentSparePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ordersTab;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage servicesPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox checkHighPrior;
        private System.Windows.Forms.TextBox tbMaster;
        private System.Windows.Forms.TextBox tbTech;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage sparePartsPage;
        private System.Windows.Forms.Panel panel2;
        private ManageButton btnDeleteService;
        private ManageButton btnAddService;
        private ManageButton btnShowService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelServicesPages;
        private System.Windows.Forms.NumericUpDown numericCurrentService;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNextServ;
        private System.Windows.Forms.Button btnPrevServ;
        private System.Windows.Forms.DataGridView dataServies;
        private System.Windows.Forms.Panel panel3;
        private ManageButton btnDeleteSparePart;
        private ManageButton btnAddSparePart;
        private ManageButton btnShowSparePart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelSparePartsPages;
        private System.Windows.Forms.NumericUpDown numericCurrentSparePart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNextSparePart;
        private System.Windows.Forms.Button btnPrevSparePart;
        private System.Windows.Forms.DataGridView dataSpareParts;
        private FontAwesome.Sharp.IconButton btnCleanMaster;
        private FontAwesome.Sharp.IconButton btnFindMaster;
        private FontAwesome.Sharp.IconButton btnCleanTech;
        private FontAwesome.Sharp.IconButton btnFindTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
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
        private System.Windows.Forms.Label labelPrepayment;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioManually;
        private System.Windows.Forms.RadioButton radioAuto;
        private System.Windows.Forms.ComboBox comboBoxShowServicesRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxShowSparePartsRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

namespace Forms_TechServ
{
    partial class FormShowOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelDateFinished = new System.Windows.Forms.Label();
            this.labelDateCanceled = new System.Windows.Forms.Label();
            this.labelDatePaid = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.labelDateAnswer = new System.Windows.Forms.Label();
            this.labelDateRepaired = new System.Windows.Forms.Label();
            this.labelDateDiagnostic = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.LinkLabel();
            this.labelClient = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.labelMaster = new System.Windows.Forms.LinkLabel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.ordersTab = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelLeftToPay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPrepayment = new System.Windows.Forms.GroupBox();
            this.labelPrepaymentMade = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPrepaymentRequired = new System.Windows.Forms.Label();
            this.labelWorkshop = new System.Windows.Forms.LinkLabel();
            this.label33 = new System.Windows.Forms.Label();
            this.labelClientSale = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.labelSparePartsPrice = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.labelSparePartsCount = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.labelServicecPrice = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.labelServicesCount = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.labelDatePrepayment = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowService = new Forms_TechServ.ManageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowServicesRows = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.labelServicesPageCout = new System.Windows.Forms.Label();
            this.numericCurrentServicePage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNextService = new System.Windows.Forms.Button();
            this.btnPrevService = new System.Windows.Forms.Button();
            this.dataServies = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEditSparePartBatches = new Forms_TechServ.ManageButton();
            this.btnShowSparePart = new Forms_TechServ.ManageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxShowSparePartsRows = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.labelSparePartsPageCount = new System.Windows.Forms.Label();
            this.numericCurrentSparePartPage = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.btnNextSparePart = new System.Windows.Forms.Button();
            this.btnPrevSparePart = new System.Windows.Forms.Button();
            this.dataSpareParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsPage = new System.Windows.Forms.TabPage();
            this.visitsPage = new System.Windows.Forms.TabPage();
            this.toolTipPriceInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ordersTab.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.groupPrepayment.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentSparePartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Техника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Конечная цена:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Статус:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Дата начала";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Дата диагностики";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Дата ответа клиента";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Дата починки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Дата оплаты";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Дата завершения";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(291, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Дата отмены";
            // 
            // labelDateFinished
            // 
            this.labelDateFinished.AutoSize = true;
            this.labelDateFinished.Location = new System.Drawing.Point(411, 140);
            this.labelDateFinished.Name = "labelDateFinished";
            this.labelDateFinished.Size = new System.Drawing.Size(91, 13);
            this.labelDateFinished.TabIndex = 38;
            this.labelDateFinished.Text = "22.10.2021 15:30";
            // 
            // labelDateCanceled
            // 
            this.labelDateCanceled.AutoSize = true;
            this.labelDateCanceled.Location = new System.Drawing.Point(411, 183);
            this.labelDateCanceled.Name = "labelDateCanceled";
            this.labelDateCanceled.Size = new System.Drawing.Size(91, 13);
            this.labelDateCanceled.TabIndex = 39;
            this.labelDateCanceled.Text = "22.10.2021 15:30";
            // 
            // labelDatePaid
            // 
            this.labelDatePaid.AutoSize = true;
            this.labelDatePaid.Location = new System.Drawing.Point(411, 100);
            this.labelDatePaid.Name = "labelDatePaid";
            this.labelDatePaid.Size = new System.Drawing.Size(91, 13);
            this.labelDatePaid.TabIndex = 40;
            this.labelDatePaid.Text = "22.10.2021 15:30";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Location = new System.Drawing.Point(411, 22);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(91, 13);
            this.labelDateStart.TabIndex = 41;
            this.labelDateStart.Text = "22.10.2021 15:30";
            // 
            // labelDateAnswer
            // 
            this.labelDateAnswer.AutoSize = true;
            this.labelDateAnswer.Location = new System.Drawing.Point(411, 264);
            this.labelDateAnswer.Name = "labelDateAnswer";
            this.labelDateAnswer.Size = new System.Drawing.Size(91, 13);
            this.labelDateAnswer.TabIndex = 42;
            this.labelDateAnswer.Text = "22.10.2021 15:30";
            // 
            // labelDateRepaired
            // 
            this.labelDateRepaired.AutoSize = true;
            this.labelDateRepaired.Location = new System.Drawing.Point(411, 305);
            this.labelDateRepaired.Name = "labelDateRepaired";
            this.labelDateRepaired.Size = new System.Drawing.Size(91, 13);
            this.labelDateRepaired.TabIndex = 43;
            this.labelDateRepaired.Text = "22.10.2021 15:30";
            // 
            // labelDateDiagnostic
            // 
            this.labelDateDiagnostic.AutoSize = true;
            this.labelDateDiagnostic.Location = new System.Drawing.Point(411, 228);
            this.labelDateDiagnostic.Name = "labelDateDiagnostic";
            this.labelDateDiagnostic.Size = new System.Drawing.Size(91, 13);
            this.labelDateDiagnostic.TabIndex = 44;
            this.labelDateDiagnostic.Text = "22.10.2021 15:30";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(120, 100);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(55, 13);
            this.labelProduct.TabIndex = 45;
            this.labelProduct.TabStop = true;
            this.labelProduct.Text = "linkLabel1";
            this.labelProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelPickedProduct_LinkClicked);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(120, 60);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(55, 13);
            this.labelClient.TabIndex = 46;
            this.labelClient.TabStop = true;
            this.labelClient.Text = "linkLabel2";
            this.labelClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedClient_LinkClicked);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Мастер";
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Location = new System.Drawing.Point(120, 143);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(55, 13);
            this.labelMaster.TabIndex = 49;
            this.labelMaster.TabStop = true;
            this.labelMaster.Text = "linkLabel3";
            this.labelMaster.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedMaster_LinkClicked);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(119, 221);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 13);
            this.labelStatus.TabIndex = 51;
            this.labelStatus.Text = "завершен";
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.Location = new System.Drawing.Point(120, 453);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(37, 13);
            this.labelFinalPrice.TabIndex = 52;
            this.labelFinalPrice.Text = "33333";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(28, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 53;
            this.label24.Text = "ID заказа:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(120, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 13);
            this.labelID.TabIndex = 54;
            this.labelID.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(585, 100);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 13);
            this.label26.TabIndex = 55;
            this.label26.Text = "Комментарий клиента";
            // 
            // tbComment
            // 
            this.tbComment.Enabled = false;
            this.tbComment.Location = new System.Drawing.Point(545, 116);
            this.tbComment.Name = "tbComment";
            this.tbComment.ReadOnly = true;
            this.tbComment.Size = new System.Drawing.Size(197, 280);
            this.tbComment.TabIndex = 56;
            this.tbComment.Text = "";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(42, 298);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 40);
            this.cancelBtn.TabIndex = 59;
            this.cancelBtn.Text = "Закрыть";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(42, 153);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(119, 40);
            this.editBtn.TabIndex = 57;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.generalPage);
            this.ordersTab.Controls.Add(this.tabPage2);
            this.ordersTab.Controls.Add(this.tabPage3);
            this.ordersTab.Controls.Add(this.logsPage);
            this.ordersTab.Controls.Add(this.visitsPage);
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(0, 0);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.SelectedIndex = 0;
            this.ordersTab.Size = new System.Drawing.Size(975, 540);
            this.ordersTab.TabIndex = 60;
            this.ordersTab.SelectedIndexChanged += new System.EventHandler(this.ordersTab_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelLeftToPay);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.groupPrepayment);
            this.generalPage.Controls.Add(this.labelWorkshop);
            this.generalPage.Controls.Add(this.label33);
            this.generalPage.Controls.Add(this.labelClientSale);
            this.generalPage.Controls.Add(this.label45);
            this.generalPage.Controls.Add(this.labelSparePartsPrice);
            this.generalPage.Controls.Add(this.label43);
            this.generalPage.Controls.Add(this.labelSparePartsCount);
            this.generalPage.Controls.Add(this.label41);
            this.generalPage.Controls.Add(this.labelServicecPrice);
            this.generalPage.Controls.Add(this.label39);
            this.generalPage.Controls.Add(this.labelServicesCount);
            this.generalPage.Controls.Add(this.label31);
            this.generalPage.Controls.Add(this.label37);
            this.generalPage.Controls.Add(this.labelDatePrepayment);
            this.generalPage.Controls.Add(this.panelEdit);
            this.generalPage.Controls.Add(this.labelAddress);
            this.generalPage.Controls.Add(this.label34);
            this.generalPage.Controls.Add(this.label24);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.tbComment);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.label26);
            this.generalPage.Controls.Add(this.label8);
            this.generalPage.Controls.Add(this.labelID);
            this.generalPage.Controls.Add(this.label9);
            this.generalPage.Controls.Add(this.label10);
            this.generalPage.Controls.Add(this.labelFinalPrice);
            this.generalPage.Controls.Add(this.label11);
            this.generalPage.Controls.Add(this.labelStatus);
            this.generalPage.Controls.Add(this.label12);
            this.generalPage.Controls.Add(this.label13);
            this.generalPage.Controls.Add(this.labelMaster);
            this.generalPage.Controls.Add(this.label14);
            this.generalPage.Controls.Add(this.label21);
            this.generalPage.Controls.Add(this.labelDateFinished);
            this.generalPage.Controls.Add(this.labelDateCanceled);
            this.generalPage.Controls.Add(this.labelClient);
            this.generalPage.Controls.Add(this.labelDatePaid);
            this.generalPage.Controls.Add(this.labelProduct);
            this.generalPage.Controls.Add(this.labelDateStart);
            this.generalPage.Controls.Add(this.labelDateDiagnostic);
            this.generalPage.Controls.Add(this.labelDateAnswer);
            this.generalPage.Controls.Add(this.labelDateRepaired);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(967, 514);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelLeftToPay
            // 
            this.labelLeftToPay.AutoSize = true;
            this.labelLeftToPay.Location = new System.Drawing.Point(118, 487);
            this.labelLeftToPay.Name = "labelLeftToPay";
            this.labelLeftToPay.Size = new System.Drawing.Size(41, 13);
            this.labelLeftToPay.TabIndex = 190;
            this.labelLeftToPay.Text = "label11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 189;
            this.label3.Text = "К оплате:";
            // 
            // groupPrepayment
            // 
            this.groupPrepayment.Controls.Add(this.labelPrepaymentMade);
            this.groupPrepayment.Controls.Add(this.label55);
            this.groupPrepayment.Controls.Add(this.label5);
            this.groupPrepayment.Controls.Add(this.labelPrepaymentRequired);
            this.groupPrepayment.Location = new System.Drawing.Point(294, 345);
            this.groupPrepayment.Name = "groupPrepayment";
            this.groupPrepayment.Size = new System.Drawing.Size(208, 100);
            this.groupPrepayment.TabIndex = 80;
            this.groupPrepayment.TabStop = false;
            this.groupPrepayment.Text = "Предоплата";
            // 
            // labelPrepaymentMade
            // 
            this.labelPrepaymentMade.AutoSize = true;
            this.labelPrepaymentMade.Location = new System.Drawing.Point(81, 74);
            this.labelPrepaymentMade.Name = "labelPrepaymentMade";
            this.labelPrepaymentMade.Size = new System.Drawing.Size(13, 13);
            this.labelPrepaymentMade.TabIndex = 81;
            this.labelPrepaymentMade.Text = "0";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(9, 74);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(53, 13);
            this.label55.TabIndex = 1;
            this.label55.Text = "Внесено:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Требуется:";
            // 
            // labelPrepaymentRequired
            // 
            this.labelPrepaymentRequired.AutoSize = true;
            this.labelPrepaymentRequired.Location = new System.Drawing.Point(81, 36);
            this.labelPrepaymentRequired.Name = "labelPrepaymentRequired";
            this.labelPrepaymentRequired.Size = new System.Drawing.Size(13, 13);
            this.labelPrepaymentRequired.TabIndex = 64;
            this.labelPrepaymentRequired.Text = "0";
            // 
            // labelWorkshop
            // 
            this.labelWorkshop.AutoSize = true;
            this.labelWorkshop.Location = new System.Drawing.Point(120, 183);
            this.labelWorkshop.Name = "labelWorkshop";
            this.labelWorkshop.Size = new System.Drawing.Size(55, 13);
            this.labelWorkshop.TabIndex = 78;
            this.labelWorkshop.TabStop = true;
            this.labelWorkshop.Text = "linkLabel3";
            this.labelWorkshop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelWorkshop_LinkClicked);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(28, 183);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(69, 13);
            this.label33.TabIndex = 77;
            this.label33.Text = "Мастерская";
            // 
            // labelClientSale
            // 
            this.labelClientSale.AutoSize = true;
            this.labelClientSale.Location = new System.Drawing.Point(120, 419);
            this.labelClientSale.Name = "labelClientSale";
            this.labelClientSale.Size = new System.Drawing.Size(41, 13);
            this.labelClientSale.TabIndex = 76;
            this.labelClientSale.Text = "label46";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(27, 419);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(91, 13);
            this.label45.TabIndex = 75;
            this.label45.Text = "Скидка клиента:";
            // 
            // labelSparePartsPrice
            // 
            this.labelSparePartsPrice.AutoSize = true;
            this.labelSparePartsPrice.Location = new System.Drawing.Point(120, 382);
            this.labelSparePartsPrice.Name = "labelSparePartsPrice";
            this.labelSparePartsPrice.Size = new System.Drawing.Size(41, 13);
            this.labelSparePartsPrice.TabIndex = 74;
            this.labelSparePartsPrice.Text = "label44";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(27, 382);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 13);
            this.label43.TabIndex = 73;
            this.label43.Text = "Цена за детали:";
            // 
            // labelSparePartsCount
            // 
            this.labelSparePartsCount.AutoSize = true;
            this.labelSparePartsCount.Location = new System.Drawing.Point(122, 345);
            this.labelSparePartsCount.Name = "labelSparePartsCount";
            this.labelSparePartsCount.Size = new System.Drawing.Size(41, 13);
            this.labelSparePartsCount.TabIndex = 72;
            this.labelSparePartsCount.Text = "label42";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(28, 345);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(88, 13);
            this.label41.TabIndex = 71;
            this.label41.Text = "Кол-во деталей:";
            // 
            // labelServicecPrice
            // 
            this.labelServicecPrice.AutoSize = true;
            this.labelServicecPrice.Location = new System.Drawing.Point(120, 305);
            this.labelServicecPrice.Name = "labelServicecPrice";
            this.labelServicecPrice.Size = new System.Drawing.Size(41, 13);
            this.labelServicecPrice.TabIndex = 70;
            this.labelServicecPrice.Text = "label40";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(27, 305);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(87, 13);
            this.label39.TabIndex = 69;
            this.label39.Text = "Цена за услуги:";
            // 
            // labelServicesCount
            // 
            this.labelServicesCount.AutoSize = true;
            this.labelServicesCount.Location = new System.Drawing.Point(121, 265);
            this.labelServicesCount.Name = "labelServicesCount";
            this.labelServicesCount.Size = new System.Drawing.Size(41, 13);
            this.labelServicesCount.TabIndex = 68;
            this.labelServicesCount.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(28, 265);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 13);
            this.label31.TabIndex = 67;
            this.label31.Text = "Кол-во услуг:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(291, 60);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(97, 13);
            this.label37.TabIndex = 65;
            this.label37.Text = "Дата предоплаты";
            // 
            // labelDatePrepayment
            // 
            this.labelDatePrepayment.AutoSize = true;
            this.labelDatePrepayment.Location = new System.Drawing.Point(411, 60);
            this.labelDatePrepayment.Name = "labelDatePrepayment";
            this.labelDatePrepayment.Size = new System.Drawing.Size(91, 13);
            this.labelDatePrepayment.TabIndex = 66;
            this.labelDatePrepayment.Text = "22.10.2021 15:30";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(768, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(196, 508);
            this.panelEdit.TabIndex = 62;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(364, 486);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 13);
            this.labelAddress.TabIndex = 61;
            this.labelAddress.Text = "label";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(291, 486);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 13);
            this.label34.TabIndex = 60;
            this.label34.Text = "Адрес:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Услуги";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnShowService);
            this.panel2.Location = new System.Drawing.Point(782, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 518);
            this.panel2.TabIndex = 1;
            // 
            // btnShowService
            // 
            this.btnShowService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowService.FlatAppearance.BorderSize = 0;
            this.btnShowService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowService.Location = new System.Drawing.Point(0, 0);
            this.btnShowService.Name = "btnShowService";
            this.btnShowService.Size = new System.Drawing.Size(185, 40);
            this.btnShowService.TabIndex = 0;
            this.btnShowService.Text = "Просмотреть";
            this.btnShowService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowService.UseVisualStyleBackColor = false;
            this.btnShowService.Click += new System.EventHandler(this.btnShowSerivce_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxShowServicesRows);
            this.panel1.Controls.Add(this.label47);
            this.panel1.Controls.Add(this.labelServicesPageCout);
            this.panel1.Controls.Add(this.numericCurrentServicePage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNextService);
            this.panel1.Controls.Add(this.btnPrevService);
            this.panel1.Controls.Add(this.dataServies);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 514);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxShowServicesRows
            // 
            this.comboBoxShowServicesRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowServicesRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowServicesRows.FormattingEnabled = true;
            this.comboBoxShowServicesRows.Location = new System.Drawing.Point(520, 485);
            this.comboBoxShowServicesRows.Name = "comboBoxShowServicesRows";
            this.comboBoxShowServicesRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowServicesRows.TabIndex = 18;
            this.comboBoxShowServicesRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowServicesRows_SelectedIndexChanged);
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label47.Location = new System.Drawing.Point(407, 486);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(107, 17);
            this.label47.TabIndex = 17;
            this.label47.Text = "Показывать по";
            // 
            // labelServicesPageCout
            // 
            this.labelServicesPageCout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelServicesPageCout.AutoSize = true;
            this.labelServicesPageCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelServicesPageCout.Location = new System.Drawing.Point(324, 486);
            this.labelServicesPageCout.Name = "labelServicesPageCout";
            this.labelServicesPageCout.Size = new System.Drawing.Size(36, 17);
            this.labelServicesPageCout.TabIndex = 10;
            this.labelServicesPageCout.Text = "из S";
            // 
            // numericCurrentServicePage
            // 
            this.numericCurrentServicePage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentServicePage.Location = new System.Drawing.Point(273, 487);
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
            this.label28.Location = new System.Drawing.Point(195, 486);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 8;
            this.label28.Text = "Страница";
            // 
            // btnNextService
            // 
            this.btnNextService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextService.FlatAppearance.BorderSize = 0;
            this.btnNextService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextService.Location = new System.Drawing.Point(652, 474);
            this.btnNextService.Name = "btnNextService";
            this.btnNextService.Size = new System.Drawing.Size(130, 40);
            this.btnNextService.TabIndex = 4;
            this.btnNextService.Text = "Следующая →";
            this.btnNextService.UseVisualStyleBackColor = false;
            this.btnNextService.Click += new System.EventHandler(this.btnNextService_Click);
            // 
            // btnPrevService
            // 
            this.btnPrevService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevService.FlatAppearance.BorderSize = 0;
            this.btnPrevService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevService.Location = new System.Drawing.Point(0, 474);
            this.btnPrevService.Name = "btnPrevService";
            this.btnPrevService.Size = new System.Drawing.Size(130, 40);
            this.btnPrevService.TabIndex = 3;
            this.btnPrevService.Text = "← Предыдущая";
            this.btnPrevService.UseVisualStyleBackColor = false;
            this.btnPrevService.Click += new System.EventHandler(this.btnPrevService_Click);
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
            this.dataServies.MultiSelect = false;
            this.dataServies.Name = "dataServies";
            this.dataServies.ReadOnly = true;
            this.dataServies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataServies.Size = new System.Drawing.Size(782, 474);
            this.dataServies.TabIndex = 1;
            this.dataServies.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataServies_CellMouseDoubleClick);
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(967, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Детали";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnEditSparePartBatches);
            this.panel4.Controls.Add(this.btnShowSparePart);
            this.panel4.Location = new System.Drawing.Point(782, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 518);
            this.panel4.TabIndex = 2;
            // 
            // btnEditSparePartBatches
            // 
            this.btnEditSparePartBatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSparePartBatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnEditSparePartBatches.FlatAppearance.BorderSize = 0;
            this.btnEditSparePartBatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSparePartBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditSparePartBatches.Location = new System.Drawing.Point(0, 40);
            this.btnEditSparePartBatches.Name = "btnEditSparePartBatches";
            this.btnEditSparePartBatches.Size = new System.Drawing.Size(185, 40);
            this.btnEditSparePartBatches.TabIndex = 1;
            this.btnEditSparePartBatches.Text = "Просмотреть поставки";
            this.btnEditSparePartBatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSparePartBatches.UseVisualStyleBackColor = false;
            this.btnEditSparePartBatches.Click += new System.EventHandler(this.btnShowSparePartBatches_Click);
            // 
            // btnShowSparePart
            // 
            this.btnShowSparePart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowSparePart.FlatAppearance.BorderSize = 0;
            this.btnShowSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowSparePart.Location = new System.Drawing.Point(0, 0);
            this.btnShowSparePart.Name = "btnShowSparePart";
            this.btnShowSparePart.Size = new System.Drawing.Size(185, 40);
            this.btnShowSparePart.TabIndex = 0;
            this.btnShowSparePart.Text = "Просмотреть деталь";
            this.btnShowSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowSparePart.UseVisualStyleBackColor = false;
            this.btnShowSparePart.Click += new System.EventHandler(this.btnShowSparePart_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.comboBoxShowSparePartsRows);
            this.panel3.Controls.Add(this.label48);
            this.panel3.Controls.Add(this.labelSparePartsPageCount);
            this.panel3.Controls.Add(this.numericCurrentSparePartPage);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.btnNextSparePart);
            this.panel3.Controls.Add(this.btnPrevSparePart);
            this.panel3.Controls.Add(this.dataSpareParts);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 518);
            this.panel3.TabIndex = 1;
            // 
            // comboBoxShowSparePartsRows
            // 
            this.comboBoxShowSparePartsRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowSparePartsRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowSparePartsRows.FormattingEnabled = true;
            this.comboBoxShowSparePartsRows.Location = new System.Drawing.Point(536, 489);
            this.comboBoxShowSparePartsRows.Name = "comboBoxShowSparePartsRows";
            this.comboBoxShowSparePartsRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowSparePartsRows.TabIndex = 18;
            this.comboBoxShowSparePartsRows.Click += new System.EventHandler(this.comboBoxShowSparePartsRows_Click);
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label48.Location = new System.Drawing.Point(423, 490);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(107, 17);
            this.label48.TabIndex = 17;
            this.label48.Text = "Показывать по";
            // 
            // labelSparePartsPageCount
            // 
            this.labelSparePartsPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSparePartsPageCount.AutoSize = true;
            this.labelSparePartsPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelSparePartsPageCount.Location = new System.Drawing.Point(328, 490);
            this.labelSparePartsPageCount.Name = "labelSparePartsPageCount";
            this.labelSparePartsPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelSparePartsPageCount.TabIndex = 10;
            this.labelSparePartsPageCount.Text = "из S";
            // 
            // numericCurrentSparePartPage
            // 
            this.numericCurrentSparePartPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentSparePartPage.Location = new System.Drawing.Point(277, 491);
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
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label30.Location = new System.Drawing.Point(199, 490);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 17);
            this.label30.TabIndex = 8;
            this.label30.Text = "Страница";
            // 
            // btnNextSparePart
            // 
            this.btnNextSparePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextSparePart.FlatAppearance.BorderSize = 0;
            this.btnNextSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextSparePart.Location = new System.Drawing.Point(652, 478);
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
            this.btnPrevSparePart.Location = new System.Drawing.Point(0, 478);
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
            this.dataSpareParts.Size = new System.Drawing.Size(782, 478);
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
            // logsPage
            // 
            this.logsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.logsPage.Location = new System.Drawing.Point(4, 22);
            this.logsPage.Name = "logsPage";
            this.logsPage.Padding = new System.Windows.Forms.Padding(3);
            this.logsPage.Size = new System.Drawing.Size(967, 514);
            this.logsPage.TabIndex = 3;
            this.logsPage.Text = "История";
            // 
            // visitsPage
            // 
            this.visitsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.visitsPage.Location = new System.Drawing.Point(4, 22);
            this.visitsPage.Name = "visitsPage";
            this.visitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.visitsPage.Size = new System.Drawing.Size(967, 514);
            this.visitsPage.TabIndex = 4;
            this.visitsPage.Text = "Выезды";
            // 
            // FormShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(975, 540);
            this.Controls.Add(this.ordersTab);
            this.MaximizeBox = false;
            this.Name = "FormShowOrder";
            this.Text = "Просмотр заказа";
            this.Load += new System.EventHandler(this.FormEditWorkshopOrder_Load);
            this.ordersTab.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.groupPrepayment.ResumeLayout(false);
            this.groupPrepayment.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentSparePartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelDateFinished;
        private System.Windows.Forms.Label labelDateCanceled;
        private System.Windows.Forms.Label labelDatePaid;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Label labelDateAnswer;
        private System.Windows.Forms.Label labelDateRepaired;
        private System.Windows.Forms.Label labelDateDiagnostic;
        private System.Windows.Forms.LinkLabel labelProduct;
        private System.Windows.Forms.LinkLabel labelClient;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel labelMaster;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TabControl ordersTab;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataServies;
        private System.Windows.Forms.Button btnPrevService;
        private System.Windows.Forms.Button btnNextService;
        private System.Windows.Forms.Label labelServicesPageCout;
        private System.Windows.Forms.NumericUpDown numericCurrentServicePage;
        private System.Windows.Forms.Label label28;
        private ManageButton btnShowService;
        private System.Windows.Forms.Panel panel4;
        private ManageButton btnShowSparePart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSparePartsPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentSparePartPage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnNextSparePart;
        private System.Windows.Forms.Button btnPrevSparePart;
        private System.Windows.Forms.DataGridView dataSpareParts;
        private System.Windows.Forms.TabPage logsPage;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label labelDatePrepayment;
        private System.Windows.Forms.Label labelPrepaymentRequired;
        private System.Windows.Forms.Label labelClientSale;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label labelSparePartsPrice;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label labelSparePartsCount;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label labelServicecPrice;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label labelServicesCount;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBoxShowServicesRows;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox comboBoxShowSparePartsRows;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TabPage visitsPage;
        private System.Windows.Forms.LinkLabel labelWorkshop;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupPrepayment;
        private System.Windows.Forms.Label labelPrepaymentMade;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLeftToPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolTip toolTipPriceInfo;
        private ManageButton btnEditSparePartBatches;
    }
}
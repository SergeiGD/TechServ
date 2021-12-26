
namespace Forms_TechServ
{
    partial class FormOrders
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.btnCleanStatus = new FontAwesome.Sharp.IconButton();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPriceInfo = new FontAwesome.Sharp.IconButton();
            this.btnCleanStartUntil = new FontAwesome.Sharp.IconButton();
            this.btnCleanStartFrom = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.datePickerStartFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerStartUntil = new System.Windows.Forms.DateTimePicker();
            this.numericPriceUntil = new System.Windows.Forms.NumericUpDown();
            this.numericPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.btnCleanProduct = new FontAwesome.Sharp.IconButton();
            this.btnFindProduct = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.btnCleanWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnFindWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnCleanClient = new FontAwesome.Sharp.IconButton();
            this.btnFindClient = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.extendFilterBtn = new Forms_TechServ.ManageButton();
            this.clearBtn = new Forms_TechServ.ManageButton();
            this.searchBtn = new Forms_TechServ.ManageButton();
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPriceInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.comboBoxShowRows);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.labelPageCount);
            this.panelContent.Controls.Add(this.numericCurrentPage);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.panelFind);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataOrders);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(875, 782);
            this.panelContent.TabIndex = 0;
            // 
            // comboBoxShowRows
            // 
            this.comboBoxShowRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowRows.FormattingEnabled = true;
            this.comboBoxShowRows.Location = new System.Drawing.Point(612, 746);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 18;
            this.comboBoxShowRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowRows_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(499, 747);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Показывать по";
            // 
            // labelPageCount
            // 
            this.labelPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPageCount.Location = new System.Drawing.Point(328, 747);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 10;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(277, 748);
            this.numericCurrentPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 9;
            this.numericCurrentPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.ValueChanged += new System.EventHandler(this.numericCurrentPage_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(199, 747);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Страница";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.checkBoxActive);
            this.panelFind.Controls.Add(this.btnCleanStatus);
            this.panelFind.Controls.Add(this.comboBoxStatus);
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.btnPriceInfo);
            this.panelFind.Controls.Add(this.btnCleanStartUntil);
            this.panelFind.Controls.Add(this.btnCleanStartFrom);
            this.panelFind.Controls.Add(this.label3);
            this.panelFind.Controls.Add(this.datePickerStartFrom);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.datePickerStartUntil);
            this.panelFind.Controls.Add(this.numericPriceUntil);
            this.panelFind.Controls.Add(this.numericPriceFrom);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.tbProduct);
            this.panelFind.Controls.Add(this.btnCleanProduct);
            this.panelFind.Controls.Add(this.btnFindProduct);
            this.panelFind.Controls.Add(this.label12);
            this.panelFind.Controls.Add(this.tbWorkshop);
            this.panelFind.Controls.Add(this.tbClient);
            this.panelFind.Controls.Add(this.btnCleanWorkshop);
            this.panelFind.Controls.Add(this.btnFindWorkshop);
            this.panelFind.Controls.Add(this.btnCleanClient);
            this.panelFind.Controls.Add(this.btnFindClient);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.label11);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(875, 120);
            this.panelFind.TabIndex = 4;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(568, 58);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(115, 17);
            this.checkBoxActive.TabIndex = 195;
            this.checkBoxActive.Text = "Только активные";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
            // 
            // btnCleanStatus
            // 
            this.btnCleanStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanStatus.FlatAppearance.BorderSize = 0;
            this.btnCleanStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanStatus.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanStatus.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanStatus.IconSize = 17;
            this.btnCleanStatus.Location = new System.Drawing.Point(840, 14);
            this.btnCleanStatus.Name = "btnCleanStatus";
            this.btnCleanStatus.Size = new System.Drawing.Size(18, 18);
            this.btnCleanStatus.TabIndex = 194;
            this.btnCleanStatus.UseVisualStyleBackColor = true;
            this.btnCleanStatus.Click += new System.EventHandler(this.btnCleanStatus_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(654, 11);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(175, 21);
            this.comboBoxStatus.TabIndex = 193;
            // 
            // btnAskOrDesk
            // 
            this.btnAskOrDesk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAskOrDesk.FlatAppearance.BorderSize = 0;
            this.btnAskOrDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAskOrDesk.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.btnAskOrDesk.IconColor = System.Drawing.Color.Black;
            this.btnAskOrDesk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAskOrDesk.IconSize = 20;
            this.btnAskOrDesk.Location = new System.Drawing.Point(759, 91);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 191;
            this.btnAskOrDesk.UseVisualStyleBackColor = true;
            this.btnAskOrDesk.Click += new System.EventHandler(this.btnAskOrDesk_Click);
            this.btnAskOrDesk.MouseHover += new System.EventHandler(this.btnAskOrDesk_MouseHover);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 192;
            this.label10.Text = "Статус заказа:";
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(654, 91);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(99, 21);
            this.comboBoxSortBy.TabIndex = 190;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 189;
            this.label2.Text = "Сортировка:";
            // 
            // btnPriceInfo
            // 
            this.btnPriceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPriceInfo.FlatAppearance.BorderSize = 0;
            this.btnPriceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnPriceInfo.IconColor = System.Drawing.Color.Black;
            this.btnPriceInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPriceInfo.IconSize = 20;
            this.btnPriceInfo.Location = new System.Drawing.Point(509, 90);
            this.btnPriceInfo.Name = "btnPriceInfo";
            this.btnPriceInfo.Size = new System.Drawing.Size(27, 21);
            this.btnPriceInfo.TabIndex = 188;
            this.btnPriceInfo.UseVisualStyleBackColor = true;
            this.btnPriceInfo.MouseHover += new System.EventHandler(this.btnPriceInfo_MouseHover);
            // 
            // btnCleanStartUntil
            // 
            this.btnCleanStartUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanStartUntil.FlatAppearance.BorderSize = 0;
            this.btnCleanStartUntil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanStartUntil.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanStartUntil.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanStartUntil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanStartUntil.IconSize = 17;
            this.btnCleanStartUntil.Location = new System.Drawing.Point(514, 38);
            this.btnCleanStartUntil.Name = "btnCleanStartUntil";
            this.btnCleanStartUntil.Size = new System.Drawing.Size(18, 18);
            this.btnCleanStartUntil.TabIndex = 187;
            this.btnCleanStartUntil.UseVisualStyleBackColor = true;
            this.btnCleanStartUntil.Click += new System.EventHandler(this.btnCleanStartUntil_Click);
            // 
            // btnCleanStartFrom
            // 
            this.btnCleanStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanStartFrom.FlatAppearance.BorderSize = 0;
            this.btnCleanStartFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanStartFrom.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanStartFrom.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanStartFrom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanStartFrom.IconSize = 17;
            this.btnCleanStartFrom.Location = new System.Drawing.Point(514, 12);
            this.btnCleanStartFrom.Name = "btnCleanStartFrom";
            this.btnCleanStartFrom.Size = new System.Drawing.Size(18, 18);
            this.btnCleanStartFrom.TabIndex = 186;
            this.btnCleanStartFrom.UseVisualStyleBackColor = true;
            this.btnCleanStartFrom.Click += new System.EventHandler(this.btnCleanStartFrom_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 178;
            this.label3.Text = "Начало от";
            // 
            // datePickerStartFrom
            // 
            this.datePickerStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datePickerStartFrom.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStartFrom.Location = new System.Drawing.Point(380, 9);
            this.datePickerStartFrom.Name = "datePickerStartFrom";
            this.datePickerStartFrom.Size = new System.Drawing.Size(128, 20);
            this.datePickerStartFrom.TabIndex = 179;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 184;
            this.label6.Text = "Начало до";
            // 
            // datePickerStartUntil
            // 
            this.datePickerStartUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datePickerStartUntil.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerStartUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStartUntil.Location = new System.Drawing.Point(380, 36);
            this.datePickerStartUntil.Name = "datePickerStartUntil";
            this.datePickerStartUntil.Size = new System.Drawing.Size(128, 20);
            this.datePickerStartUntil.TabIndex = 185;
            // 
            // numericPriceUntil
            // 
            this.numericPriceUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericPriceUntil.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericPriceUntil.Location = new System.Drawing.Point(380, 91);
            this.numericPriceUntil.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericPriceUntil.Name = "numericPriceUntil";
            this.numericPriceUntil.Size = new System.Drawing.Size(128, 20);
            this.numericPriceUntil.TabIndex = 183;
            // 
            // numericPriceFrom
            // 
            this.numericPriceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericPriceFrom.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericPriceFrom.Location = new System.Drawing.Point(380, 62);
            this.numericPriceFrom.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericPriceFrom.Name = "numericPriceFrom";
            this.numericPriceFrom.Size = new System.Drawing.Size(128, 20);
            this.numericPriceFrom.TabIndex = 182;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 181;
            this.label5.Text = "Цена до";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 180;
            this.label4.Text = "Цена от";
            // 
            // tbProduct
            // 
            this.tbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProduct.Enabled = false;
            this.tbProduct.Location = new System.Drawing.Point(94, 90);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.ReadOnly = true;
            this.tbProduct.Size = new System.Drawing.Size(113, 20);
            this.tbProduct.TabIndex = 177;
            // 
            // btnCleanProduct
            // 
            this.btnCleanProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanProduct.FlatAppearance.BorderSize = 0;
            this.btnCleanProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanProduct.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanProduct.IconSize = 17;
            this.btnCleanProduct.Location = new System.Drawing.Point(237, 91);
            this.btnCleanProduct.Name = "btnCleanProduct";
            this.btnCleanProduct.Size = new System.Drawing.Size(18, 18);
            this.btnCleanProduct.TabIndex = 175;
            this.btnCleanProduct.UseVisualStyleBackColor = true;
            this.btnCleanProduct.Click += new System.EventHandler(this.btnCleanProduct_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindProduct.FlatAppearance.BorderSize = 0;
            this.btnFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindProduct.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindProduct.IconSize = 17;
            this.btnFindProduct.Location = new System.Drawing.Point(213, 91);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(18, 18);
            this.btnFindProduct.TabIndex = 176;
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 174;
            this.label12.Text = "Техника:";
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(94, 37);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(113, 20);
            this.tbWorkshop.TabIndex = 173;
            // 
            // tbClient
            // 
            this.tbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbClient.Enabled = false;
            this.tbClient.Location = new System.Drawing.Point(94, 63);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(113, 20);
            this.tbClient.TabIndex = 172;
            // 
            // btnCleanWorkshop
            // 
            this.btnCleanWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanWorkshop.FlatAppearance.BorderSize = 0;
            this.btnCleanWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanWorkshop.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanWorkshop.IconSize = 17;
            this.btnCleanWorkshop.Location = new System.Drawing.Point(237, 39);
            this.btnCleanWorkshop.Name = "btnCleanWorkshop";
            this.btnCleanWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnCleanWorkshop.TabIndex = 170;
            this.btnCleanWorkshop.UseVisualStyleBackColor = true;
            this.btnCleanWorkshop.Click += new System.EventHandler(this.btnCleanWorkshop_Click);
            // 
            // btnFindWorkshop
            // 
            this.btnFindWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFindWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindWorkshop.IconSize = 17;
            this.btnFindWorkshop.Location = new System.Drawing.Point(213, 39);
            this.btnFindWorkshop.Name = "btnFindWorkshop";
            this.btnFindWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnFindWorkshop.TabIndex = 171;
            this.btnFindWorkshop.UseVisualStyleBackColor = true;
            this.btnFindWorkshop.Click += new System.EventHandler(this.btnFindWorkshop_Click_1);
            // 
            // btnCleanClient
            // 
            this.btnCleanClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanClient.FlatAppearance.BorderSize = 0;
            this.btnCleanClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanClient.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanClient.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanClient.IconSize = 17;
            this.btnCleanClient.Location = new System.Drawing.Point(237, 64);
            this.btnCleanClient.Name = "btnCleanClient";
            this.btnCleanClient.Size = new System.Drawing.Size(18, 18);
            this.btnCleanClient.TabIndex = 168;
            this.btnCleanClient.UseVisualStyleBackColor = true;
            this.btnCleanClient.Click += new System.EventHandler(this.btnCleanClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindClient.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindClient.IconSize = 17;
            this.btnFindClient.Location = new System.Drawing.Point(213, 64);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(18, 18);
            this.btnFindClient.TabIndex = 169;
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Мастерская:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 166;
            this.label11.Text = "Клиент:";
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(94, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(72, 20);
            this.tbID.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 134;
            this.label7.Text = "ID заказа:";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(745, 730);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 50);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Следующая →";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrev.Location = new System.Drawing.Point(0, 730);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 50);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "← Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dataOrders
            // 
            this.dataOrders.AllowUserToAddRows = false;
            this.dataOrders.AllowUserToDeleteRows = false;
            this.dataOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Location = new System.Drawing.Point(0, 120);
            this.dataOrders.MultiSelect = false;
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.ReadOnly = true;
            this.dataOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrders.Size = new System.Drawing.Size(875, 610);
            this.dataOrders.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.extendFilterBtn);
            this.panelControl.Controls.Add(this.clearBtn);
            this.panelControl.Controls.Add(this.searchBtn);
            this.panelControl.Location = new System.Drawing.Point(875, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(190, 782);
            this.panelControl.TabIndex = 1;
            // 
            // extendFilterBtn
            // 
            this.extendFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.extendFilterBtn.FlatAppearance.BorderSize = 0;
            this.extendFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extendFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extendFilterBtn.Location = new System.Drawing.Point(0, 80);
            this.extendFilterBtn.Name = "extendFilterBtn";
            this.extendFilterBtn.Size = new System.Drawing.Size(190, 40);
            this.extendFilterBtn.TabIndex = 20;
            this.extendFilterBtn.Text = "Расширенный фильтр";
            this.extendFilterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.extendFilterBtn.UseVisualStyleBackColor = false;
            this.extendFilterBtn.Click += new System.EventHandler(this.ExtendFilterBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearBtn.Location = new System.Drawing.Point(0, 40);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(190, 40);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Отчистить фильтры";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchBtn.Location = new System.Drawing.Point(0, 0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(190, 40);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Найти";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1065, 782);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelContent);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panelFind;
        private ManageButton clearBtn;
        private ManageButton searchBtn;
        private ManageButton extendFilterBtn;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbProduct;
        private FontAwesome.Sharp.IconButton btnCleanProduct;
        private FontAwesome.Sharp.IconButton btnFindProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbWorkshop;
        private System.Windows.Forms.TextBox tbClient;
        private FontAwesome.Sharp.IconButton btnCleanWorkshop;
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private FontAwesome.Sharp.IconButton btnCleanClient;
        private FontAwesome.Sharp.IconButton btnFindClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnPriceInfo;
        private FontAwesome.Sharp.IconButton btnCleanStartUntil;
        private FontAwesome.Sharp.IconButton btnCleanStartFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePickerStartFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerStartUntil;
        private System.Windows.Forms.NumericUpDown numericPriceUntil;
        private System.Windows.Forms.NumericUpDown numericPriceFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private FontAwesome.Sharp.IconButton btnCleanStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipCurrentSort;
        private System.Windows.Forms.ToolTip toolTipPriceInfo;
    }
}
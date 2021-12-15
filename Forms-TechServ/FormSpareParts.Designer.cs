
namespace Forms_TechServ
{
    partial class FormSpareParts
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
            this.label5 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupStock = new System.Windows.Forms.GroupBox();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.btnCleanWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnFIndWorkshop = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericStockUntil = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericStockFrom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupPrepayment = new System.Windows.Forms.GroupBox();
            this.radioBtnRequied = new System.Windows.Forms.RadioButton();
            this.radioBtnWithout = new System.Windows.Forms.RadioButton();
            this.numericPrepaymentUntil = new System.Windows.Forms.NumericUpDown();
            this.numericPrepaymentFrom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataSpareParts = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.clearBtn = new Forms_TechServ.ManageButton();
            this.searchBtn = new Forms_TechServ.ManageButton();
            this.toolTipPrepaymentInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnPrepaymentInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelFind.SuspendLayout();
            this.groupStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockFrom)).BeginInit();
            this.groupPrepayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrepaymentUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrepaymentFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.comboBoxShowRows);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.labelPageCount);
            this.panelContent.Controls.Add(this.numericCurrentPage);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.panelFind);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataSpareParts);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 632);
            this.panelContent.TabIndex = 8;
            // 
            // comboBoxShowRows
            // 
            this.comboBoxShowRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowRows.FormattingEnabled = true;
            this.comboBoxShowRows.Location = new System.Drawing.Point(531, 596);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 18;
            this.comboBoxShowRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowRows_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(418, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Показывать по";
            // 
            // labelPageCount
            // 
            this.labelPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPageCount.Location = new System.Drawing.Point(324, 597);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 13;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(273, 598);
            this.numericCurrentPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 12;
            this.numericCurrentPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.ValueChanged += new System.EventHandler(this.numericCurrentPage_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(195, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Страница";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.groupStock);
            this.panelFind.Controls.Add(this.groupPrepayment);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.tbName);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 148);
            this.panelFind.TabIndex = 4;
            // 
            // btnAskOrDesk
            // 
            this.btnAskOrDesk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAskOrDesk.FlatAppearance.BorderSize = 0;
            this.btnAskOrDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAskOrDesk.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.btnAskOrDesk.IconColor = System.Drawing.Color.Black;
            this.btnAskOrDesk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAskOrDesk.IconSize = 20;
            this.btnAskOrDesk.Location = new System.Drawing.Point(227, 113);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 156;
            this.btnAskOrDesk.UseVisualStyleBackColor = true;
            this.btnAskOrDesk.Click += new System.EventHandler(this.btnAskOrDesk_Click);
            this.btnAskOrDesk.MouseHover += new System.EventHandler(this.btnAskOrDesk_MouseHover);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(101, 110);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(125, 21);
            this.comboBoxSortBy.TabIndex = 155;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 154;
            this.label10.Text = "Сортировка:";
            // 
            // groupStock
            // 
            this.groupStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupStock.Controls.Add(this.tbWorkshop);
            this.groupStock.Controls.Add(this.btnCleanWorkshop);
            this.groupStock.Controls.Add(this.btnFIndWorkshop);
            this.groupStock.Controls.Add(this.label1);
            this.groupStock.Controls.Add(this.numericStockUntil);
            this.groupStock.Controls.Add(this.label9);
            this.groupStock.Controls.Add(this.numericStockFrom);
            this.groupStock.Controls.Add(this.label8);
            this.groupStock.Location = new System.Drawing.Point(551, 15);
            this.groupStock.Name = "groupStock";
            this.groupStock.Size = new System.Drawing.Size(212, 125);
            this.groupStock.TabIndex = 125;
            this.groupStock.TabStop = false;
            this.groupStock.Text = "Наличие";
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(92, 73);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(90, 20);
            this.tbWorkshop.TabIndex = 138;
            // 
            // btnCleanWorkshop
            // 
            this.btnCleanWorkshop.FlatAppearance.BorderSize = 0;
            this.btnCleanWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanWorkshop.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanWorkshop.IconSize = 17;
            this.btnCleanWorkshop.Location = new System.Drawing.Point(212, 76);
            this.btnCleanWorkshop.Name = "btnCleanWorkshop";
            this.btnCleanWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnCleanWorkshop.TabIndex = 136;
            this.btnCleanWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnFIndWorkshop
            // 
            this.btnFIndWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFIndWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFIndWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFIndWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFIndWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFIndWorkshop.IconSize = 17;
            this.btnFIndWorkshop.Location = new System.Drawing.Point(188, 76);
            this.btnFIndWorkshop.Name = "btnFIndWorkshop";
            this.btnFIndWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnFIndWorkshop.TabIndex = 137;
            this.btnFIndWorkshop.UseVisualStyleBackColor = true;
            this.btnFIndWorkshop.Click += new System.EventHandler(this.btnFIndWorkshop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Мастерская:";
            // 
            // numericStockUntil
            // 
            this.numericStockUntil.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericStockUntil.Location = new System.Drawing.Point(119, 35);
            this.numericStockUntil.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericStockUntil.Name = "numericStockUntil";
            this.numericStockUntil.Size = new System.Drawing.Size(54, 20);
            this.numericStockUntil.TabIndex = 134;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 133;
            this.label9.Text = "до:";
            // 
            // numericStockFrom
            // 
            this.numericStockFrom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericStockFrom.Location = new System.Drawing.Point(43, 35);
            this.numericStockFrom.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericStockFrom.Name = "numericStockFrom";
            this.numericStockFrom.Size = new System.Drawing.Size(54, 20);
            this.numericStockFrom.TabIndex = 132;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "От:";
            // 
            // groupPrepayment
            // 
            this.groupPrepayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupPrepayment.Controls.Add(this.btnPrepaymentInfo);
            this.groupPrepayment.Controls.Add(this.radioBtnRequied);
            this.groupPrepayment.Controls.Add(this.radioBtnWithout);
            this.groupPrepayment.Controls.Add(this.numericPrepaymentUntil);
            this.groupPrepayment.Controls.Add(this.numericPrepaymentFrom);
            this.groupPrepayment.Controls.Add(this.label7);
            this.groupPrepayment.Controls.Add(this.label3);
            this.groupPrepayment.Location = new System.Drawing.Point(254, 15);
            this.groupPrepayment.Name = "groupPrepayment";
            this.groupPrepayment.Size = new System.Drawing.Size(280, 125);
            this.groupPrepayment.TabIndex = 124;
            this.groupPrepayment.TabStop = false;
            this.groupPrepayment.Text = "Предполата";
            // 
            // radioBtnRequied
            // 
            this.radioBtnRequied.AutoSize = true;
            this.radioBtnRequied.Location = new System.Drawing.Point(9, 72);
            this.radioBtnRequied.Name = "radioBtnRequied";
            this.radioBtnRequied.Size = new System.Drawing.Size(85, 17);
            this.radioBtnRequied.TabIndex = 130;
            this.radioBtnRequied.TabStop = true;
            this.radioBtnRequied.Text = "требующие:";
            this.radioBtnRequied.UseVisualStyleBackColor = true;
            // 
            // radioBtnWithout
            // 
            this.radioBtnWithout.AutoSize = true;
            this.radioBtnWithout.Location = new System.Drawing.Point(6, 37);
            this.radioBtnWithout.Name = "radioBtnWithout";
            this.radioBtnWithout.Size = new System.Drawing.Size(161, 17);
            this.radioBtnWithout.TabIndex = 129;
            this.radioBtnWithout.TabStop = true;
            this.radioBtnWithout.Text = "не требующие предоплаты";
            this.radioBtnWithout.UseVisualStyleBackColor = true;
            // 
            // numericPrepaymentUntil
            // 
            this.numericPrepaymentUntil.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericPrepaymentUntil.Location = new System.Drawing.Point(156, 96);
            this.numericPrepaymentUntil.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPrepaymentUntil.Name = "numericPrepaymentUntil";
            this.numericPrepaymentUntil.Size = new System.Drawing.Size(87, 20);
            this.numericPrepaymentUntil.TabIndex = 127;
            // 
            // numericPrepaymentFrom
            // 
            this.numericPrepaymentFrom.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericPrepaymentFrom.Location = new System.Drawing.Point(35, 96);
            this.numericPrepaymentFrom.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericPrepaymentFrom.Name = "numericPrepaymentFrom";
            this.numericPrepaymentFrom.Size = new System.Drawing.Size(87, 20);
            this.numericPrepaymentFrom.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 126;
            this.label7.Text = "до:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "От:";
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(101, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(83, 20);
            this.tbID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID детали";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbName.Location = new System.Drawing.Point(101, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 20);
            this.tbName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Наименование";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(648, 580);
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
            this.btnPrev.Location = new System.Drawing.Point(0, 580);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 50);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "← Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            this.dataSpareParts.Location = new System.Drawing.Point(0, 148);
            this.dataSpareParts.MultiSelect = false;
            this.dataSpareParts.Name = "dataSpareParts";
            this.dataSpareParts.ReadOnly = true;
            this.dataSpareParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSpareParts.Size = new System.Drawing.Size(778, 432);
            this.dataSpareParts.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.clearBtn);
            this.panelControl.Controls.Add(this.searchBtn);
            this.panelControl.Location = new System.Drawing.Point(778, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(190, 632);
            this.panelControl.TabIndex = 9;
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
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "Отчистить фильтры";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.UseVisualStyleBackColor = false;
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
            this.searchBtn.TabIndex = 21;
            this.searchBtn.Text = "Найти";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // btnPrepaymentInfo
            // 
            this.btnPrepaymentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrepaymentInfo.FlatAppearance.BorderSize = 0;
            this.btnPrepaymentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepaymentInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnPrepaymentInfo.IconColor = System.Drawing.Color.Black;
            this.btnPrepaymentInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrepaymentInfo.IconSize = 20;
            this.btnPrepaymentInfo.Location = new System.Drawing.Point(253, 95);
            this.btnPrepaymentInfo.Name = "btnPrepaymentInfo";
            this.btnPrepaymentInfo.Size = new System.Drawing.Size(27, 21);
            this.btnPrepaymentInfo.TabIndex = 146;
            this.btnPrepaymentInfo.UseVisualStyleBackColor = true;
            this.btnPrepaymentInfo.MouseHover += new System.EventHandler(this.btnPrepaymentInfo_MouseHover);
            // 
            // FormSpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelControl);
            this.Name = "FormSpareParts";
            this.Text = "FormSpareParts";
            this.Load += new System.EventHandler(this.FormSpareParts_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.groupStock.ResumeLayout(false);
            this.groupStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockFrom)).EndInit();
            this.groupPrepayment.ResumeLayout(false);
            this.groupPrepayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrepaymentUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrepaymentFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataSpareParts;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private ManageButton clearBtn;
        private ManageButton searchBtn;
        private System.Windows.Forms.GroupBox groupPrepayment;
        private System.Windows.Forms.RadioButton radioBtnRequied;
        private System.Windows.Forms.RadioButton radioBtnWithout;
        private System.Windows.Forms.NumericUpDown numericPrepaymentUntil;
        private System.Windows.Forms.NumericUpDown numericPrepaymentFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupStock;
        private System.Windows.Forms.NumericUpDown numericStockUntil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericStockFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbWorkshop;
        private FontAwesome.Sharp.IconButton btnCleanWorkshop;
        private FontAwesome.Sharp.IconButton btnFIndWorkshop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTipPrepaymentInfo;
        private FontAwesome.Sharp.IconButton btnPrepaymentInfo;
        private System.Windows.Forms.ToolTip toolTipCurrentSort;
    }
}
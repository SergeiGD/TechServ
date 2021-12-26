
namespace Forms_TechServ
{
    partial class FormVisits
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
            this.btnNext = new System.Windows.Forms.Button();
            this.dataVisits = new System.Windows.Forms.DataGridView();
            this.datePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.btnCleanOrder = new FontAwesome.Sharp.IconButton();
            this.btnFindOrder = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaster = new System.Windows.Forms.TextBox();
            this.btnCleanMaster = new FontAwesome.Sharp.IconButton();
            this.btnFindMaster = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkNotFinished = new System.Windows.Forms.CheckBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPagesCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnClean = new Forms_TechServ.ManageButton();
            this.btnFind = new Forms_TechServ.ManageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataVisits)).BeginInit();
            this.panelFind.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // dataVisits
            // 
            this.dataVisits.AllowUserToAddRows = false;
            this.dataVisits.AllowUserToDeleteRows = false;
            this.dataVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVisits.Location = new System.Drawing.Point(0, 120);
            this.dataVisits.Name = "dataVisits";
            this.dataVisits.ReadOnly = true;
            this.dataVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVisits.Size = new System.Drawing.Size(778, 460);
            this.dataVisits.TabIndex = 0;
            // 
            // datePickerUntil
            // 
            this.datePickerUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerUntil.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerUntil.Location = new System.Drawing.Point(632, 53);
            this.datePickerUntil.Name = "datePickerUntil";
            this.datePickerUntil.Size = new System.Drawing.Size(128, 20);
            this.datePickerUntil.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата до";
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
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.tbOrder);
            this.panelFind.Controls.Add(this.btnCleanOrder);
            this.panelFind.Controls.Add(this.btnFindOrder);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Controls.Add(this.tbMaster);
            this.panelFind.Controls.Add(this.btnCleanMaster);
            this.panelFind.Controls.Add(this.btnFindMaster);
            this.panelFind.Controls.Add(this.label8);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.datePickerFrom);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.checkNotFinished);
            this.panelFind.Controls.Add(this.tbAddress);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.datePickerUntil);
            this.panelFind.Controls.Add(this.label3);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 120);
            this.panelFind.TabIndex = 4;
            // 
            // btnAskOrDesk
            // 
            this.btnAskOrDesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAskOrDesk.FlatAppearance.BorderSize = 0;
            this.btnAskOrDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAskOrDesk.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.btnAskOrDesk.IconColor = System.Drawing.Color.Black;
            this.btnAskOrDesk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAskOrDesk.IconSize = 20;
            this.btnAskOrDesk.Location = new System.Drawing.Point(469, 90);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 156;
            this.btnAskOrDesk.UseVisualStyleBackColor = true;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(339, 88);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(124, 21);
            this.comboBoxSortBy.TabIndex = 155;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 154;
            this.label10.Text = "Сортировка:";
            // 
            // tbOrder
            // 
            this.tbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbOrder.Enabled = false;
            this.tbOrder.Location = new System.Drawing.Point(339, 50);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.ReadOnly = true;
            this.tbOrder.Size = new System.Drawing.Size(124, 20);
            this.tbOrder.TabIndex = 127;
            // 
            // btnCleanOrder
            // 
            this.btnCleanOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCleanOrder.FlatAppearance.BorderSize = 0;
            this.btnCleanOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanOrder.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanOrder.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanOrder.IconSize = 17;
            this.btnCleanOrder.Location = new System.Drawing.Point(493, 52);
            this.btnCleanOrder.Name = "btnCleanOrder";
            this.btnCleanOrder.Size = new System.Drawing.Size(18, 18);
            this.btnCleanOrder.TabIndex = 125;
            this.btnCleanOrder.UseVisualStyleBackColor = true;
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFindOrder.FlatAppearance.BorderSize = 0;
            this.btnFindOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindOrder.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindOrder.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindOrder.IconSize = 17;
            this.btnFindOrder.Location = new System.Drawing.Point(469, 52);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(18, 18);
            this.btnFindOrder.TabIndex = 126;
            this.btnFindOrder.UseVisualStyleBackColor = true;
            this.btnFindOrder.Click += new System.EventHandler(this.btnFindOrder_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 124;
            this.label7.Text = "Заказ:";
            // 
            // tbMaster
            // 
            this.tbMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbMaster.Enabled = false;
            this.tbMaster.Location = new System.Drawing.Point(339, 11);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.ReadOnly = true;
            this.tbMaster.Size = new System.Drawing.Size(124, 20);
            this.tbMaster.TabIndex = 123;
            // 
            // btnCleanMaster
            // 
            this.btnCleanMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCleanMaster.FlatAppearance.BorderSize = 0;
            this.btnCleanMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanMaster.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanMaster.IconSize = 17;
            this.btnCleanMaster.Location = new System.Drawing.Point(493, 13);
            this.btnCleanMaster.Name = "btnCleanMaster";
            this.btnCleanMaster.Size = new System.Drawing.Size(18, 18);
            this.btnCleanMaster.TabIndex = 121;
            this.btnCleanMaster.UseVisualStyleBackColor = true;
            // 
            // btnFindMaster
            // 
            this.btnFindMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFindMaster.FlatAppearance.BorderSize = 0;
            this.btnFindMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMaster.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindMaster.IconSize = 17;
            this.btnFindMaster.Location = new System.Drawing.Point(469, 13);
            this.btnFindMaster.Name = "btnFindMaster";
            this.btnFindMaster.Size = new System.Drawing.Size(18, 18);
            this.btnFindMaster.TabIndex = 122;
            this.btnFindMaster.UseVisualStyleBackColor = true;
            this.btnFindMaster.Click += new System.EventHandler(this.btnFindMaster_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 120;
            this.label8.Text = "Мастер:";
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(71, 11);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(117, 20);
            this.tbID.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerFrom.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerFrom.Location = new System.Drawing.Point(632, 12);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(128, 20);
            this.datePickerFrom.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Дата от";
            // 
            // checkNotFinished
            // 
            this.checkNotFinished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkNotFinished.AutoSize = true;
            this.checkNotFinished.Location = new System.Drawing.Point(30, 92);
            this.checkNotFinished.Name = "checkNotFinished";
            this.checkNotFinished.Size = new System.Drawing.Size(148, 17);
            this.checkNotFinished.TabIndex = 19;
            this.checkNotFinished.Text = "Только невыполненные";
            this.checkNotFinished.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAddress.Location = new System.Drawing.Point(71, 51);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(117, 20);
            this.tbAddress.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Адрес";
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.comboBoxShowRows);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.labelPagesCount);
            this.panelContent.Controls.Add(this.numericCurrentPage);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.panelFind);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataVisits);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 632);
            this.panelContent.TabIndex = 2;
            // 
            // comboBoxShowRows
            // 
            this.comboBoxShowRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowRows.FormattingEnabled = true;
            this.comboBoxShowRows.Location = new System.Drawing.Point(530, 596);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(417, 597);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Показывать по";
            // 
            // labelPagesCount
            // 
            this.labelPagesCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPagesCount.AutoSize = true;
            this.labelPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPagesCount.Location = new System.Drawing.Point(317, 597);
            this.labelPagesCount.Name = "labelPagesCount";
            this.labelPagesCount.Size = new System.Drawing.Size(36, 17);
            this.labelPagesCount.TabIndex = 10;
            this.labelPagesCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(266, 598);
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
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(188, 597);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Страница";
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.btnClean);
            this.panelControl.Controls.Add(this.btnFind);
            this.panelControl.Location = new System.Drawing.Point(778, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(190, 632);
            this.panelControl.TabIndex = 3;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClean.Location = new System.Drawing.Point(0, 40);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(190, 40);
            this.btnClean.TabIndex = 22;
            this.btnClean.Text = "Отчистить фильтры";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(0, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(190, 40);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Найти";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // FormVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelControl);
            this.Name = "FormVisits";
            this.Text = "FormVisits";
            this.Load += new System.EventHandler(this.FormVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVisits)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dataVisits;
        private System.Windows.Forms.DateTimePicker datePickerUntil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.CheckBox checkNotFinished;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOrder;
        private FontAwesome.Sharp.IconButton btnCleanOrder;
        private FontAwesome.Sharp.IconButton btnFindOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaster;
        private FontAwesome.Sharp.IconButton btnCleanMaster;
        private FontAwesome.Sharp.IconButton btnFindMaster;
        private System.Windows.Forms.Label label8;
        private ManageButton btnClean;
        private ManageButton btnFind;
        private System.Windows.Forms.Label labelPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label10;
    }
}
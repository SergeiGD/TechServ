
namespace Forms_TechServ
{
    partial class FormManagers
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnSalaryInfo = new FontAwesome.Sharp.IconButton();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFindPosition = new FontAwesome.Sharp.IconButton();
            this.btnCleanPosition = new FontAwesome.Sharp.IconButton();
            this.btnFlindWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnCleanWorkshop = new FontAwesome.Sharp.IconButton();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.numericSalaryUntil = new System.Windows.Forms.NumericUpDown();
            this.numericSalaryFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataManagers = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSlalaryInfo = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxRemotely = new System.Windows.Forms.CheckBox();
            this.clearBtn = new Forms_TechServ.ManageButton();
            this.searchBtn = new Forms_TechServ.ManageButton();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalaryUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalaryFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagers)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.comboBoxShowRows);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.labelPageCount);
            this.panelContent.Controls.Add(this.numericCurrentPage);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.panelFind);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataManagers);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 632);
            this.panelContent.TabIndex = 3;
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(418, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Показывать по";
            // 
            // labelPageCount
            // 
            this.labelPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPageCount.Location = new System.Drawing.Point(326, 597);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 13;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(275, 598);
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
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(197, 597);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Страница";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.checkBoxRemotely);
            this.panelFind.Controls.Add(this.btnSalaryInfo);
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.btnFindPosition);
            this.panelFind.Controls.Add(this.btnCleanPosition);
            this.panelFind.Controls.Add(this.btnFlindWorkshop);
            this.panelFind.Controls.Add(this.btnCleanWorkshop);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label8);
            this.panelFind.Controls.Add(this.tbPhoneNum);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Controls.Add(this.tbName);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.tbPosition);
            this.panelFind.Controls.Add(this.tbWorkshop);
            this.panelFind.Controls.Add(this.numericSalaryUntil);
            this.panelFind.Controls.Add(this.numericSalaryFrom);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 120);
            this.panelFind.TabIndex = 4;
            // 
            // btnSalaryInfo
            // 
            this.btnSalaryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalaryInfo.FlatAppearance.BorderSize = 0;
            this.btnSalaryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnSalaryInfo.IconColor = System.Drawing.Color.Black;
            this.btnSalaryInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalaryInfo.IconSize = 20;
            this.btnSalaryInfo.Location = new System.Drawing.Point(741, 53);
            this.btnSalaryInfo.Name = "btnSalaryInfo";
            this.btnSalaryInfo.Size = new System.Drawing.Size(27, 21);
            this.btnSalaryInfo.TabIndex = 145;
            this.btnSalaryInfo.UseVisualStyleBackColor = true;
            this.btnSalaryInfo.MouseHover += new System.EventHandler(this.btnSalaryInfo_MouseHover);
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
            this.btnAskOrDesk.Location = new System.Drawing.Point(741, 88);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 144;
            this.btnAskOrDesk.UseVisualStyleBackColor = true;
            this.btnAskOrDesk.Click += new System.EventHandler(this.btnAskOrDesk_Click);
            this.btnAskOrDesk.MouseHover += new System.EventHandler(this.btnAskOrDesk_MouseHover);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(620, 88);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(119, 21);
            this.comboBoxSortBy.TabIndex = 143;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 142;
            this.label10.Text = "Сортировать по:";
            // 
            // btnFindPosition
            // 
            this.btnFindPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFindPosition.FlatAppearance.BorderSize = 0;
            this.btnFindPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPosition.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindPosition.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindPosition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindPosition.IconSize = 17;
            this.btnFindPosition.Location = new System.Drawing.Point(451, 53);
            this.btnFindPosition.Name = "btnFindPosition";
            this.btnFindPosition.Size = new System.Drawing.Size(18, 18);
            this.btnFindPosition.TabIndex = 141;
            this.btnFindPosition.UseVisualStyleBackColor = true;
            this.btnFindPosition.Click += new System.EventHandler(this.btnFindPosition_Click);
            // 
            // btnCleanPosition
            // 
            this.btnCleanPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCleanPosition.FlatAppearance.BorderSize = 0;
            this.btnCleanPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanPosition.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanPosition.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanPosition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanPosition.IconSize = 17;
            this.btnCleanPosition.Location = new System.Drawing.Point(475, 53);
            this.btnCleanPosition.Name = "btnCleanPosition";
            this.btnCleanPosition.Size = new System.Drawing.Size(18, 18);
            this.btnCleanPosition.TabIndex = 140;
            this.btnCleanPosition.UseVisualStyleBackColor = true;
            this.btnCleanPosition.Click += new System.EventHandler(this.btnCleanPosition_Click);
            // 
            // btnFlindWorkshop
            // 
            this.btnFlindWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFlindWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFlindWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlindWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFlindWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFlindWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFlindWorkshop.IconSize = 17;
            this.btnFlindWorkshop.Location = new System.Drawing.Point(451, 15);
            this.btnFlindWorkshop.Name = "btnFlindWorkshop";
            this.btnFlindWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnFlindWorkshop.TabIndex = 139;
            this.btnFlindWorkshop.UseVisualStyleBackColor = true;
            this.btnFlindWorkshop.Click += new System.EventHandler(this.btnFlindWorkshop_Click);
            // 
            // btnCleanWorkshop
            // 
            this.btnCleanWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCleanWorkshop.FlatAppearance.BorderSize = 0;
            this.btnCleanWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanWorkshop.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanWorkshop.IconSize = 17;
            this.btnCleanWorkshop.Location = new System.Drawing.Point(475, 15);
            this.btnCleanWorkshop.Name = "btnCleanWorkshop";
            this.btnCleanWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnCleanWorkshop.TabIndex = 138;
            this.btnCleanWorkshop.UseVisualStyleBackColor = true;
            this.btnCleanWorkshop.Click += new System.EventHandler(this.btnCleanWorkshop_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(89, 15);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(131, 20);
            this.tbID.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 136;
            this.label8.Text = "ID";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPhoneNum.Location = new System.Drawing.Point(89, 88);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(131, 20);
            this.tbPhoneNum.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 134;
            this.label7.Text = "Телефон";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbName.Location = new System.Drawing.Point(89, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(131, 20);
            this.tbName.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 132;
            this.label6.Text = "Имя";
            // 
            // tbPosition
            // 
            this.tbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbPosition.Enabled = false;
            this.tbPosition.Location = new System.Drawing.Point(338, 53);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(107, 20);
            this.tbPosition.TabIndex = 125;
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(338, 15);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(107, 20);
            this.tbWorkshop.TabIndex = 122;
            // 
            // numericSalaryUntil
            // 
            this.numericSalaryUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSalaryUntil.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSalaryUntil.Location = new System.Drawing.Point(620, 53);
            this.numericSalaryUntil.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericSalaryUntil.Name = "numericSalaryUntil";
            this.numericSalaryUntil.Size = new System.Drawing.Size(119, 20);
            this.numericSalaryUntil.TabIndex = 14;
            // 
            // numericSalaryFrom
            // 
            this.numericSalaryFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSalaryFrom.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSalaryFrom.Location = new System.Drawing.Point(620, 13);
            this.numericSalaryFrom.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericSalaryFrom.Name = "numericSalaryFrom";
            this.numericSalaryFrom.Size = new System.Drawing.Size(119, 20);
            this.numericSalaryFrom.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Зарплата до";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Зарплата от";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Мастерская";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Должность";
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
            // dataManagers
            // 
            this.dataManagers.AllowUserToAddRows = false;
            this.dataManagers.AllowUserToDeleteRows = false;
            this.dataManagers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataManagers.Location = new System.Drawing.Point(0, 120);
            this.dataManagers.Name = "dataManagers";
            this.dataManagers.ReadOnly = true;
            this.dataManagers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataManagers.Size = new System.Drawing.Size(778, 460);
            this.dataManagers.TabIndex = 0;
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
            this.panelControl.TabIndex = 4;
            // 
            // checkBoxRemotely
            // 
            this.checkBoxRemotely.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBoxRemotely.AutoSize = true;
            this.checkBoxRemotely.Location = new System.Drawing.Point(266, 90);
            this.checkBoxRemotely.Name = "checkBoxRemotely";
            this.checkBoxRemotely.Size = new System.Drawing.Size(123, 17);
            this.checkBoxRemotely.TabIndex = 146;
            this.checkBoxRemotely.Text = "Работает удаленно";
            this.checkBoxRemotely.UseVisualStyleBackColor = true;
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
            this.searchBtn.TabIndex = 21;
            this.searchBtn.Text = "Найти";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // FormManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelContent);
            this.Name = "FormManagers";
            this.Text = "FormManagers";
            this.Load += new System.EventHandler(this.FormManagers_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalaryUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalaryFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagers)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFind;
        private FontAwesome.Sharp.IconButton btnFindPosition;
        private FontAwesome.Sharp.IconButton btnCleanPosition;
        private FontAwesome.Sharp.IconButton btnFlindWorkshop;
        private FontAwesome.Sharp.IconButton btnCleanWorkshop;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbWorkshop;
        private System.Windows.Forms.NumericUpDown numericSalaryUntil;
        private System.Windows.Forms.NumericUpDown numericSalaryFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataManagers;
        private System.Windows.Forms.Panel panelControl;
        private ManageButton clearBtn;
        private ManageButton searchBtn;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnSalaryInfo;
        private System.Windows.Forms.ToolTip toolTipCurrentSort;
        private System.Windows.Forms.ToolTip toolTipSlalaryInfo;
        private System.Windows.Forms.CheckBox checkBoxRemotely;
    }
}

using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.services
{
    partial class FormServices
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.checkBoxWithParents = new System.Windows.Forms.CheckBox();
            this.btnSalaryInfo = new FontAwesome.Sharp.IconButton();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.btnCleanCat = new FontAwesome.Sharp.IconButton();
            this.btnFindCat = new FontAwesome.Sharp.IconButton();
            this.numericPriceUntil = new System.Windows.Forms.NumericUpDown();
            this.numericPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataServies = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnClean = new ManageButton();
            this.searchBtn = new ManageButton();
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPriceInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnIdInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipIdInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbName.Location = new System.Drawing.Point(101, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(129, 20);
            this.tbName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Название";
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
            this.panelContent.Controls.Add(this.dataServies);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 632);
            this.panelContent.TabIndex = 4;
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
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(418, 597);
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
            this.labelPageCount.Location = new System.Drawing.Point(322, 597);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 13;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(271, 598);
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
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(193, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Страница";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.btnIdInfo);
            this.panelFind.Controls.Add(this.checkBoxWithParents);
            this.panelFind.Controls.Add(this.btnSalaryInfo);
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Controls.Add(this.tbCat);
            this.panelFind.Controls.Add(this.btnCleanCat);
            this.panelFind.Controls.Add(this.btnFindCat);
            this.panelFind.Controls.Add(this.tbName);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.numericPriceUntil);
            this.panelFind.Controls.Add(this.numericPriceFrom);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 127);
            this.panelFind.TabIndex = 4;
            // 
            // checkBoxWithParents
            // 
            this.checkBoxWithParents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBoxWithParents.AutoSize = true;
            this.checkBoxWithParents.Location = new System.Drawing.Point(288, 50);
            this.checkBoxWithParents.Name = "checkBoxWithParents";
            this.checkBoxWithParents.Size = new System.Drawing.Size(238, 17);
            this.checkBoxWithParents.TabIndex = 155;
            this.checkBoxWithParents.Text = "Показывать также услуги род. категорий";
            this.checkBoxWithParents.UseVisualStyleBackColor = true;
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
            this.btnSalaryInfo.Location = new System.Drawing.Point(748, 53);
            this.btnSalaryInfo.Name = "btnSalaryInfo";
            this.btnSalaryInfo.Size = new System.Drawing.Size(27, 21);
            this.btnSalaryInfo.TabIndex = 154;
            this.btnSalaryInfo.UseVisualStyleBackColor = true;
            this.btnSalaryInfo.MouseHover += new System.EventHandler(this.btnSalaryInfo_MouseHover);
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
            this.btnAskOrDesk.Location = new System.Drawing.Point(236, 96);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 153;
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
            this.comboBoxSortBy.Location = new System.Drawing.Point(101, 92);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(129, 21);
            this.comboBoxSortBy.TabIndex = 152;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 151;
            this.label10.Text = "Сортировка:";
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(101, 11);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(96, 20);
            this.tbID.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 124;
            this.label7.Text = "ID услуги:";
            // 
            // tbCat
            // 
            this.tbCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbCat.Enabled = false;
            this.tbCat.Location = new System.Drawing.Point(361, 11);
            this.tbCat.Name = "tbCat";
            this.tbCat.ReadOnly = true;
            this.tbCat.Size = new System.Drawing.Size(129, 20);
            this.tbCat.TabIndex = 119;
            // 
            // btnCleanCat
            // 
            this.btnCleanCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCleanCat.FlatAppearance.BorderSize = 0;
            this.btnCleanCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanCat.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanCat.IconSize = 17;
            this.btnCleanCat.Location = new System.Drawing.Point(520, 11);
            this.btnCleanCat.Name = "btnCleanCat";
            this.btnCleanCat.Size = new System.Drawing.Size(18, 18);
            this.btnCleanCat.TabIndex = 117;
            this.btnCleanCat.UseVisualStyleBackColor = true;
            this.btnCleanCat.Click += new System.EventHandler(this.btnCleanCat_Click);
            // 
            // btnFindCat
            // 
            this.btnFindCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFindCat.FlatAppearance.BorderSize = 0;
            this.btnFindCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCat.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindCat.IconSize = 17;
            this.btnFindCat.Location = new System.Drawing.Point(496, 11);
            this.btnFindCat.Name = "btnFindCat";
            this.btnFindCat.Size = new System.Drawing.Size(18, 18);
            this.btnFindCat.TabIndex = 118;
            this.btnFindCat.UseVisualStyleBackColor = true;
            this.btnFindCat.Click += new System.EventHandler(this.btnFindCat_Click);
            // 
            // numericPriceUntil
            // 
            this.numericPriceUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericPriceUntil.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericPriceUntil.Location = new System.Drawing.Point(639, 52);
            this.numericPriceUntil.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPriceUntil.Name = "numericPriceUntil";
            this.numericPriceUntil.Size = new System.Drawing.Size(105, 20);
            this.numericPriceUntil.TabIndex = 14;
            // 
            // numericPriceFrom
            // 
            this.numericPriceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericPriceFrom.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericPriceFrom.Location = new System.Drawing.Point(640, 11);
            this.numericPriceFrom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPriceFrom.Name = "numericPriceFrom";
            this.numericPriceFrom.Size = new System.Drawing.Size(105, 20);
            this.numericPriceFrom.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена до";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цена от";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория:";
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
            // dataServies
            // 
            this.dataServies.AllowUserToAddRows = false;
            this.dataServies.AllowUserToDeleteRows = false;
            this.dataServies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataServies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataServies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataServies.Location = new System.Drawing.Point(0, 133);
            this.dataServies.MultiSelect = false;
            this.dataServies.Name = "dataServies";
            this.dataServies.ReadOnly = true;
            this.dataServies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataServies.Size = new System.Drawing.Size(778, 447);
            this.dataServies.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.btnClean);
            this.panelControl.Controls.Add(this.searchBtn);
            this.panelControl.Location = new System.Drawing.Point(778, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(190, 632);
            this.panelControl.TabIndex = 5;
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
            this.btnClean.TabIndex = 20;
            this.btnClean.Text = "Отчистить фильтры";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.UseVisualStyleBackColor = false;
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
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "Найти";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // btnIdInfo
            // 
            this.btnIdInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIdInfo.FlatAppearance.BorderSize = 0;
            this.btnIdInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnIdInfo.IconColor = System.Drawing.Color.Black;
            this.btnIdInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIdInfo.IconSize = 20;
            this.btnIdInfo.Location = new System.Drawing.Point(203, 11);
            this.btnIdInfo.Name = "btnIdInfo";
            this.btnIdInfo.Size = new System.Drawing.Size(27, 21);
            this.btnIdInfo.TabIndex = 230;
            this.btnIdInfo.UseVisualStyleBackColor = true;
            this.btnIdInfo.MouseHover += new System.EventHandler(this.btnIdInfo_MouseHover);
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelControl);
            this.Name = "FormServices";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.FormServices_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.NumericUpDown numericPriceUntil;
        private System.Windows.Forms.NumericUpDown numericPriceFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataServies;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox tbCat;
        private FontAwesome.Sharp.IconButton btnCleanCat;
        private FontAwesome.Sharp.IconButton btnFindCat;
        private ManageButton searchBtn;
        private ManageButton btnClean;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTipCurrentSort;
        private System.Windows.Forms.ToolTip toolTipPriceInfo;
        private FontAwesome.Sharp.IconButton btnSalaryInfo;
        private System.Windows.Forms.CheckBox checkBoxWithParents;
        private FontAwesome.Sharp.IconButton btnIdInfo;
        private System.Windows.Forms.ToolTip toolTipIdInfo;
    }
}
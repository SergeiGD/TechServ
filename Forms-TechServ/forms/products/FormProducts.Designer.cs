
using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.products
{
    partial class FormProducts
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnClean = new ManageButton();
            this.btnFind = new ManageButton();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.btnCleanCat = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindCat = new FontAwesome.Sharp.IconButton();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.btnFindClient = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCleanClient = new FontAwesome.Sharp.IconButton();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.btnIdInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipIdInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panelControl.SuspendLayout();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl.TabIndex = 7;
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
            this.btnClean.TabIndex = 3;
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
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.btnIdInfo);
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.tbCat);
            this.panelFind.Controls.Add(this.btnCleanCat);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.btnFindCat);
            this.panelFind.Controls.Add(this.tbClient);
            this.panelFind.Controls.Add(this.btnFindClient);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.btnCleanClient);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Controls.Add(this.tbName);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 80);
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
            this.btnAskOrDesk.Location = new System.Drawing.Point(469, 14);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 153;
            this.btnAskOrDesk.UseVisualStyleBackColor = true;
            this.btnAskOrDesk.Click += new System.EventHandler(this.btnAskOrDesk_Click);
            this.btnAskOrDesk.MouseHover += new System.EventHandler(this.btnAskOrDesk_MouseHover);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(345, 10);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(124, 21);
            this.comboBoxSortBy.TabIndex = 152;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 151;
            this.label10.Text = "Сортировать по:";
            // 
            // tbCat
            // 
            this.tbCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCat.Enabled = false;
            this.tbCat.Location = new System.Drawing.Point(570, 9);
            this.tbCat.Name = "tbCat";
            this.tbCat.ReadOnly = true;
            this.tbCat.Size = new System.Drawing.Size(127, 20);
            this.tbCat.TabIndex = 123;
            // 
            // btnCleanCat
            // 
            this.btnCleanCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanCat.FlatAppearance.BorderSize = 0;
            this.btnCleanCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanCat.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanCat.IconSize = 17;
            this.btnCleanCat.Location = new System.Drawing.Point(727, 8);
            this.btnCleanCat.Name = "btnCleanCat";
            this.btnCleanCat.Size = new System.Drawing.Size(18, 23);
            this.btnCleanCat.TabIndex = 121;
            this.btnCleanCat.UseVisualStyleBackColor = true;
            this.btnCleanCat.Click += new System.EventHandler(this.btnCleanCat_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Категория:";
            // 
            // btnFindCat
            // 
            this.btnFindCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindCat.FlatAppearance.BorderSize = 0;
            this.btnFindCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCat.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindCat.IconSize = 17;
            this.btnFindCat.Location = new System.Drawing.Point(703, 8);
            this.btnFindCat.Name = "btnFindCat";
            this.btnFindCat.Size = new System.Drawing.Size(18, 23);
            this.btnFindCat.TabIndex = 122;
            this.btnFindCat.UseVisualStyleBackColor = true;
            this.btnFindCat.Click += new System.EventHandler(this.btnFindCat_Click);
            // 
            // tbClient
            // 
            this.tbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClient.Enabled = false;
            this.tbClient.Location = new System.Drawing.Point(570, 47);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(127, 20);
            this.tbClient.TabIndex = 119;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindClient.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindClient.IconSize = 17;
            this.btnFindClient.Location = new System.Drawing.Point(703, 46);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(18, 23);
            this.btnFindClient.TabIndex = 118;
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Клиент:";
            // 
            // btnCleanClient
            // 
            this.btnCleanClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanClient.FlatAppearance.BorderSize = 0;
            this.btnCleanClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanClient.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanClient.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanClient.IconSize = 17;
            this.btnCleanClient.Location = new System.Drawing.Point(727, 46);
            this.btnCleanClient.Name = "btnCleanClient";
            this.btnCleanClient.Size = new System.Drawing.Size(18, 23);
            this.btnCleanClient.TabIndex = 117;
            this.btnCleanClient.UseVisualStyleBackColor = true;
            this.btnCleanClient.Click += new System.EventHandler(this.btnCleanClient_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(95, 10);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(101, 20);
            this.tbID.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "ID:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbName.Location = new System.Drawing.Point(95, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(134, 20);
            this.tbName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Название:";
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
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Location = new System.Drawing.Point(0, 80);
            this.dataProducts.MultiSelect = false;
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            this.dataProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProducts.Size = new System.Drawing.Size(778, 500);
            this.dataProducts.TabIndex = 0;
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
            this.panelContent.Controls.Add(this.dataProducts);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 632);
            this.panelContent.TabIndex = 6;
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
            this.labelPageCount.Location = new System.Drawing.Point(323, 597);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 10;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(272, 598);
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
            this.label8.Location = new System.Drawing.Point(194, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Страница";
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
            this.btnIdInfo.Location = new System.Drawing.Point(202, 10);
            this.btnIdInfo.Name = "btnIdInfo";
            this.btnIdInfo.Size = new System.Drawing.Size(27, 21);
            this.btnIdInfo.TabIndex = 228;
            this.btnIdInfo.UseVisualStyleBackColor = true;
            this.btnIdInfo.MouseHover += new System.EventHandler(this.btnIdInfo_MouseHover);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelContent);
            this.Name = "FormProducts";
            this.Text = "Техника клиентов";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.panelControl.ResumeLayout(false);
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCat;
        private FontAwesome.Sharp.IconButton btnCleanCat;
        private FontAwesome.Sharp.IconButton btnFindCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClient;
        private FontAwesome.Sharp.IconButton btnCleanClient;
        private FontAwesome.Sharp.IconButton btnFindClient;
        private System.Windows.Forms.Label label4;
        private ManageButton btnClean;
        private ManageButton btnFind;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTipCurrentSort;
        private FontAwesome.Sharp.IconButton btnIdInfo;
        private System.Windows.Forms.ToolTip toolTipIdInfo;
    }
}
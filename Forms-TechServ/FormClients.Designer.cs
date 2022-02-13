
namespace Forms_TechServ
{
    partial class FormClients
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
            this.label2 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnOrdersInfo = new FontAwesome.Sharp.IconButton();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericOrdersUntil = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericOrdersFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataClients = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.BtnClean = new Forms_TechServ.ManageButton();
            this.btnFind = new Forms_TechServ.ManageButton();
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOrdersInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnIdInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipIdInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrdersUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrdersFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbName.Location = new System.Drawing.Point(83, 55);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(117, 20);
            this.tbName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя";
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
            this.panelContent.Controls.Add(this.dataClients);
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
            this.comboBoxShowRows.Location = new System.Drawing.Point(527, 596);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 16;
            this.comboBoxShowRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowRows_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(414, 597);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 15;
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
            this.labelPageCount.TabIndex = 7;
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
            this.numericCurrentPage.TabIndex = 6;
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
            this.label8.TabIndex = 5;
            this.label8.Text = "Страница";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.btnIdInfo);
            this.panelFind.Controls.Add(this.btnOrdersInfo);
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.numericOrdersUntil);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.numericOrdersFrom);
            this.panelFind.Controls.Add(this.label3);
            this.panelFind.Controls.Add(this.tbPhoneNum);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.tbName);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 91);
            this.panelFind.TabIndex = 4;
            // 
            // btnOrdersInfo
            // 
            this.btnOrdersInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdersInfo.FlatAppearance.BorderSize = 0;
            this.btnOrdersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnOrdersInfo.IconColor = System.Drawing.Color.Black;
            this.btnOrdersInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrdersInfo.IconSize = 20;
            this.btnOrdersInfo.Location = new System.Drawing.Point(745, 55);
            this.btnOrdersInfo.Name = "btnOrdersInfo";
            this.btnOrdersInfo.Size = new System.Drawing.Size(27, 21);
            this.btnOrdersInfo.TabIndex = 146;
            this.btnOrdersInfo.UseVisualStyleBackColor = true;
            this.btnOrdersInfo.MouseHover += new System.EventHandler(this.btnOrdersInfo_MouseHover);
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
            this.btnAskOrDesk.Location = new System.Drawing.Point(492, 55);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 130;
            this.btnAskOrDesk.UseVisualStyleBackColor = true;
            this.btnAskOrDesk.Click += new System.EventHandler(this.btnAskOrDesk_Click);
            this.btnAskOrDesk.MouseHover += new System.EventHandler(this.btnAskOrDesk_MouseHover);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(362, 54);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(124, 21);
            this.comboBoxSortBy.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 128;
            this.label10.Text = "Сортировать по:";
            // 
            // numericOrdersUntil
            // 
            this.numericOrdersUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOrdersUntil.Location = new System.Drawing.Point(674, 55);
            this.numericOrdersUntil.Name = "numericOrdersUntil";
            this.numericOrdersUntil.Size = new System.Drawing.Size(68, 20);
            this.numericOrdersUntil.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Кол-во заказов до";
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(83, 20);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(88, 20);
            this.tbID.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "ID";
            // 
            // numericOrdersFrom
            // 
            this.numericOrdersFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOrdersFrom.Location = new System.Drawing.Point(675, 20);
            this.numericOrdersFrom.Name = "numericOrdersFrom";
            this.numericOrdersFrom.Size = new System.Drawing.Size(68, 20);
            this.numericOrdersFrom.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Кол-во заказов от";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbPhoneNum.Location = new System.Drawing.Point(362, 20);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(124, 20);
            this.tbPhoneNum.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Номер телефона:";
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
            // dataClients
            // 
            this.dataClients.AllowUserToAddRows = false;
            this.dataClients.AllowUserToDeleteRows = false;
            this.dataClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.Location = new System.Drawing.Point(0, 91);
            this.dataClients.MultiSelect = false;
            this.dataClients.Name = "dataClients";
            this.dataClients.ReadOnly = true;
            this.dataClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClients.Size = new System.Drawing.Size(778, 489);
            this.dataClients.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.BtnClean);
            this.panelControl.Controls.Add(this.btnFind);
            this.panelControl.Location = new System.Drawing.Point(778, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(190, 632);
            this.panelControl.TabIndex = 5;
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.BtnClean.FlatAppearance.BorderSize = 0;
            this.BtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnClean.Location = new System.Drawing.Point(0, 40);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(190, 40);
            this.BtnClean.TabIndex = 22;
            this.BtnClean.Text = "Отчистить фильтры";
            this.BtnClean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
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
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.btnIdInfo.Location = new System.Drawing.Point(173, 19);
            this.btnIdInfo.Name = "btnIdInfo";
            this.btnIdInfo.Size = new System.Drawing.Size(27, 21);
            this.btnIdInfo.TabIndex = 149;
            this.btnIdInfo.UseVisualStyleBackColor = true;
            this.btnIdInfo.MouseHover += new System.EventHandler(this.btnIdInfo_MouseHover);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelControl);
            this.Name = "FormClients";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrdersUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrdersFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataClients;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericOrdersFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericOrdersUntil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPageCount;
        private ManageButton BtnClean;
        private ManageButton btnFind;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTipCurrentSort;
        private FontAwesome.Sharp.IconButton btnOrdersInfo;
        private System.Windows.Forms.ToolTip toolTipOrdersInfo;
        private FontAwesome.Sharp.IconButton btnIdInfo;
        private System.Windows.Forms.ToolTip toolTipIdInfo;
    }
}
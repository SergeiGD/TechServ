﻿
namespace Forms_TechServ
{
    partial class FormInOrders
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPagesCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.btnCleanWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnFindWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnCleanClient = new FontAwesome.Sharp.IconButton();
            this.btnFindClient = new FontAwesome.Sharp.IconButton();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkHideCanceled = new System.Windows.Forms.CheckBox();
            this.datePickerStartUntil = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.numericPriceUntil = new System.Windows.Forms.NumericUpDown();
            this.numericPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerStartForm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkMyWorkshop = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPriority = new System.Windows.Forms.GroupBox();
            this.radioBtnDefPriority = new System.Windows.Forms.RadioButton();
            this.radioBtnHighPriority = new System.Windows.Forms.RadioButton();
            this.radioBtnAnyPriority = new System.Windows.Forms.RadioButton();
            this.checkMine = new System.Windows.Forms.CheckBox();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.extendFilterBtn = new Forms_TechServ.ManageButton();
            this.clearBtn = new Forms_TechServ.ManageButton();
            this.searchBtn = new Forms_TechServ.ManageButton();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_dateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_dateFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_dateCanceled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_master = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFrom)).BeginInit();
            this.groupPriority.SuspendLayout();
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
            this.panelContent.Controls.Add(this.labelPagesCount);
            this.panelContent.Controls.Add(this.numericCurrentPage);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.panelFind);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataOrders);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(875, 782);
            this.panelContent.TabIndex = 1;
            // 
            // comboBoxShowRows
            // 
            this.comboBoxShowRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowRows.FormattingEnabled = true;
            this.comboBoxShowRows.Location = new System.Drawing.Point(605, 746);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(492, 747);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Показывать по";
            // 
            // labelPagesCount
            // 
            this.labelPagesCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPagesCount.AutoSize = true;
            this.labelPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPagesCount.Location = new System.Drawing.Point(360, 747);
            this.labelPagesCount.Name = "labelPagesCount";
            this.labelPagesCount.Size = new System.Drawing.Size(36, 17);
            this.labelPagesCount.TabIndex = 10;
            this.labelPagesCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(309, 748);
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(231, 747);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Страница";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.tbWorkshop);
            this.panelFind.Controls.Add(this.tbClient);
            this.panelFind.Controls.Add(this.btnCleanWorkshop);
            this.panelFind.Controls.Add(this.btnFindWorkshop);
            this.panelFind.Controls.Add(this.btnCleanClient);
            this.panelFind.Controls.Add(this.btnFindClient);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Controls.Add(this.checkHideCanceled);
            this.panelFind.Controls.Add(this.datePickerStartUntil);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.numericPriceUntil);
            this.panelFind.Controls.Add(this.numericPriceFrom);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.datePickerStartForm);
            this.panelFind.Controls.Add(this.label3);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.checkMyWorkshop);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.groupPriority);
            this.panelFind.Controls.Add(this.checkMine);
            this.panelFind.Controls.Add(this.checkActive);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(875, 120);
            this.panelFind.TabIndex = 4;
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(729, 51);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(90, 20);
            this.tbWorkshop.TabIndex = 116;
            // 
            // tbClient
            // 
            this.tbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbClient.Enabled = false;
            this.tbClient.Location = new System.Drawing.Point(76, 90);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(104, 20);
            this.tbClient.TabIndex = 115;
            // 
            // btnCleanWorkshop
            // 
            this.btnCleanWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanWorkshop.FlatAppearance.BorderSize = 0;
            this.btnCleanWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanWorkshop.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanWorkshop.IconSize = 17;
            this.btnCleanWorkshop.Location = new System.Drawing.Point(849, 54);
            this.btnCleanWorkshop.Name = "btnCleanWorkshop";
            this.btnCleanWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnCleanWorkshop.TabIndex = 93;
            this.btnCleanWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnFindWorkshop
            // 
            this.btnFindWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFindWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindWorkshop.IconSize = 17;
            this.btnFindWorkshop.Location = new System.Drawing.Point(825, 54);
            this.btnFindWorkshop.Name = "btnFindWorkshop";
            this.btnFindWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnFindWorkshop.TabIndex = 94;
            this.btnFindWorkshop.UseVisualStyleBackColor = true;
            this.btnFindWorkshop.Click += new System.EventHandler(this.btnFindWorkshop_Click);
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
            this.btnCleanClient.Location = new System.Drawing.Point(210, 92);
            this.btnCleanClient.Name = "btnCleanClient";
            this.btnCleanClient.Size = new System.Drawing.Size(18, 18);
            this.btnCleanClient.TabIndex = 15;
            this.btnCleanClient.UseVisualStyleBackColor = true;
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
            this.btnFindClient.Location = new System.Drawing.Point(186, 92);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(18, 18);
            this.btnFindClient.TabIndex = 16;
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(76, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(104, 20);
            this.tbID.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "ID";
            // 
            // checkHideCanceled
            // 
            this.checkHideCanceled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkHideCanceled.AutoSize = true;
            this.checkHideCanceled.Location = new System.Drawing.Point(654, 91);
            this.checkHideCanceled.Name = "checkHideCanceled";
            this.checkHideCanceled.Size = new System.Drawing.Size(130, 17);
            this.checkHideCanceled.TabIndex = 88;
            this.checkHideCanceled.Text = "Скрыть отмененные";
            this.checkHideCanceled.UseVisualStyleBackColor = true;
            // 
            // datePickerStartUntil
            // 
            this.datePickerStartUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datePickerStartUntil.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerStartUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStartUntil.Location = new System.Drawing.Point(486, 41);
            this.datePickerStartUntil.Name = "datePickerStartUntil";
            this.datePickerStartUntil.Size = new System.Drawing.Size(128, 20);
            this.datePickerStartUntil.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Начало до";
            // 
            // numericPriceUntil
            // 
            this.numericPriceUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericPriceUntil.Location = new System.Drawing.Point(486, 94);
            this.numericPriceUntil.Name = "numericPriceUntil";
            this.numericPriceUntil.Size = new System.Drawing.Size(128, 20);
            this.numericPriceUntil.TabIndex = 14;
            // 
            // numericPriceFrom
            // 
            this.numericPriceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericPriceFrom.Location = new System.Drawing.Point(486, 68);
            this.numericPriceFrom.Name = "numericPriceFrom";
            this.numericPriceFrom.Size = new System.Drawing.Size(128, 20);
            this.numericPriceFrom.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена до";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цена от";
            // 
            // datePickerStartForm
            // 
            this.datePickerStartForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datePickerStartForm.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerStartForm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStartForm.Location = new System.Drawing.Point(486, 14);
            this.datePickerStartForm.Name = "datePickerStartForm";
            this.datePickerStartForm.Size = new System.Drawing.Size(128, 20);
            this.datePickerStartForm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Начало от";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Мастерская:";
            // 
            // checkMyWorkshop
            // 
            this.checkMyWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkMyWorkshop.AutoSize = true;
            this.checkMyWorkshop.Location = new System.Drawing.Point(654, 15);
            this.checkMyWorkshop.Name = "checkMyWorkshop";
            this.checkMyWorkshop.Size = new System.Drawing.Size(165, 17);
            this.checkMyWorkshop.TabIndex = 6;
            this.checkMyWorkshop.Text = "Только в моей мастреской";
            this.checkMyWorkshop.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Клиент:";
            // 
            // groupPriority
            // 
            this.groupPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupPriority.Controls.Add(this.radioBtnDefPriority);
            this.groupPriority.Controls.Add(this.radioBtnHighPriority);
            this.groupPriority.Controls.Add(this.radioBtnAnyPriority);
            this.groupPriority.Location = new System.Drawing.Point(249, 15);
            this.groupPriority.Name = "groupPriority";
            this.groupPriority.Size = new System.Drawing.Size(114, 94);
            this.groupPriority.TabIndex = 3;
            this.groupPriority.TabStop = false;
            this.groupPriority.Text = "Приоритет";
            // 
            // radioBtnDefPriority
            // 
            this.radioBtnDefPriority.AutoSize = true;
            this.radioBtnDefPriority.Location = new System.Drawing.Point(7, 70);
            this.radioBtnDefPriority.Name = "radioBtnDefPriority";
            this.radioBtnDefPriority.Size = new System.Drawing.Size(72, 17);
            this.radioBtnDefPriority.TabIndex = 2;
            this.radioBtnDefPriority.TabStop = true;
            this.radioBtnDefPriority.Text = "Обычный";
            this.radioBtnDefPriority.UseVisualStyleBackColor = true;
            // 
            // radioBtnHighPriority
            // 
            this.radioBtnHighPriority.AutoSize = true;
            this.radioBtnHighPriority.Location = new System.Drawing.Point(7, 42);
            this.radioBtnHighPriority.Name = "radioBtnHighPriority";
            this.radioBtnHighPriority.Size = new System.Drawing.Size(70, 17);
            this.radioBtnHighPriority.TabIndex = 1;
            this.radioBtnHighPriority.TabStop = true;
            this.radioBtnHighPriority.Text = "Высокий";
            this.radioBtnHighPriority.UseVisualStyleBackColor = true;
            // 
            // radioBtnAnyPriority
            // 
            this.radioBtnAnyPriority.AutoSize = true;
            this.radioBtnAnyPriority.Location = new System.Drawing.Point(7, 17);
            this.radioBtnAnyPriority.Name = "radioBtnAnyPriority";
            this.radioBtnAnyPriority.Size = new System.Drawing.Size(59, 17);
            this.radioBtnAnyPriority.TabIndex = 0;
            this.radioBtnAnyPriority.TabStop = true;
            this.radioBtnAnyPriority.Text = "Любой";
            this.radioBtnAnyPriority.UseVisualStyleBackColor = true;
            // 
            // checkMine
            // 
            this.checkMine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkMine.AutoSize = true;
            this.checkMine.Location = new System.Drawing.Point(27, 37);
            this.checkMine.Name = "checkMine";
            this.checkMine.Size = new System.Drawing.Size(86, 17);
            this.checkMine.TabIndex = 2;
            this.checkMine.Text = "Только мои";
            this.checkMine.UseVisualStyleBackColor = true;
            // 
            // checkActive
            // 
            this.checkActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkActive.AutoSize = true;
            this.checkActive.Location = new System.Drawing.Point(27, 66);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(115, 17);
            this.checkActive.TabIndex = 1;
            this.checkActive.Text = "Только активные";
            this.checkActive.UseVisualStyleBackColor = true;
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
            // 
            // dataOrders
            // 
            this.dataOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_status,
            this.column_dateStart,
            this.column_dateFinish,
            this.column_dateCanceled,
            this.column_product,
            this.column_client,
            this.column_master,
            this.column_workshop,
            this.column_price,
            this.column_sale});
            this.dataOrders.Location = new System.Drawing.Point(0, 120);
            this.dataOrders.Name = "dataOrders";
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
            this.panelControl.TabIndex = 2;
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
            // 
            // column_id
            // 
            this.column_id.HeaderText = "id";
            this.column_id.Name = "column_id";
            // 
            // column_status
            // 
            this.column_status.HeaderText = "Статус";
            this.column_status.Name = "column_status";
            // 
            // column_dateStart
            // 
            this.column_dateStart.HeaderText = "Дата начала";
            this.column_dateStart.Name = "column_dateStart";
            // 
            // column_dateFinish
            // 
            this.column_dateFinish.HeaderText = "Дата завершения";
            this.column_dateFinish.Name = "column_dateFinish";
            // 
            // column_dateCanceled
            // 
            this.column_dateCanceled.HeaderText = "Дата отмены";
            this.column_dateCanceled.Name = "column_dateCanceled";
            // 
            // column_product
            // 
            this.column_product.HeaderText = "Техника";
            this.column_product.Name = "column_product";
            // 
            // column_client
            // 
            this.column_client.HeaderText = "Клиент";
            this.column_client.Name = "column_client";
            // 
            // column_master
            // 
            this.column_master.HeaderText = "Мастер";
            this.column_master.Name = "column_master";
            // 
            // column_workshop
            // 
            this.column_workshop.HeaderText = "Мастерская";
            this.column_workshop.Name = "column_workshop";
            // 
            // column_price
            // 
            this.column_price.HeaderText = "Цена";
            this.column_price.Name = "column_price";
            // 
            // column_sale
            // 
            this.column_sale.HeaderText = "Общая скидка";
            this.column_sale.Name = "column_sale";
            // 
            // FormInOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1065, 782);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelContent);
            this.Name = "FormInOrders";
            this.Text = "FormInOrders";
            this.Load += new System.EventHandler(this.FormInOrders_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFrom)).EndInit();
            this.groupPriority.ResumeLayout(false);
            this.groupPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.TextBox tbWorkshop;
        private System.Windows.Forms.TextBox tbClient;
        private FontAwesome.Sharp.IconButton btnCleanWorkshop;
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private FontAwesome.Sharp.IconButton btnCleanClient;
        private FontAwesome.Sharp.IconButton btnFindClient;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkHideCanceled;
        private System.Windows.Forms.DateTimePicker datePickerStartUntil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericPriceUntil;
        private System.Windows.Forms.NumericUpDown numericPriceFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickerStartForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkMyWorkshop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupPriority;
        private System.Windows.Forms.RadioButton radioBtnDefPriority;
        private System.Windows.Forms.RadioButton radioBtnHighPriority;
        private System.Windows.Forms.RadioButton radioBtnAnyPriority;
        private System.Windows.Forms.CheckBox checkMine;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.Panel panelControl;
        private ManageButton extendFilterBtn;
        private ManageButton clearBtn;
        private ManageButton searchBtn;
        private System.Windows.Forms.Label labelPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_dateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_dateFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_dateCanceled;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_master;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_workshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sale;
    }
}
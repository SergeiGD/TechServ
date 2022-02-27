
using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.employees
{
    partial class FormShowMaster
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdditionInfo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.masterTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelWorkshop = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.categoriesPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowCat = new Forms_TechServ.forms.customControls.ManageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxShowCatRows = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelCatPagesCount = new System.Windows.Forms.Label();
            this.numericCurrentCatPage = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNextCat = new System.Windows.Forms.Button();
            this.btnPrevCat = new System.Windows.Forms.Button();
            this.dataCategories = new System.Windows.Forms.DataGridView();
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.visitsPage = new System.Windows.Forms.TabPage();
            this.labelPosition = new System.Windows.Forms.LinkLabel();
            this.masterTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.categoriesPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentCatPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Зарплата:";
            // 
            // tbAdditionInfo
            // 
            this.tbAdditionInfo.Enabled = false;
            this.tbAdditionInfo.Location = new System.Drawing.Point(235, 39);
            this.tbAdditionInfo.Name = "tbAdditionInfo";
            this.tbAdditionInfo.ReadOnly = true;
            this.tbAdditionInfo.Size = new System.Drawing.Size(219, 140);
            this.tbAdditionInfo.TabIndex = 30;
            this.tbAdditionInfo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Доп. информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Номер телефона:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя сотрудника:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(114, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 42;
            this.labelName.Text = "label8";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Location = new System.Drawing.Point(117, 91);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(35, 13);
            this.labelPhoneNum.TabIndex = 43;
            this.labelPhoneNum.Text = "label9";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(117, 153);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(41, 13);
            this.labelSalary.TabIndex = 44;
            this.labelSalary.Text = "label10";
            // 
            // masterTabs
            // 
            this.masterTabs.Controls.Add(this.generalPage);
            this.masterTabs.Controls.Add(this.categoriesPage);
            this.masterTabs.Controls.Add(this.timetablePage);
            this.masterTabs.Controls.Add(this.ordersPage);
            this.masterTabs.Controls.Add(this.visitsPage);
            this.masterTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTabs.Location = new System.Drawing.Point(0, 0);
            this.masterTabs.Name = "masterTabs";
            this.masterTabs.SelectedIndex = 0;
            this.masterTabs.Size = new System.Drawing.Size(803, 284);
            this.masterTabs.TabIndex = 46;
            this.masterTabs.SelectedIndexChanged += new System.EventHandler(this.masterTab_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelPosition);
            this.generalPage.Controls.Add(this.label26);
            this.generalPage.Controls.Add(this.labelPassword);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.labelID);
            this.generalPage.Controls.Add(this.labelWorkshop);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.panelEdit);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.labelSalary);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.labelPhoneNum);
            this.generalPage.Controls.Add(this.tbAdditionInfo);
            this.generalPage.Controls.Add(this.labelName);
            this.generalPage.Controls.Add(this.label5);
            this.generalPage.Controls.Add(this.label6);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(795, 258);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 123);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "Пароль:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(117, 123);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(35, 13);
            this.labelPassword.TabIndex = 54;
            this.labelPassword.Text = "label9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "ID мастера:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(114, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 13);
            this.labelID.TabIndex = 51;
            this.labelID.Text = "label11";
            // 
            // labelWorkshop
            // 
            this.labelWorkshop.AutoSize = true;
            this.labelWorkshop.Location = new System.Drawing.Point(117, 224);
            this.labelWorkshop.Name = "labelWorkshop";
            this.labelWorkshop.Size = new System.Drawing.Size(55, 13);
            this.labelWorkshop.TabIndex = 49;
            this.labelWorkshop.TabStop = true;
            this.labelWorkshop.Text = "linkLabel2";
            this.labelWorkshop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelWorkshop_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Мастерская:";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Controls.Add(this.deleteBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(632, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(160, 252);
            this.panelEdit.TabIndex = 46;
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(25, 20);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(112, 38);
            this.editBtn.TabIndex = 38;
            this.editBtn.Text = "РЕДАКТИРОВАТЬ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(25, 187);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 38);
            this.cancelBtn.TabIndex = 40;
            this.cancelBtn.Text = "ЗАКРЫТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(25, 107);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 38);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "УДАЛИТЬ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // categoriesPage
            // 
            this.categoriesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.categoriesPage.Controls.Add(this.panel3);
            this.categoriesPage.Controls.Add(this.panel2);
            this.categoriesPage.Location = new System.Drawing.Point(4, 22);
            this.categoriesPage.Name = "categoriesPage";
            this.categoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesPage.Size = new System.Drawing.Size(795, 258);
            this.categoriesPage.TabIndex = 1;
            this.categoriesPage.Text = "Категории";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnShowCat);
            this.panel3.Location = new System.Drawing.Point(644, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 258);
            this.panel3.TabIndex = 2;
            // 
            // btnShowCat
            // 
            this.btnShowCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowCat.FlatAppearance.BorderSize = 0;
            this.btnShowCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowCat.Location = new System.Drawing.Point(0, 0);
            this.btnShowCat.Name = "btnShowCat";
            this.btnShowCat.Size = new System.Drawing.Size(151, 37);
            this.btnShowCat.TabIndex = 1;
            this.btnShowCat.Text = "Просмотреть";
            this.btnShowCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCat.UseVisualStyleBackColor = false;
            this.btnShowCat.Click += new System.EventHandler(this.btnShowCat_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboBoxShowCatRows);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.labelCatPagesCount);
            this.panel2.Controls.Add(this.numericCurrentCatPage);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnNextCat);
            this.panel2.Controls.Add(this.btnPrevCat);
            this.panel2.Controls.Add(this.dataCategories);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 255);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxShowCatRows
            // 
            this.comboBoxShowCatRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowCatRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowCatRows.FormattingEnabled = true;
            this.comboBoxShowCatRows.Location = new System.Drawing.Point(439, 229);
            this.comboBoxShowCatRows.Name = "comboBoxShowCatRows";
            this.comboBoxShowCatRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowCatRows.TabIndex = 20;
            this.comboBoxShowCatRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowCatRows_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.Location = new System.Drawing.Point(326, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Показывать по";
            // 
            // labelCatPagesCount
            // 
            this.labelCatPagesCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCatPagesCount.AutoSize = true;
            this.labelCatPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCatPagesCount.Location = new System.Drawing.Point(274, 230);
            this.labelCatPagesCount.Name = "labelCatPagesCount";
            this.labelCatPagesCount.Size = new System.Drawing.Size(36, 17);
            this.labelCatPagesCount.TabIndex = 16;
            this.labelCatPagesCount.Text = "из S";
            // 
            // numericCurrentCatPage
            // 
            this.numericCurrentCatPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentCatPage.Location = new System.Drawing.Point(223, 231);
            this.numericCurrentCatPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentCatPage.Name = "numericCurrentCatPage";
            this.numericCurrentCatPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentCatPage.TabIndex = 15;
            this.numericCurrentCatPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentCatPage.ValueChanged += new System.EventHandler(this.numericCurrentCatPage_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(145, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Страница";
            // 
            // btnNextCat
            // 
            this.btnNextCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextCat.FlatAppearance.BorderSize = 0;
            this.btnNextCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextCat.Location = new System.Drawing.Point(516, 218);
            this.btnNextCat.Name = "btnNextCat";
            this.btnNextCat.Size = new System.Drawing.Size(130, 40);
            this.btnNextCat.TabIndex = 6;
            this.btnNextCat.Text = "Следующая →";
            this.btnNextCat.UseVisualStyleBackColor = false;
            this.btnNextCat.Click += new System.EventHandler(this.btnNextCat_Click);
            // 
            // btnPrevCat
            // 
            this.btnPrevCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevCat.FlatAppearance.BorderSize = 0;
            this.btnPrevCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevCat.Location = new System.Drawing.Point(-3, 218);
            this.btnPrevCat.Name = "btnPrevCat";
            this.btnPrevCat.Size = new System.Drawing.Size(130, 40);
            this.btnPrevCat.TabIndex = 5;
            this.btnPrevCat.Text = "← Предыдущая";
            this.btnPrevCat.UseVisualStyleBackColor = false;
            this.btnPrevCat.Click += new System.EventHandler(this.btnPrevCat_Click);
            // 
            // dataCategories
            // 
            this.dataCategories.AllowUserToAddRows = false;
            this.dataCategories.AllowUserToDeleteRows = false;
            this.dataCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategories.Location = new System.Drawing.Point(0, 0);
            this.dataCategories.MultiSelect = false;
            this.dataCategories.Name = "dataCategories";
            this.dataCategories.ReadOnly = true;
            this.dataCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCategories.Size = new System.Drawing.Size(643, 218);
            this.dataCategories.TabIndex = 0;
            this.dataCategories.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataCategories_CellMouseDoubleClick);
            // 
            // timetablePage
            // 
            this.timetablePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.timetablePage.Location = new System.Drawing.Point(4, 22);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(795, 258);
            this.timetablePage.TabIndex = 2;
            this.timetablePage.Text = "Расписание";
            // 
            // ordersPage
            // 
            this.ordersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(795, 258);
            this.ordersPage.TabIndex = 3;
            this.ordersPage.Text = "Заказы";
            // 
            // visitsPage
            // 
            this.visitsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.visitsPage.Location = new System.Drawing.Point(4, 22);
            this.visitsPage.Name = "visitsPage";
            this.visitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.visitsPage.Size = new System.Drawing.Size(795, 258);
            this.visitsPage.TabIndex = 4;
            this.visitsPage.Text = "Выезды";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(117, 190);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(55, 13);
            this.labelPosition.TabIndex = 55;
            this.labelPosition.TabStop = true;
            this.labelPosition.Text = "linkLabel1";
            this.labelPosition.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelPosition_LinkClicked);
            // 
            // FormShowMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(803, 284);
            this.Controls.Add(this.masterTabs);
            this.MaximizeBox = false;
            this.Name = "FormShowMaster";
            this.Text = "Просмотр сотрудника (мастер)";
            this.Load += new System.EventHandler(this.FormShowMaster_Load);
            this.ResizeEnd += new System.EventHandler(this.FormShowMaster_ResizeEnd);
            this.masterTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.categoriesPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentCatPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbAdditionInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TabControl masterTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage categoriesPage;
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.LinkLabel labelWorkshop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage visitsPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCatPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentCatPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNextCat;
        private System.Windows.Forms.Button btnPrevCat;
        private System.Windows.Forms.DataGridView dataCategories;
        private System.Windows.Forms.Panel panel3;
        private ManageButton btnShowCat;
        private System.Windows.Forms.ComboBox comboBoxShowCatRows;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.LinkLabel labelPosition;
    }
}
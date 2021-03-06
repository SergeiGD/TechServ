
using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.employees
{
    partial class FormManageMaster
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
            this.masterTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.tbPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindWorkshop = new FontAwesome.Sharp.IconButton();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.btnFindPosition = new FontAwesome.Sharp.IconButton();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categoriesPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxShowCatRows = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCatPagesCount = new System.Windows.Forms.Label();
            this.numericCurrentCatPage = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNextCat = new System.Windows.Forms.Button();
            this.btnPrevCat = new System.Windows.Forms.Button();
            this.dataCategories = new System.Windows.Forms.DataGridView();
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.showCategoryBtn = new ManageButton();
            this.addCategoryBtn = new ManageButton();
            this.masterTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.categoriesPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentCatPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // masterTabs
            // 
            this.masterTabs.Controls.Add(this.generalPage);
            this.masterTabs.Controls.Add(this.categoriesPage);
            this.masterTabs.Controls.Add(this.timetablePage);
            this.masterTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTabs.Location = new System.Drawing.Point(0, 0);
            this.masterTabs.Name = "masterTabs";
            this.masterTabs.SelectedIndex = 0;
            this.masterTabs.Size = new System.Drawing.Size(760, 286);
            this.masterTabs.TabIndex = 47;
            this.masterTabs.SelectedIndexChanged += new System.EventHandler(this.masterTab_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.tbPhoneNum);
            this.generalPage.Controls.Add(this.tbPassword);
            this.generalPage.Controls.Add(this.label11);
            this.generalPage.Controls.Add(this.btnAction);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.btnFindWorkshop);
            this.generalPage.Controls.Add(this.tbWorkshop);
            this.generalPage.Controls.Add(this.btnFindPosition);
            this.generalPage.Controls.Add(this.tbPosition);
            this.generalPage.Controls.Add(this.numericSalary);
            this.generalPage.Controls.Add(this.tbName);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.tbInfo);
            this.generalPage.Controls.Add(this.label5);
            this.generalPage.Controls.Add(this.label6);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(752, 260);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(123, 64);
            this.tbPhoneNum.Mask = "(+70)000000000";
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(113, 20);
            this.tbPhoneNum.TabIndex = 174;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(123, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(113, 20);
            this.tbPassword.TabIndex = 173;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 172;
            this.label11.Text = "Пароль";
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(569, 23);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 40);
            this.btnAction.TabIndex = 170;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(569, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 171;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindWorkshop
            // 
            this.btnFindWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFindWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindWorkshop.IconSize = 17;
            this.btnFindWorkshop.Location = new System.Drawing.Point(242, 221);
            this.btnFindWorkshop.Name = "btnFindWorkshop";
            this.btnFindWorkshop.Size = new System.Drawing.Size(18, 23);
            this.btnFindWorkshop.TabIndex = 169;
            this.btnFindWorkshop.UseVisualStyleBackColor = true;
            this.btnFindWorkshop.Click += new System.EventHandler(this.btnFindWorkshop_Click);
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(123, 223);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(113, 20);
            this.tbWorkshop.TabIndex = 167;
            // 
            // btnFindPosition
            // 
            this.btnFindPosition.FlatAppearance.BorderSize = 0;
            this.btnFindPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPosition.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindPosition.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindPosition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindPosition.IconSize = 17;
            this.btnFindPosition.Location = new System.Drawing.Point(242, 175);
            this.btnFindPosition.Name = "btnFindPosition";
            this.btnFindPosition.Size = new System.Drawing.Size(18, 23);
            this.btnFindPosition.TabIndex = 166;
            this.btnFindPosition.UseVisualStyleBackColor = true;
            this.btnFindPosition.Click += new System.EventHandler(this.btnFindPosition_Click);
            // 
            // tbPosition
            // 
            this.tbPosition.Enabled = false;
            this.tbPosition.Location = new System.Drawing.Point(123, 177);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(113, 20);
            this.tbPosition.TabIndex = 164;
            // 
            // numericSalary
            // 
            this.numericSalary.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSalary.Location = new System.Drawing.Point(123, 137);
            this.numericSalary.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericSalary.Minimum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(113, 20);
            this.numericSalary.TabIndex = 163;
            this.numericSalary.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(123, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(113, 20);
            this.tbName.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 160;
            this.label4.Text = "Мастерская:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 154;
            this.label1.Text = "Имя мастера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 155;
            this.label2.Text = "Номер телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 156;
            this.label3.Text = "Доп. информация";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(313, 39);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(219, 176);
            this.tbInfo.TabIndex = 157;
            this.tbInfo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 158;
            this.label5.Text = "Зарплата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 159;
            this.label6.Text = "Должность:";
            // 
            // categoriesPage
            // 
            this.categoriesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.categoriesPage.Controls.Add(this.panel4);
            this.categoriesPage.Controls.Add(this.panel3);
            this.categoriesPage.Location = new System.Drawing.Point(4, 22);
            this.categoriesPage.Name = "categoriesPage";
            this.categoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesPage.Size = new System.Drawing.Size(752, 260);
            this.categoriesPage.TabIndex = 1;
            this.categoriesPage.Text = "Категории";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.panel4.Controls.Add(this.showCategoryBtn);
            this.panel4.Controls.Add(this.addCategoryBtn);
            this.panel4.Location = new System.Drawing.Point(608, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 260);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.comboBoxShowCatRows);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.labelCatPagesCount);
            this.panel3.Controls.Add(this.numericCurrentCatPage);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnNextCat);
            this.panel3.Controls.Add(this.btnPrevCat);
            this.panel3.Controls.Add(this.dataCategories);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 260);
            this.panel3.TabIndex = 2;
            // 
            // comboBoxShowCatRows
            // 
            this.comboBoxShowCatRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowCatRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowCatRows.FormattingEnabled = true;
            this.comboBoxShowCatRows.Location = new System.Drawing.Point(417, 231);
            this.comboBoxShowCatRows.Name = "comboBoxShowCatRows";
            this.comboBoxShowCatRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowCatRows.TabIndex = 18;
            this.comboBoxShowCatRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowCatRows_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(304, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Показывать по";
            // 
            // labelCatPagesCount
            // 
            this.labelCatPagesCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCatPagesCount.AutoSize = true;
            this.labelCatPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCatPagesCount.Location = new System.Drawing.Point(262, 231);
            this.labelCatPagesCount.Name = "labelCatPagesCount";
            this.labelCatPagesCount.Size = new System.Drawing.Size(36, 17);
            this.labelCatPagesCount.TabIndex = 16;
            this.labelCatPagesCount.Text = "из S";
            // 
            // numericCurrentCatPage
            // 
            this.numericCurrentCatPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentCatPage.Location = new System.Drawing.Point(211, 232);
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
            this.label13.Location = new System.Drawing.Point(133, 231);
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
            this.btnNextCat.Location = new System.Drawing.Point(478, 220);
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
            this.btnPrevCat.Location = new System.Drawing.Point(0, 220);
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
            this.dataCategories.Size = new System.Drawing.Size(608, 220);
            this.dataCategories.TabIndex = 0;
            this.dataCategories.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataCategories_CellMouseDoubleClick);
            // 
            // timetablePage
            // 
            this.timetablePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.timetablePage.Location = new System.Drawing.Point(4, 22);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(752, 260);
            this.timetablePage.TabIndex = 2;
            this.timetablePage.Text = "Расписание";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // showCategoryBtn
            // 
            this.showCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.showCategoryBtn.FlatAppearance.BorderSize = 0;
            this.showCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.showCategoryBtn.Location = new System.Drawing.Point(0, 40);
            this.showCategoryBtn.Name = "showCategoryBtn";
            this.showCategoryBtn.Size = new System.Drawing.Size(148, 40);
            this.showCategoryBtn.TabIndex = 3;
            this.showCategoryBtn.Text = "Просмотреть";
            this.showCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showCategoryBtn.UseVisualStyleBackColor = false;
            this.showCategoryBtn.Click += new System.EventHandler(this.showCategoryBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.addCategoryBtn.FlatAppearance.BorderSize = 0;
            this.addCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCategoryBtn.Location = new System.Drawing.Point(0, 0);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(148, 40);
            this.addCategoryBtn.TabIndex = 1;
            this.addCategoryBtn.Text = "Добавить";
            this.addCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // FormManageMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(760, 286);
            this.Controls.Add(this.masterTabs);
            this.MaximizeBox = false;
            this.Name = "FormManageMaster";
            this.Text = "Управление сотрудником (мастер)";
            this.Load += new System.EventHandler(this.FormManageMaster_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageMaster_ResizeEnd);
            this.masterTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.categoriesPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentCatPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl masterTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage categoriesPage;
        private System.Windows.Forms.Panel panel4;
        private ManageButton addCategoryBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCatPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentCatPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNextCat;
        private System.Windows.Forms.Button btnPrevCat;
        private System.Windows.Forms.DataGridView dataCategories;
        private ManageButton showCategoryBtn;
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private System.Windows.Forms.TextBox tbWorkshop;
        private FontAwesome.Sharp.IconButton btnFindPosition;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxShowCatRows;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tbPhoneNum;
    }
}

namespace Forms_TechServ
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
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categoriesPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.showCategoryBtn = new Forms_TechServ.ManageButton();
            this.deleteCategoryBtn = new Forms_TechServ.ManageButton();
            this.addCategoryBtn = new Forms_TechServ.ManageButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTbPagesCount = new System.Windows.Forms.Label();
            this.numericCurrentTbPage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataTimetable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cleanTimetableBtn = new Forms_TechServ.ManageButton();
            this.findTimetableBtn = new Forms_TechServ.ManageButton();
            this.deleteTimetableBtn = new Forms_TechServ.ManageButton();
            this.addTimetableBtn = new Forms_TechServ.ManageButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.masterTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.categoriesPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentCatPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategories)).BeginInit();
            this.timetablePage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentTbPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.generalPage.Controls.Add(this.tbPhoneNum);
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
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(123, 64);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(113, 20);
            this.tbPhoneNum.TabIndex = 161;
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
            this.panel4.Controls.Add(this.deleteCategoryBtn);
            this.panel4.Controls.Add(this.addCategoryBtn);
            this.panel4.Location = new System.Drawing.Point(608, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 260);
            this.panel4.TabIndex = 4;
            // 
            // showCategoryBtn
            // 
            this.showCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.showCategoryBtn.FlatAppearance.BorderSize = 0;
            this.showCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.showCategoryBtn.Location = new System.Drawing.Point(0, 80);
            this.showCategoryBtn.Name = "showCategoryBtn";
            this.showCategoryBtn.Size = new System.Drawing.Size(148, 40);
            this.showCategoryBtn.TabIndex = 3;
            this.showCategoryBtn.Text = "Просмотреть";
            this.showCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showCategoryBtn.UseVisualStyleBackColor = false;
            this.showCategoryBtn.Click += new System.EventHandler(this.showCategoryBtn_Click);
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.deleteCategoryBtn.FlatAppearance.BorderSize = 0;
            this.deleteCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteCategoryBtn.Location = new System.Drawing.Point(0, 40);
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.Size = new System.Drawing.Size(148, 40);
            this.deleteCategoryBtn.TabIndex = 2;
            this.deleteCategoryBtn.Text = "Удалить";
            this.deleteCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCategoryBtn.UseVisualStyleBackColor = false;
            this.deleteCategoryBtn.Click += new System.EventHandler(this.deleteCategoryBtn_Click);
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
            // 
            // timetablePage
            // 
            this.timetablePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.timetablePage.Controls.Add(this.panel1);
            this.timetablePage.Controls.Add(this.panel2);
            this.timetablePage.Location = new System.Drawing.Point(4, 22);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(752, 260);
            this.timetablePage.TabIndex = 2;
            this.timetablePage.Text = "Расписание";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.datePickerUntil);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.datePickerFrom);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelTbPagesCount);
            this.panel1.Controls.Add(this.numericCurrentTbPage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.dataTimetable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 260);
            this.panel1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(417, 235);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(304, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Показывать по";
            // 
            // datePickerUntil
            // 
            this.datePickerUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerUntil.Location = new System.Drawing.Point(446, 8);
            this.datePickerUntil.Name = "datePickerUntil";
            this.datePickerUntil.Size = new System.Drawing.Size(130, 20);
            this.datePickerUntil.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "дата до:";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(75, 8);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(130, 20);
            this.datePickerFrom.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "дата от:";
            // 
            // labelTbPagesCount
            // 
            this.labelTbPagesCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTbPagesCount.AutoSize = true;
            this.labelTbPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTbPagesCount.Location = new System.Drawing.Point(262, 235);
            this.labelTbPagesCount.Name = "labelTbPagesCount";
            this.labelTbPagesCount.Size = new System.Drawing.Size(36, 17);
            this.labelTbPagesCount.TabIndex = 16;
            this.labelTbPagesCount.Text = "из S";
            // 
            // numericCurrentTbPage
            // 
            this.numericCurrentTbPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentTbPage.Location = new System.Drawing.Point(211, 236);
            this.numericCurrentTbPage.Name = "numericCurrentTbPage";
            this.numericCurrentTbPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentTbPage.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(133, 235);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 14;
            this.label28.Text = "Страница";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(481, 223);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 40);
            this.btnNext.TabIndex = 6;
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
            this.btnPrev.Location = new System.Drawing.Point(-3, 223);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 40);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "← Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // dataTimetable
            // 
            this.dataTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataTimetable.Location = new System.Drawing.Point(0, 34);
            this.dataTimetable.Name = "dataTimetable";
            this.dataTimetable.Size = new System.Drawing.Size(608, 189);
            this.dataTimetable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "День недели";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Начало смены";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Конец смены";
            this.Column4.Name = "Column4";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.cleanTimetableBtn);
            this.panel2.Controls.Add(this.findTimetableBtn);
            this.panel2.Controls.Add(this.deleteTimetableBtn);
            this.panel2.Controls.Add(this.addTimetableBtn);
            this.panel2.Location = new System.Drawing.Point(608, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 260);
            this.panel2.TabIndex = 4;
            // 
            // cleanTimetableBtn
            // 
            this.cleanTimetableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanTimetableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.cleanTimetableBtn.FlatAppearance.BorderSize = 0;
            this.cleanTimetableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanTimetableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cleanTimetableBtn.Location = new System.Drawing.Point(0, 40);
            this.cleanTimetableBtn.Name = "cleanTimetableBtn";
            this.cleanTimetableBtn.Size = new System.Drawing.Size(142, 40);
            this.cleanTimetableBtn.TabIndex = 5;
            this.cleanTimetableBtn.Text = "Отчистить фильры";
            this.cleanTimetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cleanTimetableBtn.UseVisualStyleBackColor = false;
            // 
            // findTimetableBtn
            // 
            this.findTimetableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findTimetableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.findTimetableBtn.FlatAppearance.BorderSize = 0;
            this.findTimetableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findTimetableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.findTimetableBtn.Location = new System.Drawing.Point(0, 0);
            this.findTimetableBtn.Name = "findTimetableBtn";
            this.findTimetableBtn.Size = new System.Drawing.Size(142, 40);
            this.findTimetableBtn.TabIndex = 4;
            this.findTimetableBtn.Text = "Найти";
            this.findTimetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findTimetableBtn.UseVisualStyleBackColor = false;
            // 
            // deleteTimetableBtn
            // 
            this.deleteTimetableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTimetableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.deleteTimetableBtn.FlatAppearance.BorderSize = 0;
            this.deleteTimetableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTimetableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteTimetableBtn.Location = new System.Drawing.Point(0, 120);
            this.deleteTimetableBtn.Name = "deleteTimetableBtn";
            this.deleteTimetableBtn.Size = new System.Drawing.Size(142, 40);
            this.deleteTimetableBtn.TabIndex = 2;
            this.deleteTimetableBtn.Text = "Удалить";
            this.deleteTimetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTimetableBtn.UseVisualStyleBackColor = false;
            this.deleteTimetableBtn.Click += new System.EventHandler(this.deleteTimetableBtn_Click);
            // 
            // addTimetableBtn
            // 
            this.addTimetableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTimetableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.addTimetableBtn.FlatAppearance.BorderSize = 0;
            this.addTimetableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTimetableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addTimetableBtn.Location = new System.Drawing.Point(0, 80);
            this.addTimetableBtn.Name = "addTimetableBtn";
            this.addTimetableBtn.Size = new System.Drawing.Size(142, 40);
            this.addTimetableBtn.TabIndex = 1;
            this.addTimetableBtn.Text = "Сформировать";
            this.addTimetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTimetableBtn.UseVisualStyleBackColor = false;
            this.addTimetableBtn.Click += new System.EventHandler(this.addTimetableBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
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
            this.Text = "FormManageMaster";
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
            this.timetablePage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentTbPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl masterTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage categoriesPage;
        private System.Windows.Forms.Panel panel4;
        private ManageButton deleteCategoryBtn;
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
        private System.Windows.Forms.Panel panel2;
        private ManageButton deleteTimetableBtn;
        private ManageButton addTimetableBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datePickerUntil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTbPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentTbPage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private ManageButton findTimetableBtn;
        private ManageButton cleanTimetableBtn;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private System.Windows.Forms.TextBox tbWorkshop;
        private FontAwesome.Sharp.IconButton btnFindPosition;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxShowCatRows;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label11;
    }
}

namespace Forms_TechServ
{
    partial class FormManageManager
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
            this.managerTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
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
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCleanTimetable = new Forms_TechServ.ManageButton();
            this.btnFindTimetable = new Forms_TechServ.ManageButton();
            this.btnDeleteTimetable = new Forms_TechServ.ManageButton();
            this.btnAddTimetable = new Forms_TechServ.ManageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowTimetableRows = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPagesCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNextTb = new System.Windows.Forms.Button();
            this.btnPrevTb = new System.Windows.Forms.Button();
            this.dataTimetable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.managerTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.timetablePage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // managerTabs
            // 
            this.managerTabs.Controls.Add(this.generalPage);
            this.managerTabs.Controls.Add(this.timetablePage);
            this.managerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerTabs.Location = new System.Drawing.Point(0, 0);
            this.managerTabs.Name = "managerTabs";
            this.managerTabs.SelectedIndex = 0;
            this.managerTabs.Size = new System.Drawing.Size(760, 283);
            this.managerTabs.TabIndex = 48;
            this.managerTabs.SelectedIndexChanged += new System.EventHandler(this.managerTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.tbPassword);
            this.generalPage.Controls.Add(this.label9);
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
            this.generalPage.Size = new System.Drawing.Size(752, 257);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(602, 23);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 40);
            this.btnAction.TabIndex = 152;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(602, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 153;
            this.btnCancel.Text = "ОТМЕНИТЬ";
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
            this.btnFindWorkshop.Location = new System.Drawing.Point(240, 219);
            this.btnFindWorkshop.Name = "btnFindWorkshop";
            this.btnFindWorkshop.Size = new System.Drawing.Size(18, 23);
            this.btnFindWorkshop.TabIndex = 151;
            this.btnFindWorkshop.UseVisualStyleBackColor = true;
            this.btnFindWorkshop.Click += new System.EventHandler(this.btnFindWorkshop_Click);
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(121, 221);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(113, 20);
            this.tbWorkshop.TabIndex = 149;
            // 
            // btnFindPosition
            // 
            this.btnFindPosition.FlatAppearance.BorderSize = 0;
            this.btnFindPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPosition.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindPosition.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindPosition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindPosition.IconSize = 17;
            this.btnFindPosition.Location = new System.Drawing.Point(240, 173);
            this.btnFindPosition.Name = "btnFindPosition";
            this.btnFindPosition.Size = new System.Drawing.Size(18, 23);
            this.btnFindPosition.TabIndex = 148;
            this.btnFindPosition.UseVisualStyleBackColor = true;
            this.btnFindPosition.Click += new System.EventHandler(this.btnFindPosition_Click);
            // 
            // tbPosition
            // 
            this.tbPosition.Enabled = false;
            this.tbPosition.Location = new System.Drawing.Point(121, 175);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(113, 20);
            this.tbPosition.TabIndex = 146;
            // 
            // numericSalary
            // 
            this.numericSalary.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSalary.Location = new System.Drawing.Point(121, 135);
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
            this.numericSalary.TabIndex = 51;
            this.numericSalary.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(121, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(113, 20);
            this.tbName.TabIndex = 50;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(121, 64);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(113, 20);
            this.tbPhoneNum.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Мастерская:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя мастера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Номер телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Доп. информация";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(311, 39);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(219, 176);
            this.tbInfo.TabIndex = 30;
            this.tbInfo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Зарплата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Должность:";
            // 
            // timetablePage
            // 
            this.timetablePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.timetablePage.Controls.Add(this.panel2);
            this.timetablePage.Controls.Add(this.panel1);
            this.timetablePage.Location = new System.Drawing.Point(4, 22);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(752, 238);
            this.timetablePage.TabIndex = 2;
            this.timetablePage.Text = "Расписание";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.btnCleanTimetable);
            this.panel2.Controls.Add(this.btnFindTimetable);
            this.panel2.Controls.Add(this.btnDeleteTimetable);
            this.panel2.Controls.Add(this.btnAddTimetable);
            this.panel2.Location = new System.Drawing.Point(608, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 234);
            this.panel2.TabIndex = 3;
            // 
            // btnCleanTimetable
            // 
            this.btnCleanTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnCleanTimetable.FlatAppearance.BorderSize = 0;
            this.btnCleanTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCleanTimetable.Location = new System.Drawing.Point(0, 40);
            this.btnCleanTimetable.Name = "btnCleanTimetable";
            this.btnCleanTimetable.Size = new System.Drawing.Size(142, 40);
            this.btnCleanTimetable.TabIndex = 4;
            this.btnCleanTimetable.Text = "Отчистить фильры";
            this.btnCleanTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCleanTimetable.UseVisualStyleBackColor = false;
            // 
            // btnFindTimetable
            // 
            this.btnFindTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnFindTimetable.FlatAppearance.BorderSize = 0;
            this.btnFindTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFindTimetable.Location = new System.Drawing.Point(0, 0);
            this.btnFindTimetable.Name = "btnFindTimetable";
            this.btnFindTimetable.Size = new System.Drawing.Size(142, 40);
            this.btnFindTimetable.TabIndex = 3;
            this.btnFindTimetable.Text = "Найти";
            this.btnFindTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindTimetable.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTimetable
            // 
            this.btnDeleteTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDeleteTimetable.FlatAppearance.BorderSize = 0;
            this.btnDeleteTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteTimetable.Location = new System.Drawing.Point(0, 120);
            this.btnDeleteTimetable.Name = "btnDeleteTimetable";
            this.btnDeleteTimetable.Size = new System.Drawing.Size(142, 40);
            this.btnDeleteTimetable.TabIndex = 2;
            this.btnDeleteTimetable.Text = "Удалить";
            this.btnDeleteTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTimetable.UseVisualStyleBackColor = false;
            // 
            // btnAddTimetable
            // 
            this.btnAddTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAddTimetable.FlatAppearance.BorderSize = 0;
            this.btnAddTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddTimetable.Location = new System.Drawing.Point(0, 80);
            this.btnAddTimetable.Name = "btnAddTimetable";
            this.btnAddTimetable.Size = new System.Drawing.Size(142, 40);
            this.btnAddTimetable.TabIndex = 1;
            this.btnAddTimetable.Text = "Сформировать";
            this.btnAddTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTimetable.UseVisualStyleBackColor = false;
            this.btnAddTimetable.Click += new System.EventHandler(this.addTimetableBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxShowTimetableRows);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.datePickerUntil);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.datePickerFrom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelPagesCount);
            this.panel1.Controls.Add(this.numericCurrentPage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNextTb);
            this.panel1.Controls.Add(this.btnPrevTb);
            this.panel1.Controls.Add(this.dataTimetable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 234);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxShowTimetableRows
            // 
            this.comboBoxShowTimetableRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowTimetableRows.FormattingEnabled = true;
            this.comboBoxShowTimetableRows.Location = new System.Drawing.Point(422, 209);
            this.comboBoxShowTimetableRows.Name = "comboBoxShowTimetableRows";
            this.comboBoxShowTimetableRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowTimetableRows.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(309, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Показывать по";
            // 
            // datePickerUntil
            // 
            this.datePickerUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerUntil.Location = new System.Drawing.Point(446, 8);
            this.datePickerUntil.Name = "datePickerUntil";
            this.datePickerUntil.Size = new System.Drawing.Size(130, 20);
            this.datePickerUntil.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "дата до:";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(75, 8);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(130, 20);
            this.datePickerFrom.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "дата от:";
            // 
            // labelPagesCount
            // 
            this.labelPagesCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPagesCount.AutoSize = true;
            this.labelPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPagesCount.Location = new System.Drawing.Point(262, 209);
            this.labelPagesCount.Name = "labelPagesCount";
            this.labelPagesCount.Size = new System.Drawing.Size(36, 17);
            this.labelPagesCount.TabIndex = 16;
            this.labelPagesCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(211, 210);
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(133, 209);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 14;
            this.label28.Text = "Страница";
            // 
            // btnNextTb
            // 
            this.btnNextTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextTb.FlatAppearance.BorderSize = 0;
            this.btnNextTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextTb.Location = new System.Drawing.Point(481, 197);
            this.btnNextTb.Name = "btnNextTb";
            this.btnNextTb.Size = new System.Drawing.Size(130, 40);
            this.btnNextTb.TabIndex = 6;
            this.btnNextTb.Text = "Следующая →";
            this.btnNextTb.UseVisualStyleBackColor = false;
            // 
            // btnPrevTb
            // 
            this.btnPrevTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevTb.FlatAppearance.BorderSize = 0;
            this.btnPrevTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevTb.Location = new System.Drawing.Point(-3, 197);
            this.btnPrevTb.Name = "btnPrevTb";
            this.btnPrevTb.Size = new System.Drawing.Size(130, 40);
            this.btnPrevTb.TabIndex = 5;
            this.btnPrevTb.Text = "← Предыдущая";
            this.btnPrevTb.UseVisualStyleBackColor = false;
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
            this.dataTimetable.Size = new System.Drawing.Size(608, 163);
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(121, 100);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(113, 20);
            this.tbPassword.TabIndex = 155;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 154;
            this.label9.Text = "Пароль:";
            // 
            // FormManageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(760, 283);
            this.Controls.Add(this.managerTabs);
            this.Name = "FormManageManager";
            this.Text = "FormManageManager";
            this.Load += new System.EventHandler(this.FormManageManager_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageManager_ResizeEnd);
            this.managerTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.timetablePage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl managerTabs;
        private System.Windows.Forms.TabPage generalPage;
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
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.Panel panel2;
        private ManageButton btnDeleteTimetable;
        private ManageButton btnAddTimetable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNextTb;
        private System.Windows.Forms.Button btnPrevTb;
        private System.Windows.Forms.DataGridView dataTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker datePickerUntil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label7;
        private ManageButton btnCleanTimetable;
        private ManageButton btnFindTimetable;
        private System.Windows.Forms.ComboBox comboBoxShowTimetableRows;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label9;
    }
}
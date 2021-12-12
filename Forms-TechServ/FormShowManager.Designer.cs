
namespace Forms_TechServ
{
    partial class FormShowManager
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
            this.managerTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelWorkshop = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.tbAdditionInfo = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cleanTimetableBtn = new Forms_TechServ.ManageButton();
            this.findTimetableBtn = new Forms_TechServ.ManageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowTimetableRows = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.datePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelPagesCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataTimetable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.managerTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.timetablePage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // managerTabs
            // 
            this.managerTabs.Controls.Add(this.generalPage);
            this.managerTabs.Controls.Add(this.timetablePage);
            this.managerTabs.Controls.Add(this.ordersPage);
            this.managerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerTabs.Location = new System.Drawing.Point(0, 0);
            this.managerTabs.Name = "managerTabs";
            this.managerTabs.SelectedIndex = 0;
            this.managerTabs.Size = new System.Drawing.Size(803, 291);
            this.managerTabs.TabIndex = 47;
            this.managerTabs.SelectedIndexChanged += new System.EventHandler(this.managerTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelPassword);
            this.generalPage.Controls.Add(this.label9);
            this.generalPage.Controls.Add(this.labelPosition);
            this.generalPage.Controls.Add(this.labelWorkshop);
            this.generalPage.Controls.Add(this.label13);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.labelID);
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
            this.generalPage.Size = new System.Drawing.Size(795, 265);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(117, 135);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 13);
            this.labelPassword.TabIndex = 56;
            this.labelPassword.Text = "labelPassword";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Пароль:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(117, 202);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(66, 13);
            this.labelPosition.TabIndex = 54;
            this.labelPosition.Text = "labelPosition";
            // 
            // labelWorkshop
            // 
            this.labelWorkshop.AutoSize = true;
            this.labelWorkshop.Location = new System.Drawing.Point(117, 233);
            this.labelWorkshop.Name = "labelWorkshop";
            this.labelWorkshop.Size = new System.Drawing.Size(78, 13);
            this.labelWorkshop.TabIndex = 53;
            this.labelWorkshop.TabStop = true;
            this.labelWorkshop.Text = "labelWorkshop";
            this.labelWorkshop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedWorkshop_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Мастерская:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "ID менеджера:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(114, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(40, 13);
            this.labelID.TabIndex = 51;
            this.labelID.Text = "labelID";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Controls.Add(this.deleteBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(632, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(160, 259);
            this.panelEdit.TabIndex = 46;
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(25, 19);
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
            this.cancelBtn.Location = new System.Drawing.Point(25, 173);
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
            this.deleteBtn.Location = new System.Drawing.Point(25, 98);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 38);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "УДАЛИТЬ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Номер телефона:";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(117, 164);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(58, 13);
            this.labelSalary.TabIndex = 44;
            this.labelSalary.Text = "labelSalary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Доп. информация";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Location = new System.Drawing.Point(117, 102);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(82, 13);
            this.labelPhoneNum.TabIndex = 43;
            this.labelPhoneNum.Text = "labelPhoneNum";
            // 
            // tbAdditionInfo
            // 
            this.tbAdditionInfo.Enabled = false;
            this.tbAdditionInfo.Location = new System.Drawing.Point(261, 51);
            this.tbAdditionInfo.Name = "tbAdditionInfo";
            this.tbAdditionInfo.ReadOnly = true;
            this.tbAdditionInfo.Size = new System.Drawing.Size(228, 163);
            this.tbAdditionInfo.TabIndex = 30;
            this.tbAdditionInfo.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(114, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 42;
            this.labelName.Text = "labelName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Зарплата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 202);
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
            this.timetablePage.Size = new System.Drawing.Size(795, 265);
            this.timetablePage.TabIndex = 2;
            this.timetablePage.Text = "Расписание";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.cleanTimetableBtn);
            this.panel2.Controls.Add(this.findTimetableBtn);
            this.panel2.Location = new System.Drawing.Point(623, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 234);
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
            this.cleanTimetableBtn.Size = new System.Drawing.Size(170, 40);
            this.cleanTimetableBtn.TabIndex = 2;
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
            this.findTimetableBtn.Size = new System.Drawing.Size(170, 40);
            this.findTimetableBtn.TabIndex = 1;
            this.findTimetableBtn.Text = "Найти";
            this.findTimetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findTimetableBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxShowTimetableRows);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.datePickerUntil);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.datePickerFrom);
            this.panel1.Controls.Add(this.labelPagesCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericCurrentPage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.dataTimetable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 234);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxShowTimetableRows
            // 
            this.comboBoxShowTimetableRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowTimetableRows.FormattingEnabled = true;
            this.comboBoxShowTimetableRows.Location = new System.Drawing.Point(417, 208);
            this.comboBoxShowTimetableRows.Name = "comboBoxShowTimetableRows";
            this.comboBoxShowTimetableRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowTimetableRows.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label18.Location = new System.Drawing.Point(304, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Показывать по";
            // 
            // datePickerUntil
            // 
            this.datePickerUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerUntil.Location = new System.Drawing.Point(464, 8);
            this.datePickerUntil.Name = "datePickerUntil";
            this.datePickerUntil.Size = new System.Drawing.Size(130, 20);
            this.datePickerUntil.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "дата до:";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(75, 8);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(130, 20);
            this.datePickerFrom.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "дата от:";
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
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(493, 197);
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
            this.btnPrev.Location = new System.Drawing.Point(-3, 197);
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
            this.dataTimetable.Size = new System.Drawing.Size(620, 163);
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
            // ordersPage
            // 
            this.ordersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(795, 265);
            this.ordersPage.TabIndex = 3;
            this.ordersPage.Text = "Заказы";
            // 
            // FormShowManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(803, 291);
            this.Controls.Add(this.managerTabs);
            this.Name = "FormShowManager";
            this.Text = "FormShowManager";
            this.Load += new System.EventHandler(this.FormShowManager_Load);
            this.ResizeEnd += new System.EventHandler(this.FormShowManager_ResizeEnd);
            this.managerTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.timetablePage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl managerTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.RichTextBox tbAdditionInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataTimetable;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickerUntil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private ManageButton cleanTimetableBtn;
        private ManageButton findTimetableBtn;
        private System.Windows.Forms.LinkLabel labelWorkshop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxShowTimetableRows;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label9;
    }
}

namespace Forms_TechServ.forms.employees
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
            this.labelRemotely = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.managerTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.panelEdit.SuspendLayout();
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
            this.managerTabs.Size = new System.Drawing.Size(803, 318);
            this.managerTabs.TabIndex = 47;
            this.managerTabs.SelectedIndexChanged += new System.EventHandler(this.managerTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelRemotely);
            this.generalPage.Controls.Add(this.label8);
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
            this.generalPage.Size = new System.Drawing.Size(795, 292);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelRemotely
            // 
            this.labelRemotely.AutoSize = true;
            this.labelRemotely.Location = new System.Drawing.Point(120, 262);
            this.labelRemotely.Name = "labelRemotely";
            this.labelRemotely.Size = new System.Drawing.Size(35, 13);
            this.labelRemotely.TabIndex = 58;
            this.labelRemotely.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Работа удаленно:";
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
            this.panelEdit.Size = new System.Drawing.Size(160, 286);
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
            this.timetablePage.Location = new System.Drawing.Point(4, 22);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(795, 292);
            this.timetablePage.TabIndex = 2;
            this.timetablePage.Text = "Расписание";
            // 
            // ordersPage
            // 
            this.ordersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(795, 292);
            this.ordersPage.TabIndex = 3;
            this.ordersPage.Text = "Заказы";
            // 
            // FormShowManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(803, 318);
            this.Controls.Add(this.managerTabs);
            this.Name = "FormShowManager";
            this.Text = "Просмотр сотрудника (менеджер)";
            this.Load += new System.EventHandler(this.FormShowManager_Load);
            this.ResizeEnd += new System.EventHandler(this.FormShowManager_ResizeEnd);
            this.managerTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.panelEdit.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.LinkLabel labelWorkshop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelRemotely;
        private System.Windows.Forms.Label label8;
    }
}
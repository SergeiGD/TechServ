
namespace Forms_TechServ
{
    partial class FormShowWorkshop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workshopTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.labelTimeClose = new System.Windows.Forms.Label();
            this.labelTimeOpen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowTimetableRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTimetablePageCount = new System.Windows.Forms.Label();
            this.numericCurrentTImetablePage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNextTimetable = new System.Windows.Forms.Button();
            this.btnPrevTimetable = new System.Windows.Forms.Button();
            this.dataTimetable = new System.Windows.Forms.DataGridView();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.batchesPage = new System.Windows.Forms.TabPage();
            this.sparePartsPage = new System.Windows.Forms.TabPage();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.workshopTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.timetablePage.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentTImetablePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес мастерской:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер телефона:";
            // 
            // workshopTabs
            // 
            this.workshopTabs.Controls.Add(this.generalPage);
            this.workshopTabs.Controls.Add(this.timetablePage);
            this.workshopTabs.Controls.Add(this.employeesPage);
            this.workshopTabs.Controls.Add(this.batchesPage);
            this.workshopTabs.Controls.Add(this.sparePartsPage);
            this.workshopTabs.Controls.Add(this.ordersPage);
            this.workshopTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workshopTabs.Location = new System.Drawing.Point(0, 0);
            this.workshopTabs.Name = "workshopTabs";
            this.workshopTabs.SelectedIndex = 0;
            this.workshopTabs.Size = new System.Drawing.Size(680, 358);
            this.workshopTabs.TabIndex = 8;
            this.workshopTabs.SelectedIndexChanged += new System.EventHandler(this.workshopTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelID);
            this.generalPage.Controls.Add(this.label10);
            this.generalPage.Controls.Add(this.labelPhoneNum);
            this.generalPage.Controls.Add(this.labelAddress);
            this.generalPage.Controls.Add(this.panelEdit);
            this.generalPage.Controls.Add(this.labelTimeClose);
            this.generalPage.Controls.Add(this.labelTimeOpen);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(672, 332);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelID.Location = new System.Drawing.Point(157, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 17);
            this.labelID.TabIndex = 46;
            this.labelID.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(18, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "ID мастерской:";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPhoneNum.Location = new System.Drawing.Point(157, 106);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(46, 17);
            this.labelPhoneNum.TabIndex = 44;
            this.labelPhoneNum.Text = "label7";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelAddress.Location = new System.Drawing.Point(157, 60);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(46, 17);
            this.labelAddress.TabIndex = 43;
            this.labelAddress.Text = "label8";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Controls.Add(this.deleteBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(468, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(201, 326);
            this.panelEdit.TabIndex = 42;
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(49, 8);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(119, 40);
            this.editBtn.TabIndex = 38;
            this.editBtn.Text = "РЕДАКТИРОВАТЬ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(49, 149);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 40);
            this.cancelBtn.TabIndex = 40;
            this.cancelBtn.Text = "ЗАКРЫТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(49, 77);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 40);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "УДАЛИТЬ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // labelTimeClose
            // 
            this.labelTimeClose.AutoSize = true;
            this.labelTimeClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTimeClose.Location = new System.Drawing.Point(154, 201);
            this.labelTimeClose.Name = "labelTimeClose";
            this.labelTimeClose.Size = new System.Drawing.Size(46, 17);
            this.labelTimeClose.TabIndex = 11;
            this.labelTimeClose.Text = "label6";
            // 
            // labelTimeOpen
            // 
            this.labelTimeOpen.AutoSize = true;
            this.labelTimeOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTimeOpen.Location = new System.Drawing.Point(154, 155);
            this.labelTimeOpen.Name = "labelTimeOpen";
            this.labelTimeOpen.Size = new System.Drawing.Size(46, 17);
            this.labelTimeOpen.TabIndex = 10;
            this.labelTimeOpen.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время закрытия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(17, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время открытия:";
            // 
            // timetablePage
            // 
            this.timetablePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.timetablePage.Controls.Add(this.panelContent);
            this.timetablePage.Location = new System.Drawing.Point(4, 22);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(614, 332);
            this.timetablePage.TabIndex = 1;
            this.timetablePage.Text = "Расписание";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.comboBoxShowTimetableRows);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.labelTimetablePageCount);
            this.panelContent.Controls.Add(this.numericCurrentTImetablePage);
            this.panelContent.Controls.Add(this.label28);
            this.panelContent.Controls.Add(this.btnNextTimetable);
            this.panelContent.Controls.Add(this.btnPrevTimetable);
            this.panelContent.Controls.Add(this.dataTimetable);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(3, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(608, 326);
            this.panelContent.TabIndex = 0;
            // 
            // comboBoxShowTimetableRows
            // 
            this.comboBoxShowTimetableRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowTimetableRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowTimetableRows.FormattingEnabled = true;
            this.comboBoxShowTimetableRows.Location = new System.Drawing.Point(418, 297);
            this.comboBoxShowTimetableRows.Name = "comboBoxShowTimetableRows";
            this.comboBoxShowTimetableRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowTimetableRows.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(305, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Показывать по";
            // 
            // labelTimetablePageCount
            // 
            this.labelTimetablePageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTimetablePageCount.AutoSize = true;
            this.labelTimetablePageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTimetablePageCount.Location = new System.Drawing.Point(263, 298);
            this.labelTimetablePageCount.Name = "labelTimetablePageCount";
            this.labelTimetablePageCount.Size = new System.Drawing.Size(36, 17);
            this.labelTimetablePageCount.TabIndex = 13;
            this.labelTimetablePageCount.Text = "из S";
            // 
            // numericCurrentTImetablePage
            // 
            this.numericCurrentTImetablePage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentTImetablePage.Location = new System.Drawing.Point(212, 299);
            this.numericCurrentTImetablePage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentTImetablePage.Name = "numericCurrentTImetablePage";
            this.numericCurrentTImetablePage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentTImetablePage.TabIndex = 12;
            this.numericCurrentTImetablePage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(134, 298);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 11;
            this.label28.Text = "Страница";
            // 
            // btnNextTimetable
            // 
            this.btnNextTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextTimetable.FlatAppearance.BorderSize = 0;
            this.btnNextTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextTimetable.Location = new System.Drawing.Point(478, 286);
            this.btnNextTimetable.Name = "btnNextTimetable";
            this.btnNextTimetable.Size = new System.Drawing.Size(130, 40);
            this.btnNextTimetable.TabIndex = 5;
            this.btnNextTimetable.Text = "Следующая →";
            this.btnNextTimetable.UseVisualStyleBackColor = false;
            // 
            // btnPrevTimetable
            // 
            this.btnPrevTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevTimetable.FlatAppearance.BorderSize = 0;
            this.btnPrevTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevTimetable.Location = new System.Drawing.Point(0, 286);
            this.btnPrevTimetable.Name = "btnPrevTimetable";
            this.btnPrevTimetable.Size = new System.Drawing.Size(130, 40);
            this.btnPrevTimetable.TabIndex = 4;
            this.btnPrevTimetable.Text = "← Предыдущая";
            this.btnPrevTimetable.UseVisualStyleBackColor = false;
            // 
            // dataTimetable
            // 
            this.dataTimetable.AllowUserToAddRows = false;
            this.dataTimetable.AllowUserToDeleteRows = false;
            this.dataTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimetable.Location = new System.Drawing.Point(0, 0);
            this.dataTimetable.MultiSelect = false;
            this.dataTimetable.Name = "dataTimetable";
            this.dataTimetable.ReadOnly = true;
            this.dataTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTimetable.Size = new System.Drawing.Size(608, 286);
            this.dataTimetable.TabIndex = 0;
            // 
            // employeesPage
            // 
            this.employeesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.employeesPage.Location = new System.Drawing.Point(4, 22);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesPage.Size = new System.Drawing.Size(614, 332);
            this.employeesPage.TabIndex = 2;
            this.employeesPage.Text = "Сотрудники";
            // 
            // batchesPage
            // 
            this.batchesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.batchesPage.Location = new System.Drawing.Point(4, 22);
            this.batchesPage.Name = "batchesPage";
            this.batchesPage.Padding = new System.Windows.Forms.Padding(3);
            this.batchesPage.Size = new System.Drawing.Size(614, 332);
            this.batchesPage.TabIndex = 3;
            this.batchesPage.Text = "Поставки";
            // 
            // sparePartsPage
            // 
            this.sparePartsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.sparePartsPage.Location = new System.Drawing.Point(4, 22);
            this.sparePartsPage.Name = "sparePartsPage";
            this.sparePartsPage.Padding = new System.Windows.Forms.Padding(3);
            this.sparePartsPage.Size = new System.Drawing.Size(614, 332);
            this.sparePartsPage.TabIndex = 4;
            this.sparePartsPage.Text = "Детали в наличии";
            // 
            // ordersPage
            // 
            this.ordersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(614, 332);
            this.ordersPage.TabIndex = 5;
            this.ordersPage.Text = "Заказы";
            // 
            // FormShowWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(680, 358);
            this.Controls.Add(this.workshopTabs);
            this.MaximizeBox = false;
            this.Name = "FormShowWorkshop";
            this.Text = "FormShowWorkshop";
            this.Load += new System.EventHandler(this.FormShowWorkshop_Load);
            this.ResizeEnd += new System.EventHandler(this.FormShowWorkshop_ResizeEnd);
            this.workshopTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.timetablePage.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentTImetablePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl workshopTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.Label labelTimeClose;
        private System.Windows.Forms.Label labelTimeOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.TabPage batchesPage;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ComboBox comboBoxShowTimetableRows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTimetablePageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentTImetablePage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNextTimetable;
        private System.Windows.Forms.Button btnPrevTimetable;
        private System.Windows.Forms.DataGridView dataTimetable;
        private System.Windows.Forms.TabPage sparePartsPage;
        private System.Windows.Forms.TabPage ordersPage;
    }
}
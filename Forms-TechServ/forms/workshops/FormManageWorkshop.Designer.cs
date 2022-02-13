
using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.workshops
{
    partial class FormManageWorkshop
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
            this.workshopTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTimetable = new ManageButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowTimetableRows = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimetablePageCount = new System.Windows.Forms.Label();
            this.numericCurrentTImetablePage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataTimetable = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.workshopTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.timetablePage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentTImetablePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // workshopTabs
            // 
            this.workshopTabs.Controls.Add(this.generalPage);
            this.workshopTabs.Controls.Add(this.timetablePage);
            this.workshopTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workshopTabs.Location = new System.Drawing.Point(0, 0);
            this.workshopTabs.Name = "workshopTabs";
            this.workshopTabs.SelectedIndex = 0;
            this.workshopTabs.Size = new System.Drawing.Size(792, 360);
            this.workshopTabs.TabIndex = 45;
            this.workshopTabs.SelectedIndexChanged += new System.EventHandler(this.workshopTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.btnAction);
            this.generalPage.Controls.Add(this.tbPhoneNum);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.tbAddress);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(784, 334);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(338, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 52);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(338, 6);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 52);
            this.btnAction.TabIndex = 19;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbPhoneNum.Location = new System.Drawing.Point(160, 74);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(148, 23);
            this.tbPhoneNum.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Адрес мастерской:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Номер телефона:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbAddress.Location = new System.Drawing.Point(160, 21);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(148, 23);
            this.tbAddress.TabIndex = 13;
            // 
            // timetablePage
            // 
            this.timetablePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.timetablePage.Controls.Add(this.panel1);
            this.timetablePage.Controls.Add(this.panelContent);
            this.timetablePage.Location = new System.Drawing.Point(4, 22);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(784, 334);
            this.timetablePage.TabIndex = 1;
            this.timetablePage.Text = "Расписание";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.btnAddTimetable);
            this.panel1.Location = new System.Drawing.Point(613, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 332);
            this.panel1.TabIndex = 2;
            // 
            // btnAddTimetable
            // 
            this.btnAddTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAddTimetable.FlatAppearance.BorderSize = 0;
            this.btnAddTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddTimetable.Location = new System.Drawing.Point(0, 0);
            this.btnAddTimetable.Name = "btnAddTimetable";
            this.btnAddTimetable.Size = new System.Drawing.Size(170, 40);
            this.btnAddTimetable.TabIndex = 1;
            this.btnAddTimetable.Text = "Добавить";
            this.btnAddTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTimetable.UseVisualStyleBackColor = false;
            this.btnAddTimetable.Click += new System.EventHandler(this.btnAddTimetable_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelContent.Controls.Add(this.comboBoxShowTimetableRows);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.labelTimetablePageCount);
            this.panelContent.Controls.Add(this.numericCurrentTImetablePage);
            this.panelContent.Controls.Add(this.label28);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataTimetable);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(613, 332);
            this.panelContent.TabIndex = 1;
            // 
            // comboBoxShowTimetableRows
            // 
            this.comboBoxShowTimetableRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowTimetableRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowTimetableRows.FormattingEnabled = true;
            this.comboBoxShowTimetableRows.Location = new System.Drawing.Point(420, 303);
            this.comboBoxShowTimetableRows.Name = "comboBoxShowTimetableRows";
            this.comboBoxShowTimetableRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowTimetableRows.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(307, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Показывать по";
            // 
            // labelTimetablePageCount
            // 
            this.labelTimetablePageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTimetablePageCount.AutoSize = true;
            this.labelTimetablePageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTimetablePageCount.Location = new System.Drawing.Point(265, 304);
            this.labelTimetablePageCount.Name = "labelTimetablePageCount";
            this.labelTimetablePageCount.Size = new System.Drawing.Size(36, 17);
            this.labelTimetablePageCount.TabIndex = 13;
            this.labelTimetablePageCount.Text = "из S";
            // 
            // numericCurrentTImetablePage
            // 
            this.numericCurrentTImetablePage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentTImetablePage.Location = new System.Drawing.Point(214, 305);
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
            this.label28.Location = new System.Drawing.Point(136, 304);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 11;
            this.label28.Text = "Страница";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(483, 292);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 40);
            this.btnNext.TabIndex = 5;
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
            this.btnPrev.Location = new System.Drawing.Point(0, 292);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 40);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "← Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = false;
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
            this.dataTimetable.Size = new System.Drawing.Size(613, 292);
            this.dataTimetable.TabIndex = 0;
            this.dataTimetable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTimetable_CellMouseDoubleClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormManageWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(792, 360);
            this.Controls.Add(this.workshopTabs);
            this.MaximizeBox = false;
            this.Name = "FormManageWorkshop";
            this.Text = "Управление филиалом";
            this.Load += new System.EventHandler(this.FormManageWorkshop_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageWorkshop_ResizeEnd);
            this.workshopTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.timetablePage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentTImetablePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl workshopTabs;
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelTimetablePageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentTImetablePage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataTimetable;
        private System.Windows.Forms.Panel panel1;
        private ManageButton btnAddTimetable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox comboBoxShowTimetableRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
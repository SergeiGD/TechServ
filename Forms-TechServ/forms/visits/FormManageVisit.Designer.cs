
using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.visits
{
    partial class FormManageVisit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.btnFindOrder = new FontAwesome.Sharp.IconButton();
            this.datePickerVisitDate = new System.Windows.Forms.DateTimePicker();
            this.checkDone = new System.Windows.Forms.CheckBox();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaster = new System.Windows.Forms.LinkLabel();
            this.visitTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.servicesPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddService = new ManageButton();
            this.btnDelService = new ManageButton();
            this.btnShowService = new ManageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowServicesRows = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.labelServicesPageCout = new System.Windows.Forms.Label();
            this.numericCurrentServicePage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNextService = new System.Windows.Forms.Button();
            this.btnPrevService = new System.Windows.Forms.Button();
            this.dataServies = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.visitTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.servicesPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(500, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(500, 40);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 40);
            this.btnAction.TabIndex = 17;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Заказ:";
            // 
            // tbOrder
            // 
            this.tbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbOrder.Enabled = false;
            this.tbOrder.Location = new System.Drawing.Point(77, 18);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.ReadOnly = true;
            this.tbOrder.Size = new System.Drawing.Size(104, 20);
            this.tbOrder.TabIndex = 117;
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.FlatAppearance.BorderSize = 0;
            this.btnFindOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindOrder.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindOrder.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindOrder.IconSize = 17;
            this.btnFindOrder.Location = new System.Drawing.Point(187, 21);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(18, 18);
            this.btnFindOrder.TabIndex = 116;
            this.btnFindOrder.UseVisualStyleBackColor = true;
            this.btnFindOrder.Click += new System.EventHandler(this.btnFindOrder_Click);
            // 
            // datePickerVisitDate
            // 
            this.datePickerVisitDate.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerVisitDate.Location = new System.Drawing.Point(76, 60);
            this.datePickerVisitDate.Name = "datePickerVisitDate";
            this.datePickerVisitDate.Size = new System.Drawing.Size(129, 20);
            this.datePickerVisitDate.TabIndex = 126;
            // 
            // checkDone
            // 
            this.checkDone.AutoSize = true;
            this.checkDone.Location = new System.Drawing.Point(20, 199);
            this.checkDone.Name = "checkDone";
            this.checkDone.Size = new System.Drawing.Size(77, 17);
            this.checkDone.TabIndex = 127;
            this.checkDone.Text = "Выполнен";
            this.checkDone.UseVisualStyleBackColor = true;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(259, 51);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(199, 165);
            this.tbComment.TabIndex = 129;
            this.tbComment.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Комментарий";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "Мастер:";
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Location = new System.Drawing.Point(73, 114);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(89, 13);
            this.labelMaster.TabIndex = 131;
            this.labelMaster.TabStop = true;
            this.labelMaster.Text = "выберите заказ";
            this.labelMaster.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelMaster_LinkClicked);
            // 
            // visitTabs
            // 
            this.visitTabs.Controls.Add(this.generalPage);
            this.visitTabs.Controls.Add(this.servicesPage);
            this.visitTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitTabs.Location = new System.Drawing.Point(0, 0);
            this.visitTabs.Name = "visitTabs";
            this.visitTabs.SelectedIndex = 0;
            this.visitTabs.Size = new System.Drawing.Size(794, 346);
            this.visitTabs.TabIndex = 132;
            this.visitTabs.SelectedIndexChanged += new System.EventHandler(this.visitTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelEstimatedTime);
            this.generalPage.Controls.Add(this.labelTime);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.tbComment);
            this.generalPage.Controls.Add(this.btnAction);
            this.generalPage.Controls.Add(this.labelMaster);
            this.generalPage.Controls.Add(this.checkDone);
            this.generalPage.Controls.Add(this.label6);
            this.generalPage.Controls.Add(this.btnFindOrder);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.tbOrder);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.datePickerVisitDate);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(786, 320);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.AutoSize = true;
            this.labelEstimatedTime.Location = new System.Drawing.Point(200, 159);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(38, 13);
            this.labelEstimatedTime.TabIndex = 133;
            this.labelEstimatedTime.Text = "N мин";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(17, 159);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(168, 13);
            this.labelTime.TabIndex = 132;
            this.labelTime.Text = "Примерное время выполнения:";
            // 
            // servicesPage
            // 
            this.servicesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.servicesPage.Controls.Add(this.panel2);
            this.servicesPage.Controls.Add(this.panel1);
            this.servicesPage.Location = new System.Drawing.Point(4, 22);
            this.servicesPage.Name = "servicesPage";
            this.servicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.servicesPage.Size = new System.Drawing.Size(786, 320);
            this.servicesPage.TabIndex = 1;
            this.servicesPage.Text = "Запланированные услуги";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.btnDelService);
            this.panel2.Controls.Add(this.btnShowService);
            this.panel2.Location = new System.Drawing.Point(632, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 324);
            this.panel2.TabIndex = 4;
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddService.Location = new System.Drawing.Point(0, 0);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(158, 40);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnDelService
            // 
            this.btnDelService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDelService.FlatAppearance.BorderSize = 0;
            this.btnDelService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelService.Location = new System.Drawing.Point(0, 40);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.Size = new System.Drawing.Size(158, 40);
            this.btnDelService.TabIndex = 1;
            this.btnDelService.Text = "Удалить";
            this.btnDelService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelService.UseVisualStyleBackColor = false;
            this.btnDelService.Click += new System.EventHandler(this.btnDelService_Click);
            // 
            // btnShowService
            // 
            this.btnShowService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowService.FlatAppearance.BorderSize = 0;
            this.btnShowService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowService.Location = new System.Drawing.Point(0, 80);
            this.btnShowService.Name = "btnShowService";
            this.btnShowService.Size = new System.Drawing.Size(158, 40);
            this.btnShowService.TabIndex = 0;
            this.btnShowService.Text = "Просмотреть";
            this.btnShowService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowService.UseVisualStyleBackColor = false;
            this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxShowServicesRows);
            this.panel1.Controls.Add(this.label47);
            this.panel1.Controls.Add(this.labelServicesPageCout);
            this.panel1.Controls.Add(this.numericCurrentServicePage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNextService);
            this.panel1.Controls.Add(this.btnPrevService);
            this.panel1.Controls.Add(this.dataServies);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 324);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxShowServicesRows
            // 
            this.comboBoxShowServicesRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowServicesRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowServicesRows.FormattingEnabled = true;
            this.comboBoxShowServicesRows.Location = new System.Drawing.Point(432, 295);
            this.comboBoxShowServicesRows.Name = "comboBoxShowServicesRows";
            this.comboBoxShowServicesRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowServicesRows.TabIndex = 18;
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label47.Location = new System.Drawing.Point(319, 296);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(107, 17);
            this.label47.TabIndex = 17;
            this.label47.Text = "Показывать по";
            // 
            // labelServicesPageCout
            // 
            this.labelServicesPageCout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelServicesPageCout.AutoSize = true;
            this.labelServicesPageCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelServicesPageCout.Location = new System.Drawing.Point(260, 296);
            this.labelServicesPageCout.Name = "labelServicesPageCout";
            this.labelServicesPageCout.Size = new System.Drawing.Size(36, 17);
            this.labelServicesPageCout.TabIndex = 10;
            this.labelServicesPageCout.Text = "из S";
            // 
            // numericCurrentServicePage
            // 
            this.numericCurrentServicePage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentServicePage.Location = new System.Drawing.Point(209, 297);
            this.numericCurrentServicePage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentServicePage.Name = "numericCurrentServicePage";
            this.numericCurrentServicePage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentServicePage.TabIndex = 9;
            this.numericCurrentServicePage.Value = new decimal(new int[] {
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
            this.label28.Location = new System.Drawing.Point(131, 296);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 8;
            this.label28.Text = "Страница";
            // 
            // btnNextService
            // 
            this.btnNextService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextService.FlatAppearance.BorderSize = 0;
            this.btnNextService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextService.Location = new System.Drawing.Point(501, 284);
            this.btnNextService.Name = "btnNextService";
            this.btnNextService.Size = new System.Drawing.Size(130, 40);
            this.btnNextService.TabIndex = 4;
            this.btnNextService.Text = "Следующая →";
            this.btnNextService.UseVisualStyleBackColor = false;
            // 
            // btnPrevService
            // 
            this.btnPrevService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevService.FlatAppearance.BorderSize = 0;
            this.btnPrevService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevService.Location = new System.Drawing.Point(0, 284);
            this.btnPrevService.Name = "btnPrevService";
            this.btnPrevService.Size = new System.Drawing.Size(130, 40);
            this.btnPrevService.TabIndex = 3;
            this.btnPrevService.Text = "← Предыдущая";
            this.btnPrevService.UseVisualStyleBackColor = false;
            // 
            // dataServies
            // 
            this.dataServies.AllowUserToAddRows = false;
            this.dataServies.AllowUserToDeleteRows = false;
            this.dataServies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataServies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataServies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataServies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.column_sale});
            this.dataServies.Location = new System.Drawing.Point(0, 0);
            this.dataServies.Name = "dataServies";
            this.dataServies.ReadOnly = true;
            this.dataServies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataServies.Size = new System.Drawing.Size(631, 278);
            this.dataServies.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // column_sale
            // 
            this.column_sale.HeaderText = "Примерное время выполнения";
            this.column_sale.Name = "column_sale";
            this.column_sale.ReadOnly = true;
            // 
            // FormManageVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(794, 346);
            this.Controls.Add(this.visitTabs);
            this.MaximizeBox = false;
            this.Name = "FormManageVisit";
            this.Text = "Выезды";
            this.Load += new System.EventHandler(this.FormManageVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.visitTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.servicesPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrder;
        private FontAwesome.Sharp.IconButton btnFindOrder;
        private System.Windows.Forms.DateTimePicker datePickerVisitDate;
        private System.Windows.Forms.CheckBox checkDone;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.LinkLabel labelMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl visitTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage servicesPage;
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxShowServicesRows;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label labelServicesPageCout;
        private System.Windows.Forms.NumericUpDown numericCurrentServicePage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNextService;
        private System.Windows.Forms.Button btnPrevService;
        private System.Windows.Forms.DataGridView dataServies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sale;
        private System.Windows.Forms.Panel panel2;
        private ManageButton btnShowService;
        private ManageButton btnAddService;
        private ManageButton btnDelService;
    }
}

namespace Forms_TechServ
{
    partial class FormShowVisit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.LinkLabel();
            this.labelClient = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.visitTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelMaster = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.servicesPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowService = new Forms_TechServ.ManageButton();
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
            this.visitTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.servicesPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Заказ:";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(88, 58);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(55, 13);
            this.labelOrder.TabIndex = 28;
            this.labelOrder.TabStop = true;
            this.labelOrder.Text = "linkLabel1";
            this.labelOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedOrder_LinkClicked);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(88, 99);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(55, 13);
            this.labelClient.TabIndex = 32;
            this.labelClient.TabStop = true;
            this.labelClient.Text = "linkLabel3";
            this.labelClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedClient_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Клиент:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(88, 254);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 13);
            this.labelDate.TabIndex = 33;
            this.labelDate.Text = "label6";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(88, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 36;
            this.labelID.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "ID:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(88, 214);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 13);
            this.labelAddress.TabIndex = 38;
            this.labelAddress.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Адрес:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Выполнен:";
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Location = new System.Drawing.Point(88, 330);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(19, 13);
            this.labelDone.TabIndex = 45;
            this.labelDone.Text = "да";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(88, 140);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(55, 13);
            this.labelProduct.TabIndex = 48;
            this.labelProduct.TabStop = true;
            this.labelProduct.Text = "linkLabel3";
            this.labelProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelProduct_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Техника:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Комментарий";
            // 
            // tbComment
            // 
            this.tbComment.Enabled = false;
            this.tbComment.Location = new System.Drawing.Point(402, 68);
            this.tbComment.Name = "tbComment";
            this.tbComment.ReadOnly = true;
            this.tbComment.Size = new System.Drawing.Size(202, 245);
            this.tbComment.TabIndex = 50;
            this.tbComment.Text = "";
            // 
            // visitTabs
            // 
            this.visitTabs.Controls.Add(this.generalPage);
            this.visitTabs.Controls.Add(this.servicesPage);
            this.visitTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitTabs.Location = new System.Drawing.Point(0, 0);
            this.visitTabs.Name = "visitTabs";
            this.visitTabs.SelectedIndex = 0;
            this.visitTabs.Size = new System.Drawing.Size(806, 381);
            this.visitTabs.TabIndex = 51;
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelMaster);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.labelEstimatedTime);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.panelEdit);
            this.generalPage.Controls.Add(this.label9);
            this.generalPage.Controls.Add(this.tbComment);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.label6);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.labelProduct);
            this.generalPage.Controls.Add(this.labelOrder);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.label5);
            this.generalPage.Controls.Add(this.labelClient);
            this.generalPage.Controls.Add(this.labelDone);
            this.generalPage.Controls.Add(this.labelDate);
            this.generalPage.Controls.Add(this.label12);
            this.generalPage.Controls.Add(this.labelID);
            this.generalPage.Controls.Add(this.labelAddress);
            this.generalPage.Controls.Add(this.label11);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(798, 355);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Location = new System.Drawing.Point(88, 175);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(55, 13);
            this.labelMaster.TabIndex = 55;
            this.labelMaster.TabStop = true;
            this.labelMaster.Text = "linkLabel3";
            this.labelMaster.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelMaster_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Мастер:";
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.AutoSize = true;
            this.labelEstimatedTime.Location = new System.Drawing.Point(213, 291);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(38, 13);
            this.labelEstimatedTime.TabIndex = 53;
            this.labelEstimatedTime.Text = "N мин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Примерное время выполнения:";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.deleteBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(625, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(170, 349);
            this.panelEdit.TabIndex = 51;
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.editBtn.Location = new System.Drawing.Point(36, 39);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(106, 43);
            this.editBtn.TabIndex = 41;
            this.editBtn.Text = "РЕДАКТИРОВАТЬ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.deleteBtn.Location = new System.Drawing.Point(36, 157);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(106, 43);
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.Text = "УДАЛИТЬ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.cancelBtn.Location = new System.Drawing.Point(36, 267);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(106, 43);
            this.cancelBtn.TabIndex = 43;
            this.cancelBtn.Text = "ЗАКРЫТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // servicesPage
            // 
            this.servicesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.servicesPage.Controls.Add(this.panel2);
            this.servicesPage.Controls.Add(this.panel1);
            this.servicesPage.Location = new System.Drawing.Point(4, 22);
            this.servicesPage.Name = "servicesPage";
            this.servicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.servicesPage.Size = new System.Drawing.Size(798, 355);
            this.servicesPage.TabIndex = 1;
            this.servicesPage.Text = "Заплнаированные услуги";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnShowService);
            this.panel2.Location = new System.Drawing.Point(641, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 352);
            this.panel2.TabIndex = 3;
            // 
            // btnShowService
            // 
            this.btnShowService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowService.FlatAppearance.BorderSize = 0;
            this.btnShowService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowService.Location = new System.Drawing.Point(0, 0);
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Size = new System.Drawing.Size(641, 352);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxShowServicesRows
            // 
            this.comboBoxShowServicesRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowServicesRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowServicesRows.FormattingEnabled = true;
            this.comboBoxShowServicesRows.Location = new System.Drawing.Point(437, 323);
            this.comboBoxShowServicesRows.Name = "comboBoxShowServicesRows";
            this.comboBoxShowServicesRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowServicesRows.TabIndex = 18;
            this.comboBoxShowServicesRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowServicesRows_SelectedIndexChanged);
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label47.Location = new System.Drawing.Point(324, 324);
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
            this.labelServicesPageCout.Location = new System.Drawing.Point(265, 324);
            this.labelServicesPageCout.Name = "labelServicesPageCout";
            this.labelServicesPageCout.Size = new System.Drawing.Size(36, 17);
            this.labelServicesPageCout.TabIndex = 10;
            this.labelServicesPageCout.Text = "из S";
            // 
            // numericCurrentServicePage
            // 
            this.numericCurrentServicePage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentServicePage.Location = new System.Drawing.Point(214, 325);
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
            this.numericCurrentServicePage.ValueChanged += new System.EventHandler(this.numericCurrentServicePage_ValueChanged);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(136, 324);
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
            this.btnNextService.Location = new System.Drawing.Point(511, 312);
            this.btnNextService.Name = "btnNextService";
            this.btnNextService.Size = new System.Drawing.Size(130, 40);
            this.btnNextService.TabIndex = 4;
            this.btnNextService.Text = "Следующая →";
            this.btnNextService.UseVisualStyleBackColor = false;
            this.btnNextService.Click += new System.EventHandler(this.btnNextService_Click);
            // 
            // btnPrevService
            // 
            this.btnPrevService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevService.FlatAppearance.BorderSize = 0;
            this.btnPrevService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevService.Location = new System.Drawing.Point(0, 312);
            this.btnPrevService.Name = "btnPrevService";
            this.btnPrevService.Size = new System.Drawing.Size(130, 40);
            this.btnPrevService.TabIndex = 3;
            this.btnPrevService.Text = "← Предыдущая";
            this.btnPrevService.UseVisualStyleBackColor = false;
            this.btnPrevService.Click += new System.EventHandler(this.btnPrevService_Click);
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
            this.dataServies.MultiSelect = false;
            this.dataServies.Name = "dataServies";
            this.dataServies.ReadOnly = true;
            this.dataServies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataServies.Size = new System.Drawing.Size(641, 306);
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
            // FormShowVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(806, 381);
            this.Controls.Add(this.visitTabs);
            this.MaximizeBox = false;
            this.Name = "FormShowVisit";
            this.Text = "Просмотр выезда";
            this.Load += new System.EventHandler(this.FormShowVisit_Load);
            this.visitTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.servicesPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel labelOrder;
        private System.Windows.Forms.LinkLabel labelClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.LinkLabel labelProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.TabControl visitTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabPage servicesPage;
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
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private ManageButton btnShowService;
        private System.Windows.Forms.LinkLabel labelMaster;
        private System.Windows.Forms.Label label4;
    }
}
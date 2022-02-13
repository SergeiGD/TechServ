
namespace Forms_TechServ.forms.orders
{
    partial class FormAddOrder
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
            this.ordersTab = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.btnFindWorkshop = new FontAwesome.Sharp.IconButton();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioManually = new System.Windows.Forms.RadioButton();
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.tbMaster = new System.Windows.Forms.TextBox();
            this.btnFindMaster = new FontAwesome.Sharp.IconButton();
            this.btnFindProduct = new FontAwesome.Sharp.IconButton();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ordersTab.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.generalPage);
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(0, 0);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.SelectedIndex = 0;
            this.ordersTab.Size = new System.Drawing.Size(675, 243);
            this.ordersTab.TabIndex = 0;
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.btnFindWorkshop);
            this.generalPage.Controls.Add(this.tbWorkshop);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.groupBox1);
            this.generalPage.Controls.Add(this.btnFindProduct);
            this.generalPage.Controls.Add(this.tbAddress);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.btnAdd);
            this.generalPage.Controls.Add(this.tbProduct);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.tbComment);
            this.generalPage.Controls.Add(this.label26);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(667, 217);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // btnFindWorkshop
            // 
            this.btnFindWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFindWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindWorkshop.IconSize = 17;
            this.btnFindWorkshop.Location = new System.Drawing.Point(207, 81);
            this.btnFindWorkshop.Name = "btnFindWorkshop";
            this.btnFindWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnFindWorkshop.TabIndex = 153;
            this.btnFindWorkshop.UseVisualStyleBackColor = true;
            this.btnFindWorkshop.Click += new System.EventHandler(this.btnFindWorkshop_Click);
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Location = new System.Drawing.Point(96, 81);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(104, 20);
            this.tbWorkshop.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 151;
            this.label1.Text = "Мастерская";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioManually);
            this.groupBox1.Controls.Add(this.radioAuto);
            this.groupBox1.Controls.Add(this.tbMaster);
            this.groupBox1.Controls.Add(this.btnFindMaster);
            this.groupBox1.Location = new System.Drawing.Point(24, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 80);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мастер";
            // 
            // radioManually
            // 
            this.radioManually.AutoSize = true;
            this.radioManually.Location = new System.Drawing.Point(6, 52);
            this.radioManually.Name = "radioManually";
            this.radioManually.Size = new System.Drawing.Size(67, 17);
            this.radioManually.TabIndex = 1;
            this.radioManually.TabStop = true;
            this.radioManually.Text = "Вручную";
            this.radioManually.UseVisualStyleBackColor = true;
            this.radioManually.CheckedChanged += new System.EventHandler(this.radioMaster_CheckedChanged);
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Location = new System.Drawing.Point(6, 28);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(103, 17);
            this.radioAuto.TabIndex = 0;
            this.radioAuto.TabStop = true;
            this.radioAuto.Text = "Автоматически";
            this.radioAuto.UseVisualStyleBackColor = true;
            this.radioAuto.CheckedChanged += new System.EventHandler(this.radioMaster_CheckedChanged);
            // 
            // tbMaster
            // 
            this.tbMaster.Enabled = false;
            this.tbMaster.Location = new System.Drawing.Point(73, 51);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.ReadOnly = true;
            this.tbMaster.Size = new System.Drawing.Size(105, 20);
            this.tbMaster.TabIndex = 123;
            // 
            // btnFindMaster
            // 
            this.btnFindMaster.FlatAppearance.BorderSize = 0;
            this.btnFindMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMaster.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindMaster.IconSize = 17;
            this.btnFindMaster.Location = new System.Drawing.Point(184, 52);
            this.btnFindMaster.Name = "btnFindMaster";
            this.btnFindMaster.Size = new System.Drawing.Size(18, 18);
            this.btnFindMaster.TabIndex = 135;
            this.btnFindMaster.UseVisualStyleBackColor = true;
            this.btnFindMaster.Click += new System.EventHandler(this.btnFindMaster_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.FlatAppearance.BorderSize = 0;
            this.btnFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindProduct.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindProduct.IconSize = 17;
            this.btnFindProduct.Location = new System.Drawing.Point(207, 48);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(18, 18);
            this.btnFindProduct.TabIndex = 133;
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(96, 11);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(105, 20);
            this.tbAddress.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Адрес:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(527, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 127;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(527, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 40);
            this.btnAdd.TabIndex = 126;
            this.btnAdd.Text = "Сохранить и добавить услуги";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(96, 48);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.ReadOnly = true;
            this.tbProduct.Size = new System.Drawing.Size(104, 20);
            this.tbProduct.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Техника";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(285, 27);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(197, 174);
            this.tbComment.TabIndex = 89;
            this.tbComment.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(326, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 13);
            this.label26.TabIndex = 88;
            this.label26.Text = "Комментарий клиента";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(675, 243);
            this.Controls.Add(this.ordersTab);
            this.MaximizeBox = false;
            this.Name = "FormAddOrder";
            this.Text = "Добавление заказа";
            this.Load += new System.EventHandler(this.FormAddOrder_Load);
            this.ordersTab.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ordersTab;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbMaster;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private FontAwesome.Sharp.IconButton btnFindMaster;
        private FontAwesome.Sharp.IconButton btnFindProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioManually;
        private System.Windows.Forms.RadioButton radioAuto;
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private System.Windows.Forms.TextBox tbWorkshop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
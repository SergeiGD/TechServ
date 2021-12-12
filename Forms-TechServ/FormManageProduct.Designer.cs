
namespace Forms_TechServ
{
    partial class FormManageProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindCat = new FontAwesome.Sharp.IconButton();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.btnFindClient = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.productsTab = new System.Windows.Forms.TabControl();
            this.genralPage = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.productsTab.SuspendLayout();
            this.genralPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(74, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 20);
            this.tbName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(269, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(269, 19);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 40);
            this.btnAction.TabIndex = 21;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tbCat
            // 
            this.tbCat.Enabled = false;
            this.tbCat.Location = new System.Drawing.Point(74, 60);
            this.tbCat.Name = "tbCat";
            this.tbCat.ReadOnly = true;
            this.tbCat.Size = new System.Drawing.Size(127, 20);
            this.tbCat.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 144;
            this.label5.Text = "Категория:";
            // 
            // btnFindCat
            // 
            this.btnFindCat.FlatAppearance.BorderSize = 0;
            this.btnFindCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCat.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindCat.IconSize = 17;
            this.btnFindCat.Location = new System.Drawing.Point(207, 59);
            this.btnFindCat.Name = "btnFindCat";
            this.btnFindCat.Size = new System.Drawing.Size(18, 23);
            this.btnFindCat.TabIndex = 146;
            this.btnFindCat.UseVisualStyleBackColor = true;
            this.btnFindCat.Click += new System.EventHandler(this.btnFindCat_Click);
            // 
            // tbClient
            // 
            this.tbClient.Enabled = false;
            this.tbClient.Location = new System.Drawing.Point(74, 101);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(127, 20);
            this.tbClient.TabIndex = 143;
            // 
            // btnFindClient
            // 
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindClient.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindClient.IconSize = 17;
            this.btnFindClient.Location = new System.Drawing.Point(207, 100);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(18, 23);
            this.btnFindClient.TabIndex = 142;
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Клиент:";
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.genralPage);
            this.productsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsTab.Location = new System.Drawing.Point(0, 0);
            this.productsTab.Name = "productsTab";
            this.productsTab.SelectedIndex = 0;
            this.productsTab.Size = new System.Drawing.Size(413, 165);
            this.productsTab.TabIndex = 148;
            this.productsTab.SelectedIndexChanged += new System.EventHandler(this.productsTab_SelectedIndexChanged);
            // 
            // genralPage
            // 
            this.genralPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.genralPage.Controls.Add(this.label1);
            this.genralPage.Controls.Add(this.tbCat);
            this.genralPage.Controls.Add(this.tbName);
            this.genralPage.Controls.Add(this.btnAction);
            this.genralPage.Controls.Add(this.label5);
            this.genralPage.Controls.Add(this.btnCancel);
            this.genralPage.Controls.Add(this.btnFindCat);
            this.genralPage.Controls.Add(this.tbClient);
            this.genralPage.Controls.Add(this.label4);
            this.genralPage.Controls.Add(this.btnFindClient);
            this.genralPage.Location = new System.Drawing.Point(4, 22);
            this.genralPage.Name = "genralPage";
            this.genralPage.Padding = new System.Windows.Forms.Padding(3);
            this.genralPage.Size = new System.Drawing.Size(405, 139);
            this.genralPage.TabIndex = 0;
            this.genralPage.Text = "Общая информация";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(413, 165);
            this.Controls.Add(this.productsTab);
            this.MaximizeBox = false;
            this.Name = "FormManageProduct";
            this.Text = "FormManageProduct";
            this.Load += new System.EventHandler(this.FormManageProduct_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageProduct_ResizeEnd);
            this.productsTab.ResumeLayout(false);
            this.genralPage.ResumeLayout(false);
            this.genralPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox tbCat;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnFindCat;
        private System.Windows.Forms.TextBox tbClient;
        private FontAwesome.Sharp.IconButton btnFindClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl productsTab;
        private System.Windows.Forms.TabPage genralPage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

namespace Forms_TechServ.forms.categories
{
    partial class FormManageCategory
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.tbParentCat = new System.Windows.Forms.TextBox();
            this.btnCleanParentCat = new FontAwesome.Sharp.IconButton();
            this.btnFinaParentCat = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriesTab = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.servicesPage = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoriesTab.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(141, 20);
            this.tbName.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(336, 85);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 36);
            this.cancelBtn.TabIndex = 49;
            this.cancelBtn.Text = "ОТМЕНИТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // actionBtn
            // 
            this.actionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionBtn.Location = new System.Drawing.Point(336, 25);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(95, 36);
            this.actionBtn.TabIndex = 48;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // tbParentCat
            // 
            this.tbParentCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbParentCat.Enabled = false;
            this.tbParentCat.Location = new System.Drawing.Point(117, 101);
            this.tbParentCat.Name = "tbParentCat";
            this.tbParentCat.ReadOnly = true;
            this.tbParentCat.Size = new System.Drawing.Size(141, 20);
            this.tbParentCat.TabIndex = 123;
            // 
            // btnCleanParentCat
            // 
            this.btnCleanParentCat.FlatAppearance.BorderSize = 0;
            this.btnCleanParentCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanParentCat.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanParentCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanParentCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanParentCat.IconSize = 17;
            this.btnCleanParentCat.Location = new System.Drawing.Point(288, 101);
            this.btnCleanParentCat.Name = "btnCleanParentCat";
            this.btnCleanParentCat.Size = new System.Drawing.Size(18, 18);
            this.btnCleanParentCat.TabIndex = 121;
            this.btnCleanParentCat.UseVisualStyleBackColor = true;
            this.btnCleanParentCat.Click += new System.EventHandler(this.btnCleanParentCat_Click);
            // 
            // btnFinaParentCat
            // 
            this.btnFinaParentCat.FlatAppearance.BorderSize = 0;
            this.btnFinaParentCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinaParentCat.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFinaParentCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFinaParentCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinaParentCat.IconSize = 17;
            this.btnFinaParentCat.Location = new System.Drawing.Point(264, 101);
            this.btnFinaParentCat.Name = "btnFinaParentCat";
            this.btnFinaParentCat.Size = new System.Drawing.Size(18, 18);
            this.btnFinaParentCat.TabIndex = 122;
            this.btnFinaParentCat.UseVisualStyleBackColor = true;
            this.btnFinaParentCat.Click += new System.EventHandler(this.btnFinaParentCat_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Род. категория:";
            // 
            // categoriesTab
            // 
            this.categoriesTab.Controls.Add(this.generalPage);
            this.categoriesTab.Controls.Add(this.servicesPage);
            this.categoriesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesTab.Location = new System.Drawing.Point(0, 0);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.SelectedIndex = 0;
            this.categoriesTab.Size = new System.Drawing.Size(473, 169);
            this.categoriesTab.TabIndex = 124;
            this.categoriesTab.SelectedIndexChanged += new System.EventHandler(this.categoriesTab_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.tbParentCat);
            this.generalPage.Controls.Add(this.tbName);
            this.generalPage.Controls.Add(this.btnCleanParentCat);
            this.generalPage.Controls.Add(this.actionBtn);
            this.generalPage.Controls.Add(this.btnFinaParentCat);
            this.generalPage.Controls.Add(this.cancelBtn);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(465, 143);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // servicesPage
            // 
            this.servicesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.servicesPage.Location = new System.Drawing.Point(4, 22);
            this.servicesPage.Name = "servicesPage";
            this.servicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.servicesPage.Size = new System.Drawing.Size(465, 143);
            this.servicesPage.TabIndex = 1;
            this.servicesPage.Text = "Услуги";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(473, 169);
            this.Controls.Add(this.categoriesTab);
            this.MaximizeBox = false;
            this.Name = "FormManageCategory";
            this.Text = "Управление категорией";
            this.Load += new System.EventHandler(this.FormManageCategory_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageCategory_ResizeEnd);
            this.categoriesTab.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.TextBox tbParentCat;
        private FontAwesome.Sharp.IconButton btnCleanParentCat;
        private FontAwesome.Sharp.IconButton btnFinaParentCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl categoriesTab;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage servicesPage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
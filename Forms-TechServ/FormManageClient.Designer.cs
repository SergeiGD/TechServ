
namespace Forms_TechServ
{
    partial class FormManageClient
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
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientsTab = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.productPage = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientsTab.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя клиента";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(123, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(116, 97);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(123, 20);
            this.tbPhoneNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер телефона";
            // 
            // clientsTab
            // 
            this.clientsTab.Controls.Add(this.generalPage);
            this.clientsTab.Controls.Add(this.productPage);
            this.clientsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsTab.Location = new System.Drawing.Point(0, 0);
            this.clientsTab.Name = "clientsTab";
            this.clientsTab.SelectedIndex = 0;
            this.clientsTab.Size = new System.Drawing.Size(443, 167);
            this.clientsTab.TabIndex = 22;
            this.clientsTab.SelectedIndexChanged += new System.EventHandler(this.clientsTab_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.btnAction);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.tbName);
            this.generalPage.Controls.Add(this.tbPhoneNum);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(435, 141);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(289, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(289, 18);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 40);
            this.btnAction.TabIndex = 44;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // productPage
            // 
            this.productPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.productPage.Location = new System.Drawing.Point(4, 22);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(435, 141);
            this.productPage.TabIndex = 1;
            this.productPage.Text = "Техника";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormManageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(443, 167);
            this.Controls.Add(this.clientsTab);
            this.MaximizeBox = false;
            this.Name = "FormManageClient";
            this.Text = "FormManageClient";
            this.Load += new System.EventHandler(this.FormManageClient_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageClient_ResizeEnd);
            this.clientsTab.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl clientsTab;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
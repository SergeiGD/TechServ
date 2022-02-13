
namespace Forms_TechServ.forms.products
{
    partial class FormShowProduct
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
            this.productTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelName = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.LinkLabel();
            this.labelClient = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.productTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTabs
            // 
            this.productTabs.Controls.Add(this.generalPage);
            this.productTabs.Controls.Add(this.historyPage);
            this.productTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTabs.Location = new System.Drawing.Point(0, 0);
            this.productTabs.Name = "productTabs";
            this.productTabs.SelectedIndex = 0;
            this.productTabs.Size = new System.Drawing.Size(425, 221);
            this.productTabs.TabIndex = 35;
            this.productTabs.SelectedIndexChanged += new System.EventHandler(this.productTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelName);
            this.generalPage.Controls.Add(this.panelEdit);
            this.generalPage.Controls.Add(this.labelID);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.labelCat);
            this.generalPage.Controls.Add(this.labelClient);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(417, 195);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(97, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 47;
            this.labelName.Text = "label6";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.deleteBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(246, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(168, 189);
            this.panelEdit.TabIndex = 46;
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(26, 14);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(119, 40);
            this.editBtn.TabIndex = 41;
            this.editBtn.Text = "РЕДАКТИРОВАТЬ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(26, 73);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 40);
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.Text = "УДАЛИТЬ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(26, 136);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 40);
            this.cancelBtn.TabIndex = 43;
            this.cancelBtn.Text = "ЗАКРЫТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(97, 17);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 45;
            this.labelID.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID техники";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(94, 166);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(55, 13);
            this.labelCat.TabIndex = 40;
            this.labelCat.TabStop = true;
            this.labelCat.Text = "linkLabel2";
            this.labelCat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedCat_LinkClicked);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(94, 113);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(55, 13);
            this.labelClient.TabIndex = 39;
            this.labelClient.TabStop = true;
            this.labelClient.Text = "linkLabel1";
            this.labelClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedClient_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Название:";
            // 
            // historyPage
            // 
            this.historyPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.historyPage.Location = new System.Drawing.Point(4, 22);
            this.historyPage.Name = "historyPage";
            this.historyPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyPage.Size = new System.Drawing.Size(417, 195);
            this.historyPage.TabIndex = 1;
            this.historyPage.Text = "История ремонта";
            // 
            // FormShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.productTabs);
            this.MaximizeBox = false;
            this.Name = "FormShowProduct";
            this.Text = "Просмотр техники";
            this.Load += new System.EventHandler(this.FormShowProduct_Load);
            this.ResizeEnd += new System.EventHandler(this.FormShowProduct_ResizeEnd);
            this.productTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl productTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.LinkLabel labelCat;
        private System.Windows.Forms.LinkLabel labelClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label labelName;
    }
}

namespace Forms_TechServ.forms.clients
{
    partial class FormShowClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOrdersCount = new System.Windows.Forms.Label();
            this.clientTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.labelLastAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productsPage = new System.Windows.Forms.TabPage();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.clientTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Номер телефона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Имя клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Кол-во заказов";
            // 
            // labelOrdersCount
            // 
            this.labelOrdersCount.AutoSize = true;
            this.labelOrdersCount.Location = new System.Drawing.Point(121, 235);
            this.labelOrdersCount.Name = "labelOrdersCount";
            this.labelOrdersCount.Size = new System.Drawing.Size(35, 13);
            this.labelOrdersCount.TabIndex = 32;
            this.labelOrdersCount.Text = "label5";
            // 
            // clientTabs
            // 
            this.clientTabs.Controls.Add(this.generalPage);
            this.clientTabs.Controls.Add(this.productsPage);
            this.clientTabs.Controls.Add(this.ordersPage);
            this.clientTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientTabs.Location = new System.Drawing.Point(0, 0);
            this.clientTabs.Name = "clientTabs";
            this.clientTabs.SelectedIndex = 0;
            this.clientTabs.Size = new System.Drawing.Size(486, 301);
            this.clientTabs.TabIndex = 33;
            this.clientTabs.SelectedIndexChanged += new System.EventHandler(this.clientTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.labelLastAddress);
            this.generalPage.Controls.Add(this.labelName);
            this.generalPage.Controls.Add(this.labelPhoneNum);
            this.generalPage.Controls.Add(this.panelEdit);
            this.generalPage.Controls.Add(this.label7);
            this.generalPage.Controls.Add(this.labelID);
            this.generalPage.Controls.Add(this.label6);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.labelOrdersCount);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(478, 275);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // labelLastAddress
            // 
            this.labelLastAddress.AutoSize = true;
            this.labelLastAddress.Location = new System.Drawing.Point(121, 183);
            this.labelLastAddress.Name = "labelLastAddress";
            this.labelLastAddress.Size = new System.Drawing.Size(41, 13);
            this.labelLastAddress.TabIndex = 44;
            this.labelLastAddress.Text = "label10";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(121, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 43;
            this.labelName.Text = "label9";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Location = new System.Drawing.Point(124, 126);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(35, 13);
            this.labelPhoneNum.TabIndex = 42;
            this.labelPhoneNum.Text = "label8";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Controls.Add(this.deleteBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(274, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(201, 269);
            this.panelEdit.TabIndex = 41;
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(49, 15);
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
            this.cancelBtn.Location = new System.Drawing.Point(49, 205);
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
            this.deleteBtn.Location = new System.Drawing.Point(49, 109);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 40);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "УДАЛИТЬ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Последний адрес";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(121, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 34;
            this.labelID.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID клиента";
            // 
            // productsPage
            // 
            this.productsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.productsPage.Location = new System.Drawing.Point(4, 22);
            this.productsPage.Name = "productsPage";
            this.productsPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsPage.Size = new System.Drawing.Size(478, 275);
            this.productsPage.TabIndex = 1;
            this.productsPage.Text = "Техника";
            // 
            // ordersPage
            // 
            this.ordersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(478, 275);
            this.ordersPage.TabIndex = 2;
            this.ordersPage.Text = "Заказы";
            // 
            // FormShowClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(486, 301);
            this.Controls.Add(this.clientTabs);
            this.MaximizeBox = false;
            this.Name = "FormShowClient";
            this.Text = "Просмотр клиента";
            this.Load += new System.EventHandler(this.FormShowClient_Load);
            this.ResizeEnd += new System.EventHandler(this.FormShowClient_ResizeEnd);
            this.clientTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOrdersCount;
        private System.Windows.Forms.TabControl clientTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage productsPage;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label labelLastAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhoneNum;
    }
}
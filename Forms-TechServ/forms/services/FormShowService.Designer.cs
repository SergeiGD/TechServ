
namespace Forms_TechServ.forms.services
{
    partial class FormShowService
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
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.LinkLabel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAvgTime = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPriceInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipPriceInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Enabled = false;
            this.tbDescription.Location = new System.Drawing.Point(290, 44);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(179, 141);
            this.tbDescription.TabIndex = 21;
            this.tbDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Примерное время:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Категория:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(95, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "label6";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(95, 91);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(55, 13);
            this.labelCat.TabIndex = 23;
            this.labelCat.TabStop = true;
            this.labelCat.Text = "linkLabel1";
            this.labelCat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPickedCat_LinkClicked);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(95, 131);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 24;
            this.labelPrice.Text = "label7";
            // 
            // labelAvgTime
            // 
            this.labelAvgTime.AutoSize = true;
            this.labelAvgTime.Location = new System.Drawing.Point(133, 168);
            this.labelAvgTime.Name = "labelAvgTime";
            this.labelAvgTime.Size = new System.Drawing.Size(35, 13);
            this.labelAvgTime.TabIndex = 25;
            this.labelAvgTime.Text = "label8";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.editBtn);
            this.panelEdit.Controls.Add(this.deleteBtn);
            this.panelEdit.Controls.Add(this.cancelBtn);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(494, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(151, 193);
            this.panelEdit.TabIndex = 26;
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(20, 12);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(119, 41);
            this.editBtn.TabIndex = 58;
            this.editBtn.Text = "РЕДАКТИРОВАТЬ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(20, 77);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 41);
            this.deleteBtn.TabIndex = 60;
            this.deleteBtn.Text = "УДАЛИТЬ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(20, 140);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 41);
            this.cancelBtn.TabIndex = 59;
            this.cancelBtn.Text = "ЗАКРЫТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(95, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 28;
            this.labelID.Text = "label6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID услуги:";
            // 
            // btnPriceInfo
            // 
            this.btnPriceInfo.FlatAppearance.BorderSize = 0;
            this.btnPriceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnPriceInfo.IconColor = System.Drawing.Color.Black;
            this.btnPriceInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPriceInfo.IconSize = 20;
            this.btnPriceInfo.Location = new System.Drawing.Point(163, 127);
            this.btnPriceInfo.Name = "btnPriceInfo";
            this.btnPriceInfo.Size = new System.Drawing.Size(27, 21);
            this.btnPriceInfo.TabIndex = 146;
            this.btnPriceInfo.UseVisualStyleBackColor = true;
            this.btnPriceInfo.MouseHover += new System.EventHandler(this.btnPriceInfo_MouseHover);
            // 
            // FormShowService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(645, 193);
            this.Controls.Add(this.btnPriceInfo);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.labelAvgTime);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormShowService";
            this.Text = "Просмотр усоуги";
            this.Load += new System.EventHandler(this.FormShowService_Load);
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel labelCat;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAvgTime;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnPriceInfo;
        private System.Windows.Forms.ToolTip toolTipPriceInfo;
    }
}
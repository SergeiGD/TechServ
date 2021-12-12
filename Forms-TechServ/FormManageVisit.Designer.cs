
namespace Forms_TechServ
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.btnCleanOrder = new FontAwesome.Sharp.IconButton();
            this.btnFindOrder = new FontAwesome.Sharp.IconButton();
            this.tbMaster = new System.Windows.Forms.TextBox();
            this.btnCleanMaster = new FontAwesome.Sharp.IconButton();
            this.btnFindMaster = new FontAwesome.Sharp.IconButton();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.datePickerVisit = new System.Windows.Forms.DateTimePicker();
            this.checkDone = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(469, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(469, 12);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 40);
            this.btnAction.TabIndex = 17;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Адрес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Мастер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Цель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Заказ:";
            // 
            // tbOrder
            // 
            this.tbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbOrder.Location = new System.Drawing.Point(58, 29);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.ReadOnly = true;
            this.tbOrder.Size = new System.Drawing.Size(104, 20);
            this.tbOrder.TabIndex = 117;
            // 
            // btnCleanOrder
            // 
            this.btnCleanOrder.FlatAppearance.BorderSize = 0;
            this.btnCleanOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanOrder.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanOrder.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanOrder.IconSize = 17;
            this.btnCleanOrder.Location = new System.Drawing.Point(192, 29);
            this.btnCleanOrder.Name = "btnCleanOrder";
            this.btnCleanOrder.Size = new System.Drawing.Size(18, 18);
            this.btnCleanOrder.TabIndex = 115;
            this.btnCleanOrder.UseVisualStyleBackColor = true;
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.FlatAppearance.BorderSize = 0;
            this.btnFindOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindOrder.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindOrder.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindOrder.IconSize = 17;
            this.btnFindOrder.Location = new System.Drawing.Point(168, 29);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(18, 18);
            this.btnFindOrder.TabIndex = 116;
            this.btnFindOrder.UseVisualStyleBackColor = true;
            this.btnFindOrder.Click += new System.EventHandler(this.btnFindOrder_Click);
            // 
            // tbMaster
            // 
            this.tbMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMaster.Location = new System.Drawing.Point(58, 65);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.ReadOnly = true;
            this.tbMaster.Size = new System.Drawing.Size(104, 20);
            this.tbMaster.TabIndex = 120;
            // 
            // btnCleanMaster
            // 
            this.btnCleanMaster.FlatAppearance.BorderSize = 0;
            this.btnCleanMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanMaster.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanMaster.IconSize = 17;
            this.btnCleanMaster.Location = new System.Drawing.Point(192, 65);
            this.btnCleanMaster.Name = "btnCleanMaster";
            this.btnCleanMaster.Size = new System.Drawing.Size(18, 18);
            this.btnCleanMaster.TabIndex = 118;
            this.btnCleanMaster.UseVisualStyleBackColor = true;
            // 
            // btnFindMaster
            // 
            this.btnFindMaster.FlatAppearance.BorderSize = 0;
            this.btnFindMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMaster.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindMaster.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindMaster.IconSize = 17;
            this.btnFindMaster.Location = new System.Drawing.Point(168, 65);
            this.btnFindMaster.Name = "btnFindMaster";
            this.btnFindMaster.Size = new System.Drawing.Size(18, 18);
            this.btnFindMaster.TabIndex = 119;
            this.btnFindMaster.UseVisualStyleBackColor = true;
            this.btnFindMaster.Click += new System.EventHandler(this.btnFindMaster_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(290, 29);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(128, 20);
            this.tbAddress.TabIndex = 124;
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Location = new System.Drawing.Point(290, 66);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(128, 21);
            this.comboBoxPurpose.TabIndex = 125;
            // 
            // datePickerVisit
            // 
            this.datePickerVisit.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.datePickerVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerVisit.Location = new System.Drawing.Point(53, 110);
            this.datePickerVisit.Name = "datePickerVisit";
            this.datePickerVisit.Size = new System.Drawing.Size(128, 20);
            this.datePickerVisit.TabIndex = 126;
            // 
            // checkDone
            // 
            this.checkDone.AutoSize = true;
            this.checkDone.Location = new System.Drawing.Point(14, 140);
            this.checkDone.Name = "checkDone";
            this.checkDone.Size = new System.Drawing.Size(77, 17);
            this.checkDone.TabIndex = 127;
            this.checkDone.Text = "Выполнен";
            this.checkDone.UseVisualStyleBackColor = true;
            // 
            // FormManageVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(613, 163);
            this.Controls.Add(this.checkDone);
            this.Controls.Add(this.datePickerVisit);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbMaster);
            this.Controls.Add(this.btnCleanMaster);
            this.Controls.Add(this.btnFindMaster);
            this.Controls.Add(this.tbOrder);
            this.Controls.Add(this.btnCleanOrder);
            this.Controls.Add(this.btnFindOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.MaximizeBox = false;
            this.Name = "FormManageVisit";
            this.Text = "FormManageVisits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrder;
        private FontAwesome.Sharp.IconButton btnCleanOrder;
        private FontAwesome.Sharp.IconButton btnFindOrder;
        private System.Windows.Forms.TextBox tbMaster;
        private FontAwesome.Sharp.IconButton btnCleanMaster;
        private FontAwesome.Sharp.IconButton btnFindMaster;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.DateTimePicker datePickerVisit;
        private System.Windows.Forms.CheckBox checkDone;
    }
}
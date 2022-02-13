
namespace Forms_TechServ.forms.services
{
    partial class FormManageService
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeriсPrice = new System.Windows.Forms.NumericUpDown();
            this.numericAvgTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnFindCat = new FontAwesome.Sharp.IconButton();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPriceInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipPriceInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numeriсPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAvgTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(99, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(147, 20);
            this.tbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена за услугу:";
            // 
            // numeriсPrice
            // 
            this.numeriсPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeriсPrice.Location = new System.Drawing.Point(134, 85);
            this.numeriсPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeriсPrice.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numeriсPrice.Name = "numeriсPrice";
            this.numeriсPrice.Size = new System.Drawing.Size(88, 20);
            this.numeriсPrice.TabIndex = 7;
            this.numeriсPrice.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericAvgTime
            // 
            this.numericAvgTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericAvgTime.Location = new System.Drawing.Point(178, 122);
            this.numericAvgTime.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericAvgTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericAvgTime.Name = "numericAvgTime";
            this.numericAvgTime.Size = new System.Drawing.Size(68, 20);
            this.numericAvgTime.TabIndex = 8;
            this.numericAvgTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Примерное время (минуты)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(295, 31);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(214, 111);
            this.tbDescription.TabIndex = 11;
            this.tbDescription.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(553, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(553, 20);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 40);
            this.btnAction.TabIndex = 40;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnFindCat
            // 
            this.btnFindCat.FlatAppearance.BorderSize = 0;
            this.btnFindCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCat.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindCat.IconSize = 17;
            this.btnFindCat.Location = new System.Drawing.Point(228, 48);
            this.btnFindCat.Name = "btnFindCat";
            this.btnFindCat.Size = new System.Drawing.Size(18, 18);
            this.btnFindCat.TabIndex = 144;
            this.btnFindCat.UseVisualStyleBackColor = true;
            this.btnFindCat.Click += new System.EventHandler(this.btnFindCat_Click);
            // 
            // tbCat
            // 
            this.tbCat.Enabled = false;
            this.tbCat.Location = new System.Drawing.Point(99, 48);
            this.tbCat.Name = "tbCat";
            this.tbCat.ReadOnly = true;
            this.tbCat.Size = new System.Drawing.Size(123, 20);
            this.tbCat.TabIndex = 142;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnPriceInfo
            // 
            this.btnPriceInfo.FlatAppearance.BorderSize = 0;
            this.btnPriceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnPriceInfo.IconColor = System.Drawing.Color.Black;
            this.btnPriceInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPriceInfo.IconSize = 20;
            this.btnPriceInfo.Location = new System.Drawing.Point(224, 84);
            this.btnPriceInfo.Name = "btnPriceInfo";
            this.btnPriceInfo.Size = new System.Drawing.Size(27, 21);
            this.btnPriceInfo.TabIndex = 145;
            this.btnPriceInfo.UseVisualStyleBackColor = true;
            this.btnPriceInfo.MouseHover += new System.EventHandler(this.btnPriceInfo_MouseHover);
            // 
            // FormManageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(684, 167);
            this.Controls.Add(this.btnPriceInfo);
            this.Controls.Add(this.btnFindCat);
            this.Controls.Add(this.tbCat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericAvgTime);
            this.Controls.Add(this.numeriсPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FormManageService";
            this.Text = "Управление услугой";
            this.Load += new System.EventHandler(this.FormManageService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeriсPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAvgTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeriсPrice;
        private System.Windows.Forms.NumericUpDown numericAvgTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private FontAwesome.Sharp.IconButton btnFindCat;
        private System.Windows.Forms.TextBox tbCat;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private FontAwesome.Sharp.IconButton btnPriceInfo;
        private System.Windows.Forms.ToolTip toolTipPriceInfo;
    }
}
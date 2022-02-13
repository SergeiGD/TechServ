
namespace Forms_TechServ.forms.orders
{
    partial class FormManageOrderService
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericSale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.btnPriceInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipPriceInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скидка";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(109, 34);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(55, 20);
            this.numericQuantity.TabIndex = 2;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // numericSale
            // 
            this.numericSale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericSale.Location = new System.Drawing.Point(254, 34);
            this.numericSale.Name = "numericSale";
            this.numericSale.Size = new System.Drawing.Size(55, 20);
            this.numericSale.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Комментарий мастера";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(39, 124);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(269, 96);
            this.tbComment.TabIndex = 5;
            this.tbComment.Text = "";
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(39, 243);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(91, 36);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Применить";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(217, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена за 1:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(106, 76);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "label5";
            // 
            // btnPriceInfo
            // 
            this.btnPriceInfo.FlatAppearance.BorderSize = 0;
            this.btnPriceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnPriceInfo.IconColor = System.Drawing.Color.Black;
            this.btnPriceInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPriceInfo.IconSize = 20;
            this.btnPriceInfo.Location = new System.Drawing.Point(171, 72);
            this.btnPriceInfo.Name = "btnPriceInfo";
            this.btnPriceInfo.Size = new System.Drawing.Size(27, 21);
            this.btnPriceInfo.TabIndex = 146;
            this.btnPriceInfo.UseVisualStyleBackColor = true;
            this.btnPriceInfo.MouseHover += new System.EventHandler(this.btnPriceInfo_MouseHover);
            // 
            // FormManageOrderService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(355, 293);
            this.Controls.Add(this.btnPriceInfo);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericSale);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManageOrderService";
            this.Text = "Управление услугой в заказе";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.NumericUpDown numericSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPrice;
        private FontAwesome.Sharp.IconButton btnPriceInfo;
        private System.Windows.Forms.ToolTip toolTipPriceInfo;
    }
}
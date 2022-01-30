
namespace Forms_TechServ
{
    partial class FormPickOrderType
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnOutOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(78, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип заказа";
            // 
            // btnInOrder
            // 
            this.btnInOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnInOrder.Location = new System.Drawing.Point(24, 74);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(107, 40);
            this.btnInOrder.TabIndex = 1;
            this.btnInOrder.Text = "В мастерской";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnOutOrder
            // 
            this.btnOutOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnOutOrder.Location = new System.Drawing.Point(175, 74);
            this.btnOutOrder.Name = "btnOutOrder";
            this.btnOutOrder.Size = new System.Drawing.Size(107, 40);
            this.btnOutOrder.TabIndex = 2;
            this.btnOutOrder.Text = "На дому";
            this.btnOutOrder.UseVisualStyleBackColor = true;
            this.btnOutOrder.Click += new System.EventHandler(this.btnOutOrder_Click);
            // 
            // FormPickOrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(308, 139);
            this.Controls.Add(this.btnOutOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.label1);
            this.Name = "FormPickOrderType";
            this.Text = "Выбор типа заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnOutOrder;
    }
}
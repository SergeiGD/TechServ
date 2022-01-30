
namespace Forms_TechServ
{
    partial class FormPickEmployeeType
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
            this.btnManager = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите позицию сотрудника";
            // 
            // btnManager
            // 
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnManager.Location = new System.Drawing.Point(176, 74);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(107, 40);
            this.btnManager.TabIndex = 4;
            this.btnManager.Text = "Менеджер";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnMaster.Location = new System.Drawing.Point(22, 74);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(107, 40);
            this.btnMaster.TabIndex = 3;
            this.btnMaster.Text = "Мастер";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // FormPickEmployeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(308, 139);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnMaster);
            this.Controls.Add(this.label1);
            this.Name = "FormPickEmployeeType";
            this.Text = "Выбор типа сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnMaster;
    }
}
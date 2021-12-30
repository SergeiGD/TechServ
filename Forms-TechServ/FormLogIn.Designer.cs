
namespace Forms_TechServ
{
    partial class FormLogIn
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.labelLogin.Location = new System.Drawing.Point(72, 58);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(85, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Телефон";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(99)))), ((int)(((byte)(123)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(174, 113);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(143, 23);
            this.tbPassword.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.labelPassword.Location = new System.Drawing.Point(72, 113);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(72, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(99)))), ((int)(((byte)(123)))));
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.btnLogIn.Location = new System.Drawing.Point(161, 191);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(102, 40);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Войти";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(99)))), ((int)(((byte)(123)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.tbLogin.Location = new System.Drawing.Point(174, 59);
            this.tbLogin.Mask = "(+70)000000000";
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(143, 23);
            this.tbLogin.TabIndex = 1;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(414, 281);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 320);
            this.MinimumSize = new System.Drawing.Size(430, 320);
            this.Name = "FormLogIn";
            this.Text = "FormLogIn";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.MaskedTextBox tbLogin;
    }
}
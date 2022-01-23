
namespace Forms_TechServ
{
    partial class FormManageRole
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
            this.roleTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.comboBoxRoleType = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.permissionsPage = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.roleTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // roleTabs
            // 
            this.roleTabs.Controls.Add(this.generalPage);
            this.roleTabs.Controls.Add(this.permissionsPage);
            this.roleTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleTabs.Location = new System.Drawing.Point(0, 0);
            this.roleTabs.Name = "roleTabs";
            this.roleTabs.SelectedIndex = 0;
            this.roleTabs.Size = new System.Drawing.Size(502, 215);
            this.roleTabs.TabIndex = 0;
            this.roleTabs.SelectedIndexChanged += new System.EventHandler(this.roleTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.comboBoxRoleType);
            this.generalPage.Controls.Add(this.tbName);
            this.generalPage.Controls.Add(this.btnAction);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.label2);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(494, 189);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // comboBoxRoleType
            // 
            this.comboBoxRoleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoleType.FormattingEnabled = true;
            this.comboBoxRoleType.Location = new System.Drawing.Point(152, 116);
            this.comboBoxRoleType.Name = "comboBoxRoleType";
            this.comboBoxRoleType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoleType.TabIndex = 58;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(152, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 57;
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAction.Location = new System.Drawing.Point(331, 39);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(112, 47);
            this.btnAction.TabIndex = 55;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Location = new System.Drawing.Point(331, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 47);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Принадлежность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Наименование:";
            // 
            // permissionsPage
            // 
            this.permissionsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.permissionsPage.Location = new System.Drawing.Point(4, 22);
            this.permissionsPage.Name = "permissionsPage";
            this.permissionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.permissionsPage.Size = new System.Drawing.Size(494, 189);
            this.permissionsPage.TabIndex = 1;
            this.permissionsPage.Text = "Права";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormManageRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(502, 215);
            this.Controls.Add(this.roleTabs);
            this.Name = "FormManageRole";
            this.Text = "FormManageRole";
            this.Load += new System.EventHandler(this.FormManageRole_Load);
            this.roleTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl roleTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage permissionsPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxRoleType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
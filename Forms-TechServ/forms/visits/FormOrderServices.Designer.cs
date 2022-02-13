
namespace Forms_TechServ.forms.visits
{
    partial class FormOrderServices
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowServicesRows = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelServicesPageCout = new System.Windows.Forms.Label();
            this.numericCurrentServicePage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNextServ = new System.Windows.Forms.Button();
            this.btnPrevServ = new System.Windows.Forms.Button();
            this.dataServies = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxShowServicesRows);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelServicesPageCout);
            this.panel1.Controls.Add(this.numericCurrentServicePage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNextServ);
            this.panel1.Controls.Add(this.btnPrevServ);
            this.panel1.Controls.Add(this.dataServies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 382);
            this.panel1.TabIndex = 7;
            // 
            // comboBoxShowServicesRows
            // 
            this.comboBoxShowServicesRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowServicesRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowServicesRows.FormattingEnabled = true;
            this.comboBoxShowServicesRows.Location = new System.Drawing.Point(544, 354);
            this.comboBoxShowServicesRows.Name = "comboBoxShowServicesRows";
            this.comboBoxShowServicesRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowServicesRows.TabIndex = 12;
            this.comboBoxShowServicesRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowServicesRows_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(431, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Показывать по";
            // 
            // labelServicesPageCout
            // 
            this.labelServicesPageCout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelServicesPageCout.AutoSize = true;
            this.labelServicesPageCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelServicesPageCout.Location = new System.Drawing.Point(314, 354);
            this.labelServicesPageCout.Name = "labelServicesPageCout";
            this.labelServicesPageCout.Size = new System.Drawing.Size(36, 17);
            this.labelServicesPageCout.TabIndex = 10;
            this.labelServicesPageCout.Text = "из S";
            // 
            // numericCurrentServicePage
            // 
            this.numericCurrentServicePage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentServicePage.Location = new System.Drawing.Point(263, 355);
            this.numericCurrentServicePage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentServicePage.Name = "numericCurrentServicePage";
            this.numericCurrentServicePage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentServicePage.TabIndex = 9;
            this.numericCurrentServicePage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentServicePage.ValueChanged += new System.EventHandler(this.numericCurrentServicePage_ValueChanged);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(185, 354);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 8;
            this.label28.Text = "Страница";
            // 
            // btnNextServ
            // 
            this.btnNextServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNextServ.FlatAppearance.BorderSize = 0;
            this.btnNextServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNextServ.Location = new System.Drawing.Point(662, 342);
            this.btnNextServ.Name = "btnNextServ";
            this.btnNextServ.Size = new System.Drawing.Size(130, 40);
            this.btnNextServ.TabIndex = 4;
            this.btnNextServ.Text = "Следующая →";
            this.btnNextServ.UseVisualStyleBackColor = false;
            this.btnNextServ.Click += new System.EventHandler(this.btnNextServ_Click);
            // 
            // btnPrevServ
            // 
            this.btnPrevServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrevServ.FlatAppearance.BorderSize = 0;
            this.btnPrevServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrevServ.Location = new System.Drawing.Point(0, 342);
            this.btnPrevServ.Name = "btnPrevServ";
            this.btnPrevServ.Size = new System.Drawing.Size(130, 40);
            this.btnPrevServ.TabIndex = 3;
            this.btnPrevServ.Text = "← Предыдущая";
            this.btnPrevServ.UseVisualStyleBackColor = false;
            this.btnPrevServ.Click += new System.EventHandler(this.btnPrevServ_Click);
            // 
            // dataServies
            // 
            this.dataServies.AllowUserToAddRows = false;
            this.dataServies.AllowUserToDeleteRows = false;
            this.dataServies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataServies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataServies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataServies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column7});
            this.dataServies.Location = new System.Drawing.Point(0, 7);
            this.dataServies.Name = "dataServies";
            this.dataServies.ReadOnly = true;
            this.dataServies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataServies.Size = new System.Drawing.Size(792, 329);
            this.dataServies.TabIndex = 1;
            this.dataServies.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataServies_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Примерное время (одной)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Сделано";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FormOrderServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(792, 382);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrderServices";
            this.Text = "Услуги в заказе";
            this.Load += new System.EventHandler(this.FormOrderServices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentServicePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxShowServicesRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelServicesPageCout;
        private System.Windows.Forms.NumericUpDown numericCurrentServicePage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNextServ;
        private System.Windows.Forms.Button btnPrevServ;
        private System.Windows.Forms.DataGridView dataServies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
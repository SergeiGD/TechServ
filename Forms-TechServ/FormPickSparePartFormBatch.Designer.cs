
namespace Forms_TechServ
{
    partial class FormPickSparePartFormBatch
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
            this.labelPagesCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupSearchBy = new System.Windows.Forms.GroupBox();
            this.radioBtnWorkshop = new System.Windows.Forms.RadioButton();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.tbBatch = new System.Windows.Forms.TextBox();
            this.btnCleanBatch = new FontAwesome.Sharp.IconButton();
            this.btnCleanWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnFindBatch = new FontAwesome.Sharp.IconButton();
            this.radioBtnBatch = new System.Windows.Forms.RadioButton();
            this.btnFindWorkshop = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pickBtn = new Forms_TechServ.ManageButton();
            this.findBtn = new Forms_TechServ.ManageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupSearchBy.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelPagesCount);
            this.panel1.Controls.Add(this.numericCurrentPage);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 438);
            this.panel1.TabIndex = 0;
            // 
            // labelPagesCount
            // 
            this.labelPagesCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPagesCount.AutoSize = true;
            this.labelPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPagesCount.Location = new System.Drawing.Point(391, 410);
            this.labelPagesCount.Name = "labelPagesCount";
            this.labelPagesCount.Size = new System.Drawing.Size(36, 17);
            this.labelPagesCount.TabIndex = 153;
            this.labelPagesCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(340, 411);
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 152;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.Location = new System.Drawing.Point(262, 410);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 17);
            this.label28.TabIndex = 151;
            this.label28.Text = "Страница";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(569, 398);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 40);
            this.btnNext.TabIndex = 150;
            this.btnNext.Text = "Следующая →";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrev.Location = new System.Drawing.Point(0, 398);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 40);
            this.btnPrev.TabIndex = 149;
            this.btnPrev.Text = "← Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 321);
            this.dataGridView1.TabIndex = 148;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id поставки";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "трэкномер";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "адрес мастерской";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "кол-во доступных деталей";
            this.Column3.Name = "Column3";
            // 
            // groupSearchBy
            // 
            this.groupSearchBy.Controls.Add(this.radioBtnWorkshop);
            this.groupSearchBy.Controls.Add(this.tbWorkshop);
            this.groupSearchBy.Controls.Add(this.tbBatch);
            this.groupSearchBy.Controls.Add(this.btnCleanBatch);
            this.groupSearchBy.Controls.Add(this.btnCleanWorkshop);
            this.groupSearchBy.Controls.Add(this.btnFindBatch);
            this.groupSearchBy.Controls.Add(this.radioBtnBatch);
            this.groupSearchBy.Controls.Add(this.btnFindWorkshop);
            this.groupSearchBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSearchBy.Location = new System.Drawing.Point(0, 0);
            this.groupSearchBy.Name = "groupSearchBy";
            this.groupSearchBy.Size = new System.Drawing.Size(699, 72);
            this.groupSearchBy.TabIndex = 147;
            this.groupSearchBy.TabStop = false;
            this.groupSearchBy.Text = "Искать по";
            // 
            // radioBtnWorkshop
            // 
            this.radioBtnWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnWorkshop.AutoSize = true;
            this.radioBtnWorkshop.Location = new System.Drawing.Point(419, 31);
            this.radioBtnWorkshop.Name = "radioBtnWorkshop";
            this.radioBtnWorkshop.Size = new System.Drawing.Size(87, 17);
            this.radioBtnWorkshop.TabIndex = 2;
            this.radioBtnWorkshop.TabStop = true;
            this.radioBtnWorkshop.Text = "Мастерской";
            this.radioBtnWorkshop.UseVisualStyleBackColor = true;
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(512, 30);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(126, 20);
            this.tbWorkshop.TabIndex = 146;
            // 
            // tbBatch
            // 
            this.tbBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBatch.Enabled = false;
            this.tbBatch.Location = new System.Drawing.Point(86, 30);
            this.tbBatch.Name = "tbBatch";
            this.tbBatch.ReadOnly = true;
            this.tbBatch.Size = new System.Drawing.Size(129, 20);
            this.tbBatch.TabIndex = 142;
            // 
            // btnCleanBatch
            // 
            this.btnCleanBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanBatch.FlatAppearance.BorderSize = 0;
            this.btnCleanBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanBatch.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanBatch.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanBatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanBatch.IconSize = 17;
            this.btnCleanBatch.Location = new System.Drawing.Point(245, 32);
            this.btnCleanBatch.Name = "btnCleanBatch";
            this.btnCleanBatch.Size = new System.Drawing.Size(18, 18);
            this.btnCleanBatch.TabIndex = 140;
            this.btnCleanBatch.UseVisualStyleBackColor = true;
            // 
            // btnCleanWorkshop
            // 
            this.btnCleanWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanWorkshop.FlatAppearance.BorderSize = 0;
            this.btnCleanWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanWorkshop.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanWorkshop.IconSize = 17;
            this.btnCleanWorkshop.Location = new System.Drawing.Point(668, 33);
            this.btnCleanWorkshop.Name = "btnCleanWorkshop";
            this.btnCleanWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnCleanWorkshop.TabIndex = 144;
            this.btnCleanWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnFindBatch
            // 
            this.btnFindBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindBatch.FlatAppearance.BorderSize = 0;
            this.btnFindBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBatch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindBatch.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindBatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindBatch.IconSize = 17;
            this.btnFindBatch.Location = new System.Drawing.Point(221, 32);
            this.btnFindBatch.Name = "btnFindBatch";
            this.btnFindBatch.Size = new System.Drawing.Size(18, 18);
            this.btnFindBatch.TabIndex = 141;
            this.btnFindBatch.UseVisualStyleBackColor = true;
            this.btnFindBatch.Click += new System.EventHandler(this.btnFindBatch_Click);
            // 
            // radioBtnBatch
            // 
            this.radioBtnBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnBatch.AutoSize = true;
            this.radioBtnBatch.Location = new System.Drawing.Point(6, 31);
            this.radioBtnBatch.Name = "radioBtnBatch";
            this.radioBtnBatch.Size = new System.Drawing.Size(74, 17);
            this.radioBtnBatch.TabIndex = 1;
            this.radioBtnBatch.TabStop = true;
            this.radioBtnBatch.Text = "Поставке";
            this.radioBtnBatch.UseVisualStyleBackColor = true;
            // 
            // btnFindWorkshop
            // 
            this.btnFindWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFindWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindWorkshop.IconSize = 17;
            this.btnFindWorkshop.Location = new System.Drawing.Point(644, 33);
            this.btnFindWorkshop.Name = "btnFindWorkshop";
            this.btnFindWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnFindWorkshop.TabIndex = 145;
            this.btnFindWorkshop.UseVisualStyleBackColor = true;
            this.btnFindWorkshop.Click += new System.EventHandler(this.btnFindWorkshop_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.panel4.Controls.Add(this.pickBtn);
            this.panel4.Controls.Add(this.findBtn);
            this.panel4.Location = new System.Drawing.Point(699, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 438);
            this.panel4.TabIndex = 6;
            // 
            // pickBtn
            // 
            this.pickBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.pickBtn.FlatAppearance.BorderSize = 0;
            this.pickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pickBtn.Location = new System.Drawing.Point(0, 40);
            this.pickBtn.Name = "pickBtn";
            this.pickBtn.Size = new System.Drawing.Size(141, 40);
            this.pickBtn.TabIndex = 2;
            this.pickBtn.Text = "Выбрать";
            this.pickBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pickBtn.UseVisualStyleBackColor = false;
            this.pickBtn.Click += new System.EventHandler(this.pickBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.findBtn.FlatAppearance.BorderSize = 0;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.findBtn.Location = new System.Drawing.Point(0, 0);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(141, 40);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Найти";
            this.findBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupSearchBy);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 72);
            this.panel2.TabIndex = 154;
            // 
            // FormPickSparePartFormBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(841, 437);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FormPickSparePartFormBatch";
            this.Text = "FormPickSparePartFormBatch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupSearchBy.ResumeLayout(false);
            this.groupSearchBy.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbBatch;
        private FontAwesome.Sharp.IconButton btnCleanBatch;
        private FontAwesome.Sharp.IconButton btnFindBatch;
        private System.Windows.Forms.TextBox tbWorkshop;
        private FontAwesome.Sharp.IconButton btnCleanWorkshop;
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupSearchBy;
        private System.Windows.Forms.RadioButton radioBtnWorkshop;
        private System.Windows.Forms.RadioButton radioBtnBatch;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelPagesCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel4;
        private ManageButton pickBtn;
        private ManageButton findBtn;
        private System.Windows.Forms.Panel panel2;
    }
}
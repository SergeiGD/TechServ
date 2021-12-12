
namespace Forms_TechServ
{
    partial class FormManageSparePart
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.checkPrepayment = new System.Windows.Forms.CheckBox();
            this.numericPrepayment = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.sparePartTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewBatch = new Forms_TechServ.ManageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dataStock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrepayment)).BeginInit();
            this.sparePartTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наименование:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(110, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(110, 20);
            this.tbName.TabIndex = 9;
            // 
            // checkPrepayment
            // 
            this.checkPrepayment.AutoSize = true;
            this.checkPrepayment.Location = new System.Drawing.Point(21, 70);
            this.checkPrepayment.Name = "checkPrepayment";
            this.checkPrepayment.Size = new System.Drawing.Size(87, 17);
            this.checkPrepayment.TabIndex = 10;
            this.checkPrepayment.Text = "Предоплата";
            this.checkPrepayment.UseVisualStyleBackColor = true;
            this.checkPrepayment.CheckedChanged += new System.EventHandler(this.checkPrepayment_CheckedChanged);
            // 
            // numericPrepayment
            // 
            this.numericPrepayment.Location = new System.Drawing.Point(110, 69);
            this.numericPrepayment.Name = "numericPrepayment";
            this.numericPrepayment.Size = new System.Drawing.Size(110, 20);
            this.numericPrepayment.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(276, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 35);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(276, 12);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(96, 35);
            this.btnAction.TabIndex = 42;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // sparePartTabs
            // 
            this.sparePartTabs.Controls.Add(this.generalPage);
            this.sparePartTabs.Controls.Add(this.stockPage);
            this.sparePartTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sparePartTabs.Location = new System.Drawing.Point(0, 0);
            this.sparePartTabs.Name = "sparePartTabs";
            this.sparePartTabs.SelectedIndex = 0;
            this.sparePartTabs.Size = new System.Drawing.Size(973, 369);
            this.sparePartTabs.TabIndex = 44;
            this.sparePartTabs.SelectedIndexChanged += new System.EventHandler(this.sparePartTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.label3);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.tbName);
            this.generalPage.Controls.Add(this.btnAction);
            this.generalPage.Controls.Add(this.checkPrepayment);
            this.generalPage.Controls.Add(this.numericPrepayment);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(965, 343);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // stockPage
            // 
            this.stockPage.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.stockPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.stockPage.Controls.Add(this.panel2);
            this.stockPage.Controls.Add(this.panel1);
            this.stockPage.Location = new System.Drawing.Point(4, 22);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(965, 343);
            this.stockPage.TabIndex = 1;
            this.stockPage.Text = "Наличие";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnNewBatch);
            this.panel2.Location = new System.Drawing.Point(822, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 347);
            this.panel2.TabIndex = 1;
            // 
            // btnNewBatch
            // 
            this.btnNewBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNewBatch.FlatAppearance.BorderSize = 0;
            this.btnNewBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNewBatch.Location = new System.Drawing.Point(0, 0);
            this.btnNewBatch.Name = "btnNewBatch";
            this.btnNewBatch.Size = new System.Drawing.Size(143, 33);
            this.btnNewBatch.TabIndex = 2;
            this.btnNewBatch.Text = "Заказать";
            this.btnNewBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBatch.UseVisualStyleBackColor = false;
            this.btnNewBatch.Click += new System.EventHandler(this.btnAddToBatch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxShowRows);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.labelPageCount);
            this.panel1.Controls.Add(this.numericCurrentPage);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataStock);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 337);
            this.panel1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(692, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 40);
            this.btnNext.TabIndex = 15;
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
            this.btnPrev.Location = new System.Drawing.Point(0, 303);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 40);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "← Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // labelPageCount
            // 
            this.labelPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPageCount.Location = new System.Drawing.Point(337, 315);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 13;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(286, 316);
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(208, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Страница";
            // 
            // dataStock
            // 
            this.dataStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataStock.Location = new System.Drawing.Point(0, 0);
            this.dataStock.Name = "dataStock";
            this.dataStock.Size = new System.Drawing.Size(822, 303);
            this.dataStock.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id мастерской";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "адрес мастерской";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "телефон мастерской";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "кол-во деталей";
            this.Column4.Name = "Column4";
            // 
            // comboBoxShowRows
            // 
            this.comboBoxShowRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowRows.FormattingEnabled = true;
            this.comboBoxShowRows.Location = new System.Drawing.Point(550, 314);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(437, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Показывать по";
            // 
            // FormManageSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(973, 369);
            this.Controls.Add(this.sparePartTabs);
            this.MaximizeBox = false;
            this.Name = "FormManageSparePart";
            this.Text = "FormManageSparePart";
            this.Load += new System.EventHandler(this.FormManageSparePart_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageSparePart_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrepayment)).EndInit();
            this.sparePartTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.stockPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox checkPrepayment;
        private System.Windows.Forms.NumericUpDown numericPrepayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TabControl sparePartTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Panel panel2;
        private ManageButton btnNewBatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label1;
    }
}
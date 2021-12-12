
namespace Forms_TechServ
{
    partial class FormManageBatch
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
            this.batchTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.checkDelivered = new System.Windows.Forms.CheckBox();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.btnCleanWorkshop = new FontAwesome.Sharp.IconButton();
            this.btnFindWorkshop = new FontAwesome.Sharp.IconButton();
            this.tbTrackNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sparePartsPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowSparePart = new Forms_TechServ.ManageButton();
            this.btnDeleteSparePart = new Forms_TechServ.ManageButton();
            this.btnAddSparePart = new Forms_TechServ.ManageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShowSparePartsRows = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dataSpareParts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.sparePartsPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).BeginInit();
            this.SuspendLayout();
            // 
            // batchTabs
            // 
            this.batchTabs.Controls.Add(this.generalPage);
            this.batchTabs.Controls.Add(this.sparePartsPage);
            this.batchTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batchTabs.Location = new System.Drawing.Point(0, 0);
            this.batchTabs.Name = "batchTabs";
            this.batchTabs.SelectedIndex = 0;
            this.batchTabs.Size = new System.Drawing.Size(788, 358);
            this.batchTabs.TabIndex = 13;
            this.batchTabs.SelectedIndexChanged += new System.EventHandler(this.batchTabs_SelectedIndexChanged);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.generalPage.Controls.Add(this.cancelBtn);
            this.generalPage.Controls.Add(this.actionBtn);
            this.generalPage.Controls.Add(this.checkDelivered);
            this.generalPage.Controls.Add(this.tbWorkshop);
            this.generalPage.Controls.Add(this.btnCleanWorkshop);
            this.generalPage.Controls.Add(this.btnFindWorkshop);
            this.generalPage.Controls.Add(this.tbTrackNum);
            this.generalPage.Controls.Add(this.label1);
            this.generalPage.Controls.Add(this.label4);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(780, 332);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Общая информация";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(302, 91);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 37);
            this.cancelBtn.TabIndex = 134;
            this.cancelBtn.Text = "ОТМЕНИТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // actionBtn
            // 
            this.actionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionBtn.Location = new System.Drawing.Point(302, 21);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(97, 37);
            this.actionBtn.TabIndex = 133;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            // 
            // checkDelivered
            // 
            this.checkDelivered.AutoSize = true;
            this.checkDelivered.Location = new System.Drawing.Point(26, 111);
            this.checkDelivered.Name = "checkDelivered";
            this.checkDelivered.Size = new System.Drawing.Size(72, 17);
            this.checkDelivered.TabIndex = 132;
            this.checkDelivered.Text = "Прибыла";
            this.checkDelivered.UseVisualStyleBackColor = true;
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.Enabled = false;
            this.tbWorkshop.Location = new System.Drawing.Point(114, 70);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.ReadOnly = true;
            this.tbWorkshop.Size = new System.Drawing.Size(117, 20);
            this.tbWorkshop.TabIndex = 131;
            // 
            // btnCleanWorkshop
            // 
            this.btnCleanWorkshop.FlatAppearance.BorderSize = 0;
            this.btnCleanWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanWorkshop.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCleanWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCleanWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCleanWorkshop.IconSize = 17;
            this.btnCleanWorkshop.Location = new System.Drawing.Point(261, 72);
            this.btnCleanWorkshop.Name = "btnCleanWorkshop";
            this.btnCleanWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnCleanWorkshop.TabIndex = 129;
            this.btnCleanWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnFindWorkshop
            // 
            this.btnFindWorkshop.FlatAppearance.BorderSize = 0;
            this.btnFindWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWorkshop.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindWorkshop.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnFindWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindWorkshop.IconSize = 17;
            this.btnFindWorkshop.Location = new System.Drawing.Point(237, 72);
            this.btnFindWorkshop.Name = "btnFindWorkshop";
            this.btnFindWorkshop.Size = new System.Drawing.Size(18, 18);
            this.btnFindWorkshop.TabIndex = 130;
            this.btnFindWorkshop.UseVisualStyleBackColor = true;
            this.btnFindWorkshop.Click += new System.EventHandler(this.btnFindWorkshop_Click);
            // 
            // tbTrackNum
            // 
            this.tbTrackNum.Location = new System.Drawing.Point(114, 30);
            this.tbTrackNum.Name = "tbTrackNum";
            this.tbTrackNum.Size = new System.Drawing.Size(117, 20);
            this.tbTrackNum.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "Мастерская:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Трэкномер:";
            // 
            // sparePartsPage
            // 
            this.sparePartsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.sparePartsPage.Controls.Add(this.panel2);
            this.sparePartsPage.Controls.Add(this.panel1);
            this.sparePartsPage.Location = new System.Drawing.Point(4, 22);
            this.sparePartsPage.Name = "sparePartsPage";
            this.sparePartsPage.Padding = new System.Windows.Forms.Padding(3);
            this.sparePartsPage.Size = new System.Drawing.Size(780, 332);
            this.sparePartsPage.TabIndex = 1;
            this.sparePartsPage.Text = "Детали";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnShowSparePart);
            this.panel2.Controls.Add(this.btnDeleteSparePart);
            this.panel2.Controls.Add(this.btnAddSparePart);
            this.panel2.Location = new System.Drawing.Point(631, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 331);
            this.panel2.TabIndex = 2;
            // 
            // btnShowSparePart
            // 
            this.btnShowSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowSparePart.FlatAppearance.BorderSize = 0;
            this.btnShowSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowSparePart.Location = new System.Drawing.Point(0, 79);
            this.btnShowSparePart.Name = "btnShowSparePart";
            this.btnShowSparePart.Size = new System.Drawing.Size(153, 33);
            this.btnShowSparePart.TabIndex = 4;
            this.btnShowSparePart.Text = "Просмотреть";
            this.btnShowSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowSparePart.UseVisualStyleBackColor = false;
            this.btnShowSparePart.Click += new System.EventHandler(this.btnShowSparePart_Click);
            // 
            // btnDeleteSparePart
            // 
            this.btnDeleteSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDeleteSparePart.FlatAppearance.BorderSize = 0;
            this.btnDeleteSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteSparePart.Location = new System.Drawing.Point(0, 40);
            this.btnDeleteSparePart.Name = "btnDeleteSparePart";
            this.btnDeleteSparePart.Size = new System.Drawing.Size(153, 33);
            this.btnDeleteSparePart.TabIndex = 3;
            this.btnDeleteSparePart.Text = "Удалить";
            this.btnDeleteSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSparePart.UseVisualStyleBackColor = false;
            // 
            // btnAddSparePart
            // 
            this.btnAddSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAddSparePart.FlatAppearance.BorderSize = 0;
            this.btnAddSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddSparePart.Location = new System.Drawing.Point(0, 0);
            this.btnAddSparePart.Name = "btnAddSparePart";
            this.btnAddSparePart.Size = new System.Drawing.Size(153, 33);
            this.btnAddSparePart.TabIndex = 2;
            this.btnAddSparePart.Text = "Добавить";
            this.btnAddSparePart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSparePart.UseVisualStyleBackColor = false;
            this.btnAddSparePart.Click += new System.EventHandler(this.btnAddSparePart_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxShowSparePartsRows);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.labelPageCount);
            this.panel1.Controls.Add(this.numericCurrentPage);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataSpareParts);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 331);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxShowSparePartsRows
            // 
            this.comboBoxShowSparePartsRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowSparePartsRows.FormattingEnabled = true;
            this.comboBoxShowSparePartsRows.Location = new System.Drawing.Point(433, 302);
            this.comboBoxShowSparePartsRows.Name = "comboBoxShowSparePartsRows";
            this.comboBoxShowSparePartsRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowSparePartsRows.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(320, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Показывать по";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(501, 290);
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
            this.btnPrev.Location = new System.Drawing.Point(0, 290);
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
            this.labelPageCount.Location = new System.Drawing.Point(265, 302);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 13;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(214, 303);
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(136, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Страница";
            // 
            // dataSpareParts
            // 
            this.dataSpareParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSpareParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSpareParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpareParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataSpareParts.Location = new System.Drawing.Point(0, 0);
            this.dataSpareParts.Name = "dataSpareParts";
            this.dataSpareParts.Size = new System.Drawing.Size(631, 290);
            this.dataSpareParts.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id детали";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "название детали";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "цена за на 1 ед.";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "кол-во деталей";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Общая цена";
            this.Column5.Name = "Column5";
            // 
            // FormManageBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(788, 358);
            this.Controls.Add(this.batchTabs);
            this.MaximizeBox = false;
            this.Name = "FormManageBatch";
            this.Text = "FormManageBatch";
            this.Load += new System.EventHandler(this.FormManageBatch_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageBatch_ResizeEnd);
            this.batchTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.sparePartsPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl batchTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TextBox tbTrackNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage sparePartsPage;
        private System.Windows.Forms.Panel panel2;
        private ManageButton btnShowSparePart;
        private ManageButton btnDeleteSparePart;
        private ManageButton btnAddSparePart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataSpareParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox tbWorkshop;
        private FontAwesome.Sharp.IconButton btnCleanWorkshop;
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private System.Windows.Forms.CheckBox checkDelivered;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.ComboBox comboBoxShowSparePartsRows;
        private System.Windows.Forms.Label label7;
    }
}
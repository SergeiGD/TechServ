
using Forms_TechServ.forms.customControls;

namespace Forms_TechServ.forms.batches
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
            this.components = new System.ComponentModel.Container();
            this.batchTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.checkConfirmed = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.checkDelivered = new System.Windows.Forms.CheckBox();
            this.tbWorkshop = new System.Windows.Forms.TextBox();
            this.btnFindWorkshop = new FontAwesome.Sharp.IconButton();
            this.tbTrackNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sparePartsPage = new System.Windows.Forms.TabPage();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnShow = new ManageButton();
            this.btnDel = new ManageButton();
            this.btnAdd = new ManageButton();
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
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.batchTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.sparePartsPage.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.generalPage.Controls.Add(this.checkConfirmed);
            this.generalPage.Controls.Add(this.btnCancel);
            this.generalPage.Controls.Add(this.btnAction);
            this.generalPage.Controls.Add(this.checkDelivered);
            this.generalPage.Controls.Add(this.tbWorkshop);
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
            // checkConfirmed
            // 
            this.checkConfirmed.AutoSize = true;
            this.checkConfirmed.Location = new System.Drawing.Point(26, 112);
            this.checkConfirmed.Name = "checkConfirmed";
            this.checkConfirmed.Size = new System.Drawing.Size(101, 17);
            this.checkConfirmed.TabIndex = 135;
            this.checkConfirmed.Text = "Подтверждена";
            this.checkConfirmed.UseVisualStyleBackColor = true;
            this.checkConfirmed.CheckedChanged += new System.EventHandler(this.checkConfirmed_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(302, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 45);
            this.btnCancel.TabIndex = 134;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(302, 30);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(116, 45);
            this.btnAction.TabIndex = 133;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // checkDelivered
            // 
            this.checkDelivered.AutoSize = true;
            this.checkDelivered.Location = new System.Drawing.Point(26, 153);
            this.checkDelivered.Name = "checkDelivered";
            this.checkDelivered.Size = new System.Drawing.Size(72, 17);
            this.checkDelivered.TabIndex = 132;
            this.checkDelivered.Text = "Прибыла";
            this.checkDelivered.UseVisualStyleBackColor = true;
            this.checkDelivered.CheckedChanged += new System.EventHandler(this.checkDelivered_CheckedChanged);
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
            this.sparePartsPage.Controls.Add(this.panelControl);
            this.sparePartsPage.Controls.Add(this.panel1);
            this.sparePartsPage.Location = new System.Drawing.Point(4, 22);
            this.sparePartsPage.Name = "sparePartsPage";
            this.sparePartsPage.Padding = new System.Windows.Forms.Padding(3);
            this.sparePartsPage.Size = new System.Drawing.Size(780, 332);
            this.sparePartsPage.TabIndex = 1;
            this.sparePartsPage.Text = "Детали";
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.btnShow);
            this.panelControl.Controls.Add(this.btnDel);
            this.panelControl.Controls.Add(this.btnAdd);
            this.panelControl.Location = new System.Drawing.Point(631, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(153, 331);
            this.panelControl.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShow.Location = new System.Drawing.Point(0, 92);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(153, 40);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Просмотреть";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShowSparePart_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDel.Location = new System.Drawing.Point(0, 46);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 40);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDeleteSparePart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAddSparePart_Click);
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
            this.comboBoxShowSparePartsRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowSparePartsRows.FormattingEnabled = true;
            this.comboBoxShowSparePartsRows.Location = new System.Drawing.Point(433, 302);
            this.comboBoxShowSparePartsRows.Name = "comboBoxShowSparePartsRows";
            this.comboBoxShowSparePartsRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowSparePartsRows.TabIndex = 17;
            this.comboBoxShowSparePartsRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowSparePartsRows_SelectedIndexChanged);
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
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            this.numericCurrentPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 12;
            this.numericCurrentPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.ValueChanged += new System.EventHandler(this.numericCurrentPage_ValueChanged);
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
            this.dataSpareParts.AllowUserToAddRows = false;
            this.dataSpareParts.AllowUserToDeleteRows = false;
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
            this.Column5,
            this.delCol});
            this.dataSpareParts.Location = new System.Drawing.Point(0, 0);
            this.dataSpareParts.Name = "dataSpareParts";
            this.dataSpareParts.ReadOnly = true;
            this.dataSpareParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSpareParts.Size = new System.Drawing.Size(631, 290);
            this.dataSpareParts.TabIndex = 0;
            this.dataSpareParts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataSpareParts_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id детали";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "название детали";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "цена за на 1 ед.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "кол-во деталей";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Общая цена";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // delCol
            // 
            this.delCol.HeaderText = "Удалить";
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
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
            this.Text = "Формирование поставки";
            this.Load += new System.EventHandler(this.FormManageBatch_Load);
            this.ResizeEnd += new System.EventHandler(this.FormManageBatch_ResizeEnd);
            this.batchTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            this.sparePartsPage.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpareParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl batchTabs;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TextBox tbTrackNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage sparePartsPage;
        private System.Windows.Forms.Panel panelControl;
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
        private FontAwesome.Sharp.IconButton btnFindWorkshop;
        private System.Windows.Forms.CheckBox checkDelivered;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox comboBoxShowSparePartsRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private ManageButton btnShow;
        private ManageButton btnDel;
        private ManageButton btnAdd;
        private System.Windows.Forms.DataGridViewButtonColumn delCol;
        private System.Windows.Forms.CheckBox checkConfirmed;
    }
}
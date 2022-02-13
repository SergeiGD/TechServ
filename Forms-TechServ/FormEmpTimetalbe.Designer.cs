
namespace Forms_TechServ
{
    partial class FormEmpTimetalbe
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
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.datePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataTimetable = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnClean = new Forms_TechServ.ManageButton();
            this.btnFind = new Forms_TechServ.ManageButton();
            this.btnIdInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipIdInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxShowRows
            // 
            this.comboBoxShowRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowRows.FormattingEnabled = true;
            this.comboBoxShowRows.Location = new System.Drawing.Point(536, 596);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 16;
            this.comboBoxShowRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowRows_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(423, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Показывать по";
            // 
            // labelPageCount
            // 
            this.labelPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPageCount.Location = new System.Drawing.Point(324, 597);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 10;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(273, 598);
            this.numericCurrentPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.Name = "numericCurrentPage";
            this.numericCurrentPage.Size = new System.Drawing.Size(45, 20);
            this.numericCurrentPage.TabIndex = 9;
            this.numericCurrentPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrentPage.ValueChanged += new System.EventHandler(this.numericCurrentPage_ValueChanged);
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(88, 18);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(79, 20);
            this.tbID.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "ID смены:";
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.comboBoxShowRows);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.labelPageCount);
            this.panelContent.Controls.Add(this.numericCurrentPage);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.panelFind);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataTimetable);
            this.panelContent.Location = new System.Drawing.Point(2, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 632);
            this.panelContent.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(195, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Страница";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.btnIdInfo);
            this.panelFind.Controls.Add(this.datePickerFrom);
            this.panelFind.Controls.Add(this.label14);
            this.panelFind.Controls.Add(this.datePickerUntil);
            this.panelFind.Controls.Add(this.label15);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label3);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 58);
            this.panelFind.TabIndex = 4;
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datePickerFrom.Location = new System.Drawing.Point(327, 18);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(130, 20);
            this.datePickerFrom.TabIndex = 126;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(559, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 125;
            this.label14.Text = "Дата до:";
            // 
            // datePickerUntil
            // 
            this.datePickerUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerUntil.Location = new System.Drawing.Point(616, 18);
            this.datePickerUntil.Name = "datePickerUntil";
            this.datePickerUntil.Size = new System.Drawing.Size(130, 20);
            this.datePickerUntil.TabIndex = 124;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 123;
            this.label15.Text = "Дата от:";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(648, 580);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 50);
            this.btnNext.TabIndex = 3;
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
            this.btnPrev.Location = new System.Drawing.Point(0, 580);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 50);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "← Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dataTimetable
            // 
            this.dataTimetable.AllowUserToAddRows = false;
            this.dataTimetable.AllowUserToDeleteRows = false;
            this.dataTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimetable.Location = new System.Drawing.Point(0, 57);
            this.dataTimetable.Name = "dataTimetable";
            this.dataTimetable.ReadOnly = true;
            this.dataTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTimetable.Size = new System.Drawing.Size(778, 523);
            this.dataTimetable.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.btnClean);
            this.panelControl.Controls.Add(this.btnFind);
            this.panelControl.Location = new System.Drawing.Point(780, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(190, 632);
            this.panelControl.TabIndex = 11;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClean.Location = new System.Drawing.Point(0, 40);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(190, 40);
            this.btnClean.TabIndex = 24;
            this.btnClean.Text = "Отчистить фильтры";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(0, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(190, 40);
            this.btnFind.TabIndex = 23;
            this.btnFind.Text = "Найти";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnIdInfo
            // 
            this.btnIdInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIdInfo.FlatAppearance.BorderSize = 0;
            this.btnIdInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnIdInfo.IconColor = System.Drawing.Color.Black;
            this.btnIdInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIdInfo.IconSize = 20;
            this.btnIdInfo.Location = new System.Drawing.Point(173, 18);
            this.btnIdInfo.Name = "btnIdInfo";
            this.btnIdInfo.Size = new System.Drawing.Size(27, 21);
            this.btnIdInfo.TabIndex = 158;
            this.btnIdInfo.UseVisualStyleBackColor = true;
            this.btnIdInfo.MouseHover += new System.EventHandler(this.btnIdInfo_MouseHover);
            // 
            // FormEmpTimetalbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(970, 634);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelControl);
            this.Name = "FormEmpTimetalbe";
            this.Text = "Расписания сотрудников";
            this.Load += new System.EventHandler(this.FormEmpTimetalbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimetable)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipCurrentSort;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataTimetable;
        private ManageButton btnClean;
        private ManageButton btnFind;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker datePickerUntil;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton btnIdInfo;
        private System.Windows.Forms.ToolTip toolTipIdInfo;
    }
}
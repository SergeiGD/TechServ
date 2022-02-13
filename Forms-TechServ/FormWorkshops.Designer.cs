
namespace Forms_TechServ
{
    partial class FormWorkshops
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnAskOrDesk = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataWorkshops = new System.Windows.Forms.DataGridView();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxShowRows = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.numericCurrentPage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.clearBtn = new Forms_TechServ.ManageButton();
            this.searchBtn = new Forms_TechServ.ManageButton();
            this.toolTipCurrentSort = new System.Windows.Forms.ToolTip(this.components);
            this.btnIdInfo = new FontAwesome.Sharp.IconButton();
            this.toolTipIdInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkshops)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(604, 11);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(144, 20);
            this.tbAddress.TabIndex = 16;
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.Controls.Add(this.btnIdInfo);
            this.panelFind.Controls.Add(this.btnAskOrDesk);
            this.panelFind.Controls.Add(this.comboBoxSortBy);
            this.panelFind.Controls.Add(this.label10);
            this.panelFind.Controls.Add(this.tbID);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.tbPhoneNum);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.tbAddress);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(778, 80);
            this.panelFind.TabIndex = 4;
            // 
            // btnAskOrDesk
            // 
            this.btnAskOrDesk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAskOrDesk.FlatAppearance.BorderSize = 0;
            this.btnAskOrDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAskOrDesk.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.btnAskOrDesk.IconColor = System.Drawing.Color.Black;
            this.btnAskOrDesk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAskOrDesk.IconSize = 20;
            this.btnAskOrDesk.Location = new System.Drawing.Point(232, 50);
            this.btnAskOrDesk.Name = "btnAskOrDesk";
            this.btnAskOrDesk.Size = new System.Drawing.Size(27, 21);
            this.btnAskOrDesk.TabIndex = 156;
            this.btnAskOrDesk.UseVisualStyleBackColor = true;
            this.btnAskOrDesk.Click += new System.EventHandler(this.btnAskOrDesk_Click);
            this.btnAskOrDesk.MouseHover += new System.EventHandler(this.btnAskOrDesk_MouseHover);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(114, 48);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(112, 21);
            this.comboBoxSortBy.TabIndex = 155;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 154;
            this.label10.Text = "Сортировка:";
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Location = new System.Drawing.Point(114, 11);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(79, 20);
            this.tbID.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID мастерской";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneNum.Location = new System.Drawing.Point(604, 51);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(144, 20);
            this.tbPhoneNum.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Адрес мастерской";
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
            // dataWorkshops
            // 
            this.dataWorkshops.AllowUserToAddRows = false;
            this.dataWorkshops.AllowUserToDeleteRows = false;
            this.dataWorkshops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataWorkshops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataWorkshops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWorkshops.Location = new System.Drawing.Point(0, 80);
            this.dataWorkshops.Name = "dataWorkshops";
            this.dataWorkshops.ReadOnly = true;
            this.dataWorkshops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataWorkshops.Size = new System.Drawing.Size(778, 500);
            this.dataWorkshops.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.comboBoxShowRows);
            this.panelContent.Controls.Add(this.label9);
            this.panelContent.Controls.Add(this.labelPageCount);
            this.panelContent.Controls.Add(this.numericCurrentPage);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.panelFind);
            this.panelContent.Controls.Add(this.btnNext);
            this.panelContent.Controls.Add(this.btnPrev);
            this.panelContent.Controls.Add(this.dataWorkshops);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 632);
            this.panelContent.TabIndex = 6;
            // 
            // comboBoxShowRows
            // 
            this.comboBoxShowRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxShowRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowRows.FormattingEnabled = true;
            this.comboBoxShowRows.Location = new System.Drawing.Point(521, 596);
            this.comboBoxShowRows.Name = "comboBoxShowRows";
            this.comboBoxShowRows.Size = new System.Drawing.Size(62, 21);
            this.comboBoxShowRows.TabIndex = 18;
            this.comboBoxShowRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowRows_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(408, 597);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Показывать по";
            // 
            // labelPageCount
            // 
            this.labelPageCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPageCount.Location = new System.Drawing.Point(335, 597);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(36, 17);
            this.labelPageCount.TabIndex = 13;
            this.labelPageCount.Text = "из S";
            // 
            // numericCurrentPage
            // 
            this.numericCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericCurrentPage.Location = new System.Drawing.Point(284, 598);
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(206, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Страница";
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.clearBtn);
            this.panelControl.Controls.Add(this.searchBtn);
            this.panelControl.Location = new System.Drawing.Point(778, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(190, 632);
            this.panelControl.TabIndex = 7;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearBtn.Location = new System.Drawing.Point(0, 40);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(190, 40);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "Отчистить фильтры";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchBtn.Location = new System.Drawing.Point(0, 0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(190, 40);
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "Найти";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.btnIdInfo.Location = new System.Drawing.Point(199, 12);
            this.btnIdInfo.Name = "btnIdInfo";
            this.btnIdInfo.Size = new System.Drawing.Size(27, 21);
            this.btnIdInfo.TabIndex = 233;
            this.btnIdInfo.UseVisualStyleBackColor = true;
            this.btnIdInfo.MouseHover += new System.EventHandler(this.btnIdInfo_MouseHover);
            // 
            // FormWorkshops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelControl);
            this.Name = "FormWorkshops";
            this.Text = "Филиалы";
            this.Load += new System.EventHandler(this.FormWorkshops_Load);
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkshops)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentPage)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataWorkshops;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label1;
        private ManageButton searchBtn;
        private ManageButton clearBtn;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.NumericUpDown numericCurrentPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxShowRows;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAskOrDesk;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTipCurrentSort;
        private FontAwesome.Sharp.IconButton btnIdInfo;
        private System.Windows.Forms.ToolTip toolTipIdInfo;
    }
}
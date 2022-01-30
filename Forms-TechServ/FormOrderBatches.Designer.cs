
namespace Forms_TechServ
{
    partial class FormOrderBatches
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataBatches = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelBatch = new Forms_TechServ.ManageButton();
            this.btnAddBatch = new Forms_TechServ.ManageButton();
            this.btnShowBatch = new Forms_TechServ.ManageButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBatches)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataBatches);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 442);
            this.panel3.TabIndex = 8;
            // 
            // dataBatches
            // 
            this.dataBatches.AllowUserToAddRows = false;
            this.dataBatches.AllowUserToDeleteRows = false;
            this.dataBatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.dataGridViewTextBoxColumn5,
            this.Column6});
            this.dataBatches.Location = new System.Drawing.Point(0, 0);
            this.dataBatches.MultiSelect = false;
            this.dataBatches.Name = "dataBatches";
            this.dataBatches.ReadOnly = true;
            this.dataBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBatches.Size = new System.Drawing.Size(782, 439);
            this.dataBatches.TabIndex = 1;
            this.dataBatches.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataBatches_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "id поставки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Цена за ед.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Общая цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Прибыла";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnShowBatch);
            this.panel4.Controls.Add(this.btnDelBatch);
            this.panel4.Controls.Add(this.btnAddBatch);
            this.panel4.Location = new System.Drawing.Point(782, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 442);
            this.panel4.TabIndex = 9;
            // 
            // btnDelBatch
            // 
            this.btnDelBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnDelBatch.FlatAppearance.BorderSize = 0;
            this.btnDelBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelBatch.Location = new System.Drawing.Point(0, 40);
            this.btnDelBatch.Name = "btnDelBatch";
            this.btnDelBatch.Size = new System.Drawing.Size(185, 40);
            this.btnDelBatch.TabIndex = 2;
            this.btnDelBatch.Text = "Удалить";
            this.btnDelBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelBatch.UseVisualStyleBackColor = false;
            this.btnDelBatch.Click += new System.EventHandler(this.btnDelBatch_Click);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnAddBatch.FlatAppearance.BorderSize = 0;
            this.btnAddBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddBatch.Location = new System.Drawing.Point(0, 0);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(185, 40);
            this.btnAddBatch.TabIndex = 1;
            this.btnAddBatch.Text = "Добавить";
            this.btnAddBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBatch.UseVisualStyleBackColor = false;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // btnShowBatch
            // 
            this.btnShowBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnShowBatch.FlatAppearance.BorderSize = 0;
            this.btnShowBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowBatch.Location = new System.Drawing.Point(0, 80);
            this.btnShowBatch.Name = "btnShowBatch";
            this.btnShowBatch.Size = new System.Drawing.Size(185, 40);
            this.btnShowBatch.TabIndex = 3;
            this.btnShowBatch.Text = "Просмотреть поставку";
            this.btnShowBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowBatch.UseVisualStyleBackColor = false;
            this.btnShowBatch.Click += new System.EventHandler(this.btnShowBatch_Click);
            // 
            // FormOrderBatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(959, 439);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "FormOrderBatches";
            this.Text = "Используемые в заказе поставки";
            this.Load += new System.EventHandler(this.FormOrderBatches_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBatches)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataBatches;
        private System.Windows.Forms.Panel panel4;
        private ManageButton btnDelBatch;
        private ManageButton btnAddBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private ManageButton btnShowBatch;
    }
}
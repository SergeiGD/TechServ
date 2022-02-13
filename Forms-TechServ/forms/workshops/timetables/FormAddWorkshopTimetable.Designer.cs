
namespace Forms_TechServ.forms.workshops.timetables
{
    partial class FormManageWorkshopTimetable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbStart = new System.Windows.Forms.MaskedTextBox();
            this.tbEnd = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время открытия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время закрытия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Действительно с:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Действительно до:";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(170, 112);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(128, 20);
            this.datePickerFrom.TabIndex = 4;
            // 
            // datePickerUntil
            // 
            this.datePickerUntil.Location = new System.Drawing.Point(170, 157);
            this.datePickerUntil.Name = "datePickerUntil";
            this.datePickerUntil.Size = new System.Drawing.Size(128, 20);
            this.datePickerUntil.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(340, 134);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 40);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // actionBtn
            // 
            this.actionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionBtn.Location = new System.Drawing.Point(340, 18);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(111, 40);
            this.actionBtn.TabIndex = 19;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.tbStart.Location = new System.Drawing.Point(170, 13);
            this.tbStart.Mask = "00:00";
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(59, 26);
            this.tbStart.TabIndex = 21;
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStart.ValidatingType = typeof(System.DateTime);
            // 
            // tbEnd
            // 
            this.tbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.tbEnd.Location = new System.Drawing.Point(170, 61);
            this.tbEnd.Mask = "00:00";
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(59, 26);
            this.tbEnd.TabIndex = 22;
            this.tbEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEnd.ValidatingType = typeof(System.DateTime);
            // 
            // FormManageWorkshopTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(473, 193);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.datePickerUntil);
            this.Controls.Add(this.datePickerFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManageWorkshopTimetable";
            this.Text = "Формирование расписания филиала";
            this.Load += new System.EventHandler(this.FormManageWorkshopTimetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.DateTimePicker datePickerUntil;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox tbEnd;
        private System.Windows.Forms.MaskedTextBox tbStart;
    }
}
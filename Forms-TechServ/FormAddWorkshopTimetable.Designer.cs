
namespace Forms_TechServ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEndMinute = new System.Windows.Forms.TextBox();
            this.tbEndHour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStartMinute = new System.Windows.Forms.TextBox();
            this.tbStartHour = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(227, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = ":";
            // 
            // tbEndMinute
            // 
            this.tbEndMinute.Location = new System.Drawing.Point(245, 66);
            this.tbEndMinute.Name = "tbEndMinute";
            this.tbEndMinute.Size = new System.Drawing.Size(53, 20);
            this.tbEndMinute.TabIndex = 10;
            // 
            // tbEndHour
            // 
            this.tbEndHour.Location = new System.Drawing.Point(170, 66);
            this.tbEndHour.Name = "tbEndHour";
            this.tbEndHour.Size = new System.Drawing.Size(53, 20);
            this.tbEndHour.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(227, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // tbStartMinute
            // 
            this.tbStartMinute.Location = new System.Drawing.Point(245, 18);
            this.tbStartMinute.Name = "tbStartMinute";
            this.tbStartMinute.Size = new System.Drawing.Size(53, 20);
            this.tbStartMinute.TabIndex = 13;
            // 
            // tbStartHour
            // 
            this.tbStartHour.Location = new System.Drawing.Point(170, 18);
            this.tbStartHour.Name = "tbStartHour";
            this.tbStartHour.Size = new System.Drawing.Size(53, 20);
            this.tbStartHour.TabIndex = 12;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(340, 134);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 40);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "ОТМЕНИТЬ";
            this.cancelBtn.UseVisualStyleBackColor = true;
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
            // 
            // FormManageWorkshopTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(473, 193);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStartMinute);
            this.Controls.Add(this.tbStartHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEndMinute);
            this.Controls.Add(this.tbEndHour);
            this.Controls.Add(this.datePickerUntil);
            this.Controls.Add(this.datePickerFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManageWorkshopTimetable";
            this.Text = "FormAddWorkshopTimetable";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEndMinute;
        private System.Windows.Forms.TextBox tbEndHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStartMinute;
        private System.Windows.Forms.TextBox tbStartHour;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button actionBtn;
    }
}
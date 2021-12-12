
namespace Forms_TechServ
{
    partial class FormAddEmployeeTimetable
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
            this.datePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStartMinute = new System.Windows.Forms.TextBox();
            this.tbStartHour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEndMinute = new System.Windows.Forms.TextBox();
            this.tbEndHour = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSun = new System.Windows.Forms.CheckBox();
            this.checkBoxSut = new System.Windows.Forms.CheckBox();
            this.checkBoxThi = new System.Windows.Forms.CheckBox();
            this.checkBoxWen = new System.Windows.Forms.CheckBox();
            this.checkBoxTue = new System.Windows.Forms.CheckBox();
            this.checkBoxMon = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericRepeat = new System.Windows.Forms.NumericUpDown();
            this.radioBtnEndRepeat = new System.Windows.Forms.RadioButton();
            this.radioBtnEndDate = new System.Windows.Forms.RadioButton();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начиная с:";
            // 
            // datePickerBegin
            // 
            this.datePickerBegin.Location = new System.Drawing.Point(137, 21);
            this.datePickerBegin.Name = "datePickerBegin";
            this.datePickerBegin.Size = new System.Drawing.Size(128, 20);
            this.datePickerBegin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начало смены:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Конец смены:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(194, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // tbStartMinute
            // 
            this.tbStartMinute.Location = new System.Drawing.Point(212, 64);
            this.tbStartMinute.Name = "tbStartMinute";
            this.tbStartMinute.Size = new System.Drawing.Size(53, 20);
            this.tbStartMinute.TabIndex = 13;
            // 
            // tbStartHour
            // 
            this.tbStartHour.Location = new System.Drawing.Point(137, 64);
            this.tbStartHour.Name = "tbStartHour";
            this.tbStartHour.Size = new System.Drawing.Size(53, 20);
            this.tbStartHour.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(194, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = ":";
            // 
            // tbEndMinute
            // 
            this.tbEndMinute.Location = new System.Drawing.Point(212, 109);
            this.tbEndMinute.Name = "tbEndMinute";
            this.tbEndMinute.Size = new System.Drawing.Size(53, 20);
            this.tbEndMinute.TabIndex = 16;
            // 
            // tbEndHour
            // 
            this.tbEndHour.Location = new System.Drawing.Point(137, 109);
            this.tbEndHour.Name = "tbEndHour";
            this.tbEndHour.Size = new System.Drawing.Size(53, 20);
            this.tbEndHour.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSun);
            this.groupBox1.Controls.Add(this.checkBoxSut);
            this.groupBox1.Controls.Add(this.checkBoxThi);
            this.groupBox1.Controls.Add(this.checkBoxWen);
            this.groupBox1.Controls.Add(this.checkBoxTue);
            this.groupBox1.Controls.Add(this.checkBoxMon);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дни повторения";
            // 
            // checkBoxSun
            // 
            this.checkBoxSun.AutoSize = true;
            this.checkBoxSun.Location = new System.Drawing.Point(255, 33);
            this.checkBoxSun.Name = "checkBoxSun";
            this.checkBoxSun.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSun.TabIndex = 5;
            this.checkBoxSun.Text = "Вс";
            this.checkBoxSun.UseVisualStyleBackColor = true;
            // 
            // checkBoxSut
            // 
            this.checkBoxSut.AutoSize = true;
            this.checkBoxSut.Location = new System.Drawing.Point(210, 33);
            this.checkBoxSut.Name = "checkBoxSut";
            this.checkBoxSut.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSut.TabIndex = 4;
            this.checkBoxSut.Text = "Сб";
            this.checkBoxSut.UseVisualStyleBackColor = true;
            // 
            // checkBoxThi
            // 
            this.checkBoxThi.AutoSize = true;
            this.checkBoxThi.Location = new System.Drawing.Point(162, 33);
            this.checkBoxThi.Name = "checkBoxThi";
            this.checkBoxThi.Size = new System.Drawing.Size(39, 17);
            this.checkBoxThi.TabIndex = 3;
            this.checkBoxThi.Text = "Пт";
            this.checkBoxThi.UseVisualStyleBackColor = true;
            // 
            // checkBoxWen
            // 
            this.checkBoxWen.AutoSize = true;
            this.checkBoxWen.Location = new System.Drawing.Point(117, 33);
            this.checkBoxWen.Name = "checkBoxWen";
            this.checkBoxWen.Size = new System.Drawing.Size(39, 17);
            this.checkBoxWen.TabIndex = 2;
            this.checkBoxWen.Text = "Ср";
            this.checkBoxWen.UseVisualStyleBackColor = true;
            // 
            // checkBoxTue
            // 
            this.checkBoxTue.AutoSize = true;
            this.checkBoxTue.Location = new System.Drawing.Point(64, 33);
            this.checkBoxTue.Name = "checkBoxTue";
            this.checkBoxTue.Size = new System.Drawing.Size(38, 17);
            this.checkBoxTue.TabIndex = 1;
            this.checkBoxTue.Text = "Вт";
            this.checkBoxTue.UseVisualStyleBackColor = true;
            // 
            // checkBoxMon
            // 
            this.checkBoxMon.AutoSize = true;
            this.checkBoxMon.Location = new System.Drawing.Point(16, 33);
            this.checkBoxMon.Name = "checkBoxMon";
            this.checkBoxMon.Size = new System.Drawing.Size(40, 17);
            this.checkBoxMon.TabIndex = 0;
            this.checkBoxMon.Text = "Пн";
            this.checkBoxMon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericRepeat);
            this.groupBox2.Controls.Add(this.radioBtnEndRepeat);
            this.groupBox2.Controls.Add(this.radioBtnEndDate);
            this.groupBox2.Controls.Add(this.datePickerEnd);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 104);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Окончание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "повторов";
            // 
            // numericRepeat
            // 
            this.numericRepeat.Location = new System.Drawing.Point(86, 68);
            this.numericRepeat.Name = "numericRepeat";
            this.numericRepeat.Size = new System.Drawing.Size(55, 20);
            this.numericRepeat.TabIndex = 23;
            // 
            // radioBtnEndRepeat
            // 
            this.radioBtnEndRepeat.AutoSize = true;
            this.radioBtnEndRepeat.Location = new System.Drawing.Point(16, 68);
            this.radioBtnEndRepeat.Name = "radioBtnEndRepeat";
            this.radioBtnEndRepeat.Size = new System.Drawing.Size(57, 17);
            this.radioBtnEndRepeat.TabIndex = 22;
            this.radioBtnEndRepeat.TabStop = true;
            this.radioBtnEndRepeat.Text = "После";
            this.radioBtnEndRepeat.UseVisualStyleBackColor = true;
            // 
            // radioBtnEndDate
            // 
            this.radioBtnEndDate.AutoSize = true;
            this.radioBtnEndDate.Location = new System.Drawing.Point(16, 28);
            this.radioBtnEndDate.Name = "radioBtnEndDate";
            this.radioBtnEndDate.Size = new System.Drawing.Size(54, 17);
            this.radioBtnEndDate.TabIndex = 21;
            this.radioBtnEndDate.TabStop = true;
            this.radioBtnEndDate.Text = "Дата:";
            this.radioBtnEndDate.UseVisualStyleBackColor = true;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Location = new System.Drawing.Point(86, 24);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(128, 20);
            this.datePickerEnd.TabIndex = 20;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(32, 384);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 40);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(194, 384);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 40);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(50, 146);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRepeat.TabIndex = 24;
            this.checkBoxRepeat.Text = "Повторять";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // FormAddEmployeeTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(337, 445);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEndMinute);
            this.Controls.Add(this.tbEndHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStartMinute);
            this.Controls.Add(this.tbStartHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickerBegin);
            this.Controls.Add(this.label1);
            this.Name = "FormAddEmployeeTimetable";
            this.Text = "FormAddEmployeeTimetable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStartMinute;
        private System.Windows.Forms.TextBox tbStartHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEndMinute;
        private System.Windows.Forms.TextBox tbEndHour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSun;
        private System.Windows.Forms.CheckBox checkBoxSut;
        private System.Windows.Forms.CheckBox checkBoxThi;
        private System.Windows.Forms.CheckBox checkBoxWen;
        private System.Windows.Forms.CheckBox checkBoxTue;
        private System.Windows.Forms.CheckBox checkBoxMon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericRepeat;
        private System.Windows.Forms.RadioButton radioBtnEndRepeat;
        private System.Windows.Forms.RadioButton radioBtnEndDate;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
    }
}
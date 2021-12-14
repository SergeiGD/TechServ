
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupDays = new System.Windows.Forms.GroupBox();
            this.checkBoxSun = new System.Windows.Forms.CheckBox();
            this.checkBoxSat = new System.Windows.Forms.CheckBox();
            this.checkBoxFri = new System.Windows.Forms.CheckBox();
            this.checkBoxWen = new System.Windows.Forms.CheckBox();
            this.checkBoxTue = new System.Windows.Forms.CheckBox();
            this.checkBoxMon = new System.Windows.Forms.CheckBox();
            this.groupEnd = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericRepeat = new System.Windows.Forms.NumericUpDown();
            this.radioBtnEndRepeat = new System.Windows.Forms.RadioButton();
            this.radioBtnEndDate = new System.Windows.Forms.RadioButton();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.tbEnd = new System.Windows.Forms.MaskedTextBox();
            this.tbStart = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxThu = new System.Windows.Forms.CheckBox();
            this.groupDays.SuspendLayout();
            this.groupEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            // groupDays
            // 
            this.groupDays.Controls.Add(this.checkBoxThu);
            this.groupDays.Controls.Add(this.checkBoxSun);
            this.groupDays.Controls.Add(this.checkBoxSat);
            this.groupDays.Controls.Add(this.checkBoxFri);
            this.groupDays.Controls.Add(this.checkBoxWen);
            this.groupDays.Controls.Add(this.checkBoxTue);
            this.groupDays.Controls.Add(this.checkBoxMon);
            this.groupDays.Location = new System.Drawing.Point(10, 183);
            this.groupDays.Name = "groupDays";
            this.groupDays.Size = new System.Drawing.Size(315, 72);
            this.groupDays.TabIndex = 18;
            this.groupDays.TabStop = false;
            this.groupDays.Text = "Дни повторения";
            // 
            // checkBoxSun
            // 
            this.checkBoxSun.AutoSize = true;
            this.checkBoxSun.Location = new System.Drawing.Point(276, 33);
            this.checkBoxSun.Name = "checkBoxSun";
            this.checkBoxSun.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSun.TabIndex = 5;
            this.checkBoxSun.Text = "Вс";
            this.checkBoxSun.UseVisualStyleBackColor = true;
            // 
            // checkBoxSat
            // 
            this.checkBoxSat.AutoSize = true;
            this.checkBoxSat.Location = new System.Drawing.Point(231, 33);
            this.checkBoxSat.Name = "checkBoxSat";
            this.checkBoxSat.Size = new System.Drawing.Size(39, 17);
            this.checkBoxSat.TabIndex = 4;
            this.checkBoxSat.Text = "Сб";
            this.checkBoxSat.UseVisualStyleBackColor = true;
            // 
            // checkBoxFri
            // 
            this.checkBoxFri.AutoSize = true;
            this.checkBoxFri.Location = new System.Drawing.Point(186, 33);
            this.checkBoxFri.Name = "checkBoxFri";
            this.checkBoxFri.Size = new System.Drawing.Size(39, 17);
            this.checkBoxFri.TabIndex = 3;
            this.checkBoxFri.Text = "Пт";
            this.checkBoxFri.UseVisualStyleBackColor = true;
            // 
            // checkBoxWen
            // 
            this.checkBoxWen.AutoSize = true;
            this.checkBoxWen.Location = new System.Drawing.Point(96, 33);
            this.checkBoxWen.Name = "checkBoxWen";
            this.checkBoxWen.Size = new System.Drawing.Size(39, 17);
            this.checkBoxWen.TabIndex = 2;
            this.checkBoxWen.Text = "Ср";
            this.checkBoxWen.UseVisualStyleBackColor = true;
            // 
            // checkBoxTue
            // 
            this.checkBoxTue.AutoSize = true;
            this.checkBoxTue.Location = new System.Drawing.Point(52, 33);
            this.checkBoxTue.Name = "checkBoxTue";
            this.checkBoxTue.Size = new System.Drawing.Size(38, 17);
            this.checkBoxTue.TabIndex = 1;
            this.checkBoxTue.Text = "Вт";
            this.checkBoxTue.UseVisualStyleBackColor = true;
            // 
            // checkBoxMon
            // 
            this.checkBoxMon.AutoSize = true;
            this.checkBoxMon.Location = new System.Drawing.Point(6, 33);
            this.checkBoxMon.Name = "checkBoxMon";
            this.checkBoxMon.Size = new System.Drawing.Size(40, 17);
            this.checkBoxMon.TabIndex = 0;
            this.checkBoxMon.Text = "Пн";
            this.checkBoxMon.UseVisualStyleBackColor = true;
            // 
            // groupEnd
            // 
            this.groupEnd.Controls.Add(this.label5);
            this.groupEnd.Controls.Add(this.numericRepeat);
            this.groupEnd.Controls.Add(this.radioBtnEndRepeat);
            this.groupEnd.Controls.Add(this.radioBtnEndDate);
            this.groupEnd.Controls.Add(this.datePickerEnd);
            this.groupEnd.Location = new System.Drawing.Point(12, 261);
            this.groupEnd.Name = "groupEnd";
            this.groupEnd.Size = new System.Drawing.Size(305, 104);
            this.groupEnd.TabIndex = 19;
            this.groupEnd.TabStop = false;
            this.groupEnd.Text = "Окончание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "повторов (недель)";
            // 
            // numericRepeat
            // 
            this.numericRepeat.Location = new System.Drawing.Point(86, 68);
            this.numericRepeat.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRepeat.Name = "numericRepeat";
            this.numericRepeat.Size = new System.Drawing.Size(55, 20);
            this.numericRepeat.TabIndex = 23;
            this.numericRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.checkBoxRepeat.CheckedChanged += new System.EventHandler(this.checkBoxRepeat_CheckedChanged);
            // 
            // tbEnd
            // 
            this.tbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.tbEnd.Location = new System.Drawing.Point(137, 101);
            this.tbEnd.Mask = "00:00";
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(59, 26);
            this.tbEnd.TabIndex = 26;
            this.tbEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEnd.ValidatingType = typeof(System.DateTime);
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.tbStart.Location = new System.Drawing.Point(137, 59);
            this.tbStart.Mask = "00:00";
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(59, 26);
            this.tbStart.TabIndex = 25;
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStart.ValidatingType = typeof(System.DateTime);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // checkBoxThu
            // 
            this.checkBoxThu.AutoSize = true;
            this.checkBoxThu.Location = new System.Drawing.Point(141, 33);
            this.checkBoxThu.Name = "checkBoxThu";
            this.checkBoxThu.Size = new System.Drawing.Size(39, 17);
            this.checkBoxThu.TabIndex = 6;
            this.checkBoxThu.Text = "Чт";
            this.checkBoxThu.UseVisualStyleBackColor = true;
            // 
            // FormAddEmployeeTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(337, 445);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupEnd);
            this.Controls.Add(this.groupDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickerBegin);
            this.Controls.Add(this.label1);
            this.Name = "FormAddEmployeeTimetable";
            this.Text = "FormAddEmployeeTimetable";
            this.Load += new System.EventHandler(this.FormAddEmployeeTimetable_Load);
            this.groupDays.ResumeLayout(false);
            this.groupDays.PerformLayout();
            this.groupEnd.ResumeLayout(false);
            this.groupEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupDays;
        private System.Windows.Forms.CheckBox checkBoxSun;
        private System.Windows.Forms.CheckBox checkBoxSat;
        private System.Windows.Forms.CheckBox checkBoxFri;
        private System.Windows.Forms.CheckBox checkBoxWen;
        private System.Windows.Forms.CheckBox checkBoxTue;
        private System.Windows.Forms.CheckBox checkBoxMon;
        private System.Windows.Forms.GroupBox groupEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericRepeat;
        private System.Windows.Forms.RadioButton radioBtnEndRepeat;
        private System.Windows.Forms.RadioButton radioBtnEndDate;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.MaskedTextBox tbEnd;
        private System.Windows.Forms.MaskedTextBox tbStart;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkBoxThu;
    }
}
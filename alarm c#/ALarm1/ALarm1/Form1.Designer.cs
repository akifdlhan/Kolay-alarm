namespace ALarm1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_dur = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_alarm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_alarm
            // 
            this.btn_alarm.BackColor = System.Drawing.Color.Lime;
            this.btn_alarm.ForeColor = System.Drawing.Color.Black;
            this.btn_alarm.Location = new System.Drawing.Point(121, 95);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(75, 23);
            this.btn_alarm.TabIndex = 0;
            this.btn_alarm.Text = "Alarm kur";
            this.btn_alarm.UseVisualStyleBackColor = false;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_dur
            // 
            this.btn_dur.Location = new System.Drawing.Point(202, 95);
            this.btn_dur.Name = "btn_dur";
            this.btn_dur.Size = new System.Drawing.Size(75, 23);
            this.btn_dur.TabIndex = 1;
            this.btn_dur.Text = "dur";
            this.btn_dur.UseVisualStyleBackColor = true;
            this.btn_dur.Click += new System.EventHandler(this.btn_dur_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_alarm
            // 
            this.lbl_alarm.AutoSize = true;
            this.lbl_alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alarm.ForeColor = System.Drawing.Color.Red;
            this.lbl_alarm.Location = new System.Drawing.Point(12, 34);
            this.lbl_alarm.Name = "lbl_alarm";
            this.lbl_alarm.Size = new System.Drawing.Size(72, 25);
            this.lbl_alarm.TabIndex = 3;
            this.lbl_alarm.Text = "Alarm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(338, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_alarm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_dur);
            this.Controls.Add(this.btn_alarm);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_dur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_alarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}


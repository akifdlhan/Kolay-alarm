using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace ALarm1
{
    
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        SoundPlayer player = new SoundPlayer();
        private void btn_alarm_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = "Alarm Kuruldu.";
            btn_alarm.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime alarmTime = dateTimePicker1.Value;

            if (dateTime.Hour == alarmTime.Hour && dateTime.Minute == alarmTime.Minute && dateTime.Second == alarmTime.Second)
            {
                timer1.Stop();
                label2.Text = "Alarm Çalıyor...";


                player.SoundLocation = @"C:\Users\MONSTER\Downloads\ikinci-dunya-savasi-siren-sesi-savas-sireni.wav";
                player.PlayLooping();
            }
        }

        private void btn_dur_Click(object sender, EventArgs e)
        {
            player.Stop();
            label2.Text = "Alarm Durduruldu.";
            btn_alarm.Enabled = true;
        }
    }
}

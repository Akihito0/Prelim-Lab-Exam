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
namespace Prelim_Lab_Exam
{
    public partial class AlarmControl : UserControl
    {
        SoundPlayer playSound = new SoundPlayer();
        string newSound = "C:\\Users\\Noah Gabriel Suan\\Downloads\\prelim exam oop2\\AlarmSound.wav";
        bool status = false;
        public AlarmControl()
        {
            InitializeComponent();
             Offbtn.Enabled = false;
        }

        private void AlarmControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string currTime = DateTime.Now.ToLongTimeString();
            string selectedTime = dateTimePicker.Value.ToLongTimeString();
            debug1.Text = currTime;
            debug2.Text = selectedTime;
            if (status)
            {
                if (currTime == selectedTime)
                {
                    timer1.Stop();
                    try
                    {
                        playSound.SoundLocation = newSound;
                        playSound.PlayLooping();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Onbtn_Click(object sender, EventArgs e)
        {
            status = true;
            statuslbl.Text = "Status: Alarm is On";
            timer1.Start();
            Onbtn.Enabled = false;
            Offbtn.Enabled = true;
            dateTimePicker.Enabled = false;
        }

        private void Offbtn_Click(object sender, EventArgs e)
        {
            status = false;
            statuslbl.Text = "Status: Alarm is Inactive";
            timer1.Stop();
            Onbtn.Enabled = true;
            Offbtn.Enabled = false;
            dateTimePicker.Enabled = true;
        }
    }
}

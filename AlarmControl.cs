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
            if (status)
            {
                if (currTime == selectedTime)
                {
                    timer1.Stop();
                    try
                    {
                        playSound.SoundLocation = newSound;
                        playSound.PlayLooping();
                        // Show the message box to notify the user
                        DialogResult result = MessageBox.Show("The alarm is ringing. Do you want to turn it off?", "Alarm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            playSound.Stop();
                            status = false;
                            statuslbl.Text = "Status: Alarm is Inactive";
                            Onbtn.Enabled = true;
                            Offbtn.Enabled = false;
                            dateTimePicker.Enabled = true;
                        }
                        else
                        {
                            timer1.Start();
                            playSound.Stop();
                        }
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
            activepb.Visible = true;
            waitingpb.Visible = false;
            status = true;
            statuslbl.Text = "Status: Alarm is On";
            timer1.Start();
            Onbtn.Enabled = false;
            Offbtn.Enabled = true;
            dateTimePicker.Enabled = false;
        }

        private void Offbtn_Click(object sender, EventArgs e)
        {
            activepb.Visible = false;
            waitingpb.Visible = true;
            status = false;
            statuslbl.Text = "Status: Alarm is Inactive";
            timer1.Stop();
            Onbtn.Enabled = true;
            Offbtn.Enabled = false;
            dateTimePicker.Enabled = true;
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            CMS.Show(alarm1pnl, alarm1pnl.Height, 0);
        }

        private void CMS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Sound File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newSound = openFileDialog.FileName;
                    playSound.SoundLocation = newSound;
                }
            }
        }

    }
}

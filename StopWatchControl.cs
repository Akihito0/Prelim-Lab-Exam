using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
namespace Prelim_Lab_Exam
{
    public partial class StopWatchControl : UserControl
    {
        System.Timers.Timer timer;
        int h, m, s, ms;
        bool status = false;
        public StopWatchControl()
        {
            InitializeComponent();
            Stopbtn.Enabled = false;
        }

        private void StopWatchControl_Load(object sender, EventArgs e)
        {
                timer = new System.Timers.Timer();
                timer.Interval = 1;
                timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                ms += 1;
                if (ms == 100) 
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60) 
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60) 
                {
                    m = 0;
                    h += 1;
                }
                stopwatch.Text = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2, '0'),m.ToString().ToString().PadLeft(2, '0'),s.ToString().ToString().PadLeft(2, '0'),ms.ToString().ToString().PadLeft(2, '0'));
            }));
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = false;
            Stopbtn.Enabled = true;
            timer.Start();
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = true;
            Stopbtn.Enabled = false;
            timer.Stop();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = true;
            Stopbtn.Enabled = false;
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            stopwatch.Text = "00:00:00:00";
        }
    }
}

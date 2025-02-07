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
using System.Diagnostics;

namespace Prelim_Lab_Exam
{
    public partial class StopWatchControl : UserControl
    {
        public Stopwatch Stopwatch;
        int h, m, s, ms;
        bool status = false;
        public StopWatchControl()
        {
            InitializeComponent();
            Stopbtn.Enabled = false;
            timer1.Interval = 1;
        }

        private void StopWatchControl_Load(object sender, EventArgs e)
        {
            Stopwatch = new Stopwatch();

        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
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
                stopwatch.Text = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));
            }));
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = false;
            Stopbtn.Enabled = true;
            timer1.Start();
            Stopwatch.Start();
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = true;
            Stopbtn.Enabled = false;
            timer1.Stop();
            Stopwatch.Stop();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = true;
            Stopbtn.Enabled = false;
            Stopwatch.Stop();
            Stopwatch.Reset();
            timer1.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            stopwatch.Text = "00:00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatch.Text = Stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }
    }
}

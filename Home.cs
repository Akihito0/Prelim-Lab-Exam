namespace Prelim_Lab_Exam
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }
        private void clockBtn_Click(object sender, EventArgs e)
        {
            clockControl1.BringToFront();
        }

        private void AlarmBtn_Click(object sender, EventArgs e)
        {
            alarmControl1.BringToFront();
        }

        private void StopWatchBtn_Click(object sender, EventArgs e)
        {
            stopWatchControl1.BringToFront();
        }
        private void TimerBtn_Click(object sender, EventArgs e)
        {
            timerControl1.BringToFront();
        }

    }
}

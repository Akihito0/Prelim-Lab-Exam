namespace Prelim_Lab_Exam
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            menuBtn = new PictureBox();
            AlarmBtn = new Button();
            alarmPn = new Panel();
            sideBar = new FlowLayoutPanel();
            homePn = new Panel();
            homeBtn = new Button();
            clockPn = new Panel();
            clockBtn = new Button();
            stopwatchPn = new Panel();
            StopWatchBtn = new Button();
            timerPn = new Panel();
            TimerBtn = new Button();
            MenuTransition = new System.Windows.Forms.Timer(components);
            homeControl1 = new HomeControl();
            clockControl1 = new ClockControl();
            alarmControl1 = new AlarmControl();
            stopWatchControl1 = new StopWatchControl();
            timerControl1 = new TimerControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).BeginInit();
            alarmPn.SuspendLayout();
            sideBar.SuspendLayout();
            homePn.SuspendLayout();
            clockPn.SuspendLayout();
            stopwatchPn.SuspendLayout();
            timerPn.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 40);
            panel1.TabIndex = 0;
            // 
            // menuBtn
            // 
            menuBtn.Image = (Image)resources.GetObject("menuBtn.Image");
            menuBtn.Location = new Point(3, 3);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(64, 33);
            menuBtn.SizeMode = PictureBoxSizeMode.Zoom;
            menuBtn.TabIndex = 1;
            menuBtn.TabStop = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // AlarmBtn
            // 
            AlarmBtn.BackColor = Color.FromArgb(224, 224, 224);
            AlarmBtn.FlatAppearance.MouseOverBackColor = Color.White;
            AlarmBtn.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlarmBtn.Image = (Image)resources.GetObject("AlarmBtn.Image");
            AlarmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AlarmBtn.Location = new Point(-17, -25);
            AlarmBtn.Name = "AlarmBtn";
            AlarmBtn.Padding = new Padding(25, 0, 0, 0);
            AlarmBtn.Size = new Size(270, 126);
            AlarmBtn.TabIndex = 2;
            AlarmBtn.Text = "Alarm";
            AlarmBtn.UseVisualStyleBackColor = false;
            AlarmBtn.Click += AlarmBtn_Click;
            // 
            // alarmPn
            // 
            alarmPn.BackColor = Color.White;
            alarmPn.Controls.Add(AlarmBtn);
            alarmPn.Location = new Point(3, 161);
            alarmPn.Name = "alarmPn";
            alarmPn.Size = new Size(228, 73);
            alarmPn.TabIndex = 3;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(224, 224, 224);
            sideBar.Controls.Add(homePn);
            sideBar.Controls.Add(clockPn);
            sideBar.Controls.Add(alarmPn);
            sideBar.Controls.Add(stopwatchPn);
            sideBar.Controls.Add(timerPn);
            sideBar.Location = new Point(0, 40);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(235, 529);
            sideBar.TabIndex = 1;
            // 
            // homePn
            // 
            homePn.BackColor = Color.White;
            homePn.Controls.Add(homeBtn);
            homePn.Location = new Point(3, 3);
            homePn.Name = "homePn";
            homePn.Size = new Size(228, 73);
            homePn.TabIndex = 5;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.FromArgb(224, 224, 224);
            homeBtn.FlatAppearance.MouseOverBackColor = Color.White;
            homeBtn.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(-17, -25);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(25, 0, 0, 0);
            homeBtn.Size = new Size(270, 126);
            homeBtn.TabIndex = 2;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // clockPn
            // 
            clockPn.BackColor = Color.White;
            clockPn.Controls.Add(clockBtn);
            clockPn.Location = new Point(3, 82);
            clockPn.Name = "clockPn";
            clockPn.Size = new Size(228, 73);
            clockPn.TabIndex = 4;
            // 
            // clockBtn
            // 
            clockBtn.BackColor = Color.FromArgb(224, 224, 224);
            clockBtn.FlatAppearance.MouseOverBackColor = Color.White;
            clockBtn.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clockBtn.Image = (Image)resources.GetObject("clockBtn.Image");
            clockBtn.ImageAlign = ContentAlignment.MiddleLeft;
            clockBtn.Location = new Point(-17, -25);
            clockBtn.Name = "clockBtn";
            clockBtn.Padding = new Padding(25, 0, 0, 0);
            clockBtn.Size = new Size(270, 126);
            clockBtn.TabIndex = 2;
            clockBtn.Text = "Clock";
            clockBtn.UseVisualStyleBackColor = false;
            clockBtn.Click += clockBtn_Click;
            // 
            // stopwatchPn
            // 
            stopwatchPn.BackColor = Color.White;
            stopwatchPn.Controls.Add(StopWatchBtn);
            stopwatchPn.Location = new Point(3, 240);
            stopwatchPn.Name = "stopwatchPn";
            stopwatchPn.Size = new Size(228, 73);
            stopwatchPn.TabIndex = 4;
            // 
            // StopWatchBtn
            // 
            StopWatchBtn.BackColor = Color.FromArgb(224, 224, 224);
            StopWatchBtn.FlatAppearance.MouseOverBackColor = Color.White;
            StopWatchBtn.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StopWatchBtn.Image = (Image)resources.GetObject("StopWatchBtn.Image");
            StopWatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            StopWatchBtn.Location = new Point(-17, -25);
            StopWatchBtn.Name = "StopWatchBtn";
            StopWatchBtn.Padding = new Padding(25, 0, 0, 0);
            StopWatchBtn.Size = new Size(270, 126);
            StopWatchBtn.TabIndex = 2;
            StopWatchBtn.Text = "Stop Watch";
            StopWatchBtn.UseVisualStyleBackColor = false;
            StopWatchBtn.Click += StopWatchBtn_Click;
            // 
            // timerPn
            // 
            timerPn.BackColor = Color.White;
            timerPn.Controls.Add(TimerBtn);
            timerPn.Location = new Point(3, 319);
            timerPn.Name = "timerPn";
            timerPn.Size = new Size(228, 73);
            timerPn.TabIndex = 5;
            // 
            // TimerBtn
            // 
            TimerBtn.BackColor = Color.FromArgb(224, 224, 224);
            TimerBtn.FlatAppearance.MouseOverBackColor = Color.White;
            TimerBtn.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerBtn.Image = (Image)resources.GetObject("TimerBtn.Image");
            TimerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TimerBtn.Location = new Point(-17, -25);
            TimerBtn.Name = "TimerBtn";
            TimerBtn.Padding = new Padding(25, 0, 0, 0);
            TimerBtn.Size = new Size(270, 126);
            TimerBtn.TabIndex = 2;
            TimerBtn.Text = "Timer";
            TimerBtn.UseVisualStyleBackColor = false;
            TimerBtn.Click += TimerBtn_Click;
            // 
            // MenuTransition
            // 
            MenuTransition.Interval = 10;
            // 
            // homeControl1
            // 
            homeControl1.BackColor = SystemColors.ButtonShadow;
            homeControl1.Location = new Point(228, 40);
            homeControl1.Name = "homeControl1";
            homeControl1.Size = new Size(844, 529);
            homeControl1.TabIndex = 2;
            // 
            // clockControl1
            // 
            clockControl1.BackColor = SystemColors.ActiveCaptionText;
            clockControl1.Location = new Point(228, 40);
            clockControl1.Name = "clockControl1";
            clockControl1.Size = new Size(844, 529);
            clockControl1.TabIndex = 2;
            // 
            // alarmControl1
            // 
            alarmControl1.Location = new Point(228, 40);
            alarmControl1.Name = "alarmControl1";
            alarmControl1.Size = new Size(844, 529);
            alarmControl1.TabIndex = 3;
            // 
            // stopWatchControl1
            // 
            stopWatchControl1.Location = new Point(228, 40);
            stopWatchControl1.Name = "stopWatchControl1";
            stopWatchControl1.Size = new Size(844, 529);
            stopWatchControl1.TabIndex = 2;
            // 
            // timerControl1
            // 
            timerControl1.Location = new Point(228, 40);
            timerControl1.Name = "timerControl1";
            timerControl1.Size = new Size(851, 529);
            timerControl1.TabIndex = 4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1072, 569);
            Controls.Add(sideBar);
            Controls.Add(panel1);
            Controls.Add(homeControl1);
            Controls.Add(clockControl1);
            Controls.Add(alarmControl1);
            Controls.Add(stopWatchControl1);
            Controls.Add(timerControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clock";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuBtn).EndInit();
            alarmPn.ResumeLayout(false);
            sideBar.ResumeLayout(false);
            homePn.ResumeLayout(false);
            clockPn.ResumeLayout(false);
            stopwatchPn.ResumeLayout(false);
            timerPn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox menuBtn;
        private Button AlarmBtn;
        private Panel alarmPn;
        private FlowLayoutPanel sideBar;
        private Panel stopwatchPn;
        private Button StopWatchBtn;
        private Panel timerPn;
        private Button TimerBtn;
        private System.Windows.Forms.Timer MenuTransition;
        private Panel clockPn;
        private Button clockBtn;
        private Panel homePn;
        private Button homeBtn;
        private HomeControl homeControl1;
        private ClockControl clockControl1;
        private AlarmControl alarmControl1;
        private StopWatchControl stopWatchControl1;
        private TimerControl timerControl1;
    }
}

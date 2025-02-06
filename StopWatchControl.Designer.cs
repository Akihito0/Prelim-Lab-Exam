namespace Prelim_Lab_Exam
{
    partial class StopWatchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stopwatch = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Startbtn = new Button();
            Stopbtn = new Button();
            Resetbtn = new Button();
            SuspendLayout();
            // 
            // stopwatch
            // 
            stopwatch.Font = new Font("Digital-7 Mono", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopwatch.ForeColor = SystemColors.ActiveCaptionText;
            stopwatch.Location = new Point(0, 72);
            stopwatch.Name = "stopwatch";
            stopwatch.Size = new Size(832, 165);
            stopwatch.TabIndex = 3;
            stopwatch.Text = "00:00:00:00";
            stopwatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Medium Cond", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(835, 71);
            label2.TabIndex = 4;
            label2.Text = "StopWatch";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Digital-7 Mono", 10.1999989F, FontStyle.Bold);
            label3.Location = new Point(127, 205);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 5;
            label3.Text = "Hour/s";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Digital-7 Mono", 10.1999989F, FontStyle.Bold);
            label4.Location = new Point(294, 205);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "Minute/s";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Digital-7 Mono", 10.1999989F, FontStyle.Bold);
            label5.Location = new Point(464, 205);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 7;
            label5.Text = "Second/s";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Digital-7 Mono", 10.1999989F, FontStyle.Bold);
            label6.Location = new Point(606, 205);
            label6.Name = "label6";
            label6.Size = new Size(125, 17);
            label6.TabIndex = 8;
            label6.Text = "Millisecond/s";
            // 
            // Startbtn
            // 
            Startbtn.BackColor = Color.FromArgb(0, 205, 115);
            Startbtn.FlatStyle = FlatStyle.Popup;
            Startbtn.Location = new Point(87, 272);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(176, 49);
            Startbtn.TabIndex = 9;
            Startbtn.Text = "Start";
            Startbtn.UseVisualStyleBackColor = false;
            Startbtn.Click += Startbtn_Click;
            // 
            // Stopbtn
            // 
            Stopbtn.BackColor = Color.FromArgb(247, 86, 91);
            Stopbtn.FlatStyle = FlatStyle.Popup;
            Stopbtn.Location = new Point(305, 272);
            Stopbtn.Name = "Stopbtn";
            Stopbtn.Size = new Size(176, 49);
            Stopbtn.TabIndex = 10;
            Stopbtn.Text = "Stop";
            Stopbtn.UseVisualStyleBackColor = false;
            Stopbtn.Click += Stopbtn_Click;
            // 
            // Resetbtn
            // 
            Resetbtn.BackColor = Color.FromArgb(25, 130, 196);
            Resetbtn.FlatStyle = FlatStyle.Popup;
            Resetbtn.Location = new Point(536, 272);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(176, 49);
            Resetbtn.TabIndex = 11;
            Resetbtn.Text = "Reset";
            Resetbtn.UseVisualStyleBackColor = false;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // StopWatchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Resetbtn);
            Controls.Add(Stopbtn);
            Controls.Add(Startbtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(stopwatch);
            Name = "StopWatchControl";
            Size = new Size(835, 529);
            Load += StopWatchControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stopwatch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Startbtn;
        private Button Stopbtn;
        private Button Resetbtn;
    }
}

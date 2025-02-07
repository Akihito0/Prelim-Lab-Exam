namespace Prelim_Lab_Exam
{
    partial class TimerControl
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
            label1 = new Label();
            timerCountDown1 = new TimerCountDown();
            timerCountDown2 = new TimerCountDown();
            timerCountDown3 = new TimerCountDown();
            timerCountDown4 = new TimerCountDown();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Medium Cond", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(835, 40);
            label1.TabIndex = 4;
            label1.Text = "Timer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerCountDown1
            // 
            timerCountDown1.BackColor = SystemColors.ControlDark;
            timerCountDown1.Location = new Point(106, 77);
            timerCountDown1.Name = "timerCountDown1";
            timerCountDown1.Size = new Size(289, 210);
            timerCountDown1.TabIndex = 5;
            timerCountDown1.Load += timerCountDown1_Load;
            // 
            // timerCountDown2
            // 
            timerCountDown2.BackColor = SystemColors.ControlDark;
            timerCountDown2.Location = new Point(401, 77);
            timerCountDown2.Name = "timerCountDown2";
            timerCountDown2.Size = new Size(289, 210);
            timerCountDown2.TabIndex = 6;
            // 
            // timerCountDown3
            // 
            timerCountDown3.BackColor = SystemColors.ControlDark;
            timerCountDown3.Location = new Point(401, 293);
            timerCountDown3.Name = "timerCountDown3";
            timerCountDown3.Size = new Size(289, 210);
            timerCountDown3.TabIndex = 8;
            // 
            // timerCountDown4
            // 
            timerCountDown4.BackColor = SystemColors.ControlDark;
            timerCountDown4.Location = new Point(106, 293);
            timerCountDown4.Name = "timerCountDown4";
            timerCountDown4.Size = new Size(289, 210);
            timerCountDown4.TabIndex = 7;
            // 
            // TimerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timerCountDown3);
            Controls.Add(timerCountDown4);
            Controls.Add(timerCountDown2);
            Controls.Add(timerCountDown1);
            Controls.Add(label1);
            Name = "TimerControl";
            Size = new Size(835, 529);
            Load += TimerControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TimerCountDown timerCountDown1;
        private TimerCountDown timerCountDown2;
        private TimerCountDown timerCountDown3;
        private TimerCountDown timerCountDown4;
    }
}

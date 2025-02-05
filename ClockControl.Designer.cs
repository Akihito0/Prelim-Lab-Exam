namespace Prelim_Lab_Exam
{
    partial class ClockControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockControl));
            greetinglbl = new Label();
            Clocklbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Moonpb = new PictureBox();
            Sunpb = new PictureBox();
            Noonpb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Moonpb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sunpb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Noonpb).BeginInit();
            SuspendLayout();
            // 
            // greetinglbl
            // 
            greetinglbl.Font = new Font("Digital-7", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetinglbl.ForeColor = SystemColors.ButtonHighlight;
            greetinglbl.Location = new Point(0, 364);
            greetinglbl.Name = "greetinglbl";
            greetinglbl.Size = new Size(832, 165);
            greetinglbl.TabIndex = 1;
            greetinglbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Clocklbl
            // 
            Clocklbl.Font = new Font("Advanced Pixel LCD-7", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clocklbl.ForeColor = SystemColors.ButtonHighlight;
            Clocklbl.Location = new Point(0, 182);
            Clocklbl.Name = "Clocklbl";
            Clocklbl.Size = new Size(835, 165);
            Clocklbl.TabIndex = 2;
            Clocklbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += ClockControl_Load;
            // 
            // Moonpb
            // 
            Moonpb.Image = (Image)resources.GetObject("Moonpb.Image");
            Moonpb.Location = new Point(678, 0);
            Moonpb.Name = "Moonpb";
            Moonpb.Size = new Size(157, 165);
            Moonpb.TabIndex = 3;
            Moonpb.TabStop = false;
            // 
            // Sunpb
            // 
            Sunpb.Image = (Image)resources.GetObject("Sunpb.Image");
            Sunpb.Location = new Point(0, 3);
            Sunpb.Name = "Sunpb";
            Sunpb.Size = new Size(157, 165);
            Sunpb.TabIndex = 4;
            Sunpb.TabStop = false;
            // 
            // Noonpb
            // 
            Noonpb.Image = (Image)resources.GetObject("Noonpb.Image");
            Noonpb.Location = new Point(340, 3);
            Noonpb.Name = "Noonpb";
            Noonpb.Size = new Size(157, 165);
            Noonpb.TabIndex = 5;
            Noonpb.TabStop = false;
            // 
            // ClockControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(Noonpb);
            Controls.Add(Sunpb);
            Controls.Add(Moonpb);
            Controls.Add(Clocklbl);
            Controls.Add(greetinglbl);
            Name = "ClockControl";
            Size = new Size(835, 529);
            Load += ClockControl_Load;
            ((System.ComponentModel.ISupportInitialize)Moonpb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sunpb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Noonpb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label greetinglbl;
        private Label Clocklbl;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Moonpb;
        private PictureBox Sunpb;
        private PictureBox Noonpb;
    }
}

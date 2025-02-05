namespace Prelim_Lab_Exam
{
    partial class AlarmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmControl));
            alarm1pnl = new Panel();
            statuslbl = new Label();
            Offbtn = new Button();
            Onbtn = new Button();
            alarm1lbl = new Label();
            dateTimePicker = new DateTimePicker();
            menubtn = new Button();
            CMS = new ContextMenuStrip(components);
            selectNewSoundToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            activepb = new PictureBox();
            waitingpb = new PictureBox();
            alarm1pnl.SuspendLayout();
            CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activepb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waitingpb).BeginInit();
            SuspendLayout();
            // 
            // alarm1pnl
            // 
            alarm1pnl.BorderStyle = BorderStyle.FixedSingle;
            alarm1pnl.Controls.Add(statuslbl);
            alarm1pnl.Controls.Add(Offbtn);
            alarm1pnl.Controls.Add(Onbtn);
            alarm1pnl.Controls.Add(alarm1lbl);
            alarm1pnl.Controls.Add(dateTimePicker);
            alarm1pnl.Controls.Add(menubtn);
            alarm1pnl.Location = new Point(248, 111);
            alarm1pnl.Name = "alarm1pnl";
            alarm1pnl.Size = new Size(278, 187);
            alarm1pnl.TabIndex = 3;
            // 
            // statuslbl
            // 
            statuslbl.AutoSize = true;
            statuslbl.Location = new Point(63, 46);
            statuslbl.Name = "statuslbl";
            statuslbl.Size = new Size(165, 20);
            statuslbl.TabIndex = 5;
            statuslbl.Text = "Status: Alarm is inactive";
            // 
            // Offbtn
            // 
            Offbtn.Location = new Point(140, 114);
            Offbtn.Name = "Offbtn";
            Offbtn.Size = new Size(69, 29);
            Offbtn.TabIndex = 4;
            Offbtn.Text = "Turn off";
            Offbtn.UseVisualStyleBackColor = true;
            Offbtn.Click += Offbtn_Click;
            // 
            // Onbtn
            // 
            Onbtn.Location = new Point(63, 114);
            Onbtn.Name = "Onbtn";
            Onbtn.Size = new Size(71, 29);
            Onbtn.TabIndex = 3;
            Onbtn.Text = "Turn On";
            Onbtn.UseVisualStyleBackColor = true;
            Onbtn.Click += Onbtn_Click;
            // 
            // alarm1lbl
            // 
            alarm1lbl.AutoSize = true;
            alarm1lbl.Location = new Point(114, 16);
            alarm1lbl.Name = "alarm1lbl";
            alarm1lbl.Size = new Size(49, 20);
            alarm1lbl.TabIndex = 2;
            alarm1lbl.Text = "Alarm";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.Location = new Point(88, 69);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(106, 27);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.Value = new DateTime(2025, 2, 5, 22, 6, 0, 0);
            // 
            // menubtn
            // 
            menubtn.Image = (Image)resources.GetObject("menubtn.Image");
            menubtn.Location = new Point(250, -3);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(28, 39);
            menubtn.TabIndex = 0;
            menubtn.UseVisualStyleBackColor = true;
            menubtn.Click += menubtn_Click;
            // 
            // CMS
            // 
            CMS.ImageScalingSize = new Size(20, 20);
            CMS.Items.AddRange(new ToolStripItem[] { selectNewSoundToolStripMenuItem });
            CMS.Name = "contextMenuStrip1";
            CMS.Size = new Size(199, 28);
            CMS.ItemClicked += CMS_ItemClicked;
            // 
            // selectNewSoundToolStripMenuItem
            // 
            selectNewSoundToolStripMenuItem.Name = "selectNewSoundToolStripMenuItem";
            selectNewSoundToolStripMenuItem.Size = new Size(198, 24);
            selectNewSoundToolStripMenuItem.Text = "Select New Sound";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += AlarmControl_Load;
            // 
            // activepb
            // 
            activepb.Image = (Image)resources.GetObject("activepb.Image");
            activepb.Location = new Point(499, 83);
            activepb.Name = "activepb";
            activepb.Size = new Size(230, 215);
            activepb.TabIndex = 4;
            activepb.TabStop = false;
            // 
            // waitingpb
            // 
            waitingpb.Image = (Image)resources.GetObject("waitingpb.Image");
            waitingpb.Location = new Point(62, 70);
            waitingpb.Name = "waitingpb";
            waitingpb.Size = new Size(218, 228);
            waitingpb.TabIndex = 5;
            waitingpb.TabStop = false;
            // 
            // AlarmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(alarm1pnl);
            Controls.Add(activepb);
            Controls.Add(waitingpb);
            Name = "AlarmControl";
            Size = new Size(835, 529);
            Load += AlarmControl_Load;
            alarm1pnl.ResumeLayout(false);
            alarm1pnl.PerformLayout();
            CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)activepb).EndInit();
            ((System.ComponentModel.ISupportInitialize)waitingpb).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel alarm1pnl;
        private ContextMenuStrip CMS;
        private Button menubtn;
        private Button Offbtn;
        private Button Onbtn;
        private Label alarm1lbl;
        private DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timer1;
        private Label statuslbl;
        private ToolStripMenuItem selectNewSoundToolStripMenuItem;
        private PictureBox activepb;
        private PictureBox waitingpb;
    }
}

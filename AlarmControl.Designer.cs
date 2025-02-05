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
            contextMenuStrip1 = new ContextMenuStrip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            debug1 = new Label();
            debug2 = new Label();
            alarm1pnl.SuspendLayout();
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
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += AlarmControl_Load;
            // 
            // debug1
            // 
            debug1.Location = new Point(248, 29);
            debug1.Name = "debug1";
            debug1.Size = new Size(229, 25);
            debug1.TabIndex = 4;
            debug1.Text = "label1";
            // 
            // debug2
            // 
            debug2.Location = new Point(248, 54);
            debug2.Name = "debug2";
            debug2.Size = new Size(229, 25);
            debug2.TabIndex = 5;
            debug2.Text = "label2";
            // 
            // AlarmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(debug2);
            Controls.Add(debug1);
            Controls.Add(alarm1pnl);
            Name = "AlarmControl";
            Size = new Size(835, 529);
            Load += AlarmControl_Load;
            alarm1pnl.ResumeLayout(false);
            alarm1pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel alarm1pnl;
        private ContextMenuStrip contextMenuStrip1;
        private Button menubtn;
        private Button Offbtn;
        private Button Onbtn;
        private Label alarm1lbl;
        private DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timer1;
        private Label statuslbl;
        private Label debug1;
        private Label debug2;
    }
}

﻿namespace Prelim_Lab_Exam
{
    partial class HomeControl
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Medium Cond", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 147);
            label1.Name = "label1";
            label1.Size = new Size(835, 165);
            label1.TabIndex = 0;
            label1.Text = "Prelim Exam Project\r\nTitle: Multi Functional Clock\r\nMade by: Noah Gabriel R. Suan\r\nInstructor: Julian Semblante";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(label1);
            Name = "HomeControl";
            Size = new Size(835, 529);
            Load += HomeControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}

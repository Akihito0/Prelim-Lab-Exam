using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelim_Lab_Exam
{
    public partial class ClockControl : UserControl
    {
        public ClockControl()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void ClockControl_Load(object sender, EventArgs e)
        {
            Clocklbl.Text = DateTime.Now.ToLongTimeString();
            greetinglbl.Text = "Good Morning!";
            //Initially set the visibility of the sun is true while noon and moon is false
            Sunpb.Visible = true;
            Noonpb.Visible = false;
            Moonpb.Visible = false;
            this.BackColor = Color.White;
            //If the time surpasses 12 noon, the sun will be hidden and the noon will be visible
            if (DateTime.Now.Hour > 11 && DateTime.Now.Hour < 18)
            {
                greetinglbl.Text = "Good Afternoon!";
                Sunpb.Visible = false;
                Moonpb.Visible = false;
                Noonpb.Visible = true;
                this.BackColor = Color.Yellow;
            }
            else if(DateTime.Now.Hour > 17)
            { 
                greetinglbl.Text = "Good Evening!";
                Sunpb.Visible = false;
                Noonpb.Visible = false;
                Moonpb.Visible = true;
                this.BackColor = Color.Black;
            }
        }

      
    }
}

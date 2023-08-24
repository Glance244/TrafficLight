using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLigth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RedStopLight.Enabled = true;
            YellowStopLight.Enabled = false;
            GreenLightStop.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          if(RedStopLight.Visible==true)
          {
                RedStopLight.Visible = false;
                YellowStopLight.Visible = false;
                GreenLightStop.Visible = true;

          }
          else if(GreenLightStop.Visible==true)
          {
                YellowStopLight.Visible=true;
                GreenLightStop.Visible = false;
                RedStopLight.Visible = false;
          }
          else if(YellowStopLight.Visible==true)
          {
                YellowStopLight.Visible = false;
                GreenLightStop.Visible = false;
                RedStopLight.Visible = true;
          }

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
        }
    }
}

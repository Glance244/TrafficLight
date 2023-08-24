namespace TrafficLigth
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GreenLightStop = new System.Windows.Forms.PictureBox();
            this.YellowStopLight = new System.Windows.Forms.PictureBox();
            this.RedStopLight = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GreenLightStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedStopLight)).BeginInit();
            this.SuspendLayout();
            // 
            // GreenLightStop
            // 
            this.GreenLightStop.Image = global::TrafficLigth.Properties.Resources.Green;
            this.GreenLightStop.Location = new System.Drawing.Point(162, 37);
            this.GreenLightStop.Name = "GreenLightStop";
            this.GreenLightStop.Size = new System.Drawing.Size(161, 342);
            this.GreenLightStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GreenLightStop.TabIndex = 2;
            this.GreenLightStop.TabStop = false;
            // 
            // YellowStopLight
            // 
            this.YellowStopLight.Image = global::TrafficLigth.Properties.Resources.Orange;
            this.YellowStopLight.Location = new System.Drawing.Point(162, 37);
            this.YellowStopLight.Name = "YellowStopLight";
            this.YellowStopLight.Size = new System.Drawing.Size(159, 343);
            this.YellowStopLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.YellowStopLight.TabIndex = 1;
            this.YellowStopLight.TabStop = false;
            // 
            // RedStopLight
            // 
            this.RedStopLight.Image = global::TrafficLigth.Properties.Resources.Red;
            this.RedStopLight.Location = new System.Drawing.Point(162, 37);
            this.RedStopLight.Name = "RedStopLight";
            this.RedStopLight.Size = new System.Drawing.Size(161, 336);
            this.RedStopLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RedStopLight.TabIndex = 0;
            this.RedStopLight.TabStop = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(386, 106);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(121, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Stopbtn
            // 
            this.Stopbtn.Location = new System.Drawing.Point(401, 272);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(124, 23);
            this.Stopbtn.TabIndex = 3;
            this.Stopbtn.Text = "Stop";
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.Stopbtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.GreenLightStop);
            this.Controls.Add(this.YellowStopLight);
            this.Controls.Add(this.RedStopLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GreenLightStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedStopLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedStopLight;
        private System.Windows.Forms.PictureBox YellowStopLight;
        private System.Windows.Forms.PictureBox GreenLightStop;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button Stopbtn;
        private System.Windows.Forms.Timer timer1;
    }
}



namespace Event_Driven_Assignment_2
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
            this.trkThrottle = new System.Windows.Forms.TrackBar();
            this.lblThrottleTitle = new System.Windows.Forms.Label();
            this.lblThrottleReading = new System.Windows.Forms.Label();
            this.lblElevationReading = new System.Windows.Forms.Label();
            this.lblElevationTitle = new System.Windows.Forms.Label();
            this.trkElevation = new System.Windows.Forms.TrackBar();
            this.grpDataDisplay = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblIPTitle = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPortTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevation)).BeginInit();
            this.grpDataDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkThrottle
            // 
            this.trkThrottle.Location = new System.Drawing.Point(34, 299);
            this.trkThrottle.Maximum = 100;
            this.trkThrottle.Name = "trkThrottle";
            this.trkThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThrottle.Size = new System.Drawing.Size(45, 123);
            this.trkThrottle.TabIndex = 0;
            this.trkThrottle.TickFrequency = 10;
            this.trkThrottle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkThrottle.Scroll += new System.EventHandler(this.trkThrottle_Scroll);
            // 
            // lblThrottleTitle
            // 
            this.lblThrottleTitle.AutoSize = true;
            this.lblThrottleTitle.Location = new System.Drawing.Point(31, 270);
            this.lblThrottleTitle.Name = "lblThrottleTitle";
            this.lblThrottleTitle.Size = new System.Drawing.Size(43, 13);
            this.lblThrottleTitle.TabIndex = 1;
            this.lblThrottleTitle.Text = "Throttle";
            // 
            // lblThrottleReading
            // 
            this.lblThrottleReading.AutoSize = true;
            this.lblThrottleReading.Location = new System.Drawing.Point(85, 345);
            this.lblThrottleReading.Name = "lblThrottleReading";
            this.lblThrottleReading.Size = new System.Drawing.Size(13, 13);
            this.lblThrottleReading.TabIndex = 2;
            this.lblThrottleReading.Text = "0";
            // 
            // lblElevationReading
            // 
            this.lblElevationReading.AutoSize = true;
            this.lblElevationReading.Location = new System.Drawing.Point(212, 345);
            this.lblElevationReading.Name = "lblElevationReading";
            this.lblElevationReading.Size = new System.Drawing.Size(13, 13);
            this.lblElevationReading.TabIndex = 5;
            this.lblElevationReading.Text = "0";
            // 
            // lblElevationTitle
            // 
            this.lblElevationTitle.AutoSize = true;
            this.lblElevationTitle.Location = new System.Drawing.Point(158, 270);
            this.lblElevationTitle.Name = "lblElevationTitle";
            this.lblElevationTitle.Size = new System.Drawing.Size(51, 13);
            this.lblElevationTitle.TabIndex = 4;
            this.lblElevationTitle.Text = "Elevation";
            // 
            // trkElevation
            // 
            this.trkElevation.Location = new System.Drawing.Point(161, 299);
            this.trkElevation.Maximum = 5;
            this.trkElevation.Minimum = -5;
            this.trkElevation.Name = "trkElevation";
            this.trkElevation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkElevation.Size = new System.Drawing.Size(45, 123);
            this.trkElevation.TabIndex = 3;
            this.trkElevation.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkElevation.Scroll += new System.EventHandler(this.trkElevation_Scroll);
            // 
            // grpDataDisplay
            // 
            this.grpDataDisplay.Controls.Add(this.label6);
            this.grpDataDisplay.Controls.Add(this.label5);
            this.grpDataDisplay.Controls.Add(this.label4);
            this.grpDataDisplay.Controls.Add(this.label3);
            this.grpDataDisplay.Controls.Add(this.label2);
            this.grpDataDisplay.Controls.Add(this.label1);
            this.grpDataDisplay.Location = new System.Drawing.Point(625, 12);
            this.grpDataDisplay.Name = "grpDataDisplay";
            this.grpDataDisplay.Size = new System.Drawing.Size(150, 214);
            this.grpDataDisplay.TabIndex = 6;
            this.grpDataDisplay.TabStop = false;
            this.grpDataDisplay.Text = "Data Recieved";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Elevator Pitch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Throttle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vertical Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pitch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altitude:";
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Location = new System.Drawing.Point(625, 233);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(32, 13);
            this.lblErrorTitle.TabIndex = 7;
            this.lblErrorTitle.Text = "Error:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(628, 250);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 8;
            // 
            // lblIPTitle
            // 
            this.lblIPTitle.AutoSize = true;
            this.lblIPTitle.Location = new System.Drawing.Point(18, 22);
            this.lblIPTitle.Name = "lblIPTitle";
            this.lblIPTitle.Size = new System.Drawing.Size(61, 13);
            this.lblIPTitle.TabIndex = 9;
            this.lblIPTitle.Text = "IP Address:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(85, 19);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(144, 20);
            this.txtIPAddress.TabIndex = 10;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(85, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(144, 20);
            this.txtPort.TabIndex = 11;
            // 
            // lblPortTitle
            // 
            this.lblPortTitle.AutoSize = true;
            this.lblPortTitle.Location = new System.Drawing.Point(45, 48);
            this.lblPortTitle.Name = "lblPortTitle";
            this.lblPortTitle.Size = new System.Drawing.Size(29, 13);
            this.lblPortTitle.TabIndex = 12;
            this.lblPortTitle.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPortTitle);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.lblIPTitle);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblErrorTitle);
            this.Controls.Add(this.grpDataDisplay);
            this.Controls.Add(this.lblElevationReading);
            this.Controls.Add(this.lblElevationTitle);
            this.Controls.Add(this.trkElevation);
            this.Controls.Add(this.lblThrottleReading);
            this.Controls.Add(this.lblThrottleTitle);
            this.Controls.Add(this.trkThrottle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevation)).EndInit();
            this.grpDataDisplay.ResumeLayout(false);
            this.grpDataDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkThrottle;
        private System.Windows.Forms.Label lblThrottleTitle;
        private System.Windows.Forms.Label lblThrottleReading;
        private System.Windows.Forms.Label lblElevationReading;
        private System.Windows.Forms.Label lblElevationTitle;
        private System.Windows.Forms.TrackBar trkElevation;
        private System.Windows.Forms.GroupBox grpDataDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblIPTitle;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPortTitle;
    }
}


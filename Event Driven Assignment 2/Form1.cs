using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Driven_Assignment_2
{
    public partial class Form1 : Form
    {
        struct TelemetryUpdate
        {
            public double Altitude; //Altitude in feet
            public double Speed; // Plan's speed in knots
            public double Pitch; // Plan's itch in degrees relative to horizon
            public double VerticalSpeed; // Plane's vertical speed in feet per minute
            public double Throttle; // Current throttle setting as a percentage
            public double ElevatorPitch; // Current elevator pitch in degrees

            public int WarningCode; // 0 = No Warning, 1 = Plane lower than 1000ft, 2 = Plane Stalled
        }

        struct ControlsUpdate
        {
            public double Throttle; // Current throttle setting as a percentage
            public double ElevatorPitch; // Current elevator pitch in degrees
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void trkThrottle_Scroll(object sender, EventArgs e)
        {
            int throttleValue = trkThrottle.Value;
            lblThrottleReading.Text = throttleValue.ToString();
        }

        private void trkElevation_Scroll(object sender, EventArgs e)
        {
            int elevationValue = trkElevation.Value;
            lblElevationReading.Text = elevationValue.ToString();
        }

        private void planeError(int errorCode)
        {
            switch(errorCode)
            {
                case 0:
                    // No Error
                    lblErrorMessage.Text = "No Error.";
                    break;

                case 1:
                    // Plane is too low
                    lblErrorMessage.Text = "Plane flying too low.";
                    break;

                case 2:
                    // Plane is at risk of stall
                    lblErrorMessage.Text = "Plane at risk of stalling.";
                    break;
            }
        }
    }
}

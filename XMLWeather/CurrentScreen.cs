using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //varibles
            string currentTemperature = Form1.days[0].currentTemp;
            string sunsetTime = Form1.days[0].sunSet;
            string sunriseTime = Form1.days[0].sunRise;
            string lastUpdatedTime = Form1.days[0].lastUpdate;

            // the current date
            currentDateLabel.Text = DateTime.Now.ToString("dddd MMMM dd yyy");

            // the current information is in index 0, thus why all information is retreived from there
            titleLabel.Text = Form1.days[0].location + " Weather";
            tempLabel.Text = Form1.days[0].currentTemp + "°C";
            minOutput.Text = Form1.days[0].tempLow + "°C";
            maxOutput.Text = Form1.days[0].tempHigh + "°C";
            conditionLabel.Text = Form1.days[0].condition + "\n" + Form1.days[0].windType;
            lastUpdatedLabel.Text = "Last Updated \nDate: " + lastUpdatedTime.Remove(10) + "\nTime: " + lastUpdatedTime.Remove(0,11);
            sunriseOutput.Text = "Time: " + sunriseTime.Remove(0, 11);
            sunsetOutput.Text = "Time: " + sunsetTime.Remove(0, 11);
            humidityOutput.Text = Form1.days[0].humidityAmount + Form1.days[0].humidityUnits;
            pressureOutput.Text = Form1.days[0].pressureAmount + Form1.days[0].pressureUnits;
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void moreDetailButton_Click(object sender, EventArgs e)
        {
            minLabel.Visible = true;
            minOutput.Visible = true;
            maxLabel.Visible = true;
            maxOutput.Visible = true;
            sunriseLabel.Visible = true;
            sunriseOutput.Visible = true;
            sunsetLabel.Visible = true;
            sunsetOutput.Visible = true;
            humidityLabel.Visible = true;
            humidityOutput.Visible = true;
            pressureLabel.Visible = true;
            pressureOutput.Visible = true;
            backButton.Visible = true;
            moreDetailButton.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            minLabel.Visible = false;
            minOutput.Visible = false;
            maxLabel.Visible = false;
            maxOutput.Visible = false;
            sunriseLabel.Visible = false;
            sunriseOutput.Visible = false;
            sunsetLabel.Visible = false;
            sunsetOutput.Visible = false;
            humidityLabel.Visible = false;
            humidityOutput.Visible = false;
            pressureLabel.Visible = false;
            pressureOutput.Visible = false;
            backButton.Visible = false;
            moreDetailButton.Visible = true;
        }
    }
}

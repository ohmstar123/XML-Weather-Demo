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
            string conditionImage = Form1.days[0].condition;

            // the current date
            currentDateLabel.Text = DateTime.Now.ToString("dddd MMMM dd yyy");

            // the current information is in index 0, thus why all information is retreived from there
            titleLabel.Text = Form1.days[0].location + " Weather";
            tempLabel.Text = Form1.days[0].currentTemp + "°C";
            minOutput.Text = Form1.days[0].tempLow + "°C";
            maxOutput.Text = Form1.days[0].tempHigh + "°C";
            conditionLabel.Text = Form1.days[0].condition;
            windLabel.Text = Form1.days[0].windType;
            lastUpdatedLabel.Text = "Last Updated \nDate: " + lastUpdatedTime.Remove(10) + "\nTime: " + lastUpdatedTime.Remove(0,11);
            sunriseOutput.Text = "Time: " + sunriseTime.Remove(0, 11);
            sunsetOutput.Text = "Time: " + sunsetTime.Remove(0, 11);
            humidityOutput.Text = Form1.days[0].humidityAmount + Form1.days[0].humidityUnits;
            pressureOutput.Text = Form1.days[0].windSpeed + Form1.days[0].windSpeedUnits + " "
                + Form1.days[0].windDirection + "°" + Form1.days[0].windDirectionUnits;

            // change image in picturebox based on the type of condition
            switch (conditionImage)
            {
                case "overcast clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "broken clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "few clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "scattered clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "light rain":
                    conditionPicture1.BackgroundImage = Properties.Resources.rainingImage;
                    conditionPicture2.BackgroundImage = Properties.Resources.rainingImage;
                    backgroundPicture.Image = Properties.Resources.realRain;
                    break;
                case "heavy intensity rain":
                    conditionPicture1.BackgroundImage = Properties.Resources.rainingImage;
                    conditionPicture2.BackgroundImage = Properties.Resources.rainingImage;
                    backgroundPicture.Image = Properties.Resources.realRain;
                    break;
                case "moderate rain":
                    conditionPicture1.BackgroundImage = Properties.Resources.rainingImage;
                    conditionPicture2.BackgroundImage = Properties.Resources.rainingImage;
                    backgroundPicture.Image = Properties.Resources.realRain;
                    break;
                case "sky is clear":
                    conditionPicture1.BackgroundImage = Properties.Resources.Sun;
                    conditionPicture2.BackgroundImage = Properties.Resources.Sun;
                    break;
                case "light snow":
                    conditionPicture1.BackgroundImage = Properties.Resources.snowImage;
                    conditionPicture2.BackgroundImage = Properties.Resources.snowImage;
                    backgroundPicture.Image = Properties.Resources.snowing;
                    break;
                case "snow":
                    conditionPicture1.BackgroundImage = Properties.Resources.snowImage;
                    conditionPicture2.BackgroundImage = Properties.Resources.snowImage;
                    backgroundPicture.Image = Properties.Resources.snowing;
                    break;
            }

            if (System.DateTime.Now.Hour <= 17 && System.DateTime.Now.Hour >= 6)
            {
                backgroundPicture.BackColor = Color.Orange;
                titleLabel.BackColor = Color.Orange;
                currentDateLabel.BackColor = Color.Orange;
                lastUpdatedLabel.BackColor = Color.Orange;
                tempLabel.BackColor = Color.Orange;
                conditionPicture1.BackColor = Color.Orange;
                conditionPicture2.BackColor = Color.Orange;
                conditionLabel.BackColor = Color.Orange;
                windLabel.BackColor = Color.Orange;
                minLabel.BackColor = Color.Orange;
                minOutput.BackColor = Color.Orange;
                maxLabel.BackColor = Color.Orange;
                maxOutput.BackColor = Color.Orange;
                sunriseLabel.BackColor = Color.Orange;
                sunriseOutput.BackColor = Color.Orange;
                sunsetLabel.BackColor = Color.Orange;
                sunsetOutput.BackColor = Color.Orange;
                humidityLabel.BackColor = Color.Orange;
                humidityOutput.BackColor = Color.Orange;
                windInfoLabel.BackColor = Color.Orange;
                pressureOutput.BackColor = Color.Orange;
            }
            else
            {
                backgroundPicture.BackColor = Color.Transparent;
                titleLabel.BackColor = Color.Transparent;
                currentDateLabel.BackColor = Color.Transparent;
                lastUpdatedLabel.BackColor = Color.Transparent;
                tempLabel.BackColor = Color.Transparent;
                conditionPicture1.BackColor = Color.Transparent;
                conditionPicture2.BackColor = Color.Transparent;
                conditionLabel.BackColor = Color.Transparent;
                windLabel.BackColor = Color.Transparent;
                minLabel.BackColor = Color.Transparent;
                minOutput.BackColor = Color.Transparent;
                maxLabel.BackColor = Color.Transparent;
                maxOutput.BackColor = Color.Transparent;
                sunriseLabel.BackColor = Color.Transparent;
                sunriseOutput.BackColor = Color.Transparent;
                sunsetLabel.BackColor = Color.Transparent;
                sunsetOutput.BackColor = Color.Transparent;
                humidityLabel.BackColor = Color.Transparent;
                humidityOutput.BackColor = Color.Transparent;
                windInfoLabel.BackColor = Color.Transparent;
                pressureOutput.BackColor = Color.Transparent;
            }

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
            windInfoLabel.Visible = true;
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
            windInfoLabel.Visible = false;
            pressureOutput.Visible = false;
            backButton.Visible = false;
            moreDetailButton.Visible = true;
        }
    }
}

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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// index 1 is tomorrow's information, 2 is 2 days from now, etc. 
        /// </summary>
        public void displayForecast()
        {
            string conditionImage1 = Form1.days[1].condition;
            string conditionImage2 = Form1.days[2].condition;
            string conditionImage3 = Form1.days[3].condition;

            // Day 1
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow + "°C";
            max1.Text = Form1.days[1].tempHigh + "°C";
            condition1.Text = Form1.days[1].condition + "\n" + Form1.days[1].windType;

            // Day 2
            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow + "°C";
            max2.Text = Form1.days[2].tempHigh + "°C";
            condition2.Text = Form1.days[2].condition + "\n" + Form1.days[2].windType;

            // Day 3
            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow + "°C";
            max3.Text = Form1.days[3].tempHigh + "°C";
            condition3.Text = Form1.days[3].condition + "\n" + Form1.days[3].windType;

            switch (conditionImage1)
            {
                case "overcast clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "broken clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "few clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "scattered clouds":
                    conditionPicture1.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "light rain":
                    conditionPicture1.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "heavy intensity rain":
                    conditionPicture1.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "moderate rain":
                    conditionPicture1.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "sky is clear":
                    conditionPicture1.BackgroundImage = Properties.Resources.Sun;
                    break;
                case "light snow":
                    conditionPicture1.BackgroundImage = Properties.Resources.snowImage;
                    break;
                case "snow":
                    conditionPicture1.BackgroundImage = Properties.Resources.snowImage;
                    break;
            }

            switch (conditionImage2)
            {
                case "overcast clouds":
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "broken clouds":
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "few clouds":
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "scattered clouds":
                    conditionPicture2.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "light rain":
                    conditionPicture2.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "heavy intensity rain":
                    conditionPicture2.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "moderate rain":
                    conditionPicture2.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "sky is clear":
                    conditionPicture2.BackgroundImage = Properties.Resources.Sun;
                    break;
                case "light snow":
                    conditionPicture2.BackgroundImage = Properties.Resources.snowImage;
                    break;
                case "snow":
                    conditionPicture2.BackgroundImage = Properties.Resources.snowImage;
                    break;
            }

            switch (conditionImage3)
            {
                case "overcast clouds":
                    conditionPicture3.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "broken clouds":
                    conditionPicture3.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "few clouds":
                    conditionPicture3.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "scattered clouds":
                    conditionPicture3.BackgroundImage = Properties.Resources.cloudy;
                    break;
                case "light rain":
                    conditionPicture3.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "heavy intensity rain":
                    conditionPicture3.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "moderate rain":
                    conditionPicture3.BackgroundImage = Properties.Resources.rainingImage;
                    break;
                case "sky is clear":
                    conditionPicture3.BackgroundImage = Properties.Resources.Sun;
                    break;
                case "light snow":
                    conditionPicture3.BackgroundImage = Properties.Resources.snowImage;
                    break;
                case "snow":
                    conditionPicture3.BackgroundImage = Properties.Resources.snowImage;
                    break;
            }

            if (System.DateTime.Now.Hour <= 17 && System.DateTime.Now.Hour >= 6)
            {
                backgroundPicture.BackColor = Color.Orange;
                titleLabel.BackColor = Color.Orange;
                date1.BackColor = Color.Orange;
                date2.BackColor = Color.Orange;
                date3.BackColor = Color.Orange;
                max1.BackColor = Color.Orange;
                max2.BackColor = Color.Orange;
                max3.BackColor = Color.Orange;
                maxLabel1.BackColor = Color.Orange;
                maxLabel2.BackColor = Color.Orange;
                maxLabel3.BackColor = Color.Orange;
                min1.BackColor = Color.Orange;
                min2.BackColor = Color.Orange;
                min3.BackColor = Color.Orange;
                minLabel.BackColor = Color.Orange;
                minLabel2.BackColor = Color.Orange;
                minLabel3.BackColor = Color.Orange;
                condition1.BackColor = Color.Orange;
                condition2.BackColor = Color.Orange;
                condition3.BackColor = Color.Orange;
                conditionLabel1.BackColor = Color.Orange;
                conditionLabel2.BackColor = Color.Orange;
                conditionLabel3.BackColor = Color.Orange;
                conditionPicture1.BackColor = Color.Orange;
                conditionPicture2.BackColor = Color.Orange;
                conditionPicture3.BackColor = Color.Orange;
                line1.BackColor = Color.Black;
                line2.BackColor = Color.Black;
                line3.BackColor = Color.Black;
                line4.BackColor = Color.Black;
            }
            else
            {
                backgroundPicture.BackColor = Color.Transparent;
                titleLabel.BackColor = Color.Transparent;
                date1.BackColor = Color.Transparent;
                date2.BackColor = Color.Transparent;
                date3.BackColor = Color.Transparent;
                max1.BackColor = Color.Transparent;
                max2.BackColor = Color.Transparent;
                max3.BackColor = Color.Transparent;
                maxLabel1.BackColor = Color.Transparent;
                maxLabel2.BackColor = Color.Transparent;
                maxLabel3.BackColor = Color.Transparent;
                min1.BackColor = Color.Transparent;
                min2.BackColor = Color.Transparent;
                min3.BackColor = Color.Transparent;
                minLabel.BackColor = Color.Transparent;
                minLabel2.BackColor = Color.Transparent;
                minLabel3.BackColor = Color.Transparent;
                condition1.BackColor = Color.Transparent;
                condition2.BackColor = Color.Transparent;
                condition3.BackColor = Color.Transparent;
                conditionLabel1.BackColor = Color.Transparent;
                conditionLabel2.BackColor = Color.Transparent;
                conditionLabel3.BackColor = Color.Transparent;
                conditionPicture1.BackColor = Color.Transparent;
                conditionPicture2.BackColor = Color.Transparent;
                conditionPicture3.BackColor = Color.Transparent;
                line1.BackColor = Color.White;
                line2.BackColor = Color.White;
                line3.BackColor = Color.White;
                line4.BackColor = Color.White;
            }


        }

        /// <summary>
        /// When the Today label is clicked, this user control is removed from the form
        /// and the CurrentScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}

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

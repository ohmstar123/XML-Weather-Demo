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

            // the current date
            currentDateLabel.Text = DateTime.Now.ToString("dddd MMMM dd yyy");

            // the current information is in index 0, thus why all information is retreived from there
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp + "°C";
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;


            conditionLabel.Text = Form1.days[0].condition + "\n" + Form1.days[0].windType;    
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
    }
}

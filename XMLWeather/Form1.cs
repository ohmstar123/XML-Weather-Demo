﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Diagnostics;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        /// <summary>
        /// This method will get forecast information for each day, including today.
        /// Each day will be setup as a separate Day object and added to the days list. 
        /// </summary>
        private void ExtractForecast()
        {
            // get forecast information from web and place in an xml file
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            // extract the relevant information for a day, and repeat for each day in the forecast
            while (reader.Read())
            {
                // create blank day object
                Day d = new Day();

                // find the time element, and get the day attribute
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                // find the symbol element, and get the name attribute
                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("name");

                // find the windSpeed element, and get the name attribute
                reader.ReadToFollowing("windSpeed");
                d.windType = reader.GetAttribute("name");

                //find the temperature element, and get the min and max attributes
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                // add day to days list
                days.Add(d);
            }
        }

        /// <summary>
        /// This method will get the current conditions from the web, convert them to an XML file,
        /// and then use that file to extract information that is not in the forecast file, 
        /// such as the current temperature
        /// </summary>
        private void ExtractCurrent()
        {
            // get current information from web and place in an xml file
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            // find the city element, and add it's name attribute to days[0], (today)
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            // find the sun element and add the set and rise attributes, (sunSet), (sunRise), to days[0], (today)
            reader.ReadToFollowing("sun");
            days[0].sunSet = reader.GetAttribute("set");
            days[0].sunRise = reader.GetAttribute("rise");
           
            // find the temperature element and add the value attribute, (current temp), to days[0], (today)
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            // find the humidity element and add the value and unit attributes, (humidityAmount), (humidityUnits), to days[0], (today)
            reader.ReadToFollowing("humidity");
            days[0].humidityAmount = reader.GetAttribute("value");
            days[0].humidityUnits = reader.GetAttribute("unit");

            // find the pressure element and add the value and unit attributes, (pressureAmount), (pressureUnits), to days[0], (today)
            reader.ReadToFollowing("pressure");
            days[0].pressureAmount = reader.GetAttribute("value");
            days[0].pressureUnits = reader.GetAttribute("unit");

            // find the wind speed element and add the name attribute, (windType), to days[0], (today)
            reader.ReadToFollowing("wind");
            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");
            days[0].windSpeedUnits = reader.GetAttribute("unit");
            days[0].windType = reader.GetAttribute("name");

            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("value");
            days[0].windDirectionUnits = reader.GetAttribute("code");

            // find the symbol element and add the name attribute, (current condition), to days[0], (today)
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");

            // find the lastupdate element and add the value attribute, (lastUpdate), to days[0], (today)
            reader.ReadToFollowing("lastupdate");
            days[0].lastUpdate = reader.GetAttribute("value");


        }
    }
}

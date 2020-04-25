using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, windType, windSpeedUnits, windDirectionUnits, precipitation, visibility, lastUpdate, sunSet, 
            sunRise, humidityAmount, humidityUnits, pressureAmount, pressureUnits;

        /// <summary>
        /// This will create a blank day object where all values are set to "" initially
        /// </summary>
        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = windType = precipitation = visibility = lastUpdate = 
                sunRise = sunSet = humidityAmount = humidityUnits = pressureAmount = pressureUnits = windSpeedUnits 
                = windDirectionUnits = "";
        }
    }
}

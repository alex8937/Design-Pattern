using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    /// <summary>
    /// The weather station.
    /// </summary>
    public class WeatherStation
    {
        /// <summary>
        /// The main.
        /// </summary>
        public static void Main()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
            weatherData.GetNewData(80, 65, 30.4f);
            weatherData.GetNewData(81, 63, 31.2f);
            weatherData.GetNewData(81, 60, 33.5f);
        }
    }
}

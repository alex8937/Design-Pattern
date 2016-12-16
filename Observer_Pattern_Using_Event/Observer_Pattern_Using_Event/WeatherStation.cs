using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Using_Event
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
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            weatherData.GetNewData(80, 65, 30.4f);
            weatherData.GetNewData(81, 63, 31.2f);
            weatherData.GetNewData(81, 60, 33.5f);

        }
    }
}

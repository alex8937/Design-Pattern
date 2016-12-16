// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CurrentConditionDisplay.cs" company="">
//   
// </copyright>
// <summary>
//   The current condition display.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer_Pattern
{
    using System;

    /// <summary>
    /// The current condition display.
    /// </summary>
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        /// <summary>
        /// The weather data.
        /// </summary>
        private ISubject weatherData;

        /// <summary>
        /// The temperature.
        /// </summary>
        private float temperature;

        /// <summary>
        /// The humidity.
        /// </summary>
        private float humidity;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentConditionDisplay"/> class.
        /// </summary>
        /// <param name="weatherData">
        /// The weather data.
        /// </param>
        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        /// <param name="humidity">
        /// The humidity.
        /// </param>
        /// <param name="pressure">
        /// The pressure.
        /// </param>
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.Display();
        }

        /// <summary>
        /// The display.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Current condition: {0} F degree, {1} % humidity", this.temperature, this.humidity);
        }
    }
}
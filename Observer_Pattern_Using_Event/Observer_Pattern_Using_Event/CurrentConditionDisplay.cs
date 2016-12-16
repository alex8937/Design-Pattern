namespace Observer_Pattern_Using_Event
{
    using System;

    /// <summary>
    /// The current condition display.
    /// </summary>
    public class CurrentConditionDisplay : IDisplay
    {
        /// <summary>
        /// The temperature.
        /// </summary>
        private float temperature;

        /// <summary>
        /// The humidity.
        /// </summary>
        private float humidity;

        /// <summary>
        /// The weather data.
        /// </summary>
        private WeatherData weatherData;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentConditionDisplay"/> class.
        /// </summary>
        /// <param name="weatherData">
        /// The weather data.
        /// </param>
        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.ChangeEvent += new WeatherData.ChangeHandler(this.Update);
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        /// <param name="humidity">
        /// The humidity.
        /// </param>
        /// <param name="pressure">
        /// The pressure.
        /// </param>
        public void Update(object subject, float temperature, float humidity, float pressure)
        {
            if (!(subject is WeatherData))
            {
                return;
            }
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
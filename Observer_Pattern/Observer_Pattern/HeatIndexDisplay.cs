namespace Observer_Pattern
{
    using System;

    public class HeatIndexDisplay : IObserver, IDisplay
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
        /// The pressure.
        /// </summary>
        private float pressure;

        /// <summary>
        /// The heatindex.
        /// </summary>
        private float heatindex;

        /// <summary>
        /// Initializes a new instance of the <see cref="HeatIndexDisplay"/> class.
        /// </summary>
        /// <param name="weatherData">
        /// The weather data.
        /// </param>
        public HeatIndexDisplay(ISubject weatherData)
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
            this.pressure = pressure;
            this.Display();
        }

        /// <summary>
        /// The display.
        /// </summary>
        public void Display()
        {
           Console.WriteLine("This heat index is {0:F1}", this.temperature * this.humidity / this.pressure);
        }
    }
}
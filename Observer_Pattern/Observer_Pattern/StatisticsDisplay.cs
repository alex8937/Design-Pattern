namespace Observer_Pattern
{
    using System;

    /// <summary>
    /// The statistics display.
    /// </summary>
    public class StatisticsDisplay : IObserver, IDisplay
    {
        /// <summary>
        /// The weather data.
        /// </summary>
        private ISubject weatherData;

        /// <summary>
        /// The have measured.
        /// </summary>
        private int haveMeasured;

        /// <summary>
        /// The average temperature.
        /// </summary>
        private float averageTemperature;

        /// <summary>
        /// The max temperature.
        /// </summary>
        private float maxTemperature;

        /// <summary>
        /// The min temperature.
        /// </summary>
        private float minTemperature;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsDisplay"/> class.
        /// </summary>
        /// <param name="weatherData">
        /// The weather data.
        /// </param>
        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            this.haveMeasured = 0;
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
            this.haveMeasured++;
            if (this.haveMeasured == 1)
            {
                this.InitializationTemperature(temperature);
            }
            else
            {
                this.UpdateAverageTemperature(temperature);
                this.UpdateMaxTemperature(temperature);
                this.UpdateMinTemperature(temperature);
            }
            this.Display();
        }

        /// <summary>
        /// The display.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Average temperature: {0:F1}, Max temperature: {1:F1}, Min temperature: {2:F1}", this.averageTemperature, this.maxTemperature, this.minTemperature);
        }

        /// <summary>
        /// The initialization temperature.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        private void InitializationTemperature(float temperature)
        {
            this.averageTemperature = this.maxTemperature = this.minTemperature = temperature;
        }

        /// <summary>
        /// The update average temperature.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        private void UpdateAverageTemperature(float temperature)
        {
            this.averageTemperature = ((this.averageTemperature * (this.haveMeasured - 1)) + temperature) / this.haveMeasured;
        }

        /// <summary>
        /// The update max temperature.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        private void UpdateMaxTemperature(float temperature)
        {
            this.maxTemperature = Math.Max(temperature, this.maxTemperature);
        }

        /// <summary>
        /// The update min temperature.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        private void UpdateMinTemperature(float temperature)
        {
            this.minTemperature = Math.Min(temperature, this.minTemperature);
        }
    }
}
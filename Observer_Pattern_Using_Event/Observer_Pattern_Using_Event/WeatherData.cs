namespace Observer_Pattern_Using_Event
{
    /// <summary>
    /// The weather data.
    /// </summary>
    public class WeatherData
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
        /// The pressure.
        /// </summary>
        private float pressure;

        /// <summary>
        /// The change handler.
        /// </summary>
        /// <param name="obj">
        /// The obj.
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
        public delegate void ChangeHandler(object subject, float temperature, float humidity, float pressure);

        /// <summary>
        /// The change event.
        /// </summary>
        public event ChangeHandler ChangeEvent;

        /// <summary>
        /// The notify observer.
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
        public void NotifyObserver(float temperature, float humidity, float pressure)
        {
            this.ChangeEvent?.Invoke(this, temperature, humidity, pressure);
        }

        /// <summary>
        /// The get new data.
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
        public void GetNewData(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.NotifyObserver(temperature, humidity, pressure);
        }
    }
}
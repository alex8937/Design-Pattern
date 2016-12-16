using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    /// <summary>
    /// The weather station.
    /// </summary>
    public class WeatherData : ISubject
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
        /// The observers.
        /// </summary>
        private List<IObserver> observers;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherData"/> class.
        /// </summary>
        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// The register observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// The remove observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        public void RemoveObserver(IObserver observer)
        {
            int pos = this.observers.IndexOf(observer);
            if (pos != -1)
            {
                this.observers.Remove(this.observers[pos]);
            }
        }

        /// <summary>
        /// The notify observer.
        /// </summary>
        public void NotifyObserver()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
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
            this.NotifyObserver();
        }
    }
}

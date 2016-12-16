using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public interface IObserver
    {
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
        void Update(float temperature, float humidity, float pressure);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    /// <summary>
    /// The Subject interface.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// The register observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// The remove observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        void RemoveObserver(IObserver observer);

        /// <summary>
        /// The notify observer.
        /// </summary>
        void NotifyObserver();

    }
}

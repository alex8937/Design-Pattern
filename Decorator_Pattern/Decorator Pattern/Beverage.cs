namespace Decorator_Pattern
{
    /// <summary>
    /// The beverage.
    /// </summary>
    public abstract class Beverage
    {
        /// <summary>
        /// Gets the description.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Gets the cost.
        /// </summary>
        public abstract decimal Cost { get; }
    }
}
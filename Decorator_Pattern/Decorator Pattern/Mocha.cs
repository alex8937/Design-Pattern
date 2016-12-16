namespace Decorator_Pattern
{
    /// <summary>
    /// The mocha.
    /// </summary>
    public class Mocha : Condiment
    {
        /// <summary>
        /// The beverage.
        /// </summary>
        private readonly Beverage beverage;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mocha"/> class.
        /// </summary>
        /// <param name="beverage">
        /// The beverage.
        /// </param>
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// The description.
        /// </summary>
        public override string Description => this.beverage.Description + " with Mocha";

        /// <summary>
        /// The cost.
        /// </summary>
        public override decimal Cost => this.beverage.Cost + .20m;
    }
}
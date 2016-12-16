namespace Decorator_Pattern
{
    /// <summary>
    /// The soymilk.
    /// </summary>
    public class Soymilk : Condiment
    {
        /// <summary>
        /// The beverage.
        /// </summary>
        private readonly Beverage beverage;

        /// <summary>
        /// Initializes a new instance of the <see cref="Soymilk"/> class.
        /// </summary>
        /// <param name="beverage">
        /// The beverage.
        /// </param>
        public Soymilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// The description.
        /// </summary>
        public override string Description => this.beverage.Description + " with Soymilk";

        /// <summary>
        /// The cost.
        /// </summary>
        public override decimal Cost => this.beverage.Cost + .25m;
    }
}
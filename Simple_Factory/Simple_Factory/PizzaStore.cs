// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PizzaStore.cs" company="Optym">
//   Chen
// </copyright>
// <summary>
//   The pizza store.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Simple_Factory
{
    /// <summary>
    /// The pizza store.
    /// </summary>
    public class PizzaStore
    {
        /// <summary>
        /// The factory.
        /// </summary>
        private readonly SimplePizzaFactory factory;

        /// <summary>
        /// Initializes a new instance of the <see cref="PizzaStore"/> class.
        /// </summary>
        /// <param name="factory">
        /// The factory.
        /// </param>
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        /// <summary>
        /// The order pizza.
        /// </summary>
        /// <param name="pizzaType">
        /// The pizza type.
        /// </param>
        /// <returns>
        /// The <see cref="Pizza"/>.
        /// </returns>
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = this.factory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimplePizzaFactory.cs" company="Optym">
//   Chen
// </copyright>
// <summary>
//   The simple pizza factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Simple_Factory
{
    /// <summary>
    /// The simple pizza factory.
    /// </summary>
    public class SimplePizzaFactory
    {
        /// <summary>
        /// The create pizza.
        /// </summary>
        /// <param name="pizzaType">
        /// The pizza Type.
        /// </param>
        /// <returns>
        /// The <see cref="Pizza"/>.
        /// </returns>
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            if (pizzaType == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (pizzaType == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }

            return pizza;
        }
    }
}
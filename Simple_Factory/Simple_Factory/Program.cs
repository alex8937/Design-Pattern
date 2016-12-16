namespace Simple_Factory
{
    /// <summary>
    /// The main body.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        public static void Main()
        {
            PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
            Pizza pizza = pizzaStore.OrderPizza("cheese");
        }
    }
}
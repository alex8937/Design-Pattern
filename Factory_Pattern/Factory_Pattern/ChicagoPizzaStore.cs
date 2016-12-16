namespace Factory_Pattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            if (pizzaType == "cheese")
            {
                pizza = new ChicagoCheesePizza();
            }
            return pizza;
        }
    }
}
namespace Factory_Pattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            if (pizzaType == "cheese")
            {
                pizza = new NYCheesePizza();
            }
            return pizza;
        }
    }
}
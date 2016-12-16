namespace Factory_Pattern
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string pizzaType);

        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = this.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake(); 
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
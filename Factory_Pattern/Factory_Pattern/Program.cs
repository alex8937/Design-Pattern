using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main()
        {
            ChicagoPizzaStore chicagoStore = new ChicagoPizzaStore();
            chicagoStore.OrderPizza("cheese");
        }
    }
}

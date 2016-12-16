namespace Decorator_Pattern
{
    using System;

    /// <summary>
    /// The cafe.
    /// </summary>
    public static class Cafe
    {
        /// <summary>
        /// The main.
        /// </summary>
        public static void Main()
        {
            Beverage drink1 = new HouseBlend(SizeType.Venti);
            Console.WriteLine(drink1.Description);
            Console.WriteLine("$ " + drink1.Cost);
            drink1 = new Mocha(new Mocha(drink1));
            drink1 = new Soymilk(drink1);
            Console.WriteLine(drink1.Description);
            Console.WriteLine("$ " + drink1.Cost);
        }
    }
}

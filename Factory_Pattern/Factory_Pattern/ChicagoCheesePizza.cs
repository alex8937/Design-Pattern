namespace Factory_Pattern
{
    using System;

    public class ChicagoCheesePizza : Pizza
    {
        public override string Name => "Chicago Cheese Pizza";

        public override void Cut()
        {
            Console.WriteLine("Chicago Cut " + this.Name);
        }
    }
}
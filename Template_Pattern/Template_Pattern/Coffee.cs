namespace Template_Pattern
{
    using System;

    public class Coffee : CafffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dip Coffee");
        }

        protected override void AddComdiment()
        {
            Console.WriteLine("Add milk");
        }
    }
}
namespace Compound_Pattern
{
    using System;

    /// <summary>
    /// The rubber duck.
    /// </summary>
    public class RubberDuck : IQuackable
    {


        public void Quack()
        {
            Console.WriteLine("Squeak");
        }

    }
}
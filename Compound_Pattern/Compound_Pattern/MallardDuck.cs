namespace Compound_Pattern
{
    using System;

    /// <summary>
    /// The mallard duck.
    /// </summary>
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
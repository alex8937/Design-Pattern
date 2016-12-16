namespace Compound_Pattern
{
    using System;

    /// <summary>
    /// The duck call.
    /// </summary>
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
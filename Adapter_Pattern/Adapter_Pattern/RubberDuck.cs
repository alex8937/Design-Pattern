namespace Adapter_Pattern
{
    using System;

    public class RubberDuck : Duck
    {
        public void Quack()
        {
            Console.WriteLine("Squeak..");
        }

        public void Fly()
        {
            Console.WriteLine("Rubber Duck Does not Fly.");
        }
    }
}
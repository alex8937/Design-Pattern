namespace Adapter_Pattern
{
    using System;

    public class WildTurkey : Turkey
    {
        public void Gobble()
        {
           Console.WriteLine("Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Turkey fly");
        }
    }
}
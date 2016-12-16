namespace Adapter_Pattern
{
    using System;

    public class TurkeyPretendingDuck : Duck
    {
        private Turkey turkey;

        public TurkeyPretendingDuck(Turkey turkey)
        {
            this.turkey = turkey;
        }
        public void Quack()
        {
           this.turkey.Gobble();
        }

        public void Fly()
        {
            Console.Write("Try to fly as a duck: ");
            this.turkey.Fly();
        }
    }
}
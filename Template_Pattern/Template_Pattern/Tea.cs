namespace Template_Pattern
{
    using System;

    public class Tea : CafffeineBeverage
    {
        public Tea(bool CustomerWantsComdiment = true)
        {
            this.CustomerWantsComdiment = CustomerWantsComdiment;
        }

        protected override void Brew()
        {
            Console.WriteLine("Steep tea");
        }

        protected override void AddComdiment()
        {
            Console.WriteLine("Add lemon");
        }
    }
}
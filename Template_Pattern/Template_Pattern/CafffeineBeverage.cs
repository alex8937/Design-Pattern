namespace Template_Pattern
{
    using System;

    public abstract class CafffeineBeverage
    {
        protected bool CustomerWantsComdiment = true;

        public void Prepare()
        {
            this.BoilWater();
            this.Brew();
            this.PourWater();
            if (this.CustomerWantsComdiment)
            {
                this.AddComdiment();
            }
        }

        protected abstract void Brew();

        protected abstract void AddComdiment();
        protected void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        protected void PourWater()
        {
            Console.WriteLine("Pour in water");
        }

        
    }
}
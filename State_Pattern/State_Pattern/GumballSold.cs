namespace State_Pattern
{
    using System;

    public class GumballSold : State
    {
        public GumballSold(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public GumballMachine gumballMachine { get; }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice does not give you another");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Do not insert another one quarter.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry. You have already turned the crank.");
        }

        public void Dispense()
        {
            Console.WriteLine("Dispensing...You get a gumball right now...");
            this.gumballMachine.count--;
            if (this.gumballMachine.count > 0)
            {
                this.gumballMachine.state = this.gumballMachine.noQuarterState;
            }
            else
            {
                this.gumballMachine.state = this.gumballMachine.outofGumballState;
            }
        }

        public override string ToString()
        {
            return "Gumball Sold";
        }
    }
}
namespace State_Pattern
{
    using System;

    public class NoQuarter : State
    {

        public NoQuarter(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public GumballMachine gumballMachine { get; }

        public void TurnCrank()
        {
            Console.WriteLine("You need to insert quarter.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You now insert a quarter.");
            this.gumballMachine.state = this.gumballMachine.hasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You need first insert a quarter.");
        }

        public void Dispense()
        {
        }
        public override string ToString()
        {
            return "No Quarter";
        }
    }
}
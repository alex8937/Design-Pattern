namespace State_Pattern
{
    using System;

    public class Forfeit : State
    {
        public Forfeit(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public GumballMachine gumballMachine { get; }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            Console.WriteLine("Dispensing...Oops...You got unlucky...Your coin has been lost..Haha");
            this.gumballMachine.state = this.gumballMachine.noQuarterState;
        }
    }
}
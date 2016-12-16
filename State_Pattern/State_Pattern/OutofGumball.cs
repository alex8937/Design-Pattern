namespace State_Pattern
{
    using System;

    public class OutofGumball : State
    {
        public OutofGumball(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public GumballMachine gumballMachine { get; }

        public void TurnCrank()
        {
            Console.WriteLine("You turned the crank but no gumball is available.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cannot insert a quarter because no gumball is available ");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You cannot eject a quarter because no gumball is available ");
        }

        public void Dispense()
        {
        }

        public override string ToString()
        {
            return "OutofGumball";
        }
    }
}
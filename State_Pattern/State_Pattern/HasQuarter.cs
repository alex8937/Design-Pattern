namespace State_Pattern
{
    using System;

    public class HasQuarter : State
    {
        public HasQuarter(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public GumballMachine gumballMachine { get; }

        public void TurnCrank()
        {
            Console.WriteLine("You turned the crank.");
            int rand = new Random(Guid.NewGuid().GetHashCode()).Next(9);
            //Console.WriteLine("Random: " + rand);
            if (rand == 0)
            {
                this.gumballMachine.state = this.gumballMachine.forfeitState;
            }
            else
            {
                this.gumballMachine.state = this.gumballMachine.gumballSoldState;
            }
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cannot insert another coin.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Return the quarter.");
            this.gumballMachine.state = this.gumballMachine.noQuarterState;
        }

        public void Dispense()
        {
            Console.WriteLine("Please first turn the crank.");
        }
        public override string ToString()
        {
            return "Has Quarter";
        }
    }
}
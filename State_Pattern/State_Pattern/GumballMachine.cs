namespace State_Pattern
{
    using System;

    public class GumballMachine
    {
        public GumballMachine(int count)
        {
            this.noQuarterState = new NoQuarter(this);
            this.hasQuarterState = new HasQuarter(this);
            this.gumballSoldState = new GumballSold(this);
            this.outofGumballState = new OutofGumball(this);
            this.forfeitState = new Forfeit(this);
            this.count = count;
            if (count > 0)
            {
                this.state = this.noQuarterState;
            }
            else
            {
                this.state = this.outofGumballState;
            }
        }

        public State state { get; set; }


        public int count { get; set; }
        public NoQuarter noQuarterState { get; }
        public HasQuarter hasQuarterState { get; }
        public GumballSold gumballSoldState { get; }
        public OutofGumball outofGumballState { get; }
        public Forfeit forfeitState { get; }

        public void TurnCrank()
        {
            Console.WriteLine("State: " + this.state);
            this.state.TurnCrank();
            this.state.Dispense();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("State: " + this.state);
            this.state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            Console.WriteLine("State: " + this.state);
            this.state.EjectQuarter();
        }
    }
}
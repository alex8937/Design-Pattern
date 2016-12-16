namespace State_Pattern
{
    public interface State
    {
        GumballMachine gumballMachine { get; }

        void TurnCrank();

        void InsertQuarter();

        void EjectQuarter();

        void Dispense();

    }
}
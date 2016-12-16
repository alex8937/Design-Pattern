using System;

namespace Compound_Pattern
{
    /// <summary>
    /// The duck simulator.
    /// </summary>
    public class DuckSimulator
    {
        public static void Main()
        {
            DuckSimulator duckSimulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new DuckFactory();
            duckSimulator.Simulate(duckFactory);
        }

        void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("Duck Simulator:");
            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);
            IQuackable mallardDuck1 = duckFactory.CreateMallardDuck();
            IQuackable mallardDuck2 = duckFactory.CreateMallardDuck();
            IQuackable mallardDuck3 = duckFactory.CreateMallardDuck();
            IQuackable mallardDuck4 = duckFactory.CreateMallardDuck();
            Flock flockOfMallards = new Flock();
            flockOfMallards.Add(mallardDuck1);
            flockOfMallards.Add(mallardDuck2);
            flockOfMallards.Add(mallardDuck3);
            flockOfMallards.Add(mallardDuck4);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nWhole Flock:");
            this.Simulate(flockOfDucks);
            Console.WriteLine("\nMallard Flock:");
            this.Simulate(flockOfMallards);
            Console.WriteLine("Total Quack: " + QuackCounter.NumberQuacker);
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}

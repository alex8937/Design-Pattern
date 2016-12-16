using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main()
        {
            Duck turkeyAdapter = new TurkeyPretendingDuck(new WildTurkey());
            DuckTester(turkeyAdapter);
        }

        static void DuckTester(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}

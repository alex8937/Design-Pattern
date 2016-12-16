using System;

namespace Template_Pattern
{
    class Program
    {
        static void Main()
        {
            Tea myTea = new Tea(false);
            myTea.Prepare();
            Coffee myCoffee = new Coffee();
            myCoffee.Prepare();
        }
    }
}

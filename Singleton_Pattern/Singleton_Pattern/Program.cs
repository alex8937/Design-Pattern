using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = StaticSingleton.GetInstance;
            Console.WriteLine(singleton1.number);
            singleton1.number = 2;
            var singleton2  = StaticSingleton.GetInstance;
            Console.WriteLine(singleton2.number);
        }
    }
}

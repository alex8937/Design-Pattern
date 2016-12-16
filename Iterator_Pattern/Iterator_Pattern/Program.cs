using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    using System.Collections;

    class Program
    {
        static void Main()
        {
            ArrayClass array = new ArrayClass(10);
            ListClass list = new ListClass(17);
            Iterator arrayIterator = array.CreateIterator; // Use writen Iterator Interface
            IEnumerator listIterator = list.CreateIterator;  // Use built-in IEnumerable
            while (arrayIterator.HasNext())
            {
                Console.Write(arrayIterator.GetNext() + " ");
            }
            Console.WriteLine();
            while (listIterator.MoveNext())
            {
                Console.Write(listIterator.Current + " ");
            }
            Console.WriteLine();
        }
    }
}

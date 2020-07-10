using System;
using System.Collections.Generic;

namespace yield_example
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var x in GetNumber())
            {
                Console.WriteLine($"Number {x}");
            }
        }

        public static IEnumerable<int> GetNumber()
        {
            for(int i=0;i<30;i++)
            {
                yield return i;
            }
        }
    }
}

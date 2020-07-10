using System;

namespace unchecked_example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                unchecked
                {
                    int maxValue = int.MaxValue;
                    maxValue = maxValue + 1;
                }
                Console.WriteLine("I'm after checked");
            }
            catch
            {
                Console.WriteLine("Hello, I jumped in the catch");
            }
        }
    }
}

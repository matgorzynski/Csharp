using System;

namespace out_example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AddTwoNumber(out int result);
            Console.WriteLine("Sum: " + result.ToString());
            }
        public static void AddTwoNumber(out int sum)
        {
            Console.WriteLine("Type next number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type last number:");
            int b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
        }
    }
}

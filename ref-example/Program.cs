using System;

namespace ref_example
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Type first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            string sum = AddTwoNumberRef(ref firstNumber, ref secondNumber).ToString();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("end ref");
        }

        public static int AddTwoNumberRef(ref int a, ref int b)
        {
            return a + b;
        }
    }
}

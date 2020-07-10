using System;

namespace boxing_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some text:");
            string _someText = Console.ReadLine();
            object obj = _someText;
            Console.WriteLine(obj.ToString());
        }
    }
}

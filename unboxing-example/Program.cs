using System;

namespace unboxing_example
{
    class Program
    {
        static void Main(string[] args)
        {
            object someObject = "some text in object";
            string someString = (string)someObject;
            Console.WriteLine(someString);

        }
    }
}

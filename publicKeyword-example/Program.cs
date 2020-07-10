using System;

namespace publicKeyword_example
{
    class Program
    {
        public class Cars
        {
            public int KilometersPerHour { get; set; }
            public string Brand { get; set; }
        }
        static void Main(string[] args)
        {
            var ford = new Cars();
            ford.KilometersPerHour = 156;
            ford.Brand = "ford";
            Console.WriteLine($"Auto brand is {ford.Brand}, max kph = {ford.KilometersPerHour}");

        }
    }
}

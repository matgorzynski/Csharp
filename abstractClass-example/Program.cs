using System;

namespace abstractClass_example
{
    class Program
    {
        abstract class Cars
        {
            public abstract string Brand { get; set; }
            public abstract string GetBrand();
        }

        class Opel : Cars
        {
            public override string Brand { get; set; } = "Opel";

            public override string GetBrand()
            {
                return Brand;
            }
        }
        static void Main(string[] args)
        {
            //Cannot create abstract class
            //var _cars = new Cars();

            var _opel = new Opel();
            Console.WriteLine($"Auto brand is {_opel.GetBrand()}");
        }
    }
}

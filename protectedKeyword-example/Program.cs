using System;

namespace protectedKeyword_example
{
    class Program
    {
        public class Cars
        {
            protected string Brand { get; set; }
            protected int NumberOfDoors { get; set; }
        }
        public class Ford : Cars
        {
            public int KilometersPerHour { get; set; }
            public void ChangeDetails(string brand, int nof, int kph)
            {
                Brand = brand;
                NumberOfDoors = nof;
                KilometersPerHour = kph;
            }

            public void GetDetails(out string brand, out int nof, out int kph)
            {
                brand = Brand;
                nof = NumberOfDoors;
                kph = KilometersPerHour;
            }
        }
        static void Main(string[] args)
        {
            /* 
             * Code gernerate error
             * var car = new Cars();
            car.Brand = "Ford";
            Console.WriteLine(car.Brand);*/

            var ford = new Ford();
            ford.ChangeDetails("ford", 5, 123);
            ford.GetDetails(out string brand, out int numberOfDoord, out int kilometerPerHours);
            Console.WriteLine($"Auto brand is {brand}, max kph = {kilometerPerHours}, and he have {numberOfDoord} doors.");
        }
    }
}

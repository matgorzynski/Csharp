using System;

namespace privateKeyword_example
{
    class Program
    {
        public class Cars
        {
            private int KilometersPerHour { get; set; }
            private string Brand { get; set; }

            public void SetKilometerPerHour(int kph)
            {
                KilometersPerHour = kph;
            }

            public void SetBrand(string brand)
            {
                Brand = brand;
            }

            public int GetKilemetersPerHour()
            { return KilometersPerHour; }
            public string GetBrand()
            { return Brand; }
        }
        static void Main(string[] args)
        {
            var car = new Cars();
            car.SetKilometerPerHour(220);
            car.SetBrand("Some Brand");
            Console.WriteLine($"Auto brand is {car.GetBrand()}, max kph = {car.GetKilemetersPerHour()}");

        }
    }
}

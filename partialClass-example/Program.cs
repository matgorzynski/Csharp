using System;

namespace partialClass_example
{
    class Program
    {

        public partial class Ford
        {
            public int NumberOfDoors { get; set; } = 4;

            public int GetNumberOfDoors()
            {
                return NumberOfDoors;
            }
        }

        public partial class Ford
        {
            public string Brand { get; set; } = "Ford";
            public string GetBrand()
            {
                return Brand;
            }
        }
        static void Main(string[] args)
        {
            var _ford = new Ford();
            Console.WriteLine($"Auto brand is {_ford.GetBrand()}, number of doors = {_ford.GetNumberOfDoors()}");
        }
    }
}

using System;

namespace sealedClass_example
{
    class Program
    {
        public class Cars
        {
            public int NumberOfDoors { get; set; } = 4;

            public int GetNumberOfDoors()
            {
                return NumberOfDoors;
            }

            public virtual int SomeFunction()
            {
                return 0;
            }
        }

        public sealed class Ford : Cars
        {
            public string Brand { get; set; } = "Ford";
            public string GetBrand()
            {
                return Brand;
            }

            sealed public override int SomeFunction()
            {
                return 0;
            }

        }


            /* public class MiniFord:Ford 
             {
             // Cannot inherent from sealed class and we cannot override sealed function

             public override int SomeFunction()
             {
                 return 0;
             }
         }*/
        static void Main(string[] args)
        {
            var _ford = new Ford();
            Console.WriteLine($"Auto brand is {_ford.GetBrand()}, number of doors = {_ford.GetNumberOfDoors()}");
        }
    }
}

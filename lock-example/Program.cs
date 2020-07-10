using System;

namespace lock_example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How much have you money in wallet?");
            int amount =  Convert.ToInt32(Console.ReadLine());
            object person = amount;
            lock (person)
            {
                Console.WriteLine("How much costed your lasts shopping?");
                int costs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Before the last purchase you had " + (int)person + costs);
            }

        }
    }
}

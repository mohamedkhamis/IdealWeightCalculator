using System;

namespace IdealWeightCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightCalculator weightCalculator = new WeightCalculator
            {
                Height = 180,
                Gender = 'm'
            };

            double weight = weightCalculator.GetIdealBodyWeight();

            Console.WriteLine($"The Ideal Body Weight is: {weight}");

            if (weight == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test succeeded");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test failed!");
            }

            weightCalculator.Gender = 'w';
            weight = weightCalculator.GetIdealBodyWeight();

            if (weight == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test succeeded");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test failed!");
            }


            Console.ReadKey();
        }
    }
}

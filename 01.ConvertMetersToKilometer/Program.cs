using System;

namespace _01.ConvertMetersToKilometer
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            meters = meters / 1000;
            Console.WriteLine($"{meters:f2}");
        }
    }
}

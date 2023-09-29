using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = (Console.ReadLine());
            if (a.ToUpper() == a)
            {
                Console.WriteLine($"upper-case");

            }
            else
            {
                Console.WriteLine($"lower-case");
            }
        }
    }
}

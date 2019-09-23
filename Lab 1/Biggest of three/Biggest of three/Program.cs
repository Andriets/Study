using System;

namespace Biggest_of_three
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
             
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"Max = {a}");
                }
                else
                {
                    Console.WriteLine($"Max = {c}");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"Max = {b}");
                }
                else
                {
                    Console.WriteLine($"Max = {c}");
                }
            }
        }
    }
}

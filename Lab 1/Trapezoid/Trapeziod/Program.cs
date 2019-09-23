using System;

namespace Trapeziod
{
    class Program
    {
        static void Main()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double area = (a + b) / 2 * h;
            Console.WriteLine($"Area = {area}");
       
        }
    }
}

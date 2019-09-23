using System;

namespace N_th
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, n;
            number = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            double nDigit =  ((number / (Math.Pow(10, (n - 1)))) % (10));
            nDigit = Math.Floor(nDigit);
            Console.WriteLine(nDigit);
        }
    }
}

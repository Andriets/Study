using System;

namespace Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lastDigit;
            n = int.Parse(Console.ReadLine());
            lastDigit = n %(10);
            Console.WriteLine(lastDigit);
        }
    }
}

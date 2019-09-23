using System;

namespace Pure_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool res = true;
             if (n%9==0 || n%11==0 || n%13==0)
            {
                Console.WriteLine(res);
            }
             else
            {
                Console.WriteLine(!res);
            }
        }
    }
}

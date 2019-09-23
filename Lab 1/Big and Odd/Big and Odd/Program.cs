using System;

namespace Big_and_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool Res;
            n = int.Parse(Console.ReadLine());

                if (n > 20 && n % 2 == 1)
                {
                Res = true;
                Console.WriteLine(Res);
                }
                else
            {
                Res = false;
                Console.WriteLine(Res);
            }
        }
    }
}

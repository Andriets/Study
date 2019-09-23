using System;

namespace Sign_of_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int k = 0;
            if (a > 0)
                k++;
            if (b > 0)
                k++;
            if (c > 0)
                k++;

            if (k == 0 || k == 2)
                Console.WriteLine("Negative");
            else if (k == 1 || k == 3)
                Console.WriteLine("Positive");
        }
    }
}

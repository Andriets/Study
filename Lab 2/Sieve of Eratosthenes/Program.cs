using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()) , p=2;
            int[] arr = new int[n];
            int b = 0;

            for (int i = 0; i < n; i++)
                arr[i] = i+1;

            Console.Write(p + " ");
            do
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % p == 0)
                    {
                        for (int j = i; j < n - 1; j++)
                            arr[j] = arr[j + 1];
                        n--; i--;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] > p)
                    {
                        p = arr[i];
                        break;
                    }
                }
                Console.Write(p + " ");
            }
            while (p != arr[n-1]);

            

        }
    }
}

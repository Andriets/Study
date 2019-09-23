using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int l = 0, r = 0 , k = 0;

            for (int i=0; i<arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    l += arr[j];
                for (int j = i + 1; j < arr.Length; j++)
                    r += arr[j];

                if (l == r)
                {
                    k = i;
                }
                r = 0; l = 0;
            }

            if (k != 0)
                Console.WriteLine(k);
            else
                Console.WriteLine("No");

        }
    }
}

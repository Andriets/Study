using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = 1, p = 0, s = 1, t = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    s++;
                    if (s > k)
                    {
                        k = s;
                        p = t;
                    }
                }
                else
                {
                    s = 1;
                    t = i;
                }                 
            }

            for (int i = p; i < p+k; i++)
                Console.Write(arr[i] + " ");

        }
    }
}

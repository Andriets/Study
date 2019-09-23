using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] arr = Console.ReadLine().Split().Select(ushort.Parse).ToArray();
            int p = 0, k=0, s=1;

            for (int i=0; i<arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        k++;
                        if (k > s)
                        {
                            s = k;
                            p = arr[i];
                        }
                    }
                }
                k = 0;
            }

            Console.WriteLine("The number: " + p + " is the most frequent (occur " + s + " times)");
        }
    }
}

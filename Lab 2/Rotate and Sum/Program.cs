using System;
using System.Linq;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = Convert.ToInt32(Console.ReadLine());

            int[] sum = new int[arr.Length];
            int t;

            for (int i=0; i<k; i++)
            {
                t = arr[arr.Length - 1];
                for (int j = arr.Length-1; j>0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = t;

                /*for (int j = 0; j < arr.Length; j++)
                    Console.Write(arr[j] + " ");
                    Console.WriteLine();*/

                for (int j = 0; j<arr.Length; j++)
                {
                    sum[j] += arr[j];
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(sum[i] + " ");

        }
    }
}

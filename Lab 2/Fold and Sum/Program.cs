using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            if (arr.Length % 4 != 0)
                Console.WriteLine("The array is not fully divisible by 4!");

            int k = arr.Length / 4;
            int[] row1 = new int[k * 2];
            int o = 0;
            for (int i=k-1; i>=0; i--)
            {
                row1[o] = arr[i];
                o++;
            }
            o = k;
            for (int i=arr.Length-1; i>arr.Length-1-k; i--)
            {
                row1[o] = arr[i];
                o++;
            }

           /* for (int i = 0; i < row1.Length; i++)
                Console.Write(row1[i] + " ");
                Console.WriteLine(" ");*/

            int[] row2 = new int[row1.Length];
            for (int i = 0; i < row2.Length ; i++)
            {
                row2[i] = arr[i+k];
               /* Console.Write(row2[i] + " ");*/
            }
            Console.WriteLine(" ");
            int[] sum = new int[row1.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = row1[i] + row2[i];
                Console.Write(sum[i] + " ");
            }
        }
    }
}

using System;
using System.Linq;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = Convert.ToInt32(Console.ReadLine()) , a, k =0 ;

            for (int i=0; i<arr.Length; i++)
            {
                a = arr[i] - n;
                for (int j=0; j<arr.Length; j++)
                {
                        if (a == arr[j])
                            k++;
                }
            }

            Console.WriteLine(k);


        }
    }
}

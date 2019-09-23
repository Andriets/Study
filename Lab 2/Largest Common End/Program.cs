using System;
using System.Linq;

namespace LAB_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше речення");
            string[] arr1 = Console.ReadLine().Split().ToArray();
            Console.WriteLine("Введіть друге речення");
            string[] arr2 = Console.ReadLine().Split().ToArray();

            int k = 0, t = 0 , s;

            if (arr1.Length > arr2.Length)
            {
                s = arr1.Length - arr2.Length;
                for (int i=0; i<arr2.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                        k++;
                    else
                        break;
                }
                for (int i = arr1.Length - 1; i > s; i--)
                {
                    if (arr1[i] == arr2[i - s])
                        t++;
                    else
                        break;
                }
            }
            else
            {
                s = arr2.Length - arr1.Length;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                        k++;
                    else
                        break;
                }
                for (int i = arr2.Length-1; i > s; i--)
                {
                    if (arr1[i-s] == arr2[i])
                        t++;
                    else
                        break;
                }
            }
            if (t > k)
                Console.WriteLine(t);
            else
                Console.WriteLine(k);


        }
    }
}

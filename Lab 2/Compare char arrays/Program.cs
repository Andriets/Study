using System;
using System.Linq;

namespace Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            Console.WriteLine();
            int k = 0;

            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                    if (arr1[i] == arr2[i])
                        k++;
                    else
                        break;
                if (k == arr2.Length)
                {
                    for (int i = 0; i < arr2.Length; i++)
                        Console.Write(arr2[i] + " ");
                    Console.WriteLine();
                    for (int i = 0; i < arr1.Length; i++)
                        Console.Write(arr1[i] + " ");
                    
                }
                else
                {
                    for (int i=0; i<arr2.Length; i++)
                        if (arr1[i] > arr2[i])
                        {
                            for (int j = 0; j < arr2.Length; j++)
                                Console.Write(arr2[j] + " ");
                            Console.WriteLine();
                            for (int j = 0; j < arr1.Length; j++)
                                Console.Write(arr1[j] + " ");
                            break;
                        }
                        else
                        {
                            for (int j = 0; j < arr1.Length; j++)
                                Console.Write(arr1[j] + " ");
                            Console.WriteLine();
                            for (int j = 0; j < arr2.Length; j++)
                                Console.Write(arr2[j] + " ");
                            break;
                        }
                }            
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                    if (arr1[i] == arr2[i])
                        k++;
                    else
                        break;
                if (k == arr2.Length)
                {
                    for (int i = 0; i < arr2.Length; i++)
                        Console.Write(arr2[i] + " ");
                    Console.WriteLine();
                    for (int i = 0; i < arr1.Length; i++)
                        Console.Write(arr1[i] + " ");
                   
                }
                else
                {
                    for (int i = 0; i < arr1.Length; i++)
                        if (arr1[i] > arr2[i])
                        {
                            for (int j = 0; j < arr2.Length; j++)
                                Console.Write(arr2[j] + " ");
                            Console.WriteLine();
                            for (int j = 0; j < arr1.Length; j++)
                                Console.Write(arr1[j] + " ");
                            break;
                        }
                        else
                        {
                            for (int j = 0; j < arr1.Length; j++)
                                Console.Write(arr1[j] + " ");
                            Console.WriteLine();
                            for (int j = 0; j < arr2.Length; j++)
                                Console.Write(arr2[j] + " ");
                            break;
                        }
                }
            }          
        }
    }
}

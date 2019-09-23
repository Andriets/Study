using System;
using System.Linq;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr1 = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] arr2 = new int[26];
            for (int i = 0; i < 26; i++)
                arr2[i] = i+1;

            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr1.Length; j++)
                    if (arr[i] == arr1[j])
                        Console.WriteLine(arr[i] + " -> " + arr2[j]);
            
        }
    }
}

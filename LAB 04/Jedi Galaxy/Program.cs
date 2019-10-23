using System;
using System.Linq;

namespace Jedi_Galaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмірність масиву: ");
            int[] dim = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dim[0];
            int cols = dim[1];
            int[,] matrix = new int[rows, cols];
            int k = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = k;
                    k++;
                }
            }

            string command = "";
            int Istars = 0;

            while (command != "Let the Force be with you")
            {
                Console.Write("Введіть координати Ivo: ");
                int[] Ivo = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int x = Ivo[0] - 1;
                int y = Ivo[1] - 1;

                Console.Write("Введіть координати Evil Pover: ");
                int[] Evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int x1 = Evil[0] - 1;
                int y1 = Evil[1] - 1;

                for (int i = rows - 1; i >= 0; i--)
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        if (i == x1 && j == y1)
                        {
                            matrix[i, j] = 0;
                            x1--;
                            y1--;
                        }
                        if (i == x && j == y)
                        {
                            Istars += matrix[i, j];
                            x--;
                            y++;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(Istars);
        }
    }
}

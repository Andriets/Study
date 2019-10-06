using System;

namespace Rentangle_Intersection
{
    class Rectangle
    {
        public string id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Rectangle(string i, int w, int h, int x1, int y1)
        {
            id = i;
            width = w;
            height = h;
            x = x1;
            y = y1;
        }

        public bool Per(Rectangle r1, Rectangle r2)
        {
            int ax = r1.x, ay = r1.y, ax1 = r1.x + r1.width, ay1 = r1.y + r1.height;
            int bx = r2.x, by = r2.y, bx1 = r2.x + r2.width, by1 = r2.y + r2.height;

            if ( (ax >= bx && ax <= bx1) || (ax1 >= bx && ax1 <= bx1) || (ay >= by && ay <= by1) || (ay1 >= by && ay1 <= by1) )
                return true;
            else
                return false;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введіть кількіть прямокутників: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість порівнянь: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Rectangle[] rectangles = new Rectangle[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введіть id: ");
                string id = Console.ReadLine();
                Console.Write("Введіть ширину: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть висоту: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                rectangles[i] = new Rectangle(id, width, height, x, y);
            }

            int first=0, second=0;
            for (int i = 0; i < m; i++)
            {
                Console.Write("Перший об'єкт: ");
                string id1 = Console.ReadLine();
                Console.Write("Другий об'єкт: ");
                string id2 = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    if (rectangles[j].id == id1)
                    {
                        first = j;
                    }
                    if (rectangles[j].id == id2)
                    {
                        second = j;
                    }
                }
                Console.WriteLine(rectangles[first].Per(rectangles[first], rectangles[second]));
            }
            

        }
    }
}

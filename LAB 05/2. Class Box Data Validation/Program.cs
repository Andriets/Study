using System;

namespace _2._Class_Box_Data_Validation
{
    class Box
    {
        private double length;
        public double Length
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Length cannot be zero or negative");
                else
                    length = value;
            }
            get { return length; }
        }
        private double width;
        public double Width
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Width cannot be zero or negative");
                else
                    width = value;
            }
            get { return width; }
        }
        private double height;
        public double Height
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Height cannot be zero or negative");
                else
                    height = value;
            }
            get { return height; }
        }

       /* public Box(double l, double w, double h)
        {
            length = l;
            width = w;
            height = h;
        }*/

        public void Surarea()
        {
            double surar = 2 * length * width + 2 * length * height + 2 * width * height;
            Console.WriteLine("Surface area - " + surar);
        }
        public void LSA()
        {
            double lsa = 2 * length * height + 2 * width * height;
            Console.WriteLine("Lateral Surface Area - " + lsa);
        }
        public void Volume()
        {
            Console.WriteLine("Volume - " + length * width * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину, ширину і висоту: ");
            Box box = new Box();
            box.Length = Convert.ToDouble(Console.ReadLine());
            box.Width = Convert.ToDouble(Console.ReadLine());
            box.Height = Convert.ToDouble(Console.ReadLine());

            if (box.Length <= 0 || box.Width <= 0 || box.Height <= 0)
                Console.WriteLine(" ");
            else
            {
                box.Surarea();
                box.LSA();
                box.Volume();
            }
        }
    }
}

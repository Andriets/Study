using System;

namespace _1._Class_Box
{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Box(double lengh, double width, double height)
        {
            Length = lengh;
            Width = width;
            Height = height;
        }

        public void Surarea()
        {
            double surar = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
            Console.WriteLine("Surface area - " + surar);
        }
        public void LSA()
        {
            double lsa = 2 * Length * Height + 2 * Width * Height;
            Console.WriteLine("Lateral Surface Area - " + lsa);
        }
        public void Volume()
        {
            Console.WriteLine("Volume - " + Length*Width*Height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину, ширину і висоту: ");
            double l = Convert.ToDouble(Console.ReadLine());
            double w = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            Box box = new Box(l, w, h);
            box.Surarea();
            box.LSA();
            box.Volume();
        }
    }
}

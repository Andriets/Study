using System;

namespace Speed_Rasing
{
    class Auto
    {
        public string Model { get; set; }
        public int Fuel_amount { get; set; }
        public double FcFor1km { get; set; }
        public int distance { get; set; } = 1;

        public Auto (string m, int f, double fc)
        {
            Model = m;
            Fuel_amount = f;
            FcFor1km = Math.Round(fc,2);
            distance = 1;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість автомобілів: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Auto[] Autos = new Auto[n];
            bool k = true;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Марка автомобіля: ");
                string Model = Console.ReadLine();
                do
                {
                    k = true;
                    for (int j = 0; j < i; j++)
                        if (Autos[j].Model == Model)
                        {
                            k = false;
                            Console.Write("Дана марка вже є, введіть другу: ");
                            Model = Console.ReadLine();
                        }
                            
                        
                } while (k != true);
                Console.Write("Кількість пального: ");
                int Fuel_amount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Використання палива на 1км: ");
                double FcFor1km = Convert.ToDouble(Console.ReadLine());
                Autos[i] = new Auto(Model, Fuel_amount, FcFor1km);
            }

            foreach (Auto p in Autos)
            {
                Console.WriteLine(p.Model + " " + p.Fuel_amount + " " + p.FcFor1km , "/n");
            }

        }
    }
}

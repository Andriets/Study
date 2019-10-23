using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars_Slesman
{
    class Engine
    {
        public string model { get; set; }
        public int power { get; set; }
        public int displacement { get; set; }
        public string efficiency { get; set; }

        public Engine (string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
    }

    class Car
    {
        public string model { get; set; }
        public Engine engine { get; set; }
        public int weight { get; set; }
        public string color { get; set; }

        public Car(string model, Engine engine, int weight, string color)
        {
            if (model == "")
                this.model = "n/a";
            else
                this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }
        public void Display(Engine eng)
        {
            Console.WriteLine("CarModel: "+this.model );
            Console.WriteLine('\t' + "EngineModel: " + eng.model );
            Console.WriteLine('\t' + "Power: "+ eng.power);
            Console.WriteLine('\t' + "Displacement: " + eng.displacement);
            Console.WriteLine('\t' + "Efficiency: " + eng.efficiency);
            Console.WriteLine("Weight: " + this.weight);
            Console.WriteLine("Color: " + this.color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < N; i++)
            {
                Console.Write("Engine model: ");
                string model = Console.ReadLine();
                Console.Write("Engine power: ");
                int power = Convert.ToInt32(Console.ReadLine());
                Console.Write("Engine displacement: ");
                int displacement = Convert.ToInt32(Console.ReadLine());
                Console.Write("Engine efficiently: ");
                string efficiently = Console.ReadLine();
                engines.Add(new Engine(model, power, displacement, efficiently));
            }
            Console.WriteLine();
            int M = Convert.ToInt32(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < M; i++)
            {
                Console.Write("Car model: ");
                string carmodel = Console.ReadLine();
                Console.Write("Car engine: ");
                string engModel = Console.ReadLine();
                Engine engine = engines.FirstOrDefault(x => x.model == engModel);
                Console.Write("Car weight: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Car color: ");
                string color = Console.ReadLine();
                cars.Add(new Car(carmodel, engine, weight, color));
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (cars[i].engine == engines[j])
                    {
                        cars[i].Display(engines[j]);
                    }
                }
            }

        }
    }
}

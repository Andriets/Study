using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Raw_Data
{
    class Car
    {
        public string model { get; set; }
        public int engineSpeed { get; set; }
        public int enginePower { get; set; }
        public int cargoWeight { get; set; }
        public string cargoType { get; set; }
        public double tire1Pressure { get; set; }
        public int tire1Age { get; set; }
        public double tire2Pressure { get; set; }
        public int tire2Age { get; set; }
        public double tire3Pressure { get; set; }
        public int tire3Age { get; set; }
        public double tire4Pressure { get; set; }
        public int tire4Age { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age )
        {
            this.model = model;
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
            this.tire1Pressure = tire1Pressure;
            this.tire1Age = tire1Age;
            this.tire2Pressure = tire2Pressure;
            this.tire2Age = tire2Age;
            this.tire3Pressure = tire3Pressure;
            this.tire3Age = tire3Age;
            this.tire4Pressure = tire4Pressure;
            this.tire4Age = tire4Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                int engineSpeed = Convert.ToInt32(parameters[1]);
                int enginePower = Convert.ToInt32(parameters[2]);
                int cargoWeight = Convert.ToInt32(parameters[3]);
                string cargoType = parameters[4];
                double tire1Pressure = Convert.ToDouble(parameters[5]);
                int tire1age = Convert.ToInt32(parameters[6]);
                double tire2Pressure = Convert.ToDouble(parameters[7]);
                int tire2age = Convert.ToInt32(parameters[8]);
                double tire3Pressure = Convert.ToDouble(parameters[9]);
                int tire3age = Convert.ToInt32(parameters[10]);
                double tire4Pressure = Convert.ToDouble(parameters[11]);
                int tire4age = Convert.ToInt32(parameters[12]);
                cars.Add(new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1age, tire2Pressure, tire2age, tire3Pressure, tire3age, tire4Pressure, tire4age));
            }

            string type = Console.ReadLine();
            if (type == "fragile")
            {
                for (int i = 0; i < n; i++)
                {
                    if (cars[i].cargoType == type && (cars[i].tire1Pressure < 1 || cars[i].tire2Pressure < 1 || cars[i].tire3Pressure < 1 || cars[i].tire4Pressure < 1))
                        Console.WriteLine(cars[i].model);
                }
            }
            else if (type == "flamable")
            {
                for (int i = 0; i < n; i++)
                {
                    if (cars[i].cargoType == type && cars[i].enginePower > 250)
                        Console.WriteLine(cars[i].model);
                }
            }

        }
    }
}

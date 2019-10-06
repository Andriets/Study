using System;

namespace Define_a_Class_Person
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public void GetInfo()
        {
            Console.WriteLine($"Ім'я: {Name} , Вік: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Pesho = new Person();
            Pesho.Name = "Pesho";
            Pesho.Age = 20;
            Person Gosho = new Person();
            Gosho.Name = "Gosho";
            Gosho.Age = 18;
            Person Stamat = new Person();
            Stamat.Name = "Stamat";
            Stamat.Age = 43;

            Pesho.GetInfo();
            Gosho.GetInfo();
            Stamat.GetInfo();
        }
    }
}

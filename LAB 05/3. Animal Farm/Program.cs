using System;

namespace _3._Animal_Farm
{
    class Program
    {
        class Chicken
        {
            private string name;
            private int age;
            public string Name
            {
                set
                {
                    name = value;
                }
                get { return name; }
            }
            public int Age
            {
                set
                {
                 age = value;
                }
                get { return age; }
            }
            public Chicken(string n, int a)
            {
                    name = n;
                    age = a;
            }
            public void Display()
            {
                if (name == "" || name == " ")
                    Console.WriteLine("Name cannot be empty!");
                else if (age <= 0 || age >= 15)
                    Console.WriteLine("Age should be between 0 and 15!");
                else
                    Console.WriteLine($"Chicken {name} (Age {age}) can produce 1 eggs per day.");
            }
        }
            static void Main(string[] args)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Chicken chicken = new Chicken(name, age);
                chicken.Display();
             
            }
    }
}


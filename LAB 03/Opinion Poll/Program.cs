using System;
using System.Collections.Generic;

namespace Opinion_Poll
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string n, int a) { Name = n; Age = a; }
        public int CompareTo(Person p)
        {
            return Name.CompareTo(p.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ім'я члена сім'ї: ");
                string name = Console.ReadLine();
                Console.Write("Вік: ");
                int age = Convert.ToInt32(Console.ReadLine());
                people[i] = new Person(name, age);
            }

            Array.Sort(people);

            foreach (Person p in people)
            {
                if (p.Age > 30)
                Console.WriteLine("{0} - {1}", p.Name, p.Age);
            }
        }
    }
}

using System;

namespace Creating_Constructors
{
    class Person
    {
        private string name;
        private int age;

        public Person() { name = "No name"; age = 1; }
        public Person(int a) { name = "NO name"; age = a; }
        public Person(string n, int a) { name = n; age = a; }

        public void GetInfo()
        {
            Console.WriteLine($"Ім'я: {name} , Вік: {age}");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
                Person Pesho = new Person();
                Person Gosho = new Person(18);
                Person Stamat = new Person("Stamat", 43);

                Pesho.GetInfo();
                Gosho.GetInfo();
                Stamat.GetInfo();
            }
    }
}

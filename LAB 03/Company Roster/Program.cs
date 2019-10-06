using System;


namespace Company_Roster
{
    class Employee
    {
        public string name { get; set; } 
        public double salary { get; set; }
        public string position { get; set; }
        public string departament { get; set; }
        public string email { get; set; }
        public string age { get; set; }

        public Employee(string n, double sal, string pos, string dep, string e, string a)
        {
            name = n;
            salary = sal;
            position = pos;
            departament = dep;
            if (e == "")
                email = "n/a";
            else
                email = e;
            if (a == "")
                age = "-1";
            else
                age = a;
        }

      /*  public Employee(string n, double sal, string pos, string dep)
        {
            name = n;
            salary = sal;
            position = pos;
            departament = dep;
            email = "n/a";
            age = "-1";
        }*/


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кількість робітників: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Employee[] people = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("Зарплата: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Посада: ");
                string position = Console.ReadLine();
                Console.Write("Відділ: ");
                string departament = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Вік: ");
                string age = Console.ReadLine();
                people[i] = new Employee(name, salary, position, departament, email, age);
            }

            string dep, topdep = people[0].departament;
            int k = 0;
            double rez = 0, sal=0, max = 0;

            for (int i = 0; i < n; i++)
            {
                if (rez > max)
                {
                    max = rez;
                    topdep = people[i - 1].departament;
                }
                sal = 0;
                k = 0;
                dep = people[i].departament;
                for (int j = 0; j < n; j++)
                {
                    if (people[j].departament == dep)
                    {
                        k++;
                        sal += people[j].salary;
                        rez = sal / k;
                    }
                }
            }
            Console.WriteLine("Highest Average salary: " + topdep);

            foreach (Employee p in people)
            {
                if (p.departament == topdep)
                {
                    Console.WriteLine(p.name + " " + Math.Round(p.salary, 2) + " " + p.email + " " + p.age);
                }
            }

        }
    }
}

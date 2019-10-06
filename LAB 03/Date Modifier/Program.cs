using System;
using System.Linq;


namespace Date_Modifier
{
    class DataModifier
    {
        private int Days;

        public int Diff(string d1, string d2)
        {
            DateTime Date1 = Convert.ToDateTime(d1);
            DateTime Date2 = Convert.ToDateTime(d2);

            Days = Convert.ToInt32((Date1 - Date2).TotalDays);
            if (Days < 0)
            {
                Days *= -1;
            }

            return Days;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DataModifier date = new DataModifier();
            Console.WriteLine(date.Diff(date1, date2));
        }
    }
}

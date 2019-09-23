using System;

class LAB_1
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        float average = (a + b + c) / 3;
        Console.WriteLine($"average = {average}");
    }
}


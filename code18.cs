using System;

class Program
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiplication Table:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}
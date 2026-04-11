using System;

class Program
{
    static void Main()
    {
        int num, fact = 1;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}
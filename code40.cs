using System;

class Program
{
    static void Main()
    {
        int n, sum = 0;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum of first " + n + " natural numbers = " + sum);
    }
}
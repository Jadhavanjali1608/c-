using System;

class Program
{
    static void Main()
    {
        int num, sum = 0, remainder;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            remainder = num % 10;
            sum += remainder;
            num = num / 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}
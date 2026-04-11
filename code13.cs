using System;

class Program
{
    static void Main()
    {
        int num, reverse = 0, remainder;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num = num / 10;
        }

        Console.WriteLine("Reversed number = " + reverse);
    }
}
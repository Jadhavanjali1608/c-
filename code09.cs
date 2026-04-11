using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        c = Convert.ToInt32(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("Largest number is: " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Largest number is: " + b);
        }
        else
        {
            Console.WriteLine("Largest number is: " + c);
        }
    }
}
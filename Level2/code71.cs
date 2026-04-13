using System;

class Program
{
    // Method with parameters
    static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Calling method with arguments
        Add(num1, num2);
    }
}
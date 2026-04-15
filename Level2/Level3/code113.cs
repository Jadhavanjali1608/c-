using System;

// Static class
static class Calculator
{
    // Static method
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Calling static methods without creating object
        int sum = Calculator.Add(5, 3);
        int product = Calculator.Multiply(5, 3);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
    }
}
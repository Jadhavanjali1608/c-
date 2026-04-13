using System;

class MathOperations
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
    static void Main()
    {
        // Calling static methods using class name
        Console.WriteLine("Sum = " + MathOperations.Add(10, 20));
        Console.WriteLine("Product = " + MathOperations.Multiply(5, 4));
    }
}
using System;

class Program
{
    static void Main()
    {
        int a = 5, b = 10;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
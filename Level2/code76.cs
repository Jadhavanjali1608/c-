using System;

class Program
{
    static void Increment(ref int num)
    {
        num = num + 10;
    }

    static void Main()
    {
        int value = 5;   // must be initialized

        Console.WriteLine("Before: " + value);

        Increment(ref value);

        Console.WriteLine("After: " + value);
    }
}
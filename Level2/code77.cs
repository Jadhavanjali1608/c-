using System;

class Program
{
    // Method using params keyword
    static int Sum(params int[] numbers)
    {
        int total = 0;

        foreach (int num in numbers)
        {
            total += num;
        }

        return total;
    }

    static void Main()
    {
        Console.WriteLine("Sum of 2 numbers: " + Sum(10, 20));
        Console.WriteLine("Sum of 3 numbers: " + Sum(10, 20, 30));
        Console.WriteLine("Sum of 5 numbers: " + Sum(1, 2, 3, 4, 5));
    }
}
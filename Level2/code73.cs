using System;

class Program
{
    // Recursive method
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)   // Base condition
            return 1;

        return n * Factorial(n - 1);  // Recursive call
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);

        Console.WriteLine("Factorial = " + result);
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = input.Replace(" ", "");

        Console.WriteLine("String without spaces: " + result);
    }
}
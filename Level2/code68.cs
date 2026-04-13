using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter substring to replace: ");
        string oldSub = Console.ReadLine();

        Console.Write("Enter new substring: ");
        string newSub = Console.ReadLine();

        string result = input.Replace(oldSub, newSub);

        Console.WriteLine("Updated string: " + result);
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string reversed = "";
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        if (input == reversed)
        {
            Console.WriteLine("Palindrome string");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}
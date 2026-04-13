using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter email address: ");
        string email = Console.ReadLine();

        // Email pattern
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        if (Regex.IsMatch(email, pattern))
        {
            Console.WriteLine("Valid Email");
        }
        else
        {
            Console.WriteLine("Invalid Email");
        }
    }
}
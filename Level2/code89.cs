using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "My email is test123@gmail.com and phone is 9876543210";

        // 1. Find email pattern
        string emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        Match emailMatch = Regex.Match(input, emailPattern);

        // 2. Find phone number (10 digits)
        string phonePattern = @"\d{10}";
        Match phoneMatch = Regex.Match(input, phonePattern);

        if (emailMatch.Success)
            Console.WriteLine("Email found: " + emailMatch.Value);

        if (phoneMatch.Success)
            Console.WriteLine("Phone found: " + phoneMatch.Value);

        // 3. Replace digits with *
        string masked = Regex.Replace(input, @"\d", "*");
        Console.WriteLine("Masked string: " + masked);
    }
}
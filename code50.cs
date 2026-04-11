using System;

class Program
{
    static void Main()
    {
        // Current date and time
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date & Time: " + now);

        // Individual parts
        Console.WriteLine("Year: " + now.Year);
        Console.WriteLine("Month: " + now.Month);
        Console.WriteLine("Day: " + now.Day);
        Console.WriteLine("Hour: " + now.Hour);
        Console.WriteLine("Minute: " + now.Minute);

        // Custom date
        DateTime date = new DateTime(2025, 5, 10);
        Console.WriteLine("\nCustom Date: " + date);

        // Formatting
        Console.WriteLine("Formatted Date: " + now.ToString("dd/MM/yyyy"));
        Console.WriteLine("Formatted Time: " + now.ToString("HH:mm:ss"));
    }
}
using System;

class UserDetails
{
    static void Main()
    {
        // Taking input from user
        Console.Write("Enter your Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your Email: ");
        string email = Console.ReadLine();

        // Displaying user details
        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Email: " + email);
    }
}
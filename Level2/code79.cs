using System;

class Program
{
    static void DisplayDetails(string name, int age, string city)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
        Console.WriteLine("-------------------");
    }

    static void Main()
    {
        // Normal way (positional arguments)
        DisplayDetails("Anjali", 20, "Nashik");

        // Named arguments (order changed)
        DisplayDetails(city: "Pune", name: "Rahul", age: 22);

        // Mixing named and positional arguments
        DisplayDetails("Priya", city: "Mumbai", age: 21);
    }
}
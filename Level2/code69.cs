using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Create StringBuilder object
        StringBuilder sb = new StringBuilder("Hello");

        Console.WriteLine("Initial string: " + sb);

        // Append text
        sb.Append(" World");
        Console.WriteLine("After Append: " + sb);

        // Insert text
        sb.Insert(5, " C#");
        Console.WriteLine("After Insert: " + sb);

        // Replace text
        sb.Replace("World", "Universe");
        Console.WriteLine("After Replace: " + sb);

        // Remove part of string
        sb.Remove(5, 3);
        Console.WriteLine("After Remove: " + sb);

        // Clear all content
        sb.Clear();
        Console.WriteLine("After Clear: " + sb);
    }
}
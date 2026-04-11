using System;

class Program
{
    static void Main()
    {
        // var keyword
        var x = 10;        // int
        var y = "Hello";   // string

        Console.WriteLine("var examples:");
        Console.WriteLine(x);
        Console.WriteLine(y);

        // dynamic keyword
        dynamic d = 10;
        Console.WriteLine("\ndynamic example:");
        Console.WriteLine(d);

        d = "Now I am string";
        Console.WriteLine(d);

        d = 5.5;
        Console.WriteLine(d);
    }
}
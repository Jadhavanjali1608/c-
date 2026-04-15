using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator obj = new Calculator();

        Console.WriteLine(obj.Add(2, 3));
        Console.WriteLine(obj.Add(2, 3, 4));
    }
}

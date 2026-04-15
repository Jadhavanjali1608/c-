using System;

class Demo
{
    // const variable (compile-time constant)
    public const double PI = 3.14;

    // readonly variable (runtime constant)
    public readonly int x;

    // Constructor
    public Demo(int value)
    {
        x = value;  // readonly can be assigned here
    }

    public void Show()
    {
        Console.WriteLine("Const PI: " + PI);
        Console.WriteLine("Readonly x: " + x);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Demo d1 = new Demo(10);
        d1.Show();

        Demo d2 = new Demo(20);
        d2.Show();
    }
}
using System;

class Program
{
    // const variable (compile-time constant)
    const double PI = 3.14;

    // readonly variable (initialized at runtime)
    readonly int value;

    // constructor to initialize readonly
    public Program(int val)
    {
        value = val;
    }

    static void Main()
    {
        Program obj = new Program(10);

        Console.WriteLine("Const PI = " + PI);
        Console.WriteLine("Readonly value = " + obj.value);

        // PI = 3.141; ❌ Error (cannot change const)
        // obj.value = 20; ❌ Error (cannot change readonly after initialization)
    }
}
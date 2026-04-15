using System;

// Interface
interface IAnimal
{
    void Sound();   // method without body
}

// Class implementing interface
class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal a = new Dog();

        a.Sound();
    }
}
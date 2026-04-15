using System;

// Abstract class
abstract class Animal
{
    public abstract void Sound();  // abstract method

    public void Sleep()            // normal method
    {
        Console.WriteLine("Animal is sleeping");
    }
}

// Interface
interface IAnimal
{
    void Eat();   // method without body
}

// Derived class implementing both
class Dog : Animal, IAnimal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }

    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();

        d.Sound();   // from abstract class
        d.Sleep();   // from abstract class
        d.Eat();     // from interface
    }
}
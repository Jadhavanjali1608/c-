using System;

// First part of partial class
public partial class Student
{
    public void GetData()
    {
        Console.WriteLine("Getting student data...");
    }
}

// Second part of same class
public partial class Student
{
    public void DisplayData()
    {
        Console.WriteLine("Displaying student data...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.GetData();
        s.DisplayData();
    }
}
using System;

class Program
{
    static void Main()
    {
        double basic, hra, da, totalSalary;

        Console.Write("Enter Basic Salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        // Allowances
        hra = 0.20 * basic;  // 20% HRA
        da = 0.10 * basic;   // 10% DA

        totalSalary = basic + hra + da;

        Console.WriteLine("HRA = " + hra);
        Console.WriteLine("DA = " + da);
        Console.WriteLine("Total Salary = " + totalSalary);
    }
}
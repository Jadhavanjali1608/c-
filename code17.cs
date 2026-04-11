using System;

class Program
{
    static void Main()
    {
        int num, count = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num == 0)
        {
            count = 1;
        }
        else
        {
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
        }

        Console.WriteLine("Number of digits = " + count);
    }
}

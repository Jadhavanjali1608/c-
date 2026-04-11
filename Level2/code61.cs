using System;

class Program
{
    static void Main()
    {
        int r1, c1, r2, c2;

        Console.Write("Enter rows and columns of first matrix: ");
        r1 = Convert.ToInt32(Console.ReadLine());
        c1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter rows and columns of second matrix: ");
        r2 = Convert.ToInt32(Console.ReadLine());
        c2 = Convert.ToInt32(Console.ReadLine());

        if (c1 != r2)
        {
            Console.WriteLine("Matrix multiplication not possible!");
            return;
        }

        int[,] a = new int[r1, c1];
        int[,] b = new int[r2, c2];
        int[,] result = new int[r1, c2];

        Console.WriteLine("Enter first matrix elements:");
        for (int i = 0; i < r1; i++)
            for (int j = 0; j < c1; j++)
                a[i, j] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second matrix elements:");
        for (int i = 0; i < r2; i++)
            for (int j = 0; j < c2; j++)
                b[i, j] = Convert.ToInt32(Console.ReadLine());

        // Matrix Multiplication
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < c1; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        Console.WriteLine("Resultant Matrix:");

        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[rows, cols];
        int[,] b = new int[rows, cols];
        int[,] sum = new int[rows, cols];

        Console.WriteLine("Enter elements of first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Matrix Addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum[i, j] = a[i, j] + b[i, j];
            }
        }

        Console.WriteLine("Resultant Matrix (Sum):");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Enter size of first array: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter size of second array: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n1];
        int[] arr2 = new int[n2];
        int[] merged = new int[n1 + n2];

        Console.WriteLine("Enter first array elements:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter second array elements:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Merge first array
        for (int i = 0; i < n1; i++)
        {
            merged[i] = arr1[i];
        }

        // Merge second array
        for (int i = 0; i < n2; i++)
        {
            merged[n1 + i] = arr2[i];
        }

        Console.WriteLine("Merged array:");

        for (int i = 0; i < n1 + n2; i++)
        {
            Console.Write(merged[i] + " ");
        }
    }
}
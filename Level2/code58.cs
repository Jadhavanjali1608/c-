using System;

class Program
{
    static void Main()
    {
        int n, key, flag = 0;

        Console.Write("Enter size of array: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter element to search: ");
        key = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == key)
            {
                Console.WriteLine("Element found at position: " + (i + 1));
                flag = 1;
                break;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("Element not found");
        }
    }
}
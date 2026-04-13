using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5, 6 }; // missing 3
        int n = 6; // total numbers (1 to 6)

        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            actualSum += arr[i];
        }

        int missingNumber = expectedSum - actualSum;

        Console.WriteLine("Missing Number = " + missingNumber);
    }
}
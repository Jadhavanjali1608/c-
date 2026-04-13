using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int[] freq = new int[256]; // ASCII size

        for (int i = 0; i < input.Length; i++)
        {
            freq[input[i]]++;
        }

        Console.WriteLine("Character frequencies:");

        for (int i = 0; i < 256; i++)
        {
            if (freq[i] > 0)
            {
                Console.WriteLine((char)i + " : " + freq[i]);
            }
        }
    }
}
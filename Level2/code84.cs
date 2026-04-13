using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Remove spaces and convert to lowercase
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Not Anagram");
            return;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        bool isAnagram = true;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                isAnagram = false;
                break;
            }
        }

        if (isAnagram)
            Console.WriteLine("Strings are Anagram");
        else
            Console.WriteLine("Strings are Not Anagram");
    }
}
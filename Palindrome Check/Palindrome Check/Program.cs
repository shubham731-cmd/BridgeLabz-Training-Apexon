using System;           // For Console, Math, etc.
using System.Collections.Generic;  // For List, Dictionary, etc.
using System.Linq;      // For LINQ operations
using System.Text;      // For string manipulation
using System.IO;

class Program
{
    static bool isPalindrome(string input)
    {
        int l = 0, r = input.Length - 1;
        while (l < r)
        {
            if (input[l] != input[r])
            {
                return false;
            }
            l++; r--;
        }
        return true;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        if (isPalindrome(s))
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("not a palindrome");
        }
    }
}

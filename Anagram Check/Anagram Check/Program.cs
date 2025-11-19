
using System;           // For Console, Math, etc.
using System.Collections.Generic;  // For List, Dictionary, etc.
using System.Linq;      // For LINQ operations
using System.Text;      // For string manipulation
using System.IO;

class Program
{
    static bool isAnagram(string s1, string s2)
    {
        //string str1=new string(s1.OrderBy(c => c).ToArray());
        //string str2=new string(s2.OrderBy(c => c).ToArray());
        //List<int>l= new List<int>();
        int[] str1= new int[26];
        foreach(char i in s1)
        {
            if (char.IsLetter(i))
            {
                str1[i - 'a']++;
            }
        }
        int[] str2 = new int[26];
        foreach (char i in s2)
        {
            if (char.IsLetter(i))
            {
                str2[i - 'a']++;
            }
        }

        return str1.SequenceEqual(str2);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter a string1: ");
        string s1 = Console.ReadLine();
        Console.Write("Enter a string2: ");
        string s2 = Console.ReadLine();
        if (isAnagram(s1,s2))
        {
            Console.WriteLine("anagram");
        }
        else
        {
            Console.WriteLine("not a anagram");
        }
    }
}

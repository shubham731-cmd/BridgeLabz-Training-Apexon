using System;           // For Console, Math, etc.
using System.Collections.Generic;  // For List, Dictionary, etc.
using System.Linq;      // For LINQ operations
using System.Text;      // For string manipulation
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        int v = 0,c=0;
        Console.Write("enter a string: "); ///s=aeadr
        string s = Console.ReadLine();
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i]=='A' || s[i] == 'E' || s[i] == 'O' || s[i] == 'I' || s[i] == 'U' || s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                v++;
            }
            else
            {
                c++;
            }
        }
        Console.WriteLine("vowels: " + v);
        Console.WriteLine("consonants: " + c);

    }
}
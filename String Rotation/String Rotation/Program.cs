using System;           // For Console, Math, etc.
using System.Collections.Generic;  // For List, Dictionary, etc.
using System.Linq;      // For LINQ operations
using System.Text;      // For string manipulation
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String1: ");
        string s1= Console.ReadLine();  
        Console.Write("Enter String2: ");
        string s2 = Console.ReadLine();  
      
        if ((s1+s1).Contains(s2))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }


    }
}
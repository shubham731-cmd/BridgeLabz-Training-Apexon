using System;           // For Console, Math, etc.
using System.Collections.Generic;  // For List, Dictionary, etc.
using System.Linq;      // For LINQ operations
using System.Text;      // For string manipulation
using System.IO;

class Program
{
    public static void Main(String [] args)
    {
        Console.Write("Enter a string: ");
        string s=Console.ReadLine();
        //Console.WriteLine(s);
        string str = "";
        for(int i = s.Length-1;i>=0; i-- ) 
        {
            str += s[i];
        }
        Console.Write(str);
    }
}

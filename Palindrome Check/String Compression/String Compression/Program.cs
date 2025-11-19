using System;           // For Console, Math, etc.
using System.Collections.Generic;  // For List, Dictionary, etc.
using System.Linq;      // For LINQ operations
using System.Text;      // For string manipulation
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string :");  //aaabbd a3b2d1
        string s= Console.ReadLine();
        Dictionary<char, int> m = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            m[s[i]] = m.GetValueOrDefault(s[i],0)+1;
        }
        foreach(var p in m){
            Console.Write(p.Key +""+ p.Value);
        }

                
    }
}

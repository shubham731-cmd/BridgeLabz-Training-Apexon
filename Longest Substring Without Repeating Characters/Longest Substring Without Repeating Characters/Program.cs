using System;           // For Console, Math, etc.
using System.Collections.Generic;  // For List, Dictionary, etc.
using System.Linq;      // For LINQ operations
using System.Text;      // For string manipulation   abcabcabc
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string s=Console.ReadLine();
        Dictionary<char,int>m = new Dictionary<char,int>();
        Dictionary<char,int>mp=new Dictionary<char,int>();
        int start = 0,maxi=int.MinValue;
        for(int i= 0;i<s.Length;i++){
            m[s[i]] = m.GetValueOrDefault(s[i], 0) + 1;
            if (m[s[i]] > 1 && mp[s[i]]>=start)
            {
                start = mp[s[i]] + 1;
            }
            mp[s[i]]= i;
            maxi = Math.Max(maxi,i+1-start);
        }
        Console.WriteLine(maxi);
    }
}
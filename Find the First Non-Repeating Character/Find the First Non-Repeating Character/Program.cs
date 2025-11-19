using System;
using System.Collections.Generic;
public class Test
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        Dictionary<char, int> m = new Dictionary<char, int>();
        foreach (var e in s)
        {
            m[e] = m.GetValueOrDefault(e, 0) + 1;
        }
        foreach (var e in s)
        {
            if (m[e] == 1)
            {
                Console.Write(e);
                return;
            }
        }

    }
}

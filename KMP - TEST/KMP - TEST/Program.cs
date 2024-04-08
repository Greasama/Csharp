using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = "ABABDABACDABABCABAB";
        string pattern = "ABABCABAB";

        int index = KmpSearch(text, pattern);

        if (index != -1)
        {
            Console.WriteLine($"Pattern found at index {index}.");
        }
        else
        {
            Console.WriteLine("Pattern not found.");
        }
    }

    static int KmpSearch(string text, string pattern)
    {
        int[] next = BuildNext(pattern);

        int i = 0;
        int j = 0;
        while (i < text.Length)
        {
            if (text[i] == pattern[j])
            {
                i++;
                j++;
            }
            else if (j > 0)
            {
                j = next[j - 1];
            }
            else
            {
                i++;
            }

            if (j == pattern.Length)
            {
                return i - j;
            }
        }

        return -1;
    }

    static int[] BuildNext(string pattern)
    {
        List<int> next = new List<int>();
        next.Add(0);
        int prefixLen = 0;
        int i = 1;
        while (i < pattern.Length)
        {
            if (pattern[prefixLen] == pattern[i])
            {
                prefixLen++;
                next.Add(prefixLen);
                i++;
            }
            else
            {
                if (prefixLen == 0)
                {
                    next.Add(0);
                    i++;
                }
                else
                {
                    prefixLen = next[prefixLen - 1];
                }
            }
        }
        return next.ToArray();
    }
}


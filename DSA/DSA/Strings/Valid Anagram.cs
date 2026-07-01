using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Valid_Anagram
    {
        public static bool Anagram(String s1, String s2)
        {
            if(s1.Length != s2.Length)
            {
                return false;
            }
            int[] str = new int[26];
            foreach(char c in s1)
            {
                str[c - 'a']++;
            }
            foreach(char c1 in s2)
            {
                if(--str[c1 - 'a'] <0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
               int[] cnt = new int[26];
            foreach (char c in s)
            {
                cnt[c - 'a']++;
            }
              foreach (char c in t)
            {
                if (--cnt[c - 'a'] < 0)
                {
                    return false;
                }
            }
                                
            return true;
        }
    }
}

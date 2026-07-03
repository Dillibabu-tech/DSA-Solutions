using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Minimum_Window_Substring
    {
        static string minimunWindow(string s ,string t)
        {
            Dictionary<char, int> need = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (need.ContainsKey(c))
                {
                    need[c]++;
                }
                else
                {
                    need[c] = 1;
                }
            }
                Dictionary<char, int> window = new Dictionary<char, int>();
                int left = 0;
                int formed = 0;
                int minlength = int.MaxValue;
                int req = need.Count;
                int start = 0;
                for(int i = 0;i<s.Length;i++)
                {
                    char cur = s[i];
                    if(window.ContainsKey(cur))
                    {
                        window[cur]++;
                    }
                    else
                    {
                        window[cur] = 1;
                    }
                    if (need.ContainsKey(cur) && window[cur] == need[cur])
                    {
                        formed++;
                    }
                    while (formed == req)
                    {
                        if (i - left + 1 < minlength)
                        {
                            minlength = i - left + 1;
                            start = left;
                        }
                        char cur1 = s[left];
                        window[cur1]--;
                        if(need.ContainsKey(cur1) && window[cur1] < need[cur1])
                        {
                            formed--;
                        }
                        left++;
                    }

                }            
               if(minlength == int.MaxValue)
                {
                    return "";
                }
                return s.Substring(start, minlength);
            }
          
        }

    }

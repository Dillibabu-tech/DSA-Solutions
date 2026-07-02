using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Group_Anagrams
    {
        public static IList<IList<string>> Groupanag(string[] s)
        {
            Dictionary<string, IList<string>> str  = new Dictionary<string, IList<string>>();
            foreach(string s1 in s)
            {
                char[] chars = s1.ToCharArray();
                Array.Sort(chars);
                String s2 = new string(chars);
                if(!str.ContainsKey(s2))
                {
                    str[s2] = new List<string>();
                }
                str[s2].Add(s1);
            }
            return str.Values.Cast<IList<string>>().ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Encode_and_Decode_Strings
    {
        public static string Encode(List<string> s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string str in s)
            {
                sb.Append(str.Length);
                sb.Append('#');
                sb.Append(str);
            }
            return sb.ToString();
        }
        public static List<string> Decode(string str1)
        {
            List<string> decode = new List<string>();
            int t = 0;
            while(t < str1.Length)
            {
                int j = str1.IndexOf('#',t);
                int len = int.Parse(str1.Substring(t,j-t));
                string word = str1.Substring(j+1,len);
                decode.Add(word);
                t = j + 1 + len;
            }
            return decode;
        }
    }
}

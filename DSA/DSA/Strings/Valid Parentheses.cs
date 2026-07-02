using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> str = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    str.Push(c);
                }
                
                else
                {
                    if(str.Count == 0)
                    {
                        return false;
                    }
                    char t = str.Pop();
                    if((c == ')' && t != '(' || c == '}' && t != '{' || c == ']' && t != '[' ))
                    {
                        return false;
                    }
                }
            }
            return str.Count == 0;
        }
    }
}

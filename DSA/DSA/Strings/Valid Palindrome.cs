using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Valid_Palindrome
    {
        public static bool str(string str1)
        {
            int min = 0;
            int max = str1.Length - 1;
            while(max > min)
            {
                while(max > min && !char.IsLetterOrDigit(str1[max]));
                min++;
                while (max > min && !char.IsLetterOrDigit(str1[min])) ;
                max--;
                if(char.ToLower(str1[min]) != char.ToLower(str1[min]))
                {
                return false;
                }
                min++;
                max--;
            }
            return true;
        }
        
    }
}

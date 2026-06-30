using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class ThreeSumProblem
    {
      public  static List<List<int>> Threesum(int[] num)
        {
            Array.Sort(num);
           List< List<int>> result = new List<List<int>>();
            for(int i =0;i<num.Length-2;i++)
            {
               if(i > 0  && num[i] == num[i-1])
                {
                    continue;
                }
                int left = i + 1;
                int right = num.Length - 1;
                while (left < right)
                {
                    int sum = num[i] + num[left] + num[right];
                    if(sum == 0)
                    {
                        result.Add(new List<int>() { num[i], num[left], num[right] });
                        left++;
                        right--;
                        while(left < right && num[left] == num[right-1])
                        {
                            left++;
                        }
                        while(left < right && num[right] == num[right+1])
                        {
                            right--;
                        }
                    }
                    else if(sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}

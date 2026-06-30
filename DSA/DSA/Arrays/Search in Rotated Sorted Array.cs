using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Search_in_Rotated_Sorted_Array
    {
     public static int Sort(int[] num, int target)
        {
           
            int min = 0;
            int max = num.Length - 1;
            while (min <= max)
            {
                int mid = min + (max - min) / 2;
                if (num[mid] == target)
                {
                    return mid;
                }
                if (num[mid] >= num[min])
                {
                    if (target >= num[min] && target < num[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                else
                {
                    if (target > num[mid] && target <= num[max])
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}

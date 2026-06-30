using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Best_Time_to_Buy_and_Sell_Stock
    {
        static int profit(int[] price)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;
            foreach (int p in price)
            {
                minprice = Math.Min(minprice, p);
                maxprofit = Math.Max(maxprofit, p - minprice);
            }
            return maxprofit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _121_BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int minSoFar = prices[0];
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                minSoFar = Math.Min(minSoFar, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minSoFar);
            }
            return maxProfit;
        }
    }
}

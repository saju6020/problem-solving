using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class StockeBuySell
    {
        public static int GetMaxProfit(List<int> inputArray)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;

            for(int i = 0; i< inputArray.Count; i++)
            {
                minPrice = Math.Min(minPrice, inputArray[i]);
                maxProfit = Math.Max(maxProfit, inputArray[i] - minPrice);
            }

            return maxProfit;
        }
    }
}

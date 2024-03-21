using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    public class NumOfPairsMethods
    {
        public int NumIdenticalPairs(int[] nums)
        {

            Dictionary<int, int> freqDic = new Dictionary<int, int>();
            int value;
            for (int index = 0; index < nums.Count(); index++)
            {
                if (freqDic.ContainsKey(nums[index]))
                {
                    freqDic.TryGetValue(nums[index], out value);
                    value = value + 1;
                    freqDic[nums[index]] = value;
                }
                else
                {
                    freqDic[nums[index]] = 1;
                }
            }

            int totalNumOfGoodPairs = 0;
            foreach (var key in freqDic.Keys)
            {
                if (freqDic[key] > 1)
                {
                    totalNumOfGoodPairs = totalNumOfGoodPairs + Convert.ToInt16((freqDic[key] * (freqDic[key] - 1)) / 2);
                }
            }

            return totalNumOfGoodPairs;
        }
    }
}

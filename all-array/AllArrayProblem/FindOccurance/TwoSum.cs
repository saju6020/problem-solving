using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class TwoSum

    { 
        public static List<int> GetTwoSum(int[] inputArray, int target) 
        { 

            Dictionary<int, int> targetFreqDic = new Dictionary<int, int>();
            int twoSumPairCount = 0;

            for(int i = 0; i< inputArray.Length; i++)
            {
                if (inputArray[i] > target) 
                {
                    continue;
                }

                if (targetFreqDic.ContainsKey(inputArray[i]))
                {
                    twoSumPairCount = twoSumPairCount + targetFreqDic[inputArray[i]];
                }
               
                if(targetFreqDic.ContainsKey(target - inputArray[i]))
                {
                    targetFreqDic[target - inputArray[i]] = targetFreqDic[target - inputArray[i]] + 1;
                }
                else
                {
                    targetFreqDic.Add(target - inputArray[i], 1);
                }
            }

            return new List<int>();
        }
    }
}

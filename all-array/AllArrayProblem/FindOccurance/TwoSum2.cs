using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class TwoSum2Functions
    {
        public static List<int> GetTwoSum(int[] inputArray, int target)
        {
            Dictionary<int,int> indexDic = new Dictionary<int, int>();
            List<int> result = new List<int>();

            for(int i = 0; i< inputArray.Length; i++)
            {
                if(indexDic.ContainsKey(target - inputArray[i]))
                {
                    result.Add(indexDic[target - inputArray[i]]);
                    result.Add(i);
                    return result;
                }
                else
                {
                    indexDic.Add(inputArray[i], i);
                }
            }

            return result;
        }
    }
}

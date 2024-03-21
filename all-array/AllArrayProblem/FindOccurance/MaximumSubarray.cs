using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    class MaximumSubarray
    {
        public static int GetMaximumSubArray(int[] inputArray)
        {
            int max = inputArray[0];
            int currentSum = inputArray[0];

            for(int i = 1; i < inputArray.Length; i++)
            {
                currentSum = Math.Max(currentSum + inputArray[i], inputArray[i]);

                max = Math.Max(currentSum, max);
            }

            return max;
        }
    }
}

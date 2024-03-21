using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class MaxMinSumOfFour
    {

        public static (long, long)  maxSum(List<int> arr,
                             int n,
                             int k)
        {

            arr.Sort();
            // Compute sum of first window of size k
            long res = 0;            
            for (int i = 0; i < k; i++)
                res += arr[i];

            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of 
            // current window.
            long curr_sum = res;
            long minSum = res;

            for (int i = k; i < n; i++)
            {
                curr_sum += arr[i] - arr[i - k];
                res = Math.Max(res, curr_sum);
                minSum = Math.Min(minSum, curr_sum);
            }

            return (minSum, res);
        }
    }
}

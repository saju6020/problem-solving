using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class OneTwosZerosSortFunctions
    {
        public static int[] GetSortedArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            int i = 0;

            while (i < right)
            {
                if (arr[i] == 2)
                {
                    arr[i] = arr[right];
                    arr[right] = 2;
                    right--;
                }
                else if (arr[i] == 1)
                {
                    i++;
                }
                else
                {
                    arr[i] = arr[left]; 
                    arr[left] = 0;                    
                    left++;
                    i++;
                }
            }

            return arr;
        }
    }
}

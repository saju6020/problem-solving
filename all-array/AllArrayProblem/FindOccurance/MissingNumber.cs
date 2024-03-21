using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class MissingNumber
    {
        public static int GetMissingNumber(int[] inputArray, int n)
        {
            int res = n * (n + 1) / 2;

            int sumOfNumbers = 0;
            for(int index=0; index <inputArray.Length; index++)
            {
                sumOfNumbers = sumOfNumbers + inputArray[index];
            }

            int missingNumber = res - sumOfNumbers;

            return missingNumber;
        }
    }
}

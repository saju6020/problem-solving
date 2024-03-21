using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
  public class SecondLargest
    {
        public static int GetSecondLargest(int[] inputArray)
        {
            int firstLargest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            for(int index = 0; index< inputArray.Length; index++)
            {
                if(inputArray[index] > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = inputArray[index];
                }
                else if(inputArray[index] > secondLargest)
                {
                    secondLargest = inputArray[index];
                }
            }

            return secondLargest;
        }
    }
}

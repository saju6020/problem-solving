using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    class LongestConsecutive
    {

        public static int GetLongestConsecutiveLength(int[] inputArray)
        {

            int consicutiveLenght = 1;

            for(int index=0; index < inputArray.Length; index++)
            {
                int previousNumber = inputArray[index] - 1;

                if(!inputArray.Contains(previousNumber))
                {
                    int currentNumber = inputArray[index];
                    int currentConsicutiveLength = 1;
                    while(true)
                    {
                        if (inputArray.Contains(currentNumber + 1))
                        {
                            currentConsicutiveLength++;
                            currentNumber++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    consicutiveLenght = currentConsicutiveLength;
                }
            }

            return consicutiveLenght;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class SortThoseSquareMethods
    {
        public static List<int> SortThoseSquare(int[] inputArray)
        {
            List<int> negativeList = new List<int>();
            List<int> positiveList = new List<int>();
            List<int> restul = new List<int>();

            for(int index = 0; index < inputArray.Length; index++)
            {
                if (inputArray[index] >=0)
                {
                    positiveList.Add(inputArray[index]);
                }
                else
                {
                    negativeList.Add(inputArray[index]);
                }
            }

            int negativeIndex = negativeList.Count - 1;
            int positiveIndex = 0;

            while (negativeIndex >= 0 && positiveIndex < positiveList.Count)
            {
                if (Math.Pow(positiveList[positiveIndex], 2) <= Math.Pow(negativeList[negativeIndex], 2))
                {
                    restul.Add(Convert.ToInt16(Math.Pow(positiveList[positiveIndex], 2)));
                    positiveIndex++;
                }
                else
                {
                    restul.Add(Convert.ToInt16(Math.Pow(negativeList[negativeIndex], 2)));
                    negativeIndex--;
                }
            }

            while(positiveIndex < positiveList.Count)
            {
                restul.Add(Convert.ToInt16(Math.Pow(positiveList[positiveIndex], 2)));
                positiveIndex++;
            }

            while(negativeIndex >= 0)
            {
                restul.Add(Convert.ToInt16(Math.Pow(negativeList[negativeIndex], 2)));
                negativeIndex--;
            }

            return restul;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
   public class FindFrequency
    {
       public static Dictionary<int, int> GetOccuranceDictionary(int[] inputArray)
        {
            Dictionary<int, int> dataDictionary = new Dictionary<int, int>();
            for (int index = 0; index < inputArray.Length; index++)
            {

                if (dataDictionary.ContainsKey(inputArray[index]))
                {
                    int currentKeyValue;
                    dataDictionary.TryGetValue(inputArray[index], out currentKeyValue);
                    currentKeyValue = currentKeyValue + 1;
                    dataDictionary[inputArray[index]] = currentKeyValue;
                }
                else
                {
                    dataDictionary[inputArray[index]] = 1;
                }
            }

            return dataDictionary;
        }
    }
}

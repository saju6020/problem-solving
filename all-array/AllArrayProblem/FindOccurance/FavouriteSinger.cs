using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class FavouriteSinger
    {
        public static int GetCountOfFavouriteSinger(List<string> inputArray)
        {
            Dictionary<string, int> frequencyDic = new Dictionary<string, int>();
            int maxFrequency = 1;

            for (int index = 0; index < inputArray.Count; index++)
            {
                
                    string currentNumber = inputArray[index];
                    if (frequencyDic.ContainsKey(inputArray[index]))
                    {
                        int currentKeyValue;
                        frequencyDic.TryGetValue(inputArray[index], out currentKeyValue);
                        currentKeyValue++;                                           
                        frequencyDic[inputArray[index]] = currentKeyValue;

                        if (currentKeyValue > maxFrequency)
                        {
                            maxFrequency = currentKeyValue;
                        }
                    }
                    else
                    {
                        frequencyDic[inputArray[index]] = 1;
                    }
                
            }

            int favouriteSingerCount = 0;
            foreach (var data in frequencyDic)
            {
                if (data.Value == maxFrequency)
                {
                    favouriteSingerCount++;
                }
            }

            return favouriteSingerCount;
        }
    }
}

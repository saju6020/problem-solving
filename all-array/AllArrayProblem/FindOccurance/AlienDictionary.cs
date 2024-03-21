using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class AlienDictionaryMethods
    {
        public bool IsAlienSorted(string[] words, string order)
        {

            Dictionary<char, int> keyOrderDic = new Dictionary<char, int>();

            for (int index = 0; index < order.Length; index++)
            {
                keyOrderDic.Add(order[index], index);
            }

            for (int wordIndex = 0; wordIndex < words.Length -1; wordIndex++)
            {
                if (!IsLexicographicallyOrder(words[wordIndex], words[wordIndex + 1], keyOrderDic))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsLexicographicallyOrder(string firstWord, string secondWord, Dictionary<char, int> keyOrderDic)
        {
            
            for (int index = 0; index < firstWord.Length; index++)
            {
                if (index >= firstWord.Length || index >= secondWord.Length)
                {
                    return false;
                }
                if (firstWord[index] != secondWord[index])
                {
                    if (keyOrderDic[firstWord[index]] > keyOrderDic[secondWord[index]])
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return true;
        }
    }
}

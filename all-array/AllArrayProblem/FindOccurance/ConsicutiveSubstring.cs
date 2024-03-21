using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class LongestSubStringWithoutRepeat
    {

        public int GetLongestSubStringWithoutRepeat(string inputStr)
        {
            int start = 0;
            int end = 0;
            int maxLenght = 0;            

            Dictionary<char, int> ht = new Dictionary<char, int>();

            for(int i = 0; i < inputStr.Length; i++)
            {
                if (ht.ContainsKey(inputStr[i]) && ht[inputStr[i]] >= start)
                {                    
                   start = ht[inputStr[i]] + 1;                                 
                }

                end = i;

                if (ht.ContainsKey(inputStr[i]))
                {
                    ht[inputStr[i]] = i;
                }
                else
                {
                    ht.Add(inputStr[i], i);
                }

                maxLenght = Math.Max(end - start, maxLenght);
            }
            
            return maxLenght + 1;
        }
    }
}

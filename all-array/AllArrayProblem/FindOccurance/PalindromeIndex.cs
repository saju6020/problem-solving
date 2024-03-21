using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class PalindromeIndex
    {
        public int GetPalindromeIndex(string s)
        {
            int start = 0;
            int end = s.Length -1;
            int result = -1;

            while(end > start)
            {
                if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    if (s[start + 1] == s[end])
                    {
                        result = start;
                        break;
                    }
                    else if (s[start] == s[end -1])
                    {
                        result = end;
                        break;
                    }
                    else
                    {
                        return -1;
                    }

                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class DestroyPairFunctions
    {
        public static string DestroyPairs(string inputStr)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(inputStr[0]);

            for(int i = 1; i < inputStr.Length; i++)
            {
                char currentChr =  stack.Peek();

                if (currentChr == inputStr[i]) 
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(inputStr[i]);
                }
            }

            return string.Join("", stack.Reverse().ToArray());
        }
    }
}

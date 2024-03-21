﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class GenerateParanthesis
    {
        static void _printParenthesis(char[] str, int pos,
                                  int n, int open,
                                  int close)
        {
            if (close == n)
            {
                // print the possible combinations
                for (int i = 0; i < str.Length; i++)
                    Console.Write(str[i]);

                Console.WriteLine();
                return;
            }
            else
            {
                if (open > close)
                {
                    str[pos] = '}';
                    _printParenthesis(str, pos + 1, n, open,
                                      close + 1);
                }
                if (open < n)
                {
                    str[pos] = '{';
                    _printParenthesis(str, pos + 1, n, open + 1,
                                      close);
                }
            }
        }

        // Wrapper over _printParenthesis()
        static void printParenthesis(char[] str, int n)
        {
            if (n > 0)
                _printParenthesis(str, 0, n, 0, 0);
            return;
        }

        // driver program
      /*  public static void Main()
        {
            int n = 3;
            char[] str = new char[2 * n];

            printParenthesis(str, n);
        }*/
    }
}

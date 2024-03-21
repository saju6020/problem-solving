using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    class SumLeftDiagonal
    {
        public static int GetSumOfLeftDiagonal(int[,] inputArray, int arraySize)
        {
            int sum = 0;
            int row = 0;

            for (int column = arraySize - 1; column >= 0; column--)
            {
                sum = sum + inputArray[row, column];
                row++;
            }


            return sum;
        }
    }
}

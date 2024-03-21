using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHackerrank
{
    internal class ZeroMatrix
    {
        public void SetZeroes(int[][] matrix)
        {

        }

        private void SetRowZero(int[][] matrix, int rowNumber)
        {
            int matrixLength = matrix.Length;
           
                for (int columnIndex = 0; columnIndex < matrixLength; columnIndex++)
                {
                    if (matrix[rowNumber][columnIndex] != 0)
                    {
                        matrix[rowNumber][columnIndex] = -1;
                    }
                }
           
    }
    }
}

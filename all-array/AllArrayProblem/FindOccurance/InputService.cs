// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputService.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AllArrayProblem
{
    using System;

    public class InputService
    {
        private static string[] GetInputArray()
        {
            var inputElements = Console.ReadLine();
            string[] elements = null;
            if (inputElements != null)
            {
                elements = inputElements.Split(' ');
            }
            return elements;
        }

        public static int[,] GetMatrix(int matrixSize)
        {
            var matrix = new int[matrixSize, matrixSize];

            for (var row = 0; row < matrixSize; row++)
            {
                var elements = GetInputArray();

                for (var index = 0; index < matrixSize; index++)
                {
                    matrix[row, index] = Convert.ToInt32(elements[index]);
                }
            }

            return matrix;
        }
    }
}
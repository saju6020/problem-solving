using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    class SumOfPrimeNumber
    {
        private static bool IsPrimeNumber(int inputNumber)
        {
            int inputNumberSqrt = Convert.ToInt32(Math.Sqrt(inputNumber));
            bool isPrime = true;

            for (int devider = 2; devider <= inputNumberSqrt; devider++)
            {
                if (inputNumber % devider == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;

        }

        public static int  GetSumOfPrime(int[] inputArray)
        {
            int sum = 0;
            for(int index=0; index < inputArray.Length; index++)
            {
                if(IsPrimeNumber(inputArray[index]))
                {
                    Console.WriteLine(inputArray[index]);
                    sum = sum + inputArray[index];
                }
            }

            return sum;
        }
    }
}

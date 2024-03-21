using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    public class MeltingCoinProblem
    {
       
       public static int solve(int N, int H, int[] piles)
        {
            // You must complete the logic for the function that is provided
            // before compiling or submitting to avoid an error.
            // Write your code here

            int lowest = 0;
            int hourCount = 0;
            int sum = 0;

            for (int i = 0; i < piles.Length; i++)
            {
                sum = sum + piles[i];
            }

            lowest = Math.Abs(sum / H);

            while (hourCount != H)
            {
                hourCount = 0;
                for (int pilesIndex = 0; pilesIndex < piles.Length; pilesIndex++)
                {
                    int pilesCurrentValue = piles[pilesIndex];
                    while (pilesCurrentValue > 0)
                    {
                        if (pilesCurrentValue < lowest)
                        {
                            pilesCurrentValue = 0;
                        }
                        else
                        {
                            pilesCurrentValue = pilesCurrentValue - lowest;
                        }
                        hourCount++;

                    }

                    if (hourCount > H)
                    {
                        break;
                    }
                }
                if(hourCount <= H)
                {
                    break;
                }
                lowest++;
            }

            return lowest;

        }

    }
}

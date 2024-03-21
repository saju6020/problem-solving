using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class IntersectionOf3SortedArray
    {
        public static List<int> IntersectArray(int n1, int n2, int n3, int[] arr1, int[] arr2, int[] arr3)
        {
            int xLocIndex = 0;
            int yLocIndex = 0;
            int zLocIndex = 0;

            List<int> result = new List<int>();

            while(xLocIndex != n1 && yLocIndex != n2 && zLocIndex!= n3) 
            {
                int x = arr1[xLocIndex];
                int y = arr2[yLocIndex];
                int z = arr3[zLocIndex];

                if(x== y && y==z)
                {
                    result.Add(x);
                    xLocIndex++;
                    yLocIndex++;
                    zLocIndex++;
                }
                else if(x <= y && y <=z)
                {
                    xLocIndex++;
                }
                else if(y<= x && y<=z)
                {
                    yLocIndex++;
                }
                else
                {
                    zLocIndex++;
                }
            }

            return result;

        }
    }
}

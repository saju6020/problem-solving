using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSorting
{
    internal class MergeSort
    {
        public static List<int> Sort(List<int> inputArray)
        {
            if(inputArray.Count <= 1)
            {
                return inputArray;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int mid = inputArray.Count / 2;

            for (int i = 0; i < mid; i++)
            {
                left.Add(inputArray[i]);
            }

            for (int i = mid; i < inputArray.Count; i++)
            {
                right.Add(inputArray[i]);
            }

            left = Sort(left);
            right = Sort(right);

            return MergeList(left, right);
        }


        private static List<int> MergeList(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AllSorting
{
    internal class MergeSort2
    {
        public int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int[] output = new int[m + n];

            int leftStart = 0;
            int rightStart = 0;
            int leftCount = m;
            int rightCount = n;

            int index = 0;

            while (leftCount > 0 || rightCount > 0)
            {
                if (leftCount > 0 && rightCount > 0)
                {
                    if (nums1[leftStart] <= nums2[rightStart])
                    {                       
                        leftStart++;
                        leftCount--;
                    }
                    else
                    {
                        insertItem(ref nums1, nums2[rightStart], index, (m+n)-1);
                        rightStart++;
                        rightCount--;
                        leftStart++;
                    }
                }
                else if (leftCount > 0)
                {                    
                    leftStart++;
                    leftCount--;
                }
                else if (rightCount > 0)
                {
                    insertItem(ref nums1, nums2[rightStart], index, (m + n) - 1);
                    rightStart++;
                    rightCount--;
                    leftStart++;
                }
                index++;
            }

            return nums1;
        }

        private void insertItem(ref int[] nums1,int item, int strtIndex, int lastIndex)
        {
            int temp = nums1[strtIndex];
            nums1[strtIndex] = item;
            
            for (int index = lastIndex-1; index > strtIndex ; index --)
            {
                nums1[index + 1] = nums1[index];          
            }

            if (strtIndex < lastIndex)
            {
                nums1[strtIndex + 1] = temp;
            }
        }
    }
}

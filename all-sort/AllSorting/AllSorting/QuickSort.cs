using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AllSorting
{
    internal class QuickSortMethods
    {
        public void QuickSort(int[] nums, int leftIndex, int rightIndex) 
        {
            if (rightIndex <= leftIndex) return;

            int pivot = Partition(nums, leftIndex, rightIndex);

            QuickSort(nums, leftIndex, pivot - 1);
            QuickSort( nums, pivot + 1, rightIndex);
           
        }

        public int Partition(int[] nums, int leftIndex, int rightIndex)
        {
            int pivot = nums[rightIndex];
            int i = leftIndex - 1;

            for(int j= leftIndex; j<= rightIndex; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    int temp1 = nums[i]; 
                    nums[i] = nums[j];
                    nums[j] = temp1;
                }
            }

            i++;

            int temp = nums[i];
            nums[i] = nums[rightIndex];
            nums[rightIndex] = temp;
            return i;
        }

    }
}

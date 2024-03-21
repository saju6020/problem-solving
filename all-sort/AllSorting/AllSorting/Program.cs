using NUnit.Framework;
using System;
using System.Linq;

namespace AllSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] inputArray = { 1, 0, 3, 10, 5, 16, 37, 8, };

            // var mergedResult =  MergeSort.Sort(inputArray.ToList());

            // Console.WriteLine(string.Join(",", mergedResult));

            // int[] nums1 = { 4, 5, 6, 0, 0, 0 };
            //  int[] nums2 = { 1, 2, 3 };

            //  MergeSort2 mergeSort2 = new MergeSort2();
            // int[] output = mergeSort2.Merge(nums1, 3, nums2, 3);

            // Console.WriteLine("Hello World!");

            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            var sortFunction = new QuickSortMethods();

            // sortFunction.QuickSort(array, 0, array.Length - 1);

            QuickSort2.Quick_Sort(array, 0, array.Length - 1);

           Assert.NotNull(array);
           CollectionAssert.AreEqual(array, expected);


        }
    }
}

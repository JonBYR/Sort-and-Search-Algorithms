using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assessment_1
{
    class Merge
    {
        public static int counter = 0;
        public static void MergeAscending(int[] data, int[] temp, int low, int middle, int high)
        {
            //method taken from week 5 workshop
            int ri = low;
            int ti = low;
            int di = middle;
            while (ti < middle && di <= high)
            {
                if (data[di] < temp[ti])
                {
                    counter++;
                    data[ri++] = data[di++];
                }
                else
                {
                    counter++;
                    data[ri++] = temp[ti++];
                }
            }
            while (ti < middle)
            {
                data[ri++] = temp[ti++];
            }
        }
        public static void MergeSortRecursiveAscending(int[] data, int[] temp, int low, int high)
        {
            int n = high - low + 1;
            int middle = low + n / 2;
            int i;
            if (n < 2) return;
            for (i = low; i < middle; i++)
            {
                temp[i] = data[i];
            }
            MergeSortRecursiveAscending(temp, data, low, middle - 1);
            MergeSortRecursiveAscending(data, temp, middle, high);
            MergeAscending(data, temp, low, middle, high);
        }
        public static void MergeSortAscending(int[] data, int n)
        {
            int[] temp = new int[n];
            MergeSortRecursiveAscending(data, temp, 0, n - 1);
        }
        public static void MergeDescending(int[] data, int[] temp, int low, int middle, int high)
        {
            int ri = low;
            int ti = low;
            int di = middle;
            while (ti < middle && di <= high)
            {
                if (data[di] > temp[ti]) //checking if the element in the array is greater than the element in the temporary array, then assigning the value to the correct position
                {
                    counter++;
                    data[ri++] = data[di++];
                }
                else
                {
                    counter++;
                    data[ri++] = temp[ti++];
                }
            }
            while (ti < middle)
            {
                data[ri++] = temp[ti++];
            }
        }
        public static void MergeSortRecursiveDescending(int[] data, int[] temp, int low, int high)
        {
            int n = high - low + 1;
            int middle = low + n / 2;
            int i;
            if (n < 2) return;
            for (i = low; i < middle; i++)
            {
                temp[i] = data[i];
            }
            MergeSortRecursiveDescending(temp, data, low, middle - 1);
            MergeSortRecursiveDescending(data, temp, middle, high);
            MergeDescending(data, temp, low, middle, high);
        }
        public static void MergeSortDescending(int[] data, int n)
        {
            int[] temp = new int[n];
            MergeSortRecursiveDescending(data, temp, 0, n - 1);
        }
        public static int[] ArrayMerger(int[] array1, int[] array2) //will take two arrays and merge them together
        {
            List<int> mergedArrays = new List<int>(); //creates an empty list to add the contents too
            mergedArrays.AddRange(array1);
            mergedArrays.AddRange(array2);
            int[] finalArray = mergedArrays.ToArray(); //converts the list to an array
            return finalArray;
        }
    }
}

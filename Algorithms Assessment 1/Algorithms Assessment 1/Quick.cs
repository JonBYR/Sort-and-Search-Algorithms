using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assessment_1
{
    class Quick
    {
        public static int counter = 0;
        public static void QuickSortAscending(int[] data, int n)
        {
            //method taken from week 6
            int counter = 0;
            Quick_Sort_Ascending(data, 0, n - 1);
        }
        public static void Quick_Sort_Ascending(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            
            pivot = data[(left + right) / 2];
            do
            {
                while ((data[i] < pivot) && (i < right))
                {
                    counter++;
                    i++;
                }//checking for all values less than the pivot
                while ((pivot < data[j]) && (j > left)) //checking for all values greater than the pivot
                {
                    counter++;
                    j--;
                }
                  
                if (i <= j)
                {
                    counter = counter + 1;
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) Quick_Sort_Ascending(data, left, j);
            if (i < right) Quick_Sort_Ascending(data, i, right);
            
        }
        public static void QuickSortDescending(int[] data, int n)
        {
            int counter = 0;
            Quick_Sort_Descending(data, 0, n - 1);
        }
        public static void Quick_Sort_Descending(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            do
            {
                while ((data[i] > pivot) && (i < right))  //as we are going in descending order, we now are checking for all values that are greater than the pivot
                {
                    counter++;
                    i++;
                }              
                while ((pivot > data[j]) && (j > left)) //then checking for values less than the pivot
                {
                    counter++;
                    j--;
                }                 
                if (i <= j)
                {
                    counter++;
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) Quick_Sort_Descending(data, left, j);
            if (i < right) Quick_Sort_Descending(data, i, right);
            
        }
       
    }
}

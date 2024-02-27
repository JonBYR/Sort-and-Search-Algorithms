using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assessment_1
{
    class Bubble
    {
        public static int counter = 0;
        public static void BubbleSortAscending(int[] a, int n)
        {
            //method taken from week 5
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    if(a[j+1] < a[j])
                    {
                        counter++;
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubbleSortDescending(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j + 1] > a[j]) //as it is in descending order, we need to check if the next element is greater than as it needs to be replaced by the value less than
                    {
                        counter++;
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }
}

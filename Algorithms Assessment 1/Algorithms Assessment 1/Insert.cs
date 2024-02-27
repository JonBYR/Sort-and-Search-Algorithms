using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assessment_1
{
    class Insert
    {
        public static int counter = 0;
        public static void InsertionSortAscending(int[] data, int n)
        {
            //method taken from week 5
            int numSorted = 1;
            int index;
            while (numSorted < n)
            {
                int temp = data[numSorted];
                for (index=numSorted; index > 0; index--)
                {
                    if (temp < data[index-1])
                    {
                        counter++;
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        counter++;
                        break;
                    }
                }
                data[index] = temp;
                numSorted++;
            }
        }
        public static void InsertionSortDescending(int[] data, int n)
        {
            int numSorted = 1;
            int index;
            while (numSorted < n)
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp > data[index - 1])
                    {
                        counter++;
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        counter++;
                        break;
                    }
                }
                data[index] = temp;
                numSorted++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assessment_1
{
    class Binary
    {
        public static int counter = 0;
        public static string BinarySearchAscending(int key, int[] array, int low, int high)
        {
            if (low > high) 
            {
                if (high == -1) //should high have returned -1 then it means that low was returned as 0, meaning the first element of the array was reached
                {
                    return $"Value not found: Nearest value was {array[low]} and was at position {low + 1}";
                }
                int lowDifference = array[low] - key; //as low is now greater than high, to work out the difference the value at position low must be subtracted by the value of key
                int highDifference = key - array[high]; //as high is now less than low, to work out the difference the value at position high will subtract from key
                if (lowDifference < highDifference) //this will return the value and position of the value (starting at 1 through to the length of the array) of the value with the least distance from the key
                {
                    return $"Value not found: Nearest value was {array[low]} and was at position {low + 1}";
                }
                else if (highDifference < lowDifference)
                {
                    return $"Value not found: Nearest value was {array[high]} and was at position {high + 1}";
                }
                else if (highDifference == lowDifference) //if the differences were the same both values will be shown and their positions
                {
                    return $"Value not found: Nearest values were {array[high]}, {array[low]} at positions {low + 1}, {high + 1}";
                }
            }
            //method taken from week 4 workshop
            int mid = (low + high) / 2;
            if (mid == array.Length) //if the midpoint is now equal to the length of the array, it means all elements have been checked, and that the value closest to it is at the far right of the array
            {
                return $"Value not found: Nearest value was {array[high - 1]} at position {high}"; //as high is one more than the final index of the array the value returned from the index is high-1
            }
            if (key == array[mid])
            {
                counter++;
                int leftMid = mid - 1;
                int rightMid = mid + 1;
                if ((leftMid < 0) || (rightMid >= array.Length)) //checks if the index is out of range
                {
                    return ($"Value found at position {mid + 1}");
                }
                if (array[leftMid] == key)
                {
                    return ($"Value found at positions {leftMid + 1}, {mid + 1}"); //if the value left of the midpoint is also equal both are displayed, and likewise if the value on the right of the midpoint is also equal to the key both are displayed
                }
                else if (array[rightMid] == key)
                {
                    return ($"Value found at positions {mid + 1}, {rightMid + 1}");
                }
                else
                {
                    return ($"Value found at position {mid + 1}");
                }             
            } 
            if (key < array[mid])
            {
                counter++;
                return BinarySearchAscending(key, array, low, mid - 1);
            }
            else
            {
                counter++;
                return BinarySearchAscending(key, array, mid + 1, high);
            }

        }
        public static string BinarySearchDescending(int key, int[] array, int low, int high)
        {
            if (low > high) //this has similar functionality to the ascending binary search shown above
            {
                if (high == -1)
                {
                    return $"Value not found: Nearest value was {array[low]} and was at position {low + 1}";
                }
                int lowDifference = array[low] - key;
                int highDifference = key - array[high];
                if (lowDifference > highDifference) //as the value of low is greater than high, the value at position low will be lower than at position high. As the differences are now negetive the signs are now swapped to check if the differences are greater than each other
                {
                    return $"Value not found: Nearest value was {array[low]} and was at position {low + 1}";
                }
                else if (highDifference > lowDifference)
                {
                    return $"Value not found: Nearest value was {array[high]} and was at position {high + 1}";
                }
                else if (highDifference == lowDifference)
                {
                    return $"Value not found: Nearest values were {array[high]}, {array[low]} at positions {low + 1}, {high + 1}";
                }
            }
            int mid = (low + high) / 2;
            if (mid == array.Length)
            {
                return $"Value not found: Nearest value was {array[high - 1]} at position {high}";
            }
            if (key == array[mid])
            {
                counter++;
                int leftMid = mid - 1;
                int rightMid = mid + 1;
                if ((leftMid < 0) || (rightMid >= array.Length))
                {
                    return ($"Value found at position {mid + 1}");
                }
                if (array[leftMid] == key)
                {
                    return ($"Value found at positions {leftMid + 1}, {mid + 1}");
                }
                else if (array[rightMid] == key)
                {
                    return ($"Value found at positions {mid + 1}, {rightMid + 1}");
                }
                else
                {
                    return ($"Value found at position {mid + 1}");
                }
            }
            if (key > array[mid]) //as the list is in descending order the elements are in a reverse order to the ascending method, meaning that we now should check if the value is greater than the key instead of less than
            {
                counter++;
                return BinarySearchDescending(key, array, low, mid - 1);
            }
            else
            {
                counter++;
                return BinarySearchDescending(key, array, mid + 1, high);
            }
        }
        
        }
    }
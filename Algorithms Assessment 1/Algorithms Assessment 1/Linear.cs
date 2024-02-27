using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assessment_1
{
    class Linear
    {
        public static int counter = 0;
        public static List<int> OtherLocationsAscending(int key, int[] array, int low, int high) //takes an array and will then try to find all instances of that number in the array
        {
            List<int> valuePositions = new List<int>(); //creates a new list that will store the positions of each value
            for (int i =low; i < high; i++)
            {
                counter++;
                if (array[i] == key) //if the key is the same as the value at the position it is added to the list
                { 
                    valuePositions.Add(i+1);
                }
            }
            return valuePositions; //returns the list
        }
        public static List<int> OtherLocationsDescending(int key, int[] array, int low, int high) //takes an array and will then try to find all instances of that number in the array, same method
        {
            List<int> valuePositions = new List<int>();
            for (int i =low; i < high; i++)
            {
                counter++;
                if (array[i] == key)
                {    
                    valuePositions.Add(i+1);
                }
            }
            return valuePositions;
        }
    }
}

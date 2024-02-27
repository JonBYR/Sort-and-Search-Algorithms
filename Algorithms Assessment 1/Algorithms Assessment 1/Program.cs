using System;
using System.IO;
using System.Collections.Generic;



namespace Algorithms_Assessment_1
{
    class Program
    {
        public static int[] IntConverter(string[] a) //takes an array of strings and converts them into an array of integers
        {
            int[] intArray = Array.ConvertAll(a, s => int.Parse(s));
            return intArray;
        }
        public static void ArraySortandSearch(int[] array, int n) //for whatever array that was picked, we will ask them if they want it in ascending or descending order, which will then lead to a search of that sorted array
        {
            Console.WriteLine("Would you like to sort in ascending or descending order? Pick 1 for ascending and 2 for descending");
            string answer = Console.ReadLine(); //asks user for an answer then converts to an int based on that answer
            answer = answer.Trim(); //removes whitespaces
            int sortTypeAnswer = Convert.ToInt32(answer);
            if ((sortTypeAnswer >= 3) || (sortTypeAnswer <= 0))
            {
                ArraySortandSearch(array, n); //if the wrong integer is given the method will be called again
            }
            Console.WriteLine("Pick a number for: Bubble, Insert, Merge, Quick or Heap sort (1-4) respectively");
            string initialAnswer = Console.ReadLine(); //asks user for what search they'd like to do, then preform the same processes as the sortTypeAnswer
            initialAnswer = initialAnswer.Trim();
            int sorterAnswer = Convert.ToInt32(initialAnswer);
            if ((sorterAnswer >= 5) || (sorterAnswer <= 0))
            {
                ArraySortandSearch(array, n); //method called again if the wrong int is called
            }
            else
            {
                if (sortTypeAnswer == 1)
                {
                    Ascending(array, n, sorterAnswer); //if 1 was picked for sortTypeAnswer then for whatever search the user picked in sorterAnswer will be done in ascending order with the ascending method. Otherwise the descending method is called instead 
                }
                else if (sortTypeAnswer == 2)
                {
                    Descending(array, n, sorterAnswer);
                }
            }
        }
        public static void Ascending(int[] b, int n, int sortAnswer) //will preform the required sorts in ascending order
        {
            
            if (sortAnswer == 1)
            {
                Bubble.BubbleSortAscending(b, n); //method for an ascending bubble sort called
                Console.WriteLine($"Bubble Sort completed in: {Bubble.counter} steps"); //number of steps for a bubble sort is displayed
            }
            else if (sortAnswer == 2)
            {
                Insert.InsertionSortAscending(b, n); //method for an ascending insertion sort called
                Console.WriteLine($"Insert Sort completed in: {Insert.counter} steps"); //number of steps for an insertion sort is displayed
            }
            else if (sortAnswer == 3)
            {
                Merge.MergeSortAscending(b, n); //method for an ascending merge sort called
                Console.WriteLine($"Merge Sort completed in: {Merge.counter} steps"); //number of steps for a merge sort is displayed
            }
            else if (sortAnswer == 4)
            {
                Quick.QuickSortAscending(b, n); //method for an ascending quick sort is called
                Console.WriteLine($"Quick Sort completed in: {Quick.counter} steps"); //number of steps for a quick sort is displayed
            }
            Console.WriteLine("\n");
            Console.WriteLine("The required numbers are:"); //will output every 10th number in the sorted array if it was network 1,2,3 or the merged network of 1 and 3
            if ((n == 256) || (n == 512))
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if ((i + 1) % 10 == 0)
                    {
                        Console.WriteLine(b[i]);
                    }
                }
            }
            if ((n == 2048) || (n == 4096)) //will output every 50th number in the sorted array if it was network 4,5,6 or the nerged network of 4 and 6
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if ((i + 1) % 50 == 0)
                    {
                        Console.WriteLine(b[i]);
                    }
                }
            }
            bool ascending = true;
            FirstSearch(b, n, ascending); //method for the binary search of an array that is in ascending order
            SecondSearch(b, n, ascending); //method for a custom search of an array that is in descending order
            Console.WriteLine($"Binary Search completed in {Binary.counter} steps"); //displays the number of steps needed to complete a binary search
            Console.WriteLine($"Linear Search completed in {Linear.counter} steps"); //displays the number of steps needed to complete the linear search
        }
        public static void Descending(int[] c, int n, int sortAnswer) //same method as the ascending method, but will do each sort in descending order
        {
            if (sortAnswer == 1)
            {
                Bubble.BubbleSortDescending(c, n); //each sort will have it's method for descending order called, then display the steps it required
                Console.WriteLine($"Bubble Sort completed in: {Bubble.counter} steps");
            }
            else if (sortAnswer == 2)
            {
                Insert.InsertionSortDescending(c, n);
                Console.WriteLine($"Insert Sort completed in: {Insert.counter} steps");
            }
            else if (sortAnswer == 3)
            {
                Merge.MergeSortDescending(c, n);
                Console.WriteLine($"Merge Sort completed in: {Merge.counter} steps");
            }
            else if (sortAnswer == 4)
            {
                Quick.QuickSortDescending(c, n);
                Console.WriteLine($"Quick Sort completed in: {Quick.counter} steps");
            }
            Console.WriteLine("The required numbers are:");
            Console.WriteLine("\n");
            if ((n == 256) || (n == 512))
            {
                for (int i = 0; i < c.Length; i++)
                {
                    if ((i + 1) % 10 == 0)
                    {
                        Console.WriteLine(c[i]);
                    }
                }
            }
            if ((n == 2048) || (n == 4096))
            {
                for (int i = 0; i < c.Length; i++)
                {
                    if ((i + 1) % 50 == 0)
                    {
                        Console.WriteLine(c[i]);
                    }
                }
            }
            bool ascending = false;
            FirstSearch(c, n, ascending); //does a binary search in descending order
            SecondSearch(c, n, ascending); //does a linear search in descending order
            Console.WriteLine($"Binary Search completed in {Binary.counter} steps");
            Console.WriteLine($"Linear Search completed in {Linear.counter} steps");
        }
        public static void FirstSearch(int[] d, int n, bool ascending) //first search will preform a binary search as the first searching algorithm
        {
            Console.WriteLine("What number would you like to find for the binary search?"); //asks the user for whatever number they'd like, then removes the whitespaces and stores it as an int
            string initialAnswer = Console.ReadLine();
            initialAnswer = initialAnswer.Trim();
            int number = Convert.ToInt32(initialAnswer);
            if (ascending == true) //if the method was called from the Ascending method
            {
                Console.WriteLine(Binary.BinarySearchAscending(number, d, 0, n)); //preform a search on an ascending array
            }
            else
            {
                Console.WriteLine(Binary.BinarySearchDescending(number, d, 0, n)); //preform a search on a descending array
            }
            
        }
        public static void SecondSearch(int[] e, int n, bool ascending) //second search will preform a linear search as the second searching algorithm
        {
            Console.WriteLine("What number would you like to find in the custom search?");
            string initialAnswer = Console.ReadLine();
            initialAnswer = initialAnswer.Trim();
            int number = Convert.ToInt32(initialAnswer);
            if (ascending == true)
            {
                List<int> positions = Linear.OtherLocationsAscending(number, e, 0, n);
                if (positions.Count != 0)
                {
                    foreach (int num in positions) //if the list isn't empty it will show all the positions that it had existed in the array
                    {
                        Console.WriteLine($"Value found at location {num}");
                    }
                }
                else
                {
                    Console.WriteLine("Not in array");
                }
            }
            else
            {
                List<int> positions = Linear.OtherLocationsAscending(number, e, 0, n);
                if (positions.Count != 0)
                {
                    foreach (int num in positions) //same as above
                    {
                        Console.WriteLine($"Value found at location {num}");
                    }
                }
                else
                {
                    Console.WriteLine("Not in array");
                }
            }
        }
        static void Main(string[] args)
        {
            //reads each file into an array seperately
            string[] file1 = File.ReadAllLines("Net_1_256.txt");
            string[] file2 = File.ReadAllLines("Net_2_256.txt");
            string[] file3 = File.ReadAllLines("Net_3_256.txt");
            string[] file4 = File.ReadAllLines("Net_1_2048.txt");
            string[] file5 = File.ReadAllLines("Net_2_2048.txt");
            string[] file6 = File.ReadAllLines("Net_3_2048.txt");
            //converts each file into an integer array seperately
            int[] net1 = IntConverter(file1);
            int[] net2 = IntConverter(file2);
            int[] net3 = IntConverter(file3);
            int[] net4 = IntConverter(file4);
            int[] net5 = IntConverter(file5);
            int[] net6 = IntConverter(file6);
            
            Console.WriteLine("Which file would you like to sort? Pick 1, 2 or 3 for the 256 networks, 4, 5 or 6 for the 2048 networks, or 7/8 for merged networks"); //asks user for an answer then converts to an int based on that answer
            string baseAnswer = Console.ReadLine();
            baseAnswer = baseAnswer.Trim(); //removes whitespaces
            int answer = Convert.ToInt32(baseAnswer);
            while ((answer >= 9) || (answer <= 0))
            {
                
                Console.WriteLine("Which file would you like to sort? Pick 1, 2 or 3 for the 256 networks, 4, 5 or 6 for the 2048 networks, or 7/8 for merged networks");
                string initial = Console.ReadLine();
                initial = initial.Trim();
                int newAnswer = Convert.ToInt32(initial);
                answer = newAnswer; //if the required integars were not picked, then a while loop is created that will ask for another answer, and keep doing so until the correct one is given
            }
            if (answer == 1) //for each answer, we get the length of the array, and based on the number send the array length and the network array to be sorted and searched
            {
                int arrayLength = net1.Length;
                ArraySortandSearch(net1, arrayLength);    
            }
            else if (answer == 2) //1, 2 and 3 will sort through the 256 networks
            {
                int arrayLength = net2.Length;
                ArraySortandSearch(net2, arrayLength);
            }
            else if (answer == 3)
            {
                int arrayLength = net3.Length;
                ArraySortandSearch(net3, arrayLength); 
            }
            else if (answer == 4) //4,5 and 6 will sort through the 2048 networks
            {
                int arrayLength = net4.Length;
                ArraySortandSearch(net4, arrayLength);
            }
            else if (answer == 5)
            {
                int arrayLength = net5.Length;
                ArraySortandSearch(net5, arrayLength);
            }
            else if (answer == 6)
            {
                int arrayLength = net6.Length;
                ArraySortandSearch(net6, arrayLength);
            }
            else if (answer == 7) //for 7 and 8 the arrays are merged together with a method in the merge class
            {
                int[] merge1 = Merge.ArrayMerger(net1, net3);
                int arrayLength = merge1.Length;
                ArraySortandSearch(merge1, arrayLength);
            }
            else if (answer == 8)
            {
                int[] merge2 = Merge.ArrayMerger(net4, net6);
                int arrayLength = merge2.Length;
                ArraySortandSearch(merge2, arrayLength);
            }
        }
   
            
    }
}

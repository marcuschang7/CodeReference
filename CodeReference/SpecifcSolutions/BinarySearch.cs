using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class BinarySearch
    {
        // BinarySearch Iterative

        // Here we pass an array and the key we are searching for
        //This should be a sorted array
        public static object BinarySearchIterative(int[] inputArray, int Searchvalue)
        {
            // Set Start positions
            int min = 0;
            int max = inputArray.Length -1;
            

            while (min <= max)
            {
                // Calculate the middle (min + max)/2, rounded down so that it is an integer.
                int mid = ((min + max) / 2);

                // Check the value at the middle position. if it is what you want, stopreturn results
                if (Searchvalue == inputArray[mid])
                {
                    return mid;
                }
                else if (Searchvalue < inputArray[mid]) //If the middle value was too high, set max to be middle position -1.
                {
                    max = mid - 1;
                }
                else //If the middle value was too low, set min to be middle position + 1.
                {
                    min = mid + 1;
                }

            }
            return "Nil";
        }

        public static void Main(string[] args)
        {
            // Create an array
            int[] numbersArray = { 3, 5, 3, 7, 9, 12, 1 };

            // Sort it 
            Array.Sort(numbersArray);

            // Call method get position of value passed
            var position = BinarySearchIterative(numbersArray, 12);
            Console.Read();
        }
    }
}
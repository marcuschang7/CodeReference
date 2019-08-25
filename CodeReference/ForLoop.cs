using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class ForLoop
    {
        // Reverse a string with a for loop
        public static string reverseString()
        {
            string TheString = "abcdef";
            string nameReverse = String.Empty;
            char[] cArray = TheString.ToCharArray();

            //Decrementing For loop   
            for (int i = TheString.Length - 1; i > -1; i--)
            {
                if (i == TheString.Length - 1) //First pass
                {
                    nameReverse += cArray[i];
                }
                else
                {
                    nameReverse = nameReverse + "," + cArray[i];
                }
            }
            return nameReverse;
        }

        // Push values into array with For Loop

        static void Main(string[] args)
        {
            var result = reverseString();
        }

        // Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) // Get first index
            {
                for (int j = i + 1; j < nums.Length; j++) // Get the following index
                {
                    if (nums[j] == target - nums[i]) // Compare values from index
                    {
                        return new int[] { i, j }; // Since there is amatch return values
                    }

                }
            }
            throw new ArgumentException("No Solution");
        }


    }
}

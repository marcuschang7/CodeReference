using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class RemoveDupesFromArray
    {
        public static int RemoveDuplicates(int[] nums) // Assume Array is sorted
        {
            if (nums.Length <= 1) // If less than or equal to 1 return Length
            {
                return nums.Length;
            }

            int current = nums[0];   // First pass current is 1 from {1,1,2} input data current will start one step behind
            int newLength = 1;       // First pass set newLength = 1 //newLenth is now one step ahead of current
            for (int i = 1; i < nums.Length; i++) // Loop through nums length in the case of {1,1,2} it will be three because [0],[1],[2] equal 3
            {
                var testi = nums[i];
                var testnewLength = nums[newLength];
                if (nums[i] != current) // Here as we loop through nums[i] we check if nums[i] is not equal to current. This works since array is sorted. We are comparing the past with the present
                {

                    // nums[i] is not equal to current so do the following
                    nums[newLength] = nums[i];  // Set the value of nums[newLength] to equal nums[i]. This modifies the array directly
                    newLength++; // Increment newLength
                    current = nums[i]; // Set current to become nums[i]
                }
                //else continue to next item
            }

            return newLength; // return incremented newLength 
        }

        static void Main(string[] args)
        {
            int[] test = { 1, 1, 2 };
            var result = RemoveDuplicates(test).ToString(); // Passing int array by value
            Console.WriteLine("Count of Array is " + RemoveDuplicates(test).ToString());
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class RemoveValueFromArray
    {
        public static int RemoveElement(int[] nums, int val) // Assume Array is sorted
        {
            int valToReturn = 0;
            for (int currentnum = 0; currentnum < nums.Length; currentnum++)
            {
                if (nums[currentnum] != val)
                {
                    nums[valToReturn] = nums[currentnum];
                    valToReturn++;
                }
            }
            return valToReturn;
        }
        static void Main(string[] args)
        {
            int[] test = { 3, 2, 2, 3 };
            var val = 3;
            var result = RemoveElement(test, val).ToString(); // Passing int array by value
            Console.WriteLine("Count of Array is " + RemoveElement(test, val).ToString());
            Console.ReadKey();


        }
    }
}

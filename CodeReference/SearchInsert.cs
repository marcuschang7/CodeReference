using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class SearchInsertExample
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int i = nums.ToList().BinarySearch(target);
            var test = ~i;
            return i >= 0 ? i : ~i;
        }

        static void Main(string[] args)
        {
            //Input: [1, 3, 5, 6], 5
            //int[] array = new int[4];
            int[] array =  { 1, 3, 5, 6 };
            //Expected Output: 2

            var test = SearchInsert(array, 4);
        }

    }
}

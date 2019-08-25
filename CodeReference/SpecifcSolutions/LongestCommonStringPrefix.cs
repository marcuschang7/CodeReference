using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class LongestCommonStringPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) // if str is null or 0 length return ""
                return "";

            //TODO: See if you can get rid of below for the first iteration or maybe we must have this?
            char[] c_list = strs[0].ToCharArray(); // Convert first string into char array (Array of the String)
            int lengthOfFirstNodeInStrs = c_list.Length;
            int currentChar = 0;
            for (int indexOfStringArray = 1; indexOfStringArray < strs.Length; indexOfStringArray++) // Loop runs according to the size of the array
            {
                for (currentChar = 0; currentChar < lengthOfFirstNodeInStrs && currentChar < strs[indexOfStringArray].Length; currentChar++) // Loop runs according to the size of the current string in array
                    if (c_list[currentChar] != strs[indexOfStringArray].ElementAt(currentChar)) // Once current does not match element in indexOfStringArray we break and continue loop
                        break;
                lengthOfFirstNodeInStrs = currentChar; // If lengthOfFirstNodeInStrs && currentChar LESS Then strs[indexOfStringArray].Length we continue
            }
            var testAgain = new String(c_list).Substring(0, lengthOfFirstNodeInStrs); // Create new string with results ()

            return new String(c_list).Substring(0, lengthOfFirstNodeInStrs);

        }
        static void Main(string[] args)
        {

            string[] str = new string[4];
            str[0] = "geek1234";
            str[1] = "geekter";
            str[2] = "geeks";
            str[3] = "geeksdf";


            var test = LongestCommonPrefix(str);
            Console.WriteLine("Matching prefix in common is {0} ", test);
            Console.ReadKey();
        }
    }
}

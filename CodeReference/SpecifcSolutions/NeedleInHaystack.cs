using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class NeedleInHaystack
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Length == 0 && needle.Length == 0)
            {
                return 0;
            }
            if (haystack == needle) // Exact match so index is 0
            {
                return 0;
            }

            if (!haystack.Contains(needle)) // Without this your substring equals blows up
            {
                return -1;
            }

            // Return Index of first occurrence of string
            for (int i = 0; i < haystack.Length; i++) 
            {
                if (haystack.Substring(i, needle.Length).Equals(needle))
                {
                    var test = haystack.Substring(i, needle.Length).Equals(needle); // i is starting index then needleLength= how is how many characters to Equal to test
                    return i;
                }
            }
            return -1;

        }

        static void Main(string[] args)
        {
            var test = StrStr("Mississippi", "pi");


            Console.WriteLine("The index needle starts at " + test);
            Console.ReadKey();
        }
    }
}


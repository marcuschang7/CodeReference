using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class CountChars
    {
        public static void CountCharactersLinq(string str)
        {
            var counts = str.GroupBy(c => c) // put each character into a "bucket"
                 .OrderBy(c => c.Key)  // order the buckets alphabetically
                 .ToDictionary(grp => grp.Key, grp => grp.Count()); // then convert to dictionary where key = character, value = count

            foreach (var item in counts)
            {
                Console.WriteLine("Count of {0} is {1} ", item.Key, item.Value);
            }

        }
        static void Main(string[] args)
        {
            string str = "aaaabbbcccdddeeeeez";
            CountCharactersLinq(str);
            Console.ReadKey();
        }
    }

}

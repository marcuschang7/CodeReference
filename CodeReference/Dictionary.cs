using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Dictionary
    {
        public static Dictionary<int, string> PopulateDict(string name)
        {
            var dict = new Dictionary<int, string>();
            dict.Add(1, name);

            return dict;

        }

        static void main(string[] args)
        {
            var dict = PopulateDict("John");
        }
    }
}

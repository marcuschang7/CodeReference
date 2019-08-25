using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class StringBuilderExample
    {
        public static StringBuilder SB()
        {
            StringBuilder sb = new StringBuilder("1234");

            for (int i = 4; i < 10; i++)
            {
                sb.Append(i);
            }
            return sb;
        }

        static void Main(string[] args)
        {
            var test = SB();
        }

    }
}

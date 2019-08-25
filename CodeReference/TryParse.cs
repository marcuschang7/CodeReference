using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class TryParse
    {
        public int SumInt(string letterNumbers)
        {
            int sum=0;
            foreach (var item in letterNumbers)
            {
                var test= Convert.ToString(item);
                int testNum;
                var Bool = int.TryParse(test, out testNum);
                sum = sum + 1;


            }

            return sum;
        }

        public int TotalInt(string letterNumbers)
        {
            int sum = 0;
            foreach (var item in letterNumbers)
            {
                var test = Convert.ToString(item);
                int testNum;
                var Bool = int.TryParse(test, out testNum);
                sum ++;


            }

            return sum;
        }
    }
   



}

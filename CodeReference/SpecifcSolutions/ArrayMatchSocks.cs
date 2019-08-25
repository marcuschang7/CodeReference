using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class ArrayMatchSocks
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var test = ar.GroupBy(item => item).OrderBy(v => v.Key).ToDictionary(grp => grp.Key, grp => grp.Count());
            int pairs = 0;
            foreach (var item in test) // divide value of each group
            {
                var grp = item.Key;
                var total = item.Value / 2;
                pairs += total;
            }
            return pairs;


        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp)) ;
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = sockMerchant(n, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Arrays
    {

        public static int[] GetDataRecords(int num)
        {
            int[] Labels = new int[num];
            for (int i = 0; i < num; i++)
            {
                Labels[i] = i;
            }

            return Labels;
        }

        // Jagged Array "array is an array of arrays" //int[][] scores = new int[2][]{new int[]{92,93,94},new int[]{85,66,87,88}};

        static void Main(string[] args)
        {
         var value=   GetDataRecords(15);
        }
    }
}

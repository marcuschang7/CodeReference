using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Array2DHourGlassSum
    {
        static int R = 5;
        static int C = 5;
        // Complete the hourglassSum function below.
        static int hourglassSum(int [][] arr)
        {

            //ROw
            int sum = -1000;
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {

                    int top = arr[i][x] + arr[i][x + 1] + arr[i][x + 2];
                    int middle = arr[i + 1][x + 1];
                    int bottom = arr[i + 2][x] + arr[i + 2][x + 1] + arr[i + 2][x + 2];
                    if (top + middle + bottom > sum) { sum = top + middle + bottom; }
                }
            }
            //System.out.println(sum);
            return sum;
    }


        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Func
    {
        static int SumMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // Func<int,int,int> add= SumMethod;
            //int result = add(10, 10);
            var result=FuncWithLambda();
            Console.WriteLine(result);
        }

        static int FuncWithLambda()
        {
            Func<int, int, int> Sum = (x, y) => x + y;
            int result = Sum(5, 5);
            // Call the Func

            //Func<int> getRandomNumber = () = new Random().Next(1, 100);

            //Func<int, int, int> Sum = (x, y) => x + y;

            //Console.WriteLine(getRandomNumber());
            //Console.WriteLine(Sum(10, 20));
            return result;
        }
    }
}

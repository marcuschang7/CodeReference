using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class FibonacciExample
    {

        public static void Fibonacci (int n)
        {
            int prev = 0, next = 1, sum = 0;
            int[] array = new int[n + 2];

            Console.Write("{0} {1}", prev, next); // Gets official Fibonacci for initial values
            array[0] = prev;
            array[1] = next;

            for (int i = 2; i < n+2; i++)

            {

                sum = prev + next;

                Console.Write(" {0}", sum);
                array[i] = sum;

                prev = next;

                next = sum;

            }
        }

        static void Main(string[] args)
        {
            Fibonacci(15);
            Console.ReadKey();
        }
    }
}

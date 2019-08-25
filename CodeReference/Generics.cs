using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Generics
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }


   
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Swap<int>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

        // Generic with constraint
        void SwapIfGreater<T>(ref T lhs, ref T rhs) where T : System.IComparable<T>
        {
            T temp;
            if (lhs.CompareTo(rhs) > 0)
            {
                temp = lhs;
                lhs = rhs;
                rhs = temp;
            }
        }

    }
  
}

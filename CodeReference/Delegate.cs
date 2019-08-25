using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Delegate
    {
        delegate int NumberChanger(int n);
        static int num = 10;
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger ncAddNum = new NumberChanger(AddNum);
            NumberChanger ncMultNum = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            ncAddNum(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            ncMultNum(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
}

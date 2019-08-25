using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    interface ITest1
    {
        void Print();
    }
    class TestInterface
    {
        static void Main(string[] args)
        {
            ITest1 test = new Interface1();
            ITest1 test2 = new Interface2();
            test.Print();
            test2.Print();
            Console.ReadKey();
        }
        class Interface1 : ITest1
        {
            public void Print()
            {
                Console.WriteLine("I'm Test Interface1");
            }
        }

        class Interface2 : ITest1
        {
            public void Print()
            {
                Console.WriteLine("I'm Test Interface2");
            }
        }
    }

}

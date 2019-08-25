using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    public interface IText
    {
        void print();
    }

    class DependencyInjectionCtorExample : IText
    {
        public void print()
        {
            Console.WriteLine(" Here is text format");

        }

        // Constructor Injection Example
        public class PropertyInjection
        {
            private IText _text;
            public PropertyInjection(IText t1)
            {
                this._text = t1;
            }
            public void print()
            {
                _text.print();
            }
        }
        class constructor
        {
            static void Main(string[] args)
            {
                PropertyInjection cs = new PropertyInjection(new DependencyInjectionCtorExample());
                cs.print();
                Console.ReadKey();
            }
        }

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    public interface Iset
    {
        void print();
    }
    public class servic : Iset
    {
        public void print()
        {
            Console.WriteLine("print........");
        }
    }
    public class client
    {
        private Iset _set;
        public void run(Iset serv)
        {
            this._set = serv;
            Console.WriteLine("start");
            this._set.print();
        }
    }
    class method
    {
        public static void Main()
        {
            client cn = new client();
            cn.run(new servic());
            Console.ReadKey();
        }
    }
}
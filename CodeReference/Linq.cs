using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Linq
    {
        static void Main(string[] args)
        {
            var Newclass = new LinqStuff();
            Newclass.LinqMethodLambda();
        }


        public class stuff
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string State { get; set; }
        }
        public class order
        {
            public int OrderId { get; set; }
            public string Item { get; set; }

        }

        public class LinqStuff
        {
            public IList<stuff> Student { get; set; }
            public IList<order> Orders { get; set; }

            // Constructor
            public LinqStuff()
            {
                Student = new List<stuff>()
            {
                new stuff() { Id= 1,Name="Sarah",State="GA" },
                new stuff() { Id= 2,Name="Bill",State="FL" },
                new stuff() { Id= 3,Name="George",State="GA" },
                new stuff() { Id= 4,Name="Phil",State="MA" },
                new stuff() { Id= 5,Name="Laura",State="GA" },
                new stuff() { Id= 6,Name="Jill",State="CA" },
                new stuff() { Id= 7,Name="Will",State="GA" }
            };

                Orders = new List<order>()
            {
                new order() {OrderId = 1,Item="Towel" },

                new order() {OrderId = 3,Item="Towel" },
                new order() {OrderId = 4,Item="Towel" },

                new order() {OrderId = 6,Item="Towel" },
                new order() {OrderId = 7,Item="Towel" }
            };

            }

            //LinqMethod
            public void LinqMethodLambda()
            {
                // Select a Order by ID 3
                var orderID3 = Orders.Where(o => o.OrderId == 3).FirstOrDefault();

                // Group Students by state
                var ByState = Student.GroupBy(
                    s => s.Name,
                    s => s.State,
                    (key, group) => new { Name = key, ByState = group.ToList() }
                    );

                // Join Students and there respective order

                // Get Students with order

                // Get Student without order
            }
            public void LinqMethodQuery()
            {
                // Select a Order by ID 3
                var orderID3 = Orders.Where(o => o.OrderId == 3).FirstOrDefault();

                // Group Students by state
                var ByState = Student.GroupBy(
                    s => s.Name,
                    s => s.State,
                    (key, group) => new { Name = key, ByState = group.ToList() }
                    );

                // Join Students and there respective order

                // Get Students with order

                // Get Student without order
            }
        }
    }
}

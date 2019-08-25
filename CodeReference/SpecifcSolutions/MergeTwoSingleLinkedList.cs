using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeReference
{
    class MergeTwoSingleLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        // Recursive
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // Needed or this will crash
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val < l2.val) 
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l2.next, l1);
                return l2;
            }
        }

        public static void Print(ListNode node)
        {

            do
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            while (node != null);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            var firstNode1 = new ListNode(1);
            var firstNode2 = new ListNode(3);
            var firstNode3 = new ListNode(5);
            var firstNode4 = new ListNode(7);
            var firstNode5 = new ListNode(9);
            firstNode1.next = firstNode2;
            firstNode2.next = firstNode3;
            firstNode3.next = firstNode4;
            firstNode4.next = firstNode5;

            var SecondNode1 = new ListNode(2);
            var SecondNode2 = new ListNode(4);
            var SecondNode3 = new ListNode(6);
            var SecondNode4 = new ListNode(8);
            var SecondNode5 = new ListNode(10);
            var SecondNode6 = new ListNode(12);
            var SecondNode7 = new ListNode(14);
            var SecondNode8 = new ListNode(16);
            SecondNode1.next = SecondNode2;
            SecondNode2.next = SecondNode3;
            SecondNode3.next = SecondNode4;
            SecondNode4.next = SecondNode5;
            SecondNode5.next = SecondNode6;
            SecondNode6.next = SecondNode7;
            SecondNode7.next = SecondNode8;

            var test = MergeTwoLists(firstNode1, SecondNode1);
            Print(test);

            Console.ReadKey();
        }
    }
}

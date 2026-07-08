using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Linked_List
{
    internal class Reorder_List
    {
        public class  ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int value)
            {
                val = value;
                next = null;
            }
        }
        public class list
        {
            public static void Reorder(ListNode ln)
            {
                if (ln == null || ln.next == null)
                {
                    return;
                }
                ListNode slow = ln;
                ListNode fast = ln;
                while(fast.next !=null && fast.next.next !=null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }
                ListNode pre = null;
                ListNode pra = slow.next;
                slow.next = null;
                while(pra != null)
                {
                    ListNode next = pra.next;
                    pra.next = pre;
                    pre = pra;
                    pra = next;
                }
                ListNode first = ln;
                ListNode second = pre;
                while(second != null)
                {
                    ListNode temp1 = first.next;
                    ListNode temp2 = second.next;

                    first.next = second;
                    second.next = temp1;

                    first = temp1;
                    second = temp2;
                }
                
            }
        }
        public static void print(ListNode ln)
        {
            Console.WriteLine(ln.val+" ");
            ln = ln.next;
        }
        //static void Main()
        //{
        //    ListNode ln1 = new ListNode(1);
        //    ln1.next = new ListNode(2);
        //    ln1.next.next = new ListNode(3);
        //    ln1.next.next.next = new ListNode(4);
        //    ln1.next.next.next.next = new ListNode(5);
        //    Console.WriteLine("Before Order:");
        //    print(ln1);
        //    Reorder(ln1);
        //    Console.WriteLine();
        //    Console.WriteLine("After Order:");
        //    print(ln1);
        //}
    }
}

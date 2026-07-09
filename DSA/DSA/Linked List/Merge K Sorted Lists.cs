using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Linked_List
{
    internal class Merge_K_Sorted_Lists
    {
        public  class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int value)
            {
                val = value;
                next = null;
            }
        }
        public class hello
        {
            public static ListNode mergelist(ListNode[] ln)
            {
                if(ln == null || ln.Length == 0)
                {
                    return null;
                }
                ListNode res =  null;
               foreach(ListNode list in ln)
                {
                    res = mergetwolist(res, list);
                }
                return res;
            }
            public  static ListNode mergetwolist(ListNode ln1,ListNode ln2)
            {
                ListNode demo = new ListNode(0);
                ListNode pra = demo;
                while(ln1 != null && ln2 != null)
                {
                    if(ln1.val < ln2.val)
                    {
                        pra.next = ln1;
                        ln1 = ln1.next;
                    }
                    else
                    {
                        pra.next = ln2;
                        ln2 = ln2.next;
                    }
                    pra = pra.next;
                }
                pra.next = ln1 ?? ln2;
                return demo.next;
            }
            //public static void Main()
            //{
            //    ListNode ln1 = new ListNode(1);
            //    ln1.next = new ListNode(2);
            //    ln1.next.next = new ListNode(3);

            //    ListNode ln2 = new ListNode(4);
            //    ln2.next = new ListNode(5);

            //    ListNode ln3 = new ListNode(6);

            //    ListNode[] res = { ln1, ln2, ln3 };

            //    ListNode result = mergelist(res);
            //    while(result != null)
            //    {
            //        Console.WriteLine(result.val+" ");
            //        result = result.next;
            //    }
            //}
        }
    }
}

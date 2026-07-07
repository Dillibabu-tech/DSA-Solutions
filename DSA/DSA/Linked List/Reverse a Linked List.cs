using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Linked_List
{
    internal class Reverse_a_Linked_List
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int value)
            {
                val = value;
                next = null;
            }
        }
        public static ListNode ReverseList(ListNode str)
        {
            ListNode l = null;
            ListNode l1 = str;
            while(l1 != null)
            {
                ListNode next = l1.next;
                l1.next = l;
                l = l1;
                l1 = next;   

            }
            return l;
        }
    }
}

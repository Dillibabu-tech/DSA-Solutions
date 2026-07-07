using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Linked_List
{
    internal class Merge_Two_Sorted_Lists
    {
        public class ListNode
        {
            public int mny;
            public ListNode next;
            public  ListNode(int value)
            {
                mny = value;
                next = null;
            }
        }
        public class ListNode1
        {
            public static ListNode TwomergedList(ListNode ln1,ListNode ln2)
            {
                ListNode demo = new ListNode(0);
                ListNode pre = demo;
                while(ln1 != null && ln2 != null)
                {
                     if(ln1.mny <= ln2.mny)
                    {
                        pre.next = ln1;
                        ln1 = ln1.next;
                    }
                    else
                    {
                        pre.next = ln2;
                        ln2 = ln2.next;
                    }
                    pre = pre.next;
                }
                pre.next = ln1 ?? ln2;
                return demo.next;
            }
        }
    }
}

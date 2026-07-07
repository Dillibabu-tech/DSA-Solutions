using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Linked_List
{
    internal class Detect_Cycle_in_Linked_List
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
        public class list
        {
            public static bool cycle(ListNode ln)
            {
                var slow = ln;
                var fast = ln;
                while(fast !=null && fast.next !=null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                    if(slow == fast)
                    {
                       return true; 
                    }
                }
                return false;
            }
        }
    }
}

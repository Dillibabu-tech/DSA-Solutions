using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Linked_List
{
    internal class Remove_Nth_Node_From_End
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
            public static ListNode FindNth(ListNode ln,int n)
            {
                ListNode demo = new ListNode(0) { next = ln};
                ListNode right = demo;
                ListNode left = demo;
                for(int i = 0;i<=n;i++)
                {
                    right = right.next;
                }
                while(right != null)
                {
                    right = right.next;
                    left = left.next;
                }
                left.next = left.next.next;
                return demo.next;
            }           
        }
    }
}

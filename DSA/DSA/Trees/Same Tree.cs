using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Same_Tree
    {
     public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int Value)
            {
                val = Value;
            }
        }
        public static bool sametree(TreeNode tn1,TreeNode tn2)
        {
            if(tn1 == null && tn2 == null)
            {
                return true;
            }
            if(tn1 == null || tn2 == null  || tn1.val != tn2.val)
            {
                return false;
            }
            return sametree(tn1.left, tn2.left) && sametree(tn1.right, tn2.right);
        }
        //public static void Main()
        //{
        //    TreeNode tn = new TreeNode(2);
        //    tn.left = new TreeNode(1);
        //    tn.right = new TreeNode(3);

        //    TreeNode tn1 = new TreeNode(2);
        //    tn1.left = new TreeNode(1);
        //    tn1.right = new TreeNode(3);

        //    bool result = sametree(tn,tn1);

        //    Console.Write(result);
        //}
    }
}

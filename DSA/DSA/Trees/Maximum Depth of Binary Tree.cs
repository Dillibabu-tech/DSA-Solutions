using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Maximum_Depth_of_Binary_Tree
    {

            public class TreeNode
            {
                public int val;
                public TreeNode left;
                public TreeNode right;
                public TreeNode (int value)
                {
                    val = value;
                }
            }
            public static int Depthbinary(TreeNode tn)
            {
                if(tn == null)
                {
                    return 0;
                }
                int leftdepth = Depthbinary(tn.left);
                int rightdepth = Depthbinary(tn.right);
                return 1 + Math.Max(leftdepth, rightdepth);
            }
        //public static void Main()
        //{
        //    TreeNode tn1 = new TreeNode(4);

        //    tn1.left = new TreeNode(3);
        //    tn1.right = new TreeNode(2);

        //    tn1.right.left = new TreeNode(6);
        //    tn1.right.right = new TreeNode(7);

        //    Console.WriteLine("Maximum_Depth_of_Binary_Tree:");
        //    Console.WriteLine(Depthbinary(tn1));
        //}
    }
}

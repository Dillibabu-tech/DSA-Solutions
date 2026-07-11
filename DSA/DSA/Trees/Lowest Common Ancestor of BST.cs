using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Lowest_Common_Ancestor_of_BST
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int value)
            {
                val = value;
            }
        }
        public class Solution
        {
            public static TreeNode sametree(TreeNode root,TreeNode tn1,TreeNode tn2)
            {
                while(root !=null)
                {
                    if(tn1.val < root.val  && tn2.val < root.val)
                    {
                        root = root.left;
                    }
                    else if(tn1.val  > root.val && tn2.val > root.val)
                    {
                        root = root.right;
                    }
                    else
                    {
                        return root;
                    }
                }
                return null;
            }
            //public static void Main()
            //{
            //    TreeNode root = new TreeNode(4);

            //    root.left = new TreeNode(2);
            //    root.right = new TreeNode(6);

            //    root.left.left = new TreeNode(1);
            //    root.left.right = new TreeNode(3);

            //    root.right.left = new TreeNode(5);
            //    root.right.right = new TreeNode(7);

            //    TreeNode tn1 = root.left;
            //    TreeNode tn2 = root.right;

            //    TreeNode result = sametree(root, tn1, tn2);
            //    Console.WriteLine(result.val);
            //}
        }
    }
}

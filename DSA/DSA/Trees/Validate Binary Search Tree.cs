using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Validate_Binary_Search_Tree
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
        public static bool IsvalidateBSt(TreeNode root)
        {
            return validate(root, long.MinValue, long.MaxValue);
        }
        public static bool validate(TreeNode root,long min,long max)
        {
            if(root == null)
            {
                return true;
            }
            if (root.val <= min || root.val >= max )
            {
                 return false;
            }
            return validate(root.left,min,root.val) && validate(root.right,root.val,max);
        }
        //public static void Main()
        //{

        //    TreeNode root = new TreeNode(8);
        //    root.left = new TreeNode(3);
        //    root.right = new TreeNode(10);
        //    root.left.left = new TreeNode(1);
        //    root.left.right = new TreeNode(6);
        //    root.left.right.left = new TreeNode(4);
        //    root.left.right.right = new TreeNode(7);
        //    root.right.right = new TreeNode(14);
        //    root.right.right.left = new TreeNode(13);

        //    bool result = IsvalidateBSt(root);
        //    Console.WriteLine(result);
        //}
    }
}

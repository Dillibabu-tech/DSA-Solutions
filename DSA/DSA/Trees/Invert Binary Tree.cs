using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Invert_Binary_Tree
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
        public static TreeNode invertTree(TreeNode tn)
        {
            if(tn == null)
            {
                return null;
            }
            TreeNode left = invertTree(tn.left);
            TreeNode right = invertTree(tn.right);

            tn.left = right;
            tn.right = left;
            return tn;
        }
        public static void Preorder(TreeNode tn1)
        {
            if(tn1 == null)
            {
                return;
            }
            Console.Write(tn1.val+" ");
            Preorder(tn1.left);
            Preorder(tn1.right);

        }
        //public static void Main()
        //{
        //    TreeNode tn = new TreeNode(4);

        //    tn.left = new TreeNode(1);
        //    tn.right = new TreeNode(3);

        //    tn.left.left = new TreeNode(2);
        //    tn.left.right = new TreeNode(5);

        //    tn.right.left = new TreeNode(7);
        //    tn.right.right = new TreeNode(6);

        //    Console.WriteLine("Before InvertTree");
        //    Preorder(tn);
        //    invertTree(tn);
        //    Console.WriteLine("\n After InvertTree");
        //    Preorder(tn);
        //}
    }
}

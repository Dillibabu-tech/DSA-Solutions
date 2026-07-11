using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Subtree_of_Another_Tree
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
        public class Listnode2
        {
            public static bool Issame(TreeNode root, TreeNode sub)
            {
                if(root == null)
                {
                   return false;
                }
                if(Sametree(root,sub))
                {
                  return true;
                }
                return Issame(root.left,sub) || Issame(root.right,sub);
            }
            public static bool Sametree(TreeNode tn1,TreeNode tn2)
            {
                if(tn1 == null && tn2 == null)
                {
                    return true;
                }
                if(tn1 == null || tn2 == null || tn1.val != tn2.val)
                {
                    return false;
                }
                return Sametree(tn1.left,tn2.left) && Sametree(tn1.right,tn2.right);
            }
            //public static void Main()
            //{
            //    TreeNode root = new TreeNode(4);
            //    root.left = new TreeNode(3);
            //    root.right = new TreeNode(2);

            //    root.right.left = new TreeNode(1);
            //    root.right.right = new TreeNode(5);

            //    TreeNode sub = new TreeNode(2);
            //    sub.left = new TreeNode(1);
            //    sub.right = new TreeNode(5);

            //    bool result = Issame(root, sub);
            //    Console.WriteLine(result);
            //}
        }
       
    }
}

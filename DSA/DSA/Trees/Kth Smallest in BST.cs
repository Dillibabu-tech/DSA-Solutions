using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DSA.Trees.Kth_Smallest_in_BST;

namespace DSA.Trees
{
    internal class Kth_Smallest_in_BST
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
        public class tree
        {
            public int counnt = 0;
            public int resu = 0;
            public  int KthValue(TreeNode tn, int k)
            {
                counnt = 0;
                resu = 0;
                value(tn,k);
                return resu;
             }
            public void  value(TreeNode root,int k)
            {
                if(root == null || counnt >= k)
                {
                    return;
                }
                value(root.left,k);
                counnt++;
                if(counnt == k)
                {
                    resu = root.val;
                    return;
                }
                value(root.right, k);
            }
        }
        //static void Main(string[] args)
        //{
        //    TreeNode root = new TreeNode(15);

        //    root.left = new TreeNode(10);
        //    root.right = new TreeNode(20);

        //    root.left.left = new TreeNode(8);
        //    root.left.right = new TreeNode(12);

        //    root.right.left = new TreeNode(17);
        //    root.right.right = new TreeNode(25);

        //    tree obj = new tree();

        //    int k = 5;

        //    int ans = obj.KthValue(root, k);

        //    Console.WriteLine("Kth Smallest Element : " + ans);
        //}


    }
}

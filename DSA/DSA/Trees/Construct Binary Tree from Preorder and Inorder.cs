using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Construct_Binary_Tree_from_Preorder_and_Inorder
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
        public class Tree
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            public int preindex = 0;    
            public  TreeNode buildvalTree(int[] preorder, int[] inorder)
            {
                map.Clear();
                for(int i = 0;i< inorder.Length;i++)
                {
                    map[inorder[i]] = i;
                }
                preindex = 0; 
                return  buildval(preorder,0, inorder.Length-1);
            }
            public   TreeNode  buildval(int[] preorder,int left,int right)
            {
                if(left > right)
                {
                    return null;
                }
                TreeNode root = new TreeNode(preorder[preindex]);
                int mid = map[root.val];
                preindex++;
                root.left = buildval(preorder, left, mid - 1);
                root.right = buildval(preorder, mid+1,right);
                return root;
            }
            public static void print(TreeNode tn)
            {
                if(tn == null)
                {
                    return;
                }
                print(tn.left);
                Console.WriteLine(tn.val);
                print(tn.right);
            }
            //public  void Main()
            //{
            //    int[] preorder = { 3, 9, 20, 15, 7 };
            //    int[] inorder = { 9, 3, 15, 20, 7 };

            //    TreeNode root1 = buildvalTree(preorder, inorder);

            //    Console.WriteLine("Inorder Traversal:");

            //    print(root1);
            //}
        }
    
    }
}

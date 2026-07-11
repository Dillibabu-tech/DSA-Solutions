using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    internal class Binary_Tree_Level_Order_Traversal
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
        public class lis
        {
            public IList<IList<int>> TN(TreeNode root)
            {
                List<IList<int>> res= new List<IList<int>>();
                if(root == null)
                {
                    return res;
                }
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while(queue.Count > 0)
                {
                    List<int> curr = new List<int>();
                    int size = queue.Count;
                    for(int i =0;i< size;i++)
                    {
                      TreeNode level = queue.Dequeue();
                        curr.Add(level.val);
                        if(level.left != null)
                        {
                            queue.Enqueue(level.left);
                        }
                        if (level.right != null)
                        {
                            queue.Enqueue(level.right);
                        }
                    }
                    res.Add(curr);
                }
                return res;
            }
        }
    }
}

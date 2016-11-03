using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Tree
    {
        public class TreeNode
        {
            public int Value;
            public int Count = 0; 
            public TreeNode Left;
            public TreeNode Right; 
            //public int Value { get; set; }
            //public int Count { get; set; }
            //public TreeNode Left { get; set; }
            //public TreeNode Right { get; set; }
        }
        public TreeNode Node;

        public void AddRecursion(ref TreeNode node, int val)
        {
            if (node == null)
            {
                node = new TreeNode();
                node.Value = val;
                node.Left = node.Right = null;
                return;
            }
            if (node.Value > val)
            {
                AddRecursion(ref node.Left, val);
            }
            else
            {
                AddRecursion(ref node.Right, val);
            }
            
        }

        public void SymmetricalRound(TreeNode node, ref string s)
        {
            if (node != null)
            {
                SymmetricalRound(node.Left, ref s);
                s += node.Value.ToString() + " ";
                SymmetricalRound(node.Right, ref s); 
            }
        }
    }
}

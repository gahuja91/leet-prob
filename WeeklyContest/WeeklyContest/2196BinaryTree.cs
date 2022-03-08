using System;
using System.Collections.Generic;
using System.Linq;

namespace WeeklyContest
{
    public class _2196BinaryTree
    {
        public List<TreeNode> Nodes = new List<TreeNode>();
        public Dictionary<TreeNode, int> NodeLevels = new Dictionary<TreeNode, int>(); 
        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            foreach (var description in descriptions)
            {
                TreeNode child = GetNode(description[1]);
                TreeNode parent = GetNode(description[0]);

                //Left Child
                if (description[2] == 1)
                    parent.left = child;
                else
                    parent.right = child;

                int value;
                NodeLevels.TryGetValue(parent, out value);
                if (value == 0 || value == 1)
                    NodeLevels[parent] = 1;
                NodeLevels.TryGetValue(child, out value);
                if (value == 0 || value == 1)
                    NodeLevels[child] = 2;
            }
            TreeNode root = NodeLevels.First(node => node.Value == 1).Key;
            Console.WriteLine($"Root: {root.val}, Left Child: {root.left?.val}, Right Child: {root.right?.val}");
            return root;
        }

        public TreeNode GetNode(int val)
        {
            TreeNode node = this.Nodes.Find(node => node.val == val);
            if (node == null)
            {
                var newNode = new TreeNode(val);
                this.Nodes.Add(newNode);
                return newNode;
            }
            else
                return node;
        }

        public void Execute()
        {
            var input = new int[][]
            {
                new int[] { 85,74,0 },
                new int[] { 38,82,0 },
                new int[] { 39,70,0 },
                new int[] { 82,85,0 },
                new int[] { 74,13,0 },
                new int[] { 13,39,0 },
            };
            CreateBinaryTree(input);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

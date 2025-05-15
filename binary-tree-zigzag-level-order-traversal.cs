// 103. Binary Tree Zigzag Level Order Traversal   
// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal
// Medium 33.8%
// 526.1573210057749
// Submission: https://leetcode.com/submissions/detail/70704403/
// Runtime: 560 ms
// Your runtime beats 3.37 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var list = new List<IList<int>>();
        if (root == null)
            return list;
            var parents = new List<TreeNode>() { root };
        bool reverse = false;
                while (parents.Count > 0)
        {
            var values = parents.ConvertAll(p=>p.val);
            if (reverse)
                values.Reverse();
            list.Add(values);
            var oldParents = parents;
            parents = new List<TreeNode>();  
            foreach (var p in oldParents)
            {
                if (p.left != null) parents.Add(p.left);
                if (p.right != null) parents.Add(p.right);
            }
                        reverse = !reverse;
        }
        return list;
    }
    }

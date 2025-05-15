// 107. Binary Tree Level Order Traversal II   
// https://leetcode.com/problems/binary-tree-level-order-traversal-ii
// Easy 39.4%
// 591.8047974836203
// Submission: https://leetcode.com/submissions/detail/68951909/
// Runtime: 496 ms
// Your runtime beats 27.40 % of csharp submissions.

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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var q = new List<TreeNode>();
        var list = new List<IList<int>>();
        if (root != null)
            q.Add(root);
        while (q.Count > 0)
        {
            int count = q.Count;
            var list2 = new List<int>();
            list.Add(list2);
                        for (int i=0; i<count; i++)
            {
                var n = q[i];
                list2.Add(n.val);
                if (n.left != null) q.Add(n.left);
                if (n.right != null) q.Add(n.right);
            }
                        q.RemoveRange(0, count);
        }
        list.Reverse();
        return list;        
    }
}

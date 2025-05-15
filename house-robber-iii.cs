// 337. House Robber III   
// https://leetcode.com/problems/house-robber-iii
// Medium 42.8%
// 658.8515578799557
// Submission: https://leetcode.com/submissions/detail/70021148/
// Runtime: 188 ms
// Your runtime beats 29.55 % of csharp submissions.

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
    public int Rob(TreeNode root) {
        int e;
        return Rob(root, out e);
    }
        int Rob(TreeNode node,  out int exclude)
    {
        exclude = 0;
        if (node == null)
            return 0;
                int e1, e2;
        exclude = Rob(node.left, out e1) + Rob(node.right, out e2);
        return Math.Max(exclude, node.val + e1 + e2);
    }
}

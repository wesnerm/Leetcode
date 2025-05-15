// 236. Lowest Common Ancestor of a Binary Tree   
// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree
// Medium 29.7%
// 818.751145641959
// Submission: https://leetcode.com/submissions/detail/68945996/
// Runtime: 188 ms
// Your runtime beats 14.38 % of csharp submissions.

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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null || root==p || root==q)
            return root;
                    var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);
        if (left != null && right != null)
            return root;
        return left ?? right;
    }
}

// 226. Invert Binary Tree   
// https://leetcode.com/problems/invert-binary-tree
// Easy 51.2%
// 1395.4544147339116
// Submission: https://leetcode.com/submissions/detail/68929787/
// Runtime: 160 ms
// Your runtime beats 20.99 % of csharp submissions.

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
    public TreeNode InvertTree(TreeNode root) {
        if (root==null)
            return null;
        TreeNode tmp = InvertTree(root.left);
        root.left = InvertTree(root.right);
        root.right = tmp;
        return root;
    }
}

// 104. Maximum Depth of Binary Tree   
// https://leetcode.com/problems/maximum-depth-of-binary-tree
// Easy 52.1%
// 1627.8556081561846
// Submission: https://leetcode.com/submissions/detail/68931682/
// Runtime: 180 ms
// Your runtime beats 9.88 % of csharp submissions.

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
    public int MaxDepth(TreeNode root) {
        if (root==null) 
            return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

// 111. Minimum Depth of Binary Tree   
// https://leetcode.com/problems/minimum-depth-of-binary-tree
// Easy 32.9%
// 621.6941771261191
// Submission: https://leetcode.com/submissions/detail/68932126/
// Runtime: 177 ms
// Your runtime beats 11.48 % of csharp submissions.

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
    public int MinDepth(TreeNode root) {
        if (root==null) 
            return 0;
                if (root.left==null) return 1+MinDepth(root.right);
        if (root.right==null) return 1+MinDepth(root.left);
        return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
    }
}

// 235. Lowest Common Ancestor of a Binary Search Tree   
// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree
// Easy 38.7%
// 1017.0028021279927
// Submission: https://leetcode.com/submissions/detail/68816589/
// Runtime: 192 ms
// Your runtime beats 25.30 % of csharp submissions.

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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        if (root.val > p.val && root.val > q.val)
            return LowestCommonAncestor(root.left, p, q);
        if (root.val < p.val && root.val < q.val)
            return LowestCommonAncestor(root.right, p, q);
        return root;
    }
}

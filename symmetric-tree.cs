// 101. Symmetric Tree   
// https://leetcode.com/problems/symmetric-tree
// Easy 38.2%
// 791.4947045592891
// Submission: https://leetcode.com/submissions/detail/70103456/
// Runtime: 160 ms
// Your runtime beats 14.74 % of csharp submissions.

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
    public bool IsSymmetric(TreeNode root) {
        return root==null
            || Mirror(root.left, root.right);
    }
        public bool Mirror(TreeNode left, TreeNode right)
    {
        if (left==right)
            return true;
        if (left == null || right == null)
            return false;
                    return left.val == right.val
            && Mirror(left.left, right.right)
            && Mirror(left.right, right.left);
            }
}

// 110. Balanced Binary Tree   
// https://leetcode.com/problems/balanced-binary-tree
// Easy 37.1%
// 927.3526635745231
// Submission: https://leetcode.com/submissions/detail/70007317/
// Runtime: 184 ms
// Your runtime beats 11.97 % of csharp submissions.

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
    public bool IsBalanced(TreeNode root) {
        int height;
        return IsBalanced(root, out height);
    }
        public bool IsBalanced(TreeNode node, out int height)
    {
        if (node == null)
        {
            height = 0;
            return true;
        }
                int height2;
        if (IsBalanced(node.left, out height)
            && IsBalanced(node.right, out height2)
            && Math.Abs(height2 - height) <= 1)
            {
                height = 1 + Math.Max(height, height2);
                return true;
            }
        return false;
    }
}

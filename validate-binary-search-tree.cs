// 98. Validate Binary Search Tree   
// https://leetcode.com/problems/validate-binary-search-tree
// Medium 23.0%
// 608.5737832703702
// Submission: https://leetcode.com/submissions/detail/68948725/
// Runtime: 184 ms
// Your runtime beats 10.23 % of csharp submissions.

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
    public bool IsValidBST(TreeNode root, long min=long.MinValue, long max=long.MaxValue) {
        if (root == null) return true;
        return root.val > min 
            && root.val < max
            && IsValidBST(root.left, min, root.val)
            && IsValidBST(root.right, root.val, max);
    }
    }

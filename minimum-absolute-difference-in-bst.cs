// 530. Minimum Absolute Difference in BST   
// https://leetcode.com/problems/minimum-absolute-difference-in-bst
// Easy 47.1%
// 336.9933890261838
// Submission: https://leetcode.com/submissions/detail/101897466/
// Runtime: 162 ms
// Your runtime beats 50.00 % of csharp submissions.

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
        int min = int.MaxValue;
    int prev = int.MinValue;
        public int GetMinimumDifference(TreeNode root) {
        prev = int.MinValue;
        GetMinimumDifferenceCore(root);
        return min;
    }
    public void GetMinimumDifferenceCore(TreeNode root) 
    {
        if (root == null) return;
                GetMinimumDifferenceCore(root.left);
                if (prev >= 0)
            min = Math.Min(root.val - prev, min);
        prev = root.val;
        GetMinimumDifferenceCore(root.right);
    }
    }

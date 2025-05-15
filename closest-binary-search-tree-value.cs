// 270. Closest Binary Search Tree Value   
// https://leetcode.com/problems/closest-binary-search-tree-value
// Easy 39.1%
// 408.5391481457848
// Submission: https://leetcode.com/submissions/detail/68228331/
// Runtime: 192 ms
// Your runtime beats 8.11 % of csharp submissions.

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
    public int ClosestValue(TreeNode root, double target) {
        var val = root.val;
        var kid = target < root.val ? root.left : root.right;
        if (kid == null) return val;
        var val2 = ClosestValue(kid, target);
        return Math.Abs(val-target) < Math.Abs(val2-target) ? val : val2;
    }
}

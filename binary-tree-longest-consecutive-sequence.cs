// 298. Binary Tree Longest Consecutive Sequence   
// https://leetcode.com/problems/binary-tree-longest-consecutive-sequence
// Medium 40.7%
// 486.7763633541393
// Submission: https://leetcode.com/submissions/detail/68420773/
// Runtime: 208 ms
// Your runtime beats 12.90 % of csharp submissions.

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
    public int LongestConsecutive(TreeNode root) {
        return dfs(root, 0, int.MinValue);
    }
        public int dfs(TreeNode root, int count, int val)
    {
        if (root == null)
            return count;
        count = (root.val-val==1)? count+1:1;
        int left = dfs(root.left,count,root.val);
        int right = dfs(root.right,count, root.val);
        return Math.Max(Math.Max(left, right), count);
    }
}

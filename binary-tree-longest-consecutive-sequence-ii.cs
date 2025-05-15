// 549. Binary Tree Longest Consecutive Sequence II   
// https://leetcode.com/problems/binary-tree-longest-consecutive-sequence-ii
// Medium 39.8%
// 138.97914825336193
// Submission: https://leetcode.com/submissions/detail/111721111/
// Runtime: 202 ms
// Your runtime beats 23.08 % of csharp submissions.

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
    int max = 0;
        public int LongestConsecutive(TreeNode root) {
                if (root==null)
            return 0;
                max = 1;
        while (root.left==null && root.right != null && Math.Abs(root.val-root.right.val) != 1)
            root = root.right;
                while (root.right==null && root.left != null && Math.Abs(root.val-root.left.val) != 1)
            root = root.left;
                Core(root);
        return max;
            }
        public int[] Core(TreeNode root)
    {
        if (root==null) return new int[] {0,0};
                int[] la = Core(root.left);
        int[] ra = Core(root.right);
        int inc = 1;
        int dec = 1;
                if (root.left != null)
        {
            if (root.left.val==root.val-1) inc = Math.Max(la[0]+1, inc);
            if (root.left.val==root.val+1) dec = Math.Max(la[1]+1, dec);
        }
        if (root.right != null)
        {
            if (root.right.val==root.val-1) inc = Math.Max(ra[0]+1, inc);
            if (root.right.val==root.val+1) dec = Math.Max(ra[1]+1, dec);
        }
        max = Math.Max(max, inc);
        max = Math.Max(max, dec);
                if (root.left != null && root.right != null)
        {
            if (root.left.val==root.val-1 && root.right.val==root.val+1)
                max = Math.Max(la[0] + ra[1]+1, max);
            if (root.left.val==root.val+1 && root.right.val==root.val-1)
                max = Math.Max(la[1] + ra[0]+1, max);
        }
                return new int[] { inc, dec };
    }
}

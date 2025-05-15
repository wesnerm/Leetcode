// 404. Sum of Left Leaves   
// https://leetcode.com/problems/sum-of-left-leaves
// Easy 46.8%
// 469.5415099633865
// Submission: https://leetcode.com/submissions/detail/75871257/
// Runtime: 145 ms
// Your runtime beats 46.67 % of csharp submissions.

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
    public int SumOfLeftLeaves(TreeNode root) {
        return SumOfLeftLeaves(root, false);
    }
        public int SumOfLeftLeaves(TreeNode root, bool left)
    {
        if (root==null) return 0;
        if (root.left==null && root.right==null)
            return left ? root.val : 0;
        return SumOfLeftLeaves(root.left,true) + SumOfLeftLeaves(root.right,false);
    }
}

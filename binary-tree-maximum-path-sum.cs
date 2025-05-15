// 124. Binary Tree Maximum Path Sum   
// https://leetcode.com/problems/binary-tree-maximum-path-sum
// Hard 25.7%
// 817.8271007885654
// Submission: https://leetcode.com/submissions/detail/70116958/
// Runtime: 192 ms
// Your runtime beats 19.51 % of csharp submissions.

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
    public int MaxPathSum(TreeNode root) {
        int maxpath, maxroot;
        MaxPathCore(root, out maxpath, out maxroot);
        return maxpath;
    }
        public void MaxPathCore(TreeNode root, out int maxpath, out int maxroot)
    {
        if (root == null)
        {
            maxroot = 0;
            maxpath = int.MinValue;
            return;
        }
                int maxpath1, maxpath2;
        int maxroot1, maxroot2;
                MaxPathCore(root.left, out maxpath1, out maxroot1);
        MaxPathCore(root.right, out maxpath2, out maxroot2);
                maxroot = Math.Max(0, root.val + Math.Max(maxroot1, maxroot2));
        maxpath = Math.Max(root.val + maxroot1 + maxroot2, Math.Max(maxpath1, maxpath2));
    }
    }

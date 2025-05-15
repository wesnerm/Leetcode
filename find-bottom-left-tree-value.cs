// 513. Find Bottom Left Tree Value   
// https://leetcode.com/problems/find-bottom-left-tree-value
// Medium 55.8%
// 288.3138299905165
// Submission: https://leetcode.com/submissions/detail/101886309/
// Runtime: 235 ms
// Your runtime beats 0.00 % of csharp submissions.

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
    public int FindBottomLeftValue(TreeNode root) {
        long v = 0;
        long d = 0;
                Find(root, 0, ref v, ref d);
        return (int) v;
            }
        void Find(TreeNode root, int depth, ref long v, ref long d)
    {
        if (root == null) return;
        depth++;
        if (depth > d)
        {
            d = depth;
            v = root.val;
        }
        Find(root.left, depth, ref v, ref d);
        Find(root.right, depth, ref v, ref d);
    }
    }

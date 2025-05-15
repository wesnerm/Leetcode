// 100. Same Tree   
// https://leetcode.com/problems/same-tree
// Easy 46.1%
// 1032.1243333773584
// Submission: https://leetcode.com/submissions/detail/70004505/
// Runtime: 180 ms
// Your runtime beats 3.73 % of csharp submissions.

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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if ( p==null || q ==null)
            return p == q;
        return p.val == q.val
            && IsSameTree(p.left, q.left)
            && IsSameTree(p.right, q.right);
    }
}

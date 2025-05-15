// 572. Subtree of Another Tree   
// https://leetcode.com/problems/subtree-of-another-tree
// Easy 41.9%
// 127.64670487844613
// Submission: https://leetcode.com/submissions/detail/105459130/
// Runtime: 202 ms
// Your runtime beats 20.00 % of csharp submissions.

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
    public bool IsSubtree(TreeNode s, TreeNode t) {
        if (s==null || t==null) return s==t;
                if (Match(s,t))
            return true;
        return IsSubtree(s.left,t) || IsSubtree(s.right, t);
    }
        bool Match(TreeNode s, TreeNode t)
    {
        if (s==t) return true;
        if (s==null || t==null) return false;
        return s.val == t.val && Match(s.left, t.left) && Match(s.right, t.right);
    }
}

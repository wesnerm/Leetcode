// 99. Recover Binary Search Tree   
// https://leetcode.com/problems/recover-binary-search-tree
// Hard 29.5%
// 707.8480796493529
// Submission: https://leetcode.com/submissions/detail/70708668/
// Runtime: 216 ms
// Your runtime beats 7.69 % of csharp submissions.

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
    public void RecoverTree(TreeNode root) {
                TreeNode prev = null;
        TreeNode first = null;
        TreeNode second = null;
                Dfs(root, ref prev, ref first, ref second);
                int tmp = first.val;
        first.val = second.val;
        second.val = tmp;
    }
        void Dfs(TreeNode root, ref TreeNode prev, ref TreeNode first, ref TreeNode second)
    {
        if (root == null)
            return;
        Dfs(root.left, ref prev, ref first, ref second);
                if (first == null && prev != null && prev.val > root.val)
            first = prev;
        if (first != null && prev.val > root.val)
            second = root;
        prev = root;
        Dfs(root.right, ref prev, ref first, ref second);
    }
    }

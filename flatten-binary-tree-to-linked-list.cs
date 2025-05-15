// 114. Flatten Binary Tree to Linked List   
// https://leetcode.com/problems/flatten-binary-tree-to-linked-list
// Medium 34.6%
// 688.3219651767416
// Submission: https://leetcode.com/submissions/detail/70152133/
// Runtime: 172 ms
// Your runtime beats 5.75 % of csharp submissions.

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
    public void Flatten(TreeNode root) 
    {
        TreeNode tail = null;
        Flatten(root, ref tail);
    }
        public  void Flatten(TreeNode root, ref TreeNode tail) {
        if (root == null)
            return;
                Flatten(root.right, ref tail);
        Flatten(root.left, ref tail);
        root.right = tail;
        root.left = null;
        tail = root;
    }
}

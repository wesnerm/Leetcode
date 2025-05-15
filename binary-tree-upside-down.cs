// 156. Binary Tree Upside Down   
// https://leetcode.com/problems/binary-tree-upside-down
// Medium 43.9%
// 562.5214517214763
// Submission: https://leetcode.com/submissions/detail/70120268/
// Runtime: 180 ms
// Your runtime beats 5.56 % of csharp submissions.

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
    public TreeNode UpsideDownBinaryTree(TreeNode root) 
    {
        return UpsideDown(root, null, null);
    }
        public TreeNode UpsideDown(TreeNode node, TreeNode invertedParent, TreeNode sibling)
    {
        if (node == null)
            return invertedParent;
        return UpsideDown(node.left, Construct(node.val, sibling, invertedParent), node.right);
    }
        public TreeNode Construct(int val, TreeNode left = null, TreeNode right = null)
    {
        return new TreeNode(val) { left = left, right = right };
    }
}

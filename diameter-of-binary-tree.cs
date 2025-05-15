// 543. Diameter of Binary Tree   
// https://leetcode.com/problems/diameter-of-binary-tree
// Easy 42.9%
// 468.6679844225144
// Submission: https://leetcode.com/submissions/detail/101835436/
// Runtime: 138 ms
// Your runtime beats 92.76 % of csharp submissions.

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
    public int DiameterOfBinaryTree(TreeNode root) {
        int height, diam;
        GetDiameter(root, out height, out diam);
        return diam;
    }
        public void GetDiameter(TreeNode node, out int height, out int diam)
    {
        if (node == null)
        {
            height = 0;
            diam = 0;
            return;
        }
                int h1, h2, d1, d2;
        GetDiameter(node.left, out h1, out d1);
        GetDiameter(node.right, out h2, out d2);
                        height = Math.Max(h1, h2) + 1;
        diam = Math.Max( d1, d2 );
        diam = Math.Max( diam, h1 + h2 );
    }
}

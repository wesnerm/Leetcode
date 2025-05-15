// 563. Binary Tree Tilt   
// https://leetcode.com/problems/binary-tree-tilt
// Easy 47.1%
// 294.824850322212
// Submission: https://leetcode.com/submissions/detail/105459370/
// Runtime: 169 ms
// Your runtime beats 43.72 % of csharp submissions.

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
    public int FindTilt(TreeNode root) {
        int sum, tiltsum;
        Tilt(root, out sum, out tiltsum);
        return tiltsum;
    }
        public void Tilt(TreeNode node, out int sum, out int tiltsum)
    {
        if (node == null)
        {
            sum = 0;
            tiltsum = 0;
            return;
        }
                int suml, tiltsuml;
        int sumr, tiltsumr;
        Tilt(node.left, out suml, out tiltsuml);
        Tilt(node.right, out sumr, out tiltsumr);
        sum = suml + sumr + node.val;
        int tilt = System.Math.Abs(suml - sumr);
        tiltsum = tilt + tiltsuml + tiltsumr;
    }
}

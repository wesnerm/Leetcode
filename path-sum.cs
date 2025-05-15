// 112. Path Sum   
// https://leetcode.com/problems/path-sum
// Easy 33.7%
// 720.4885454783632
// Submission: https://leetcode.com/submissions/detail/70104296/
// Runtime: 164 ms
// Your runtime beats 19.30 % of csharp submissions.

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
    public bool HasPathSum(TreeNode node, int sum) {
        if (node == null)
            return false;
        sum -= node.val;
        if (node.left == null && node.right == null)
            return sum == 0;
                    return HasPathSum(node.left, sum) || HasPathSum(node.right, sum);        
    }
}

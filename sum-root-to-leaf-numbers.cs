// 129. Sum Root to Leaf Numbers   
// https://leetcode.com/problems/sum-root-to-leaf-numbers
// Medium 36.1%
// 504.1153541530372
// Submission: https://leetcode.com/submissions/detail/70103977/
// Runtime: 167 ms
// Your runtime beats 1.37 % of csharp submissions.

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
    public int SumNumbers(TreeNode node, int val=0)
    {
        if (node == null)
            return 0;
        val = val*10 + node.val;
        if (node.left == null && node.right == null)
            return val;
                    return SumNumbers(node.left, val) + SumNumbers(node.right, val);
    }
    }

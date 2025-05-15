// 250. Count Univalue Subtrees   
// https://leetcode.com/problems/count-univalue-subtrees
// Medium 41.4%
// 637.3636229330323
// Submission: https://leetcode.com/submissions/detail/70105382/
// Runtime: 164 ms
// 

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
    public int CountUnivalSubtrees(TreeNode node) {
        bool unival;
        return CountUnivalSubtrees(node, out unival);
    }
    int CountUnivalSubtrees(TreeNode node, out bool unival)
    {
        unival = true;
        if (node==null) return 0;
                bool u1, u2;
        int cLeft = CountUnivalSubtrees(node.left, out u1);
        int cRight = CountUnivalSubtrees(node.right, out u2);
        unival = u1 && u2 
            && (node.left==null || node.val==node.left.val)
            && (node.right==null || node.val==node.right.val);
        return cLeft + cRight + (unival?1:0);
   }
}

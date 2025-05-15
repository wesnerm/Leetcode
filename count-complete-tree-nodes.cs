// 222. Count Complete Tree Nodes   
// https://leetcode.com/problems/count-complete-tree-nodes
// Medium 27.3%
// 719.7696487426418
// Submission: https://leetcode.com/submissions/detail/71285546/
// Runtime: 300 ms
// Your runtime beats 76.19 % of csharp submissions.

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
    public int CountNodes(TreeNode root) {
        if (root == null) 
            return 0;
                int leftHeight = EdgeHeight(root.left);
        int rightHeight = EdgeHeight(root.right);
                if (leftHeight==rightHeight)
            return (1<<leftHeight) + CountNodes(root.right);
        return CountNodes(root.left) + (1<<rightHeight);
    }
        int EdgeHeight(TreeNode root, bool left=true)
    {
        int height = 0;
        while (root != null)
        {
            height++;
            root = left ? root.left : root.right;
        }
        return height;
    }
    }

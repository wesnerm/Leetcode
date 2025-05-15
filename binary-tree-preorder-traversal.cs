// 144. Binary Tree Preorder Traversal   
// https://leetcode.com/problems/binary-tree-preorder-traversal
// Medium 44.4%
// 659.4309309642766
// Submission: https://leetcode.com/submissions/detail/70021572/
// Runtime: 504 ms
// Your runtime beats 11.46 % of csharp submissions.

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
    public IList<int> PreorderTraversal(TreeNode root) {
        var list = new List<int>();
        Populate(list, root);
        return list;
    }
        void Populate(List<int> list, TreeNode node)
    {
        if (node == null) return;
        list.Add(node.val);
        Populate(list, node.left);
        Populate(list, node.right);
    }
}

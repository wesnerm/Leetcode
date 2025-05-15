// 145. Binary Tree Postorder Traversal   
// https://leetcode.com/problems/binary-tree-postorder-traversal
// Hard 39.6%
// 596.4916430853752
// Submission: https://leetcode.com/submissions/detail/70021479/
// Runtime: 484 ms
// Your runtime beats 15.58 % of csharp submissions.

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
    public IList<int> PostorderTraversal(TreeNode root) {
        var list = new List<int>();
        Populate(list, root);
        return list;
    }
        void Populate(List<int> list, TreeNode node)
    {
        if (node == null) return;
        Populate(list, node.left);
        Populate(list, node.right);
        list.Add(node.val);
    }
}

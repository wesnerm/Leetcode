// 257. Binary Tree Paths   
// https://leetcode.com/problems/binary-tree-paths
// Easy 37.4%
// 704.4428843543225
// Submission: https://leetcode.com/submissions/detail/68202560/
// Runtime: 516 ms
// Your runtime beats 23.15 % of csharp submissions.

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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var list = new List<string>();
        DescendRoot(list, "", root);
        return list;
    }
        void DescendRoot(List<string> list, string s, TreeNode node)
    {
        if (node==null) return;
                s = s=="" ? s+node.val : s+"->"+node.val;
        if (node.left==null && node.right==null)
            list.Add(s);
        else
        {
            DescendRoot(list, s, node.left);
            DescendRoot(list, s, node.right);
        }
    }
}

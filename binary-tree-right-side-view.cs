// 199. Binary Tree Right Side View   
// https://leetcode.com/problems/binary-tree-right-side-view
// Medium 40.1%
// 684.6627068052518
// Submission: https://leetcode.com/submissions/detail/70130739/
// Runtime: 448 ms
// Your runtime beats 34.29 % of csharp submissions.

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
    List<int> list;
        public IList<int> RightSideView(TreeNode root) {
        list = new List<int>();
        Fill(root, 0);
        return list;
    }
        public void Fill(TreeNode root, int depth)
    {
        if (root==null)
            return;
                if (depth >= list.Count)
            list.Add(root.val);
        Fill(root.right, depth+1);
        Fill(root.left, depth+1);
    }
}

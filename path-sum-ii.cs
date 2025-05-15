// 113. Path Sum II   
// https://leetcode.com/problems/path-sum-ii
// Medium 32.9%
// 535.2557527968476
// Submission: https://leetcode.com/submissions/detail/70104763/
// Runtime: 532 ms
// Your runtime beats 11.48 % of csharp submissions.

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
        List<IList<int>> list;
    IList<int> path;
                public IList<IList<int>> PathSum(TreeNode root, int sum) {
        list = new List<IList<int>>();
        path = new List<int>();
        HasPathSum(root, sum);
        return list;
    }
        public void HasPathSum(TreeNode node, int sum) {
        if (node == null)
            return;
        sum -= node.val;
        path.Add(node.val);
        if (node.left == null && node.right == null)
        {
            if (sum == 0)
                list.Add(new List<int>(path));
        }
        else
        {
            HasPathSum(node.left, sum);
            HasPathSum(node.right, sum);
        }
        path.RemoveAt(path.Count-1);
    }
}

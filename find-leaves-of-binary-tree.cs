// 366. Find Leaves of Binary Tree   
// https://leetcode.com/problems/find-leaves-of-binary-tree
// Medium 58.9%
// 337.57354634669025
// Submission: https://leetcode.com/submissions/detail/70138440/
// Runtime: 552 ms
// Your runtime beats 1.61 % of csharp submissions.

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
        public IList<IList<int>> FindLeaves(TreeNode root) {
        list = new List<IList<int>>();
        FindLeavesCore(root);
        return list;
    }
            int FindLeavesCore(TreeNode root)
    {
        if (root == null)
            return -1;
                int depth1 = FindLeavesCore(root.left);
        int depth2 = FindLeavesCore(root.right);
        int depth = 1+Math.Max(depth1, depth2);
                if (depth>=list.Count)
            list.Add(new List<int>());
                list[depth].Add(root.val);
        return depth;
    }
}

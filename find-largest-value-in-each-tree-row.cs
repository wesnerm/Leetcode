// 515. Find Largest Value in Each Tree Row   
// https://leetcode.com/problems/find-largest-value-in-each-tree-row
// Medium 54.6%
// 268.7778000897059
// Submission: https://leetcode.com/submissions/detail/101886340/
// Runtime: 438 ms
// Your runtime beats 69.07 % of csharp submissions.

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
    public int[] LargestValues(TreeNode root) {
        var list = new List<int>();
        Find(root, -1, list);
        return list.ToArray();        
    }
        void Find(TreeNode root, int depth, List<int> list)
    {
        if (root == null) return;
        depth++;
        if (depth>=list.Count)
            list.Add(int.MinValue);
                    if (root.val>list[depth]) list[depth]= root.val;            
        Find(root.left, depth, list);
        Find(root.right, depth, list);
    }
}

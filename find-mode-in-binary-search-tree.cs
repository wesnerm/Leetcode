// 501. Find Mode in Binary Search Tree   
// https://leetcode.com/problems/find-mode-in-binary-search-tree
// Easy 38.0%
// 353.34031611347484
// Submission: https://leetcode.com/submissions/detail/101886064/
// Runtime: 476 ms
// Your runtime beats 40.98 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System;
using System.Collections.Generic;
 using System.Linq;
 public class Solution {
    public int[] FindMode(TreeNode root) {
        if (root==null)
             return new int[0];
                var dict = new Dictionary<int, int>();
        FindModeCore(dict, root);
        var max = dict.Values.Max();
        return dict.Keys.Where(x=>dict[x]==max).ToArray();
    }
        public void FindModeCore(Dictionary<int, int> dict, TreeNode root)
    {
        if (root==null)return;
        FindModeCore(dict, root.left);
        FindModeCore(dict, root.right);
        var val = root.val;
        if (!dict.ContainsKey(root.val)) dict[val] = 0;
        dict[val]++;
    }
}

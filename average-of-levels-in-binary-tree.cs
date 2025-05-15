// 637. Average of Levels in Binary Tree   
// https://leetcode.com/problems/average-of-levels-in-binary-tree
// Easy 57.0%
// 421.08884638790255
// Submission: https://leetcode.com/submissions/detail/111482639/
// Runtime: 579 ms
// Your runtime beats 82.72 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Linq;
public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
                var avg = new List<double>();
        var list = new List<TreeNode>();
        var list2 = new List<TreeNode>();
                list.Add(root);
        while (list.Count > 0)
        {
            avg.Add(list.Average(x=>x.val));
            foreach(var v in list)
            {
                if (v.left != null) list2.Add(v.left);
                if (v.right != null) list2.Add(v.right);
            }
                        list.Clear();
            var tmp = list;
            list = list2;
            list2 = tmp;
        }
                return avg;
    }
}

// 437. Path Sum III   
// https://leetcode.com/problems/path-sum-iii
// Easy 39.5%
// 466.3814233109752
// Submission: https://leetcode.com/submissions/detail/101881846/
// Runtime: 189 ms
// Your runtime beats 34.85 % of csharp submissions.

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
    public int PathSum(TreeNode root, int sum)
    {
        int count = 0;
        while (root != null)
        {
            count += RootedSum(root, sum);
            if (root.left == null)
                root = root.right;
            else
            {
                count += PathSum(root.right, sum);
                root = root.left;
            }
        }
        return count;
   }
      public int RootedSum(TreeNode root, int sum)
   {
       int count = 0;
       while (root != null)
       {
            sum -= root.val;
            if (sum == 0)
                count++;
                        if (root.left == null)
                root = root.right;
            else
            {
                count += RootedSum(root.right, sum);
                root = root.left;
            }
       }
       return count;
   }
}

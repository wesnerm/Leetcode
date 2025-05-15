// 333. Largest BST Subtree   
// https://leetcode.com/problems/largest-bst-subtree
// Medium 30.3%
// 199.44729588301038
// Submission: https://leetcode.com/submissions/detail/70160822/
// Runtime: 176 ms
// Your runtime beats 4.17 % of csharp submissions.

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
    public int LargestBSTSubtree(TreeNode root) {
        bool bst;
        int largest;
        int count;
        int min;
        int max;
        Largest(root, out min, out max, out bst, out largest, out count);
        return largest;
    }
        void Largest(TreeNode root, out int min,  out int max, out bool bst, out int largest, out int count)
    {
        if (root==null)
        {
            bst = true;
            count = 0;
            largest = 0;
            min = int.MaxValue;
            max = int.MinValue;
            return;
        }
                bool b1, b2;
        int count1, count2;
        int largest1, largest2;
        int min1, min2;
        int max1, max2;
                Largest(root.left, out min1, out max1, out b1, out largest1, out count1);
        Largest(root.right, out min2, out max2, out b2, out largest2, out count2);
                bst = b1 && b2 && root.val >= max1 && root.val <= min2;
        count = count1 + count2 + 1;
        largest = bst ? count : 0;
        largest = Math.Max(largest, Math.Max(largest1, largest2));
        min = Math.Min(Math.Min(min1, min2), root.val);
        max = Math.Max(Math.Max(max1, max2), root.val);
            }
}

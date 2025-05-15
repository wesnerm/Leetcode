// 108. Convert Sorted Array to Binary Search Tree   
// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree
// Easy 41.6%
// 836.0419754606179
// Submission: https://leetcode.com/submissions/detail/70128524/
// Runtime: 168 ms
// Your runtime beats 20.65 % of csharp submissions.

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
    public TreeNode SortedArrayToBST(int[] nums) {
                      return BuildTree(nums, 0, nums.Length-1);
    }
        public TreeNode BuildTree(int[] num, int start, int end)
    {
        if (start>end) return null;
        int mid = (start + end)/2;
        return Construct(num[mid], BuildTree(num, start, mid-1), BuildTree(num,mid+1, end)); 
    }
            public TreeNode Construct(int val, TreeNode left = null, TreeNode right = null)
    {
        return new TreeNode(val) { left =left, right=right };
    }
}

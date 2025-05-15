// 109. Convert Sorted List to Binary Search Tree   
// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree
// Medium 33.5%
// 685.8710468599944
// Submission: https://leetcode.com/submissions/detail/70129791/
// Runtime: 176 ms
// Your runtime beats 18.52 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
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
    public TreeNode SortedListToBST(ListNode head) {
           return BuildTree(ref head, 0, Length(head)-1);
    }
        public TreeNode BuildTree(ref ListNode head, int start, int end)
    {
        if (start>end) return null;
                int mid = (start + end)/2;
                TreeNode left = BuildTree(ref head, start, mid-1);
                int val = head.val;
        head = head.next;
                TreeNode right = BuildTree(ref head, mid+1, end);
        return Construct(val, left, right); 
    }
            public TreeNode Construct(int val, TreeNode left = null, TreeNode right = null)
    {
        return new TreeNode(val) { left =left, right=right };
    }
        int Length(ListNode head)
    {
        int count = 0;
        while (head != null)
        {
            head = head.next;
            count++;
        }
        return count;
    }
    }

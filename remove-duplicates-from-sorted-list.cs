// 83. Remove Duplicates from Sorted List   
// https://leetcode.com/problems/remove-duplicates-from-sorted-list
// Easy 39.6%
// 751.1974851154512
// Submission: https://leetcode.com/submissions/detail/69987374/
// Runtime: 168 ms
// Your runtime beats 14.96 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode prev = null;
        ListNode cur = head;
        while (cur != null)
        {
            if (prev!=null && cur.val == prev.val)
                prev.next = cur.next;
            else
                prev = cur;
            cur = cur.next;
        }
        return head;
    }
}

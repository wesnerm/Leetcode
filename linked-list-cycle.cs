// 141. Linked List Cycle   
// https://leetcode.com/problems/linked-list-cycle
// Easy 35.4%
// 1323.2302146443024
// Submission: https://leetcode.com/submissions/detail/68816889/
// Runtime: 176 ms
// Your runtime beats 8.70 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
                while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
                return true;
        }
                return false;
    }
}

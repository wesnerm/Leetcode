// 206. Reverse Linked List   
// https://leetcode.com/problems/reverse-linked-list
// Easy 44.9%
// 1513.5603148950952
// Submission: https://leetcode.com/submissions/detail/68812782/
// Runtime: 164 ms
// Your runtime beats 13.06 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode reversed = null;
        ListNode current = head;
                while (current!= null)
        {
            ListNode tmp = current;
            current = current.next;
            tmp.next = reversed;
            reversed = tmp;
        }
                return reversed;
    }
}

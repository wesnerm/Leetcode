// 203. Remove Linked List Elements   
// https://leetcode.com/problems/remove-linked-list-elements
// Easy 32.0%
// 791.6457625710464
// Submission: https://leetcode.com/submissions/detail/69989426/
// Runtime: 184 ms
// Your runtime beats 9.68 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        while (head != null && head.val == val)
            head = head.next;
        ListNode prev = null;
        for (ListNode cur = head; cur != null; cur=cur.next)
            if (cur.val == val)
                prev.next = cur.next;
            else
                prev = cur;
            return head;        
    }
}

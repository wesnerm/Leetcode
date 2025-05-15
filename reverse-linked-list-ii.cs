// 92. Reverse Linked List II   
// https://leetcode.com/problems/reverse-linked-list-ii
// Medium 30.3%
// 685.2524969711
// Submission: https://leetcode.com/submissions/detail/69991611/
// Runtime: 188 ms
// Your runtime beats 2.94 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        ListNode prev = null;
        ListNode cur = head;
                m--;
        n--;
        if (m>=n)
            return head;
                int i=0;
        while (cur != null && i<m)
        {
            prev = cur;
            cur = cur.next;
            i++;
        }
                if (cur == null)
            return head;
                i=n-m;
        ListNode reversed = null;
        ListNode reversedPrev = cur;
        while (cur != null && i>=0)
        {
            ListNode node = cur;
            cur = cur.next;
            node.next = reversed;
            reversed = node;
            i--;
        }
                if (prev==null)
            head = reversed;
        else
            prev.next = reversed;
        reversedPrev.next = cur;
        return head;        
    }
}

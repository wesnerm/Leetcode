// 369. Plus One Linked List   
// https://leetcode.com/problems/plus-one-linked-list
// Medium 54.0%
// 230.50030991348137
// Submission: https://leetcode.com/submissions/detail/68242419/
// Runtime: 184 ms
// Your runtime beats 14.29 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode PlusOne(ListNode head) {
        var current = head;
        ListNode beforeNon9 = null;
        ListNode previous = null;
        for  (; current != null; previous=current, current=current.next)
            if (current.val!=9)
                beforeNon9 = previous;
        ListNode non9 = null;
        if (beforeNon9==null)
        {
            if (head.val == 9)
                head = new ListNode(0) { next = head };
            non9 = head;
        }
        else
        {
            non9 = beforeNon9.next;
        }
        non9.val++;
                for (current=non9.next; current != null; current =current.next)
            current.val = 0;
        return head;
    }
}

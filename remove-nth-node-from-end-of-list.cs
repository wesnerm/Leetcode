// 19. Remove Nth Node From End of List   
// https://leetcode.com/problems/remove-nth-node-from-end-of-list
// Medium 33.0%
// 847.4078037872641
// Submission: https://leetcode.com/submissions/detail/69988026/
// Runtime: 148 ms
// Your runtime beats 37.80 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode prev = null;
        ListNode cur;
        int length = 0;
                for (cur=head; cur != null && n>0; cur=cur.next)
            length++;
                int i = length-n;
        for (cur=head; cur != null && i>0; cur=cur.next, i--)
            prev = cur;
        if (cur != null)
        {
            if (prev!=null)
                prev.next = cur.next;
            else
                head = cur.next;
        }
                return head;
    }
}

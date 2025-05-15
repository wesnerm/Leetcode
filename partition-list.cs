// 86. Partition List   
// https://leetcode.com/problems/partition-list
// Medium 32.2%
// 672.9708521564078
// Submission: https://leetcode.com/submissions/detail/70576373/
// Runtime: 152 ms
// Your runtime beats 25.00 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode tail2 = null;
        ListNode head2 = null;
                ListNode cur = head;
        ListNode prev = null;
                while (cur != null)
        {
            ListNode tmp = cur;
            cur = cur.next; 
            if (tmp.val < x)
                prev = tmp;
            else
            {
                tmp.next = null;
                                if (prev == null)
                    head = cur;
                else
                    prev.next = cur;
                if (tail2 == null)
                    head2 = tail2 = tmp;
                else
                    tail2 = tail2.next = tmp;
            }
        }
                if (prev == null)
            head = head2;
        else
            prev.next = head2;
                return head;
    }
}

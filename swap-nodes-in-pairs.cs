// 24. Swap Nodes in Pairs   
// https://leetcode.com/problems/swap-nodes-in-pairs
// Medium 38.0%
// 817.3643491083783
// Submission: https://leetcode.com/submissions/detail/69992561/
// Runtime: 160 ms
// Your runtime beats 14.63 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode prev = null;
        ListNode cur = head;
        while (cur != null && cur.next != null)
        {
            var first = cur;
            var second = cur.next;
            if (prev != null)
                prev.next = second;
            else
                head = second;
            prev = first;
            cur = second.next;
            second.next = first;
            first.next = cur;
        }
                return head;
    }
}

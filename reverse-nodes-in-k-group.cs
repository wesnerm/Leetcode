// 25. Reverse Nodes in k-Group   
// https://leetcode.com/problems/reverse-nodes-in-k-group
// Hard 30.4%
// 661.9873180526623
// Submission: https://leetcode.com/submissions/detail/69993685/
// Runtime: 164 ms
// Your runtime beats 28.99 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (k<=1)
            return head;
        ListNode prev = null;
        ListNode cur = head;
        while (true)
        {
            ListNode start = cur;
            ListNode end = start;
            int i = k;
            while (cur != null && i>0)
            {
                end = cur;                
                cur = cur.next;
                i--;
            }
                        if (i>0) break;
                        ListNode reversed = cur;
            ListNode cur2 = start;
            while (cur2 != cur)
            {
                ListNode node = cur2;
                cur2 = cur2.next;
                node.next = reversed;
                reversed = node;
            }
            if (prev == null)
                head = end;
            else
                prev.next = end;
            prev = start;
        }
                return head;
    }
}

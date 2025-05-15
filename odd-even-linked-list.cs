// 328. Odd Even Linked List   
// https://leetcode.com/problems/odd-even-linked-list
// Medium 43.1%
// 1232.2981671549305
// Submission: https://leetcode.com/submissions/detail/69988917/
// Runtime: 144 ms
// Your runtime beats 56.16 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        ListNode cur = head;
        ListNode evenList = null;
        ListNode oddList = null;
        ListNode prev = null;
        ListNode evenHead = head != null ? head.next : null;
                bool odd = true;
        while (cur != null)
        {
            var node = cur;
            cur = cur.next;
            node.next = null;            
                        if (odd)
            {
                if (oddList == null) oddList = node;
                else oddList = oddList.next = node;
            }
            else
            {
                if (evenList == null) evenList = node;
                else evenList = evenList.next = node;
            }
                        odd = !odd;
        }
                if (oddList != null)
            oddList.next = evenHead;
                return head;
    }
}

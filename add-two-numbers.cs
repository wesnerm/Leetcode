// 2. Add Two Numbers   
// https://leetcode.com/problems/add-two-numbers
// Medium 27.7%
// 2455.106524623839
// Submission: https://leetcode.com/submissions/detail/68945483/
// Runtime: 224 ms
// Your runtime beats 9.11 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
                var head = new ListNode(0);
        var tail = head;
                int carry = 0;
        while (l1 != null || l2 != null)
        {
            int v1=0, v2=0;
                        if (l1 != null)
            {
                v1 = l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                v2 = l2.val;
                l2 = l2.next;
            }
            var v3 = v1 + v2 + carry;
            carry = v3 / 10;
                        tail = tail.next = new ListNode(v3 % 10);
        }
                  if (carry > 0)
            tail = tail.next = new ListNode(carry);
                return head.next;
    }
}

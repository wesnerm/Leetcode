// 61. Rotate List   
// https://leetcode.com/problems/rotate-list
// Medium 24.3%
// 643.0296291572784
// Submission: https://leetcode.com/submissions/detail/69996831/
// Runtime: 180 ms
// Your runtime beats 4.22 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null)
            return null;
                int length = 1;
        ListNode tail = head;
        while (tail.next != null)
        {
            length++;
            tail = tail.next;
        }
                tail.next = head;
        k %= length;
        for  (int cut = (length-k) % length; cut>0; cut--)
            tail = tail.next;
        var newHead = tail.next;
        tail.next = null;
        return newHead;
    }
}

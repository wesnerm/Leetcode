// 82. Remove Duplicates from Sorted List II   
// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii
// Medium 29.2%
// 554.7642378673175
// Submission: https://leetcode.com/submissions/detail/70500715/
// Runtime: 164 ms
// Your runtime beats 16.33 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode cur = head;
        ListNode prev = null;
        while (cur != null) 
        {
            int val = cur.val;
            if (cur.next != null && cur.next.val==val)
            {
                while (cur != null && cur.val==val)
                    cur = cur.next;
                if (prev == null)
                    head = cur;
                else
                    prev.next = cur;
            }
            else
            {
                prev = cur;
                cur = cur.next;
            }
        }
        return head;
    }
}

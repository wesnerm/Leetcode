// 147. Insertion Sort List   
// https://leetcode.com/problems/insertion-sort-list
// Medium 32.7%
// 956.8427422631343
// Submission: https://leetcode.com/submissions/detail/71115512/
// Runtime: 184 ms
// Your runtime beats 48.89 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
        public ListNode InsertionSortList(ListNode head)
    {
        var helper = new ListNode(0) { next = head };
        var prev = helper;
        while (prev.next != null)
        {
            // skip nodes until find one that is misplaced
            while (prev.next.next != null && prev.next.val <= prev.next.next.val)
                prev = prev.next;
            ListNode misplaced = prev.next.next;
            if (misplaced == null)
                break;
                        prev.next.next = misplaced.next;
                        var inserthead = helper;
            while (inserthead.next != null && inserthead.next.val < misplaced.val)
                inserthead = inserthead.next;
                            misplaced.next = inserthead.next;
            inserthead.next = misplaced;
        }
                return helper.next;
    }
            public ListNode InsertionSortList2(ListNode head)
    {
        var helper = new ListNode(0) { next = head };
        var prev = helper;
        var curr = head;
        while (curr != null)
        {
            // skip nodes until find one that is misplaced
            while (curr.next != null && curr.val <= curr.next.val)
            {
                prev = curr;
                curr = curr.next;
            }
                        ListNode misplaced = curr.next;
            if (misplaced == null)
                break;
                        curr.next = misplaced.next;
                        var inserthead = helper;
            while (inserthead.next != null && inserthead.next.val < misplaced.val)
                inserthead = inserthead.next;
                            misplaced.next = inserthead.next;
            inserthead.next = misplaced;
        }
                return helper.next;
    }
}

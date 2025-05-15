// 21. Merge Two Sorted Lists   
// https://leetcode.com/problems/merge-two-sorted-lists
// Easy 38.8%
// 1218.6196659989441
// Submission: https://leetcode.com/submissions/detail/68819758/
// Runtime: 164 ms
// Your runtime beats 18.61 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var dummy = new ListNode(0);
        var tail = dummy;
                while (l1 != null && l2 != null)
        {
            ListNode tmp;
            if (l1.val <= l2.val)
            {
                tmp = l1;
                l1 = l1.next;
            }
            else
            {
                tmp = l2;
                l2 = l2.next;
            }
            tail = tail.next = tmp;
        }
                tail.next = l2==null ? l1 : l2;
        return dummy.next;
    }
}

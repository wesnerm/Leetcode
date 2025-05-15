// 143. Reorder List   
// https://leetcode.com/problems/reorder-list
// Medium 25.2%
// 818.7653465079107
// Submission: https://leetcode.com/submissions/detail/70499887/
// Runtime: 160 ms
// Your runtime beats 75.68 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        int length = Length(head);
        if (length <= 2) return;
                var list1 = head;
        var list2 = Reverse(Split(head, length/2));
        Zip(list1, list2);
    }
        public ListNode Reverse(ListNode list)
    {
        ListNode reverse = null;
        var cur = list;
        while (cur != null)
        {
            ListNode cur2 = cur;
            cur = cur.next;
            cur2.next = reverse;
            reverse = cur2;
        }
        return reverse;
    }
        public void Zip(ListNode head1, ListNode head2)
    {
        while (head1 != null && head2 != null)
        {
            var prev1 = head1;
            var prev2 = head2;
                        head1 = head1.next;
            head2 = head2.next;
                        prev1.next = prev2;
            prev2.next = head1 ?? head2;
        }
    }
        public int Length(ListNode head)
    {
        int len=0;
        for (var cur = head; cur != null; cur=cur.next)
            len++;
        return len;
    }
        public ListNode Split(ListNode head, int n)
    {
        ListNode prev = null;
        while (head != null && n-->0)
        {
            prev = head;
            head = head.next;
        }
                ListNode split = head;
        if (prev != null)
            prev.next = null;
        return split;
    }
}

// 148. Sort List   
// https://leetcode.com/problems/sort-list
// Medium 28.3%
// 1340.41547922939
// Submission: https://leetcode.com/submissions/detail/70555127/
// Runtime: 180 ms
// Your runtime beats 36.67 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head)
    {
        return SortList(head, Length(head));
    }
        ListNode SortList(ListNode head, int length)
    {
        if (length<2)
            return head;
                var split = Split(head, length/2);
        var right = SortList(split, length - length/2);
        var left =  SortList(head, length/2);
        return MergeList(left, right);
    }
    public ListNode MergeList(ListNode list1, ListNode list2)
    {
        ListNode head = null;
        ListNode tail = null;
                while (list1 != null || list2 != null)
        {
            ListNode node;
            if (list1 == null || list2 != null && list2.val < list1.val)
            {
                node = list2;
                list2 = list2.next;
            }
            else
            {
                node = list1;
                list1 = list1.next;
            }
                        if (tail==null)
                tail = head = node;
            else 
                tail = tail.next = node;
        }
                if (tail != null)
            tail.next = null;                
        return head;        
    }
        public ListNode Split(ListNode head, int n)
    {
        ListNode prev = null;
        ListNode cur = head;
                while (cur != null && n-->0)
        {
            prev = cur;
            cur = cur.next;
        }   
            if (prev==null)
            return null;
                    prev.next = null;
        return cur;
    }
        public int Length(ListNode head)
    {
        int len=0;
        while (head != null)
        {
            len++;
            head = head.next;
        }
        return len;
    }
}

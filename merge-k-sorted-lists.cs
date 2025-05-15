// 23. Merge k Sorted Lists   
// https://leetcode.com/problems/merge-k-sorted-lists
// Hard 26.8%
// 1068.024747492768
// Submission: https://leetcode.com/submissions/detail/67714663/
// Runtime: 200 ms
// Your runtime beats 56.48 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var queue = new Queue<ListNode>();
        foreach (var item in lists)
            queue.Enqueue(item);
        while (queue.Count >= 2)
        {
            var item1 = queue.Dequeue();
            var item2 = queue.Dequeue();
            queue.Enqueue(MergeLists(item1, item2));
        }
                if (queue.Count == 0)
            return null;
        return queue.Dequeue();
    }
        public ListNode MergeLists(ListNode list1, ListNode list2)
    {
        ListNode head = null;
        ListNode tail = null;
        while (list1 != null && list2 != null)
        {
            ListNode node;
            if (list1.val < list2.val)
            {
                node = list1;
                list1 = list1.next;
            }
            else
            {
                node = list2;
                list2 = list2.next;
            }
            node.next = null;
            Append(ref head, ref tail, node);
        }
                Append(ref head, ref tail, list1 != null ? list1 : list2);
        return head;
    }
        private void Append(ref ListNode head, ref ListNode tail, ListNode node)
    {
        if (head == null)
        {
            head = tail = node;
            return;
        }
                tail.next = node;
        tail = node;
    }
    }

// 160. Intersection of Two Linked Lists   
// https://leetcode.com/problems/intersection-of-two-linked-lists
// Easy 30.4%
// 1112.2724711620729
// Submission: https://leetcode.com/submissions/detail/92224949/
// Runtime: 199 ms
// Your runtime beats 73.17 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode head = null;
        ListNode tail = head;
                while (headA!=null && headB!=null)
        {
            if (headA.val < headB.val)
                headA = headA.next;
            else if (headA.val > headB.val)
                headB = headB.next;
            else
            {
                return headA;
                /*
                var node = new ListNode(headA.val);
                if (tail == null)
                    head = node;
                else 
                    tail.next = node;
                tail = node;                            
                headA = headA.next;
                headB = headB.next;*/
            }
        }
                return head;
    }
}

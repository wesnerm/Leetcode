// 142. Linked List Cycle II    
// https://leetcode.com/problems/linked-list-cycle-ii
// Medium 31.0%
// 917.1557335694488
// Submission: https://leetcode.com/submissions/detail/70878760/
// Runtime: 160 ms
// Your runtime beats 24.62 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
                while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
                break;
        }
                if (fast == null || fast.next==null)
            return null;
                    slow = head;
        int cycleStart = 0;
        while (fast != slow)
        {
            fast = fast.next;
            slow = slow.next;
            cycleStart++;
        }
        /*
        int cycleLength = 0;
        do
        {
            fast = fast.next;
            cycleLength++;
        }
        while (slow != fast);
        */
        return slow;
    }
        public ListNode Brent(ListNode head)
    {
        // main phase: search successive powers of two
        int power = 1;
        int cycleLength = 1;
        ListNode tortoise = head;
        ListNode hare = head.next; // f(x0) is the element/node next to x0.
        while (tortoise != hare)
        {
            if (power == cycleLength)  // time to start a new power of two?
            {
                tortoise = hare;
                power *= 2;
                cycleLength = 0;
            }
            hare = hare.next;
            cycleLength += 1;
        }
            //Find the position of the first repetition of length λ
        tortoise = hare = head;
        for (int i=0; i<cycleLength; i++)
            hare = hare.next;
                    // The distance between the hare and tortoise is now λ.
        // Next, the hare and tortoise move at same speed until they agree
        int cycleStart;
        for (cycleStart = 0; tortoise != hare; cycleStart++)
        {
            tortoise = tortoise.next;
            hare = hare.next;
        }
                return hare;
    }
}

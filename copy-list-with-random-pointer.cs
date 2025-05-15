// 138. Copy List with Random Pointer   
// https://leetcode.com/problems/copy-list-with-random-pointer
// Medium 26.4%
// 1095.979446772804
// Submission: https://leetcode.com/submissions/detail/68814994/
// Runtime: 106 ms
// Your runtime beats 23.61 % of csharp submissions.

/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        var current = head;
        while (current != null)
        {
            var tmp = new RandomListNode(current.label)
            { 
                next = current.next,
                random = current.random,
            };
            current.next = tmp;
            current = tmp.next;
        }
        current = head;
        while (current != null)
        {
            current = current.next;
            current.random = current.random==null ? null : current.random.next;
            current = current.next;
        }
                var dummy = new RandomListNode(0) { next = head };
        var tail = dummy;
        current = head;
        while (current != null)
        {
            tail = tail.next = current.next;
            current = current.next = tail.next;
        }
        tail.next = null;
        return dummy.next;
    }
}

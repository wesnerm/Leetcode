// 237. Delete Node in a Linked List   
// https://leetcode.com/problems/delete-node-in-a-linked-list
// Easy 46.1%
// 1666.3237610686201
// Submission: https://leetcode.com/submissions/detail/69989828/
// Runtime: 156 ms
// Your runtime beats 32.35 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        if (node.next != null)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}

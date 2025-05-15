// 234. Palindrome Linked List   
// https://leetcode.com/problems/palindrome-linked-list
// Easy 32.4%
// 1022.001095641255
// Submission: https://leetcode.com/submissions/detail/70449739/
// Runtime: 176 ms
// Your runtime beats 21.31 % of csharp submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
                var cur = head;
        int length = 0;
        while (cur != null)
        {
            length++;
            cur = cur.next;
        }
                int mid = length/2;
                cur = head;
        while (mid-- > 0)
            cur=cur.next;
        if (length %2==1) cur = cur.next;
                var list1 = head;
        var list2 = Reverse(cur);
        int count = length/2;
            while (count>0 && list1.val == list2.val)        
        {
            list1 = list1.next;
            list2 = list2.next;
            count--;
        }
                return count==0;
    }
        ListNode Reverse(ListNode node)
    {
        ListNode reverse = null;
        ListNode cur = node;
                while (cur != null)
        {
            ListNode tmp = cur;
            cur=cur.next;
            tmp.next = reverse;
            reverse = tmp;
        }
                return reverse;
    }
}

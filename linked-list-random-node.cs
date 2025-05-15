// 382. Linked List Random Node   
// https://leetcode.com/problems/linked-list-random-node
// Medium 46.8%
// 551.3674048530233
// Submission: https://leetcode.com/submissions/detail/70121854/
// Runtime: 145 ms
// Your runtime beats 28.51 % of java submissions.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    ListNode front;
    Random random;
    /** @param head The linked list's head.
        Note that the head is guaranteed to be not null, so it contains at least one node. */
    public Solution(ListNode head) {
        front = head;   
        random = new Random();
    }
        /** Returns a random node's value. */
    public int getRandom() {
        ListNode cur = front;
        ListNode choose = front;
        int i = 1;
                for (; cur != null; cur=cur.next, i++)
            if (Math.random() * i < 1)
                choose = cur;
        return choose==null ? 0 : choose.val;
    }
}
/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.getRandom();
 */

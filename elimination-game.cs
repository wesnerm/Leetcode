// 390. Elimination Game   
// https://leetcode.com/problems/elimination-game
// Medium 40.8%
// 770.0096997110217
// Submission: https://leetcode.com/submissions/detail/74815946/
// Runtime: 29 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public int LastRemaining(int n) {
        if (n<=2) return n;
        int n2 = n/2;
        return 2*(n2-LastRemaining(n2)+1);
    }
}

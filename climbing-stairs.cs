// 70. Climbing Stairs   
// https://leetcode.com/problems/climbing-stairs
// Easy 39.5%
// 1327.248492301576
// Submission: https://leetcode.com/submissions/detail/70028278/
// Runtime: 52 ms
// Your runtime beats 24.16 % of csharp submissions.

public class Solution {
    public int ClimbStairs(int n) {
        if (n<2) return 1;
                int prev = 1;
        int cur = 1;
        for (int i=2; i<=n; i++)
        {
            int oldCur = cur;
            cur = cur + prev;
            prev = oldCur;
        }
                return cur;
    }
}

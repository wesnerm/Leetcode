// 441. Arranging Coins   
// https://leetcode.com/problems/arranging-coins
// Easy 36.2%
// 349.5244897194007
// Submission: https://leetcode.com/submissions/detail/101884992/
// Runtime: 56 ms
// Your runtime beats 68.75 % of csharp submissions.

public class Solution {
    public int ArrangeCoins(int n) {
        long left = 1;
        long right = n;
        while (left <= right)
        {
            long mid = left + (right-left)/2;
            if (n >= Staircase(mid))
                left = mid + 1;
            else
                right = mid - 1;
        }
        return (int)right;
    }
        public long Staircase(long floors)
    {
        return floors * (floors + 1) /2;
    }
}

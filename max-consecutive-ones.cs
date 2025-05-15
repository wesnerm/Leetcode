// 485. Max Consecutive Ones   
// https://leetcode.com/problems/max-consecutive-ones
// Easy 54.3%
// 473.7040342646858
// Submission: https://leetcode.com/submissions/detail/101835659/
// Runtime: 222 ms
// Your runtime beats 56.43 % of csharp submissions.

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int prev = -1;
        int maxcnt = 0;
        int cnt = 0;
        for (int i=0; i<nums.Length;i++)
        {
            if (prev!=1)
                cnt = 0;
            if (nums[i] == 1) cnt++;
            maxcnt = Math.Max(cnt, maxcnt);
            prev = nums[i];
        }
                return maxcnt;
    }
}

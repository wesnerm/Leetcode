// 300. Longest Increasing Subsequence   
// https://leetcode.com/problems/longest-increasing-subsequence
// Medium 38.0%
// 642.4483301403945
// Submission: https://leetcode.com/submissions/detail/69810531/
// Runtime: 152 ms
// Your runtime beats 65.98 % of csharp submissions.

public class Solution {
    public int LengthOfLIS(int[] nums) {
        var dp = new int[nums.Length];
                int len = 0;
        for (int i=0; i<nums.Length; i++)
        {
            int index = Array.BinarySearch(dp, 0, len, nums[i]);
            if (index<0) index = ~index;
            if (index>=len) len++;
            dp[index] = nums[i];
        }
                return len;
    }
}

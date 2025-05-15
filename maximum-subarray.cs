// 53. Maximum Subarray   
// https://leetcode.com/problems/maximum-subarray
// Easy 39.4%
// 1251.7111022701938
// Submission: https://leetcode.com/submissions/detail/68559468/
// Runtime: 168 ms
// Your runtime beats 13.73 % of csharp submissions.

public class Solution {
    public int MaxSubArray(int[] nums) {
         int sum = 0;
         int maxsum = int.MinValue;
         for (int i=0; i<nums.Length; i++)
         {
             sum = Math.Max(sum,0) + nums[i];
             maxsum = Math.Max(sum, maxsum);
         }
         return maxsum;
    }
}

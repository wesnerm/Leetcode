// 643. Maximum Average Subarray I   
// https://leetcode.com/problems/maximum-average-subarray-i
// Easy 39.3%
// 302.013443909597
// Submission: https://leetcode.com/submissions/detail/111581072/
// Runtime: 432 ms
// Your runtime beats 51.95 % of csharp submissions.

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var presum = new long[nums.Length+1];
        for (int i=0; i<nums.Length; i++)
            presum[i+1] = presum[i] + nums[i];
        double max = double.MinValue;
        for (int i=0; i+k<=nums.Length; i++)
            max = Math.Max(max, (presum[i+k] - presum[i]) / (double) k );
                return max;        
    }
}

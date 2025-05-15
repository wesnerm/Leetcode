// 325. Maximum Size Subarray Sum Equals k    
// https://leetcode.com/problems/maximum-size-subarray-sum-equals-k
// Medium 42.2%
// 571.8099983359795
// Submission: https://leetcode.com/submissions/detail/71247904/
// Runtime: 200 ms
// Your runtime beats 20.97 % of csharp submissions.

public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        var hash = new Dictionary<int, int>();
        int presum = 0;        
            int maxlen = 0;
        for(int i=0; i<nums.Length; i++)
        {
            var e = nums[i];
            presum += nums[i];
            if (presum == k) maxlen = i+1;
            if (hash.ContainsKey(presum - k))
                maxlen = Math.Max(maxlen, i-hash[presum - k]);
            if (!hash.ContainsKey(presum)) 
                hash[presum] = i;
        }
        return maxlen;
    }
}

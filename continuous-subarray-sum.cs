// 523. Continuous Subarray Sum   
// https://leetcode.com/problems/continuous-subarray-sum
// Medium 22.0%
// 253.86417641127255
// Submission: https://leetcode.com/submissions/detail/104598706/
// Runtime: 209 ms
// Your runtime beats 51.72 % of csharp submissions.

public class Solution {
    public bool CheckSubarraySum(int[] nums, int kk) {
        long k = kk==0 ? 1L<<32 : kk;
        var presum = new long[nums.Length+1];
        for (int i=0; i<nums.Length; i++)
            presum[i+1] = presum[i] + nums[i];
                var set = new HashSet<long>();
        for (int i=0; i<presum.Length; i++)
        {
            var v = presum[i];
            if (set.Contains(Fix(v,k)))
                return true;
            if (i>=1) set.Add(Fix(presum[i-1],k));
        }
                return false;
    }
        public long Fix(long x, long k)
    {
        return x%k; //((x%k) + k)%k;
    }
}

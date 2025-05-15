// 560. Subarray Sum Equals K   
// https://leetcode.com/problems/subarray-sum-equals-k
// Medium 40.8%
// 424.24413064336704
// Submission: https://leetcode.com/submissions/detail/111724836/
// Runtime: 192 ms
// Your runtime beats 70.00 % of csharp submissions.

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var sums = new long[nums.Length+1];
        long sum = 0;
        for (int i=0; i<nums.Length; i++)
            sums[i+1] = sum = sum + nums[i];
                    var dict = new Dictionary<long, int>();
        int result = 0;
        for (int left=0; left<sums.Length; left++)
        {
            var v = sums[left];
            int tmp;
            if (dict.TryGetValue(v-k, out tmp))
               result += tmp; 
                        if (dict.ContainsKey(v) == false) dict[v]=0;
            dict[v]++;
        }
                return result;
    }
}

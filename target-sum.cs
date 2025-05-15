// 494. Target Sum   
// https://leetcode.com/problems/target-sum
// Medium 43.8%
// 329.3639777852773
// Submission: https://leetcode.com/submissions/detail/101885870/
// Runtime: 172 ms
// Your runtime beats 70.73 % of csharp submissions.

public class Solution {
    public int FindTargetSumWays(int[] nums, int S) {
        if (S>1000 || S<-1000)
            return 0;
                Array.Sort(nums);
        var dp = new int[21,4001];
        return FindTargetSumWays(dp, nums, nums.Length-1, S);
    }
        public int FindTargetSumWays(int [,] dp, int [] nums, int index, int S)
    {
        if (index<0) return S==0 ? 1 : 0;
                if (dp[index,S+2000] != 0)
            return dp[index, S+2000] - 1;
                int result = FindTargetSumWays(dp, nums, index-1, S-nums[index])
            + FindTargetSumWays(dp, nums, index-1, S+nums[index]);
                    dp[index,S+2000] = result+1;
        return result;
    }
}

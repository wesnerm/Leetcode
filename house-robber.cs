// 198. House Robber   
// https://leetcode.com/problems/house-robber
// Easy 38.4%
// 1302.3167547641585
// Submission: https://leetcode.com/submissions/detail/70017590/
// Runtime: 144 ms
// Your runtime beats 31.43 % of csharp submissions.

public class Solution {
    public int Rob(int[] nums) 
    {
        int numMinus2 = 0;
        int numMinus1 = 0;
        int max = 0;
        for (int i=0; i<nums.Length; i++)
        {
            max = Math.Max(numMinus2 + nums[i], numMinus1 );
            numMinus2 = numMinus1;
            numMinus1 = max;
        }
        return max;
    }
}

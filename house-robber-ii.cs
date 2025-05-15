// 213. House Robber II   
// https://leetcode.com/problems/house-robber-ii
// Medium 33.7%
// 501.9420192458163
// Submission: https://leetcode.com/submissions/detail/70019157/
// Runtime: 160 ms
// Your runtime beats 9.09 % of csharp submissions.

public class Solution {
    public int Rob(int[] nums) 
    {
        int max = nums.Length > 0 ? nums[0] : 0;
        int numMinus2 = 0;
        int numMinus1 = 0;
        for (int i=0; i<nums.Length-1; i++)
        {
            int cur = Math.Max(numMinus2 + nums[i], numMinus1 );
            numMinus2 = numMinus1;
            numMinus1 = cur;
        }
        max = Math.Max(max, numMinus1);
                numMinus2 = 0;
        numMinus1 = 0;
        for (int i=1; i<nums.Length; i++)
        {
            int cur = Math.Max(numMinus2 + nums[i], numMinus1 );
            numMinus2 = numMinus1;
            numMinus1 = cur;
        }
        max = Math.Max(max, numMinus1);
        return max;
    }
}
